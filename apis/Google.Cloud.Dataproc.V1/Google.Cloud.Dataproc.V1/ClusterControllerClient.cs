// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.LongRunning;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>
    /// Settings for a <see cref="ClusterControllerClient"/>.
    /// </summary>
    public sealed partial class ClusterControllerSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ClusterControllerSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ClusterControllerSettings"/>.
        /// </returns>
        public static ClusterControllerSettings GetDefault() => new ClusterControllerSettings();

        /// <summary>
        /// Constructs a new <see cref="ClusterControllerSettings"/> object with default settings.
        /// </summary>
        public ClusterControllerSettings() { }

        private ClusterControllerSettings(ClusterControllerSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateClusterSettings = existing.CreateClusterSettings;
            CreateClusterOperationsSettings = existing.CreateClusterOperationsSettings?.Clone();
            UpdateClusterSettings = existing.UpdateClusterSettings;
            UpdateClusterOperationsSettings = existing.UpdateClusterOperationsSettings?.Clone();
            DeleteClusterSettings = existing.DeleteClusterSettings;
            DeleteClusterOperationsSettings = existing.DeleteClusterOperationsSettings?.Clone();
            GetClusterSettings = existing.GetClusterSettings;
            ListClustersSettings = existing.ListClustersSettings;
            DiagnoseClusterSettings = existing.DiagnoseClusterSettings;
            DiagnoseClusterOperationsSettings = existing.DiagnoseClusterOperationsSettings?.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(ClusterControllerSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ClusterControllerClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="ClusterControllerClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ClusterControllerClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ClusterControllerClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ClusterControllerClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="ClusterControllerClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ClusterControllerClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ClusterControllerClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 10000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 10000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(10000),
            maxDelay: TimeSpan.FromMilliseconds(10000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterControllerClient.CreateCluster</c> and <c>ClusterControllerClient.CreateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterControllerClient.CreateCluster</c> and
        /// <c>ClusterControllerClient.CreateClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 10000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 10000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 300000 milliseconds.
        /// </remarks>
        public CallSettings CreateClusterSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ClusterControllerClient.CreateCluster</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 1000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 2.0</description></item>
        /// <item><description>Maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings CreateClusterOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000L)),
                TimeSpan.FromMilliseconds(1000L),
                2.0,
                TimeSpan.FromMilliseconds(10000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterControllerClient.UpdateCluster</c> and <c>ClusterControllerClient.UpdateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterControllerClient.UpdateCluster</c> and
        /// <c>ClusterControllerClient.UpdateClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 10000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 10000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 300000 milliseconds.
        /// </remarks>
        public CallSettings UpdateClusterSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ClusterControllerClient.UpdateCluster</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 1000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 2.0</description></item>
        /// <item><description>Maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings UpdateClusterOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000L)),
                TimeSpan.FromMilliseconds(1000L),
                2.0,
                TimeSpan.FromMilliseconds(10000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterControllerClient.DeleteCluster</c> and <c>ClusterControllerClient.DeleteClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterControllerClient.DeleteCluster</c> and
        /// <c>ClusterControllerClient.DeleteClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 10000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 10000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 300000 milliseconds.
        /// </remarks>
        public CallSettings DeleteClusterSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ClusterControllerClient.DeleteCluster</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 1000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 2.0</description></item>
        /// <item><description>Maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings DeleteClusterOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000L)),
                TimeSpan.FromMilliseconds(1000L),
                2.0,
                TimeSpan.FromMilliseconds(10000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterControllerClient.GetCluster</c> and <c>ClusterControllerClient.GetClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterControllerClient.GetCluster</c> and
        /// <c>ClusterControllerClient.GetClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 10000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 10000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 300000 milliseconds.
        /// </remarks>
        public CallSettings GetClusterSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterControllerClient.ListClusters</c> and <c>ClusterControllerClient.ListClustersAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterControllerClient.ListClusters</c> and
        /// <c>ClusterControllerClient.ListClustersAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 10000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 10000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 300000 milliseconds.
        /// </remarks>
        public CallSettings ListClustersSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterControllerClient.DiagnoseCluster</c> and <c>ClusterControllerClient.DiagnoseClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterControllerClient.DiagnoseCluster</c> and
        /// <c>ClusterControllerClient.DiagnoseClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 10000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 10000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 300000 milliseconds.
        /// </remarks>
        public CallSettings DiagnoseClusterSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ClusterControllerClient.DiagnoseCluster</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 1000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 2.0</description></item>
        /// <item><description>Maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Total timeout: 30000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings DiagnoseClusterOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(30000L)),
                TimeSpan.FromMilliseconds(1000L),
                2.0,
                TimeSpan.FromMilliseconds(10000L))
        };

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ClusterControllerSettings"/> object.</returns>
        public ClusterControllerSettings Clone() => new ClusterControllerSettings(this);
    }

    /// <summary>
    /// ClusterController client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ClusterControllerClient
    {
        /// <summary>
        /// The default endpoint for the ClusterController service, which is a host of "dataproc.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("dataproc.googleapis.com", 443);

        /// <summary>
        /// The default ClusterController scopes.
        /// </summary>
        /// <remarks>
        /// The default ClusterController scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="ClusterControllerClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ClusterControllerSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ClusterControllerClient"/>.</returns>
        public static async Task<ClusterControllerClient> CreateAsync(ServiceEndpoint endpoint = null, ClusterControllerSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ClusterControllerClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ClusterControllerSettings"/>.</param>
        /// <returns>The created <see cref="ClusterControllerClient"/>.</returns>
        public static ClusterControllerClient Create(ServiceEndpoint endpoint = null, ClusterControllerSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ClusterControllerClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ClusterControllerSettings"/>.</param>
        /// <returns>The created <see cref="ClusterControllerClient"/>.</returns>
        public static ClusterControllerClient Create(Channel channel, ClusterControllerSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            ClusterController.ClusterControllerClient grpcClient = new ClusterController.ClusterControllerClient(channel);
            return new ClusterControllerClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, ClusterControllerSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, ClusterControllerSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, ClusterControllerSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, ClusterControllerSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ClusterController client.
        /// </summary>
        public virtual ClusterController.ClusterControllerClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Creates a cluster in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Cluster, ClusterOperationMetadata>> CreateClusterAsync(
            string projectId,
            string region,
            Cluster cluster,
            CallSettings callSettings = null) => CreateClusterAsync(
                new CreateClusterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    Cluster = GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                },
                callSettings);

        /// <summary>
        /// Creates a cluster in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Cluster, ClusterOperationMetadata>> CreateClusterAsync(
            string projectId,
            string region,
            Cluster cluster,
            CancellationToken cancellationToken) => CreateClusterAsync(
                projectId,
                region,
                cluster,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a cluster in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Cluster, ClusterOperationMetadata> CreateCluster(
            string projectId,
            string region,
            Cluster cluster,
            CallSettings callSettings = null) => CreateCluster(
                new CreateClusterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    Cluster = GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                },
                callSettings);

        /// <summary>
        /// Creates a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Cluster, ClusterOperationMetadata>> CreateClusterAsync(
            CreateClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateClusterAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Cluster, ClusterOperationMetadata>> PollOnceCreateClusterAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Cluster, ClusterOperationMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Creates a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Cluster, ClusterOperationMetadata> CreateCluster(
            CreateClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateCluster</c>.
        /// </summary>
        public virtual OperationsClient CreateClusterOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCluster</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Cluster, ClusterOperationMetadata> PollOnceCreateCluster(
            string operationName,
            CallSettings callSettings = null) => Operation<Cluster, ClusterOperationMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Updates a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Cluster, ClusterOperationMetadata>> UpdateClusterAsync(
            UpdateClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateClusterAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Cluster, ClusterOperationMetadata>> PollOnceUpdateClusterAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Cluster, ClusterOperationMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Updates a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Cluster, ClusterOperationMetadata> UpdateCluster(
            UpdateClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateCluster</c>.
        /// </summary>
        public virtual OperationsClient UpdateClusterOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateCluster</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Cluster, ClusterOperationMetadata> PollOnceUpdateCluster(
            string operationName,
            CallSettings callSettings = null) => Operation<Cluster, ClusterOperationMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Deletes a cluster in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Empty, ClusterOperationMetadata>> DeleteClusterAsync(
            string projectId,
            string region,
            string clusterName,
            CallSettings callSettings = null) => DeleteClusterAsync(
                new DeleteClusterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    ClusterName = GaxPreconditions.CheckNotNullOrEmpty(clusterName, nameof(clusterName)),
                },
                callSettings);

        /// <summary>
        /// Deletes a cluster in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Empty, ClusterOperationMetadata>> DeleteClusterAsync(
            string projectId,
            string region,
            string clusterName,
            CancellationToken cancellationToken) => DeleteClusterAsync(
                projectId,
                region,
                clusterName,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a cluster in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Empty, ClusterOperationMetadata> DeleteCluster(
            string projectId,
            string region,
            string clusterName,
            CallSettings callSettings = null) => DeleteCluster(
                new DeleteClusterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    ClusterName = GaxPreconditions.CheckNotNullOrEmpty(clusterName, nameof(clusterName)),
                },
                callSettings);

        /// <summary>
        /// Deletes a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Empty, ClusterOperationMetadata>> DeleteClusterAsync(
            DeleteClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteClusterAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Empty, ClusterOperationMetadata>> PollOnceDeleteClusterAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Empty, ClusterOperationMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                DeleteClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Deletes a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Empty, ClusterOperationMetadata> DeleteCluster(
            DeleteClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>DeleteCluster</c>.
        /// </summary>
        public virtual OperationsClient DeleteClusterOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCluster</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Empty, ClusterOperationMetadata> PollOnceDeleteCluster(
            string operationName,
            CallSettings callSettings = null) => Operation<Empty, ClusterOperationMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                DeleteClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Gets the resource representation for a cluster in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Cluster> GetClusterAsync(
            string projectId,
            string region,
            string clusterName,
            CallSettings callSettings = null) => GetClusterAsync(
                new GetClusterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    ClusterName = GaxPreconditions.CheckNotNullOrEmpty(clusterName, nameof(clusterName)),
                },
                callSettings);

        /// <summary>
        /// Gets the resource representation for a cluster in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Cluster> GetClusterAsync(
            string projectId,
            string region,
            string clusterName,
            CancellationToken cancellationToken) => GetClusterAsync(
                projectId,
                region,
                clusterName,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for a cluster in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Cluster GetCluster(
            string projectId,
            string region,
            string clusterName,
            CallSettings callSettings = null) => GetCluster(
                new GetClusterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    ClusterName = GaxPreconditions.CheckNotNullOrEmpty(clusterName, nameof(clusterName)),
                },
                callSettings);

        /// <summary>
        /// Gets the resource representation for a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Cluster> GetClusterAsync(
            GetClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the resource representation for a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Cluster> GetClusterAsync(
            GetClusterRequest request,
            CancellationToken cancellationToken) => GetClusterAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Cluster GetCluster(
            GetClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all regions/{region}/clusters in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Cluster"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(
            string projectId,
            string region,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListClustersAsync(
                new ListClustersRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all regions/{region}/clusters in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Cluster"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListClustersResponse, Cluster> ListClusters(
            string projectId,
            string region,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListClusters(
                new ListClustersRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all regions/{region}/clusters in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Cluster"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(
            ListClustersRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all regions/{region}/clusters in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Cluster"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListClustersResponse, Cluster> ListClusters(
            ListClustersRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets cluster diagnostic information.
        /// After the operation completes, the Operation.response field
        /// contains `DiagnoseClusterOutputLocation`.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Empty, DiagnoseClusterResults>> DiagnoseClusterAsync(
            string projectId,
            string region,
            string clusterName,
            CallSettings callSettings = null) => DiagnoseClusterAsync(
                new DiagnoseClusterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    ClusterName = GaxPreconditions.CheckNotNullOrEmpty(clusterName, nameof(clusterName)),
                },
                callSettings);

        /// <summary>
        /// Gets cluster diagnostic information.
        /// After the operation completes, the Operation.response field
        /// contains `DiagnoseClusterOutputLocation`.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Empty, DiagnoseClusterResults>> DiagnoseClusterAsync(
            string projectId,
            string region,
            string clusterName,
            CancellationToken cancellationToken) => DiagnoseClusterAsync(
                projectId,
                region,
                clusterName,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets cluster diagnostic information.
        /// After the operation completes, the Operation.response field
        /// contains `DiagnoseClusterOutputLocation`.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Empty, DiagnoseClusterResults> DiagnoseCluster(
            string projectId,
            string region,
            string clusterName,
            CallSettings callSettings = null) => DiagnoseCluster(
                new DiagnoseClusterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    ClusterName = GaxPreconditions.CheckNotNullOrEmpty(clusterName, nameof(clusterName)),
                },
                callSettings);

        /// <summary>
        /// Gets cluster diagnostic information.
        /// After the operation completes, the Operation.response field
        /// contains `DiagnoseClusterOutputLocation`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Empty, DiagnoseClusterResults>> DiagnoseClusterAsync(
            DiagnoseClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DiagnoseClusterAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Empty, DiagnoseClusterResults>> PollOnceDiagnoseClusterAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Empty, DiagnoseClusterResults>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                DiagnoseClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Gets cluster diagnostic information.
        /// After the operation completes, the Operation.response field
        /// contains `DiagnoseClusterOutputLocation`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Empty, DiagnoseClusterResults> DiagnoseCluster(
            DiagnoseClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>DiagnoseCluster</c>.
        /// </summary>
        public virtual OperationsClient DiagnoseClusterOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DiagnoseCluster</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Empty, DiagnoseClusterResults> PollOnceDiagnoseCluster(
            string operationName,
            CallSettings callSettings = null) => Operation<Empty, DiagnoseClusterResults>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                DiagnoseClusterOperationsClient,
                callSettings);

    }

    /// <summary>
    /// ClusterController client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ClusterControllerClientImpl : ClusterControllerClient
    {
        private readonly ApiCall<CreateClusterRequest, Operation> _callCreateCluster;
        private readonly ApiCall<UpdateClusterRequest, Operation> _callUpdateCluster;
        private readonly ApiCall<DeleteClusterRequest, Operation> _callDeleteCluster;
        private readonly ApiCall<GetClusterRequest, Cluster> _callGetCluster;
        private readonly ApiCall<ListClustersRequest, ListClustersResponse> _callListClusters;
        private readonly ApiCall<DiagnoseClusterRequest, Operation> _callDiagnoseCluster;

        /// <summary>
        /// Constructs a client wrapper for the ClusterController service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ClusterControllerSettings"/> used within this client </param>
        public ClusterControllerClientImpl(ClusterController.ClusterControllerClient grpcClient, ClusterControllerSettings settings)
        {
            GrpcClient = grpcClient;
            ClusterControllerSettings effectiveSettings = settings ?? ClusterControllerSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            CreateClusterOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateClusterOperationsSettings);
            UpdateClusterOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.UpdateClusterOperationsSettings);
            DeleteClusterOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.DeleteClusterOperationsSettings);
            DiagnoseClusterOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.DiagnoseClusterOperationsSettings);
            _callCreateCluster = clientHelper.BuildApiCall<CreateClusterRequest, Operation>(
                GrpcClient.CreateClusterAsync, GrpcClient.CreateCluster, effectiveSettings.CreateClusterSettings);
            _callUpdateCluster = clientHelper.BuildApiCall<UpdateClusterRequest, Operation>(
                GrpcClient.UpdateClusterAsync, GrpcClient.UpdateCluster, effectiveSettings.UpdateClusterSettings);
            _callDeleteCluster = clientHelper.BuildApiCall<DeleteClusterRequest, Operation>(
                GrpcClient.DeleteClusterAsync, GrpcClient.DeleteCluster, effectiveSettings.DeleteClusterSettings);
            _callGetCluster = clientHelper.BuildApiCall<GetClusterRequest, Cluster>(
                GrpcClient.GetClusterAsync, GrpcClient.GetCluster, effectiveSettings.GetClusterSettings);
            _callListClusters = clientHelper.BuildApiCall<ListClustersRequest, ListClustersResponse>(
                GrpcClient.ListClustersAsync, GrpcClient.ListClusters, effectiveSettings.ListClustersSettings);
            _callDiagnoseCluster = clientHelper.BuildApiCall<DiagnoseClusterRequest, Operation>(
                GrpcClient.DiagnoseClusterAsync, GrpcClient.DiagnoseCluster, effectiveSettings.DiagnoseClusterSettings);
            Modify_ApiCall(ref _callCreateCluster);
            Modify_CreateClusterApiCall(ref _callCreateCluster);
            Modify_ApiCall(ref _callUpdateCluster);
            Modify_UpdateClusterApiCall(ref _callUpdateCluster);
            Modify_ApiCall(ref _callDeleteCluster);
            Modify_DeleteClusterApiCall(ref _callDeleteCluster);
            Modify_ApiCall(ref _callGetCluster);
            Modify_GetClusterApiCall(ref _callGetCluster);
            Modify_ApiCall(ref _callListClusters);
            Modify_ListClustersApiCall(ref _callListClusters);
            Modify_ApiCall(ref _callDiagnoseCluster);
            Modify_DiagnoseClusterApiCall(ref _callDiagnoseCluster);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref ApiCall<TRequest, TResponse> call)
            where TRequest : class, IMessage<TRequest>
            where TResponse : class, IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_CreateClusterApiCall(ref ApiCall<CreateClusterRequest, Operation> call);
        partial void Modify_UpdateClusterApiCall(ref ApiCall<UpdateClusterRequest, Operation> call);
        partial void Modify_DeleteClusterApiCall(ref ApiCall<DeleteClusterRequest, Operation> call);
        partial void Modify_GetClusterApiCall(ref ApiCall<GetClusterRequest, Cluster> call);
        partial void Modify_ListClustersApiCall(ref ApiCall<ListClustersRequest, ListClustersResponse> call);
        partial void Modify_DiagnoseClusterApiCall(ref ApiCall<DiagnoseClusterRequest, Operation> call);
        partial void OnConstruction(ClusterController.ClusterControllerClient grpcClient, ClusterControllerSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ClusterController client.
        /// </summary>
        public override ClusterController.ClusterControllerClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateClusterRequest(ref CreateClusterRequest request, ref CallSettings settings);
        partial void Modify_UpdateClusterRequest(ref UpdateClusterRequest request, ref CallSettings settings);
        partial void Modify_DeleteClusterRequest(ref DeleteClusterRequest request, ref CallSettings settings);
        partial void Modify_GetClusterRequest(ref GetClusterRequest request, ref CallSettings settings);
        partial void Modify_ListClustersRequest(ref ListClustersRequest request, ref CallSettings settings);
        partial void Modify_DiagnoseClusterRequest(ref DiagnoseClusterRequest request, ref CallSettings settings);

        /// <summary>
        /// Creates a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override async Task<Operation<Cluster, ClusterOperationMetadata>> CreateClusterAsync(
            CreateClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new Operation<Cluster, ClusterOperationMetadata>(
                await _callCreateCluster.Async(request, callSettings).ConfigureAwait(false), CreateClusterOperationsClient);
        }

        /// <summary>
        /// Creates a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Operation<Cluster, ClusterOperationMetadata> CreateCluster(
            CreateClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new Operation<Cluster, ClusterOperationMetadata>(
                _callCreateCluster.Sync(request, callSettings), CreateClusterOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateCluster</c>.
        /// </summary>
        public override OperationsClient CreateClusterOperationsClient { get; }

        /// <summary>
        /// Updates a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override async Task<Operation<Cluster, ClusterOperationMetadata>> UpdateClusterAsync(
            UpdateClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateClusterRequest(ref request, ref callSettings);
            return new Operation<Cluster, ClusterOperationMetadata>(
                await _callUpdateCluster.Async(request, callSettings).ConfigureAwait(false), UpdateClusterOperationsClient);
        }

        /// <summary>
        /// Updates a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Operation<Cluster, ClusterOperationMetadata> UpdateCluster(
            UpdateClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateClusterRequest(ref request, ref callSettings);
            return new Operation<Cluster, ClusterOperationMetadata>(
                _callUpdateCluster.Sync(request, callSettings), UpdateClusterOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateCluster</c>.
        /// </summary>
        public override OperationsClient UpdateClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override async Task<Operation<Empty, ClusterOperationMetadata>> DeleteClusterAsync(
            DeleteClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return new Operation<Empty, ClusterOperationMetadata>(
                await _callDeleteCluster.Async(request, callSettings).ConfigureAwait(false), DeleteClusterOperationsClient);
        }

        /// <summary>
        /// Deletes a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Operation<Empty, ClusterOperationMetadata> DeleteCluster(
            DeleteClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return new Operation<Empty, ClusterOperationMetadata>(
                _callDeleteCluster.Sync(request, callSettings), DeleteClusterOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>DeleteCluster</c>.
        /// </summary>
        public override OperationsClient DeleteClusterOperationsClient { get; }

        /// <summary>
        /// Gets the resource representation for a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<Cluster> GetClusterAsync(
            GetClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the resource representation for a cluster in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Cluster GetCluster(
            GetClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all regions/{region}/clusters in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Cluster"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(
            ListClustersRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListClustersRequest, ListClustersResponse, Cluster>(_callListClusters, request, callSettings);
        }

        /// <summary>
        /// Lists all regions/{region}/clusters in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Cluster"/> resources.
        /// </returns>
        public override PagedEnumerable<ListClustersResponse, Cluster> ListClusters(
            ListClustersRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListClustersRequest, ListClustersResponse, Cluster>(_callListClusters, request, callSettings);
        }

        /// <summary>
        /// Gets cluster diagnostic information.
        /// After the operation completes, the Operation.response field
        /// contains `DiagnoseClusterOutputLocation`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override async Task<Operation<Empty, DiagnoseClusterResults>> DiagnoseClusterAsync(
            DiagnoseClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_DiagnoseClusterRequest(ref request, ref callSettings);
            return new Operation<Empty, DiagnoseClusterResults>(
                await _callDiagnoseCluster.Async(request, callSettings).ConfigureAwait(false), DiagnoseClusterOperationsClient);
        }

        /// <summary>
        /// Gets cluster diagnostic information.
        /// After the operation completes, the Operation.response field
        /// contains `DiagnoseClusterOutputLocation`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Operation<Empty, DiagnoseClusterResults> DiagnoseCluster(
            DiagnoseClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_DiagnoseClusterRequest(ref request, ref callSettings);
            return new Operation<Empty, DiagnoseClusterResults>(
                _callDiagnoseCluster.Sync(request, callSettings), DiagnoseClusterOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>DiagnoseCluster</c>.
        /// </summary>
        public override OperationsClient DiagnoseClusterOperationsClient { get; }

    }

    // Partial classes to enable page-streaming

    public partial class ListClustersRequest : IPageRequest { }
    public partial class ListClustersResponse : IPageResponse<Cluster>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<Cluster> GetEnumerator() => Clusters.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class ClusterController
    {
        public partial class ClusterControllerClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual Operations.OperationsClient CreateOperationsClient() => new Operations.OperationsClient(CallInvoker);
        }
    }


}
