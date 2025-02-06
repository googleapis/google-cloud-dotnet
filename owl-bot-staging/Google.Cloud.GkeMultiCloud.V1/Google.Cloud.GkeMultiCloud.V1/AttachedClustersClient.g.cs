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

namespace Google.Cloud.GkeMultiCloud.V1
{
    /// <summary>Settings for <see cref="AttachedClustersClient"/> instances.</summary>
    public sealed partial class AttachedClustersSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AttachedClustersSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AttachedClustersSettings"/>.</returns>
        public static AttachedClustersSettings GetDefault() => new AttachedClustersSettings();

        /// <summary>Constructs a new <see cref="AttachedClustersSettings"/> object with default settings.</summary>
        public AttachedClustersSettings()
        {
        }

        private AttachedClustersSettings(AttachedClustersSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateAttachedClusterSettings = existing.CreateAttachedClusterSettings;
            CreateAttachedClusterOperationsSettings = existing.CreateAttachedClusterOperationsSettings.Clone();
            UpdateAttachedClusterSettings = existing.UpdateAttachedClusterSettings;
            UpdateAttachedClusterOperationsSettings = existing.UpdateAttachedClusterOperationsSettings.Clone();
            ImportAttachedClusterSettings = existing.ImportAttachedClusterSettings;
            ImportAttachedClusterOperationsSettings = existing.ImportAttachedClusterOperationsSettings.Clone();
            GetAttachedClusterSettings = existing.GetAttachedClusterSettings;
            ListAttachedClustersSettings = existing.ListAttachedClustersSettings;
            DeleteAttachedClusterSettings = existing.DeleteAttachedClusterSettings;
            DeleteAttachedClusterOperationsSettings = existing.DeleteAttachedClusterOperationsSettings.Clone();
            GetAttachedServerConfigSettings = existing.GetAttachedServerConfigSettings;
            GenerateAttachedClusterInstallManifestSettings = existing.GenerateAttachedClusterInstallManifestSettings;
            GenerateAttachedClusterAgentTokenSettings = existing.GenerateAttachedClusterAgentTokenSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AttachedClustersSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AttachedClustersClient.CreateAttachedCluster</c> and <c>AttachedClustersClient.CreateAttachedClusterAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAttachedClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AttachedClustersClient.CreateAttachedCluster</c> and
        /// <c>AttachedClustersClient.CreateAttachedClusterAsync</c>.
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
        public lro::OperationsSettings CreateAttachedClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AttachedClustersClient.UpdateAttachedCluster</c> and <c>AttachedClustersClient.UpdateAttachedClusterAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAttachedClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AttachedClustersClient.UpdateAttachedCluster</c> and
        /// <c>AttachedClustersClient.UpdateAttachedClusterAsync</c>.
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
        public lro::OperationsSettings UpdateAttachedClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AttachedClustersClient.ImportAttachedCluster</c> and <c>AttachedClustersClient.ImportAttachedClusterAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportAttachedClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AttachedClustersClient.ImportAttachedCluster</c> and
        /// <c>AttachedClustersClient.ImportAttachedClusterAsync</c>.
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
        public lro::OperationsSettings ImportAttachedClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AttachedClustersClient.GetAttachedCluster</c> and <c>AttachedClustersClient.GetAttachedClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAttachedClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AttachedClustersClient.ListAttachedClusters</c> and <c>AttachedClustersClient.ListAttachedClustersAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAttachedClustersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AttachedClustersClient.DeleteAttachedCluster</c> and <c>AttachedClustersClient.DeleteAttachedClusterAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAttachedClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AttachedClustersClient.DeleteAttachedCluster</c> and
        /// <c>AttachedClustersClient.DeleteAttachedClusterAsync</c>.
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
        public lro::OperationsSettings DeleteAttachedClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AttachedClustersClient.GetAttachedServerConfig</c> and
        /// <c>AttachedClustersClient.GetAttachedServerConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAttachedServerConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AttachedClustersClient.GenerateAttachedClusterInstallManifest</c> and
        /// <c>AttachedClustersClient.GenerateAttachedClusterInstallManifestAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateAttachedClusterInstallManifestSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AttachedClustersClient.GenerateAttachedClusterAgentToken</c> and
        /// <c>AttachedClustersClient.GenerateAttachedClusterAgentTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateAttachedClusterAgentTokenSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AttachedClustersSettings"/> object.</returns>
        public AttachedClustersSettings Clone() => new AttachedClustersSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AttachedClustersClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AttachedClustersClientBuilder : gaxgrpc::ClientBuilderBase<AttachedClustersClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AttachedClustersSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AttachedClustersClientBuilder() : base(AttachedClustersClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AttachedClustersClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AttachedClustersClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AttachedClustersClient Build()
        {
            AttachedClustersClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AttachedClustersClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AttachedClustersClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AttachedClustersClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AttachedClustersClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AttachedClustersClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AttachedClustersClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AttachedClustersClient.ChannelPool;
    }

    /// <summary>AttachedClusters client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The AttachedClusters API provides a single centrally managed service
    /// to register and manage Anthos attached clusters that run on customer's owned
    /// infrastructure.
    /// </remarks>
    public abstract partial class AttachedClustersClient
    {
        /// <summary>
        /// The default endpoint for the AttachedClusters service, which is a host of "gkemulticloud.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "gkemulticloud.googleapis.com:443";

        /// <summary>The default AttachedClusters scopes.</summary>
        /// <remarks>
        /// The default AttachedClusters scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AttachedClusters.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AttachedClustersClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AttachedClustersClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AttachedClustersClient"/>.</returns>
        public static stt::Task<AttachedClustersClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AttachedClustersClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AttachedClustersClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AttachedClustersClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AttachedClustersClient"/>.</returns>
        public static AttachedClustersClient Create() => new AttachedClustersClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AttachedClustersClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AttachedClustersSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AttachedClustersClient"/>.</returns>
        internal static AttachedClustersClient Create(grpccore::CallInvoker callInvoker, AttachedClustersSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AttachedClusters.AttachedClustersClient grpcClient = new AttachedClusters.AttachedClustersClient(callInvoker);
            return new AttachedClustersClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AttachedClusters client</summary>
        public virtual AttachedClusters.AttachedClustersClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AttachedCluster, OperationMetadata> CreateAttachedCluster(CreateAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> CreateAttachedClusterAsync(CreateAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> CreateAttachedClusterAsync(CreateAttachedClusterRequest request, st::CancellationToken cancellationToken) =>
            CreateAttachedClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAttachedCluster</c>.</summary>
        public virtual lro::OperationsClient CreateAttachedClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAttachedCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AttachedCluster, OperationMetadata> PollOnceCreateAttachedCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AttachedCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAttachedClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAttachedCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> PollOnceCreateAttachedClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AttachedCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAttachedClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="attachedCluster">
        /// Required. The specification of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] to create.
        /// </param>
        /// <param name="attachedClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// name formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AttachedCluster, OperationMetadata> CreateAttachedCluster(string parent, AttachedCluster attachedCluster, string attachedClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAttachedCluster(new CreateAttachedClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AttachedCluster = gax::GaxPreconditions.CheckNotNull(attachedCluster, nameof(attachedCluster)),
                AttachedClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(attachedClusterId, nameof(attachedClusterId)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="attachedCluster">
        /// Required. The specification of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] to create.
        /// </param>
        /// <param name="attachedClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// name formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> CreateAttachedClusterAsync(string parent, AttachedCluster attachedCluster, string attachedClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAttachedClusterAsync(new CreateAttachedClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AttachedCluster = gax::GaxPreconditions.CheckNotNull(attachedCluster, nameof(attachedCluster)),
                AttachedClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(attachedClusterId, nameof(attachedClusterId)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="attachedCluster">
        /// Required. The specification of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] to create.
        /// </param>
        /// <param name="attachedClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// name formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> CreateAttachedClusterAsync(string parent, AttachedCluster attachedCluster, string attachedClusterId, st::CancellationToken cancellationToken) =>
            CreateAttachedClusterAsync(parent, attachedCluster, attachedClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="attachedCluster">
        /// Required. The specification of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] to create.
        /// </param>
        /// <param name="attachedClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// name formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AttachedCluster, OperationMetadata> CreateAttachedCluster(gagr::LocationName parent, AttachedCluster attachedCluster, string attachedClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAttachedCluster(new CreateAttachedClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AttachedCluster = gax::GaxPreconditions.CheckNotNull(attachedCluster, nameof(attachedCluster)),
                AttachedClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(attachedClusterId, nameof(attachedClusterId)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="attachedCluster">
        /// Required. The specification of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] to create.
        /// </param>
        /// <param name="attachedClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// name formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> CreateAttachedClusterAsync(gagr::LocationName parent, AttachedCluster attachedCluster, string attachedClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAttachedClusterAsync(new CreateAttachedClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AttachedCluster = gax::GaxPreconditions.CheckNotNull(attachedCluster, nameof(attachedCluster)),
                AttachedClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(attachedClusterId, nameof(attachedClusterId)),
            }, callSettings);

        /// <summary>
        /// Creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="attachedCluster">
        /// Required. The specification of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] to create.
        /// </param>
        /// <param name="attachedClusterId">
        /// Required. A client provided ID the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// name formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> CreateAttachedClusterAsync(gagr::LocationName parent, AttachedCluster attachedCluster, string attachedClusterId, st::CancellationToken cancellationToken) =>
            CreateAttachedClusterAsync(parent, attachedCluster, attachedClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AttachedCluster, OperationMetadata> UpdateAttachedCluster(UpdateAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> UpdateAttachedClusterAsync(UpdateAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> UpdateAttachedClusterAsync(UpdateAttachedClusterRequest request, st::CancellationToken cancellationToken) =>
            UpdateAttachedClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAttachedCluster</c>.</summary>
        public virtual lro::OperationsClient UpdateAttachedClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAttachedCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AttachedCluster, OperationMetadata> PollOnceUpdateAttachedCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AttachedCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAttachedClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAttachedCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> PollOnceUpdateAttachedClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AttachedCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAttachedClusterOperationsClient, callSettings);

        /// <summary>
        /// Updates an
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster].
        /// </summary>
        /// <param name="attachedCluster">
        /// Required. The
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field can only include these
        /// fields from
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster]:
        /// 
        /// *   `annotations`.
        /// *   `authorization.admin_groups`.
        /// *   `authorization.admin_users`.
        /// *   `binary_authorization.evaluation_mode`.
        /// *   `description`.
        /// *   `logging_config.component_config.enable_components`.
        /// *   `monitoring_config.managed_prometheus_config.enabled`.
        /// *   `platform_version`.
        /// *   `proxy_config.kubernetes_secret.name`.
        /// *   `proxy_config.kubernetes_secret.namespace`.
        /// *   `security_posture_config.vulnerability_mode`
        /// *   `monitoring_config.cloud_monitoring_config.enabled`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AttachedCluster, OperationMetadata> UpdateAttachedCluster(AttachedCluster attachedCluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAttachedCluster(new UpdateAttachedClusterRequest
            {
                AttachedCluster = gax::GaxPreconditions.CheckNotNull(attachedCluster, nameof(attachedCluster)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster].
        /// </summary>
        /// <param name="attachedCluster">
        /// Required. The
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field can only include these
        /// fields from
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster]:
        /// 
        /// *   `annotations`.
        /// *   `authorization.admin_groups`.
        /// *   `authorization.admin_users`.
        /// *   `binary_authorization.evaluation_mode`.
        /// *   `description`.
        /// *   `logging_config.component_config.enable_components`.
        /// *   `monitoring_config.managed_prometheus_config.enabled`.
        /// *   `platform_version`.
        /// *   `proxy_config.kubernetes_secret.name`.
        /// *   `proxy_config.kubernetes_secret.namespace`.
        /// *   `security_posture_config.vulnerability_mode`
        /// *   `monitoring_config.cloud_monitoring_config.enabled`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> UpdateAttachedClusterAsync(AttachedCluster attachedCluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAttachedClusterAsync(new UpdateAttachedClusterRequest
            {
                AttachedCluster = gax::GaxPreconditions.CheckNotNull(attachedCluster, nameof(attachedCluster)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster].
        /// </summary>
        /// <param name="attachedCluster">
        /// Required. The
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field can only include these
        /// fields from
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster]:
        /// 
        /// *   `annotations`.
        /// *   `authorization.admin_groups`.
        /// *   `authorization.admin_users`.
        /// *   `binary_authorization.evaluation_mode`.
        /// *   `description`.
        /// *   `logging_config.component_config.enable_components`.
        /// *   `monitoring_config.managed_prometheus_config.enabled`.
        /// *   `platform_version`.
        /// *   `proxy_config.kubernetes_secret.name`.
        /// *   `proxy_config.kubernetes_secret.namespace`.
        /// *   `security_posture_config.vulnerability_mode`
        /// *   `monitoring_config.cloud_monitoring_config.enabled`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> UpdateAttachedClusterAsync(AttachedCluster attachedCluster, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAttachedClusterAsync(attachedCluster, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// by importing an existing Fleet Membership resource.
        /// 
        /// Attached Clusters created before the introduction of the Anthos Multi-Cloud
        /// API can be imported through this method.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AttachedCluster, OperationMetadata> ImportAttachedCluster(ImportAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// by importing an existing Fleet Membership resource.
        /// 
        /// Attached Clusters created before the introduction of the Anthos Multi-Cloud
        /// API can be imported through this method.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> ImportAttachedClusterAsync(ImportAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// by importing an existing Fleet Membership resource.
        /// 
        /// Attached Clusters created before the introduction of the Anthos Multi-Cloud
        /// API can be imported through this method.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> ImportAttachedClusterAsync(ImportAttachedClusterRequest request, st::CancellationToken cancellationToken) =>
            ImportAttachedClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportAttachedCluster</c>.</summary>
        public virtual lro::OperationsClient ImportAttachedClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportAttachedCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AttachedCluster, OperationMetadata> PollOnceImportAttachedCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AttachedCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportAttachedClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportAttachedCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> PollOnceImportAttachedClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AttachedCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportAttachedClusterOperationsClient, callSettings);

        /// <summary>
        /// Imports creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// by importing an existing Fleet Membership resource.
        /// 
        /// Attached Clusters created before the introduction of the Anthos Multi-Cloud
        /// API can be imported through this method.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="fleetMembership">
        /// Required. The name of the fleet membership resource to import.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AttachedCluster, OperationMetadata> ImportAttachedCluster(string parent, string fleetMembership, gaxgrpc::CallSettings callSettings = null) =>
            ImportAttachedCluster(new ImportAttachedClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FleetMembership = gax::GaxPreconditions.CheckNotNullOrEmpty(fleetMembership, nameof(fleetMembership)),
            }, callSettings);

        /// <summary>
        /// Imports creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// by importing an existing Fleet Membership resource.
        /// 
        /// Attached Clusters created before the introduction of the Anthos Multi-Cloud
        /// API can be imported through this method.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="fleetMembership">
        /// Required. The name of the fleet membership resource to import.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> ImportAttachedClusterAsync(string parent, string fleetMembership, gaxgrpc::CallSettings callSettings = null) =>
            ImportAttachedClusterAsync(new ImportAttachedClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FleetMembership = gax::GaxPreconditions.CheckNotNullOrEmpty(fleetMembership, nameof(fleetMembership)),
            }, callSettings);

        /// <summary>
        /// Imports creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// by importing an existing Fleet Membership resource.
        /// 
        /// Attached Clusters created before the introduction of the Anthos Multi-Cloud
        /// API can be imported through this method.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="fleetMembership">
        /// Required. The name of the fleet membership resource to import.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> ImportAttachedClusterAsync(string parent, string fleetMembership, st::CancellationToken cancellationToken) =>
            ImportAttachedClusterAsync(parent, fleetMembership, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// by importing an existing Fleet Membership resource.
        /// 
        /// Attached Clusters created before the introduction of the Anthos Multi-Cloud
        /// API can be imported through this method.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="fleetMembership">
        /// Required. The name of the fleet membership resource to import.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AttachedCluster, OperationMetadata> ImportAttachedCluster(gagr::LocationName parent, string fleetMembership, gaxgrpc::CallSettings callSettings = null) =>
            ImportAttachedCluster(new ImportAttachedClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FleetMembership = gax::GaxPreconditions.CheckNotNullOrEmpty(fleetMembership, nameof(fleetMembership)),
            }, callSettings);

        /// <summary>
        /// Imports creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// by importing an existing Fleet Membership resource.
        /// 
        /// Attached Clusters created before the introduction of the Anthos Multi-Cloud
        /// API can be imported through this method.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="fleetMembership">
        /// Required. The name of the fleet membership resource to import.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> ImportAttachedClusterAsync(gagr::LocationName parent, string fleetMembership, gaxgrpc::CallSettings callSettings = null) =>
            ImportAttachedClusterAsync(new ImportAttachedClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FleetMembership = gax::GaxPreconditions.CheckNotNullOrEmpty(fleetMembership, nameof(fleetMembership)),
            }, callSettings);

        /// <summary>
        /// Imports creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// by importing an existing Fleet Membership resource.
        /// 
        /// Attached Clusters created before the introduction of the Anthos Multi-Cloud
        /// API can be imported through this method.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="fleetMembership">
        /// Required. The name of the fleet membership resource to import.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> ImportAttachedClusterAsync(gagr::LocationName parent, string fleetMembership, st::CancellationToken cancellationToken) =>
            ImportAttachedClusterAsync(parent, fleetMembership, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AttachedCluster GetAttachedCluster(GetAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttachedCluster> GetAttachedClusterAsync(GetAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttachedCluster> GetAttachedClusterAsync(GetAttachedClusterRequest request, st::CancellationToken cancellationToken) =>
            GetAttachedClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// to describe.
        /// 
        /// `AttachedCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AttachedCluster GetAttachedCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttachedCluster(new GetAttachedClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// to describe.
        /// 
        /// `AttachedCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttachedCluster> GetAttachedClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttachedClusterAsync(new GetAttachedClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// to describe.
        /// 
        /// `AttachedCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttachedCluster> GetAttachedClusterAsync(string name, st::CancellationToken cancellationToken) =>
            GetAttachedClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// to describe.
        /// 
        /// `AttachedCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AttachedCluster GetAttachedCluster(AttachedClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttachedCluster(new GetAttachedClusterRequest
            {
                AttachedClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// to describe.
        /// 
        /// `AttachedCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttachedCluster> GetAttachedClusterAsync(AttachedClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttachedClusterAsync(new GetAttachedClusterRequest
            {
                AttachedClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// to describe.
        /// 
        /// `AttachedCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttachedCluster> GetAttachedClusterAsync(AttachedClusterName name, st::CancellationToken cancellationToken) =>
            GetAttachedClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AttachedCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttachedClustersResponse, AttachedCluster> ListAttachedClusters(ListAttachedClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AttachedCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttachedClustersResponse, AttachedCluster> ListAttachedClustersAsync(ListAttachedClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location which owns this collection of
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resources.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
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
        /// <returns>A pageable sequence of <see cref="AttachedCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttachedClustersResponse, AttachedCluster> ListAttachedClusters(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttachedClustersRequest request = new ListAttachedClustersRequest
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
            return ListAttachedClusters(request, callSettings);
        }

        /// <summary>
        /// Lists all [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location which owns this collection of
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resources.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AttachedCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttachedClustersResponse, AttachedCluster> ListAttachedClustersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttachedClustersRequest request = new ListAttachedClustersRequest
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
            return ListAttachedClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location which owns this collection of
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resources.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
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
        /// <returns>A pageable sequence of <see cref="AttachedCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttachedClustersResponse, AttachedCluster> ListAttachedClusters(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttachedClustersRequest request = new ListAttachedClustersRequest
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
            return ListAttachedClusters(request, callSettings);
        }

        /// <summary>
        /// Lists all [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location which owns this collection of
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resources.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AttachedCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttachedClustersResponse, AttachedCluster> ListAttachedClustersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttachedClustersRequest request = new ListAttachedClustersRequest
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
            return ListAttachedClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAttachedCluster(DeleteAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAttachedClusterAsync(DeleteAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAttachedClusterAsync(DeleteAttachedClusterRequest request, st::CancellationToken cancellationToken) =>
            DeleteAttachedClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAttachedCluster</c>.</summary>
        public virtual lro::OperationsClient DeleteAttachedClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAttachedCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAttachedCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAttachedClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAttachedCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAttachedClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAttachedClusterOperationsClient, callSettings);

        /// <summary>
        /// Deletes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] to delete.
        /// 
        /// `AttachedCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAttachedCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAttachedCluster(new DeleteAttachedClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] to delete.
        /// 
        /// `AttachedCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAttachedClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAttachedClusterAsync(new DeleteAttachedClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] to delete.
        /// 
        /// `AttachedCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAttachedClusterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAttachedClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] to delete.
        /// 
        /// `AttachedCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAttachedCluster(AttachedClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAttachedCluster(new DeleteAttachedClusterRequest
            {
                AttachedClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] to delete.
        /// 
        /// `AttachedCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAttachedClusterAsync(AttachedClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAttachedClusterAsync(new DeleteAttachedClusterRequest
            {
                AttachedClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] to delete.
        /// 
        /// `AttachedCluster` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud Platform resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAttachedClusterAsync(AttachedClusterName name, st::CancellationToken cancellationToken) =>
            DeleteAttachedClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information, such as supported Kubernetes versions, on a given
        /// Google Cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AttachedServerConfig GetAttachedServerConfig(GetAttachedServerConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information, such as supported Kubernetes versions, on a given
        /// Google Cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttachedServerConfig> GetAttachedServerConfigAsync(GetAttachedServerConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information, such as supported Kubernetes versions, on a given
        /// Google Cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttachedServerConfig> GetAttachedServerConfigAsync(GetAttachedServerConfigRequest request, st::CancellationToken cancellationToken) =>
            GetAttachedServerConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information, such as supported Kubernetes versions, on a given
        /// Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AttachedServerConfig][google.cloud.gkemulticloud.v1.AttachedServerConfig]
        /// resource to describe.
        /// 
        /// `AttachedServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AttachedServerConfig GetAttachedServerConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttachedServerConfig(new GetAttachedServerConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information, such as supported Kubernetes versions, on a given
        /// Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AttachedServerConfig][google.cloud.gkemulticloud.v1.AttachedServerConfig]
        /// resource to describe.
        /// 
        /// `AttachedServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttachedServerConfig> GetAttachedServerConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttachedServerConfigAsync(new GetAttachedServerConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information, such as supported Kubernetes versions, on a given
        /// Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AttachedServerConfig][google.cloud.gkemulticloud.v1.AttachedServerConfig]
        /// resource to describe.
        /// 
        /// `AttachedServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttachedServerConfig> GetAttachedServerConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetAttachedServerConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information, such as supported Kubernetes versions, on a given
        /// Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AttachedServerConfig][google.cloud.gkemulticloud.v1.AttachedServerConfig]
        /// resource to describe.
        /// 
        /// `AttachedServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AttachedServerConfig GetAttachedServerConfig(AttachedServerConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttachedServerConfig(new GetAttachedServerConfigRequest
            {
                AttachedServerConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information, such as supported Kubernetes versions, on a given
        /// Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AttachedServerConfig][google.cloud.gkemulticloud.v1.AttachedServerConfig]
        /// resource to describe.
        /// 
        /// `AttachedServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttachedServerConfig> GetAttachedServerConfigAsync(AttachedServerConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttachedServerConfigAsync(new GetAttachedServerConfigRequest
            {
                AttachedServerConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information, such as supported Kubernetes versions, on a given
        /// Google Cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [AttachedServerConfig][google.cloud.gkemulticloud.v1.AttachedServerConfig]
        /// resource to describe.
        /// 
        /// `AttachedServerConfig` names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedServerConfig`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttachedServerConfig> GetAttachedServerConfigAsync(AttachedServerConfigName name, st::CancellationToken cancellationToken) =>
            GetAttachedServerConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates the install manifest to be installed on the target cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAttachedClusterInstallManifestResponse GenerateAttachedClusterInstallManifest(GenerateAttachedClusterInstallManifestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates the install manifest to be installed on the target cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAttachedClusterInstallManifestResponse> GenerateAttachedClusterInstallManifestAsync(GenerateAttachedClusterInstallManifestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates the install manifest to be installed on the target cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAttachedClusterInstallManifestResponse> GenerateAttachedClusterInstallManifestAsync(GenerateAttachedClusterInstallManifestRequest request, st::CancellationToken cancellationToken) =>
            GenerateAttachedClusterInstallManifestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates the install manifest to be installed on the target cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="attachedClusterId">
        /// Required. A client provided ID of the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// name formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// 
        /// When generating an install manifest for importing an existing Membership
        /// resource, the attached_cluster_id field must be the Membership id.
        /// 
        /// Membership names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/memberships/&lt;membership-id&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAttachedClusterInstallManifestResponse GenerateAttachedClusterInstallManifest(string parent, string attachedClusterId, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAttachedClusterInstallManifest(new GenerateAttachedClusterInstallManifestRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AttachedClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(attachedClusterId, nameof(attachedClusterId)),
            }, callSettings);

        /// <summary>
        /// Generates the install manifest to be installed on the target cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="attachedClusterId">
        /// Required. A client provided ID of the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// name formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// 
        /// When generating an install manifest for importing an existing Membership
        /// resource, the attached_cluster_id field must be the Membership id.
        /// 
        /// Membership names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/memberships/&lt;membership-id&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAttachedClusterInstallManifestResponse> GenerateAttachedClusterInstallManifestAsync(string parent, string attachedClusterId, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAttachedClusterInstallManifestAsync(new GenerateAttachedClusterInstallManifestRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AttachedClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(attachedClusterId, nameof(attachedClusterId)),
            }, callSettings);

        /// <summary>
        /// Generates the install manifest to be installed on the target cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="attachedClusterId">
        /// Required. A client provided ID of the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// name formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// 
        /// When generating an install manifest for importing an existing Membership
        /// resource, the attached_cluster_id field must be the Membership id.
        /// 
        /// Membership names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/memberships/&lt;membership-id&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAttachedClusterInstallManifestResponse> GenerateAttachedClusterInstallManifestAsync(string parent, string attachedClusterId, st::CancellationToken cancellationToken) =>
            GenerateAttachedClusterInstallManifestAsync(parent, attachedClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates the install manifest to be installed on the target cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="attachedClusterId">
        /// Required. A client provided ID of the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// name formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// 
        /// When generating an install manifest for importing an existing Membership
        /// resource, the attached_cluster_id field must be the Membership id.
        /// 
        /// Membership names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/memberships/&lt;membership-id&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAttachedClusterInstallManifestResponse GenerateAttachedClusterInstallManifest(gagr::LocationName parent, string attachedClusterId, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAttachedClusterInstallManifest(new GenerateAttachedClusterInstallManifestRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AttachedClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(attachedClusterId, nameof(attachedClusterId)),
            }, callSettings);

        /// <summary>
        /// Generates the install manifest to be installed on the target cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="attachedClusterId">
        /// Required. A client provided ID of the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// name formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// 
        /// When generating an install manifest for importing an existing Membership
        /// resource, the attached_cluster_id field must be the Membership id.
        /// 
        /// Membership names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/memberships/&lt;membership-id&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAttachedClusterInstallManifestResponse> GenerateAttachedClusterInstallManifestAsync(gagr::LocationName parent, string attachedClusterId, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAttachedClusterInstallManifestAsync(new GenerateAttachedClusterInstallManifestRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AttachedClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(attachedClusterId, nameof(attachedClusterId)),
            }, callSettings);

        /// <summary>
        /// Generates the install manifest to be installed on the target cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location where this
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// will be created.
        /// 
        /// Location names are formatted as `projects/&lt;project-id&gt;/locations/&lt;region&gt;`.
        /// 
        /// See [Resource Names](https://cloud.google.com/apis/design/resource_names)
        /// for more details on Google Cloud resource names.
        /// </param>
        /// <param name="attachedClusterId">
        /// Required. A client provided ID of the resource. Must be unique within the
        /// parent resource.
        /// 
        /// The provided ID will be part of the
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// name formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/attachedClusters/&lt;cluster-id&gt;`.
        /// 
        /// Valid characters are `/[a-z][0-9]-/`. Cannot be longer than 63 characters.
        /// 
        /// When generating an install manifest for importing an existing Membership
        /// resource, the attached_cluster_id field must be the Membership id.
        /// 
        /// Membership names are formatted as
        /// `projects/&lt;project-id&gt;/locations/&lt;region&gt;/memberships/&lt;membership-id&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAttachedClusterInstallManifestResponse> GenerateAttachedClusterInstallManifestAsync(gagr::LocationName parent, string attachedClusterId, st::CancellationToken cancellationToken) =>
            GenerateAttachedClusterInstallManifestAsync(parent, attachedClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates an access token for a cluster agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAttachedClusterAgentTokenResponse GenerateAttachedClusterAgentToken(GenerateAttachedClusterAgentTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an access token for a cluster agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAttachedClusterAgentTokenResponse> GenerateAttachedClusterAgentTokenAsync(GenerateAttachedClusterAgentTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an access token for a cluster agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAttachedClusterAgentTokenResponse> GenerateAttachedClusterAgentTokenAsync(GenerateAttachedClusterAgentTokenRequest request, st::CancellationToken cancellationToken) =>
            GenerateAttachedClusterAgentTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AttachedClusters client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The AttachedClusters API provides a single centrally managed service
    /// to register and manage Anthos attached clusters that run on customer's owned
    /// infrastructure.
    /// </remarks>
    public sealed partial class AttachedClustersClientImpl : AttachedClustersClient
    {
        private readonly gaxgrpc::ApiCall<CreateAttachedClusterRequest, lro::Operation> _callCreateAttachedCluster;

        private readonly gaxgrpc::ApiCall<UpdateAttachedClusterRequest, lro::Operation> _callUpdateAttachedCluster;

        private readonly gaxgrpc::ApiCall<ImportAttachedClusterRequest, lro::Operation> _callImportAttachedCluster;

        private readonly gaxgrpc::ApiCall<GetAttachedClusterRequest, AttachedCluster> _callGetAttachedCluster;

        private readonly gaxgrpc::ApiCall<ListAttachedClustersRequest, ListAttachedClustersResponse> _callListAttachedClusters;

        private readonly gaxgrpc::ApiCall<DeleteAttachedClusterRequest, lro::Operation> _callDeleteAttachedCluster;

        private readonly gaxgrpc::ApiCall<GetAttachedServerConfigRequest, AttachedServerConfig> _callGetAttachedServerConfig;

        private readonly gaxgrpc::ApiCall<GenerateAttachedClusterInstallManifestRequest, GenerateAttachedClusterInstallManifestResponse> _callGenerateAttachedClusterInstallManifest;

        private readonly gaxgrpc::ApiCall<GenerateAttachedClusterAgentTokenRequest, GenerateAttachedClusterAgentTokenResponse> _callGenerateAttachedClusterAgentToken;

        /// <summary>
        /// Constructs a client wrapper for the AttachedClusters service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AttachedClustersSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AttachedClustersClientImpl(AttachedClusters.AttachedClustersClient grpcClient, AttachedClustersSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AttachedClustersSettings effectiveSettings = settings ?? AttachedClustersSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateAttachedClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAttachedClusterOperationsSettings, logger);
            UpdateAttachedClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAttachedClusterOperationsSettings, logger);
            ImportAttachedClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportAttachedClusterOperationsSettings, logger);
            DeleteAttachedClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAttachedClusterOperationsSettings, logger);
            _callCreateAttachedCluster = clientHelper.BuildApiCall<CreateAttachedClusterRequest, lro::Operation>("CreateAttachedCluster", grpcClient.CreateAttachedClusterAsync, grpcClient.CreateAttachedCluster, effectiveSettings.CreateAttachedClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAttachedCluster);
            Modify_CreateAttachedClusterApiCall(ref _callCreateAttachedCluster);
            _callUpdateAttachedCluster = clientHelper.BuildApiCall<UpdateAttachedClusterRequest, lro::Operation>("UpdateAttachedCluster", grpcClient.UpdateAttachedClusterAsync, grpcClient.UpdateAttachedCluster, effectiveSettings.UpdateAttachedClusterSettings).WithGoogleRequestParam("attached_cluster.name", request => request.AttachedCluster?.Name);
            Modify_ApiCall(ref _callUpdateAttachedCluster);
            Modify_UpdateAttachedClusterApiCall(ref _callUpdateAttachedCluster);
            _callImportAttachedCluster = clientHelper.BuildApiCall<ImportAttachedClusterRequest, lro::Operation>("ImportAttachedCluster", grpcClient.ImportAttachedClusterAsync, grpcClient.ImportAttachedCluster, effectiveSettings.ImportAttachedClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportAttachedCluster);
            Modify_ImportAttachedClusterApiCall(ref _callImportAttachedCluster);
            _callGetAttachedCluster = clientHelper.BuildApiCall<GetAttachedClusterRequest, AttachedCluster>("GetAttachedCluster", grpcClient.GetAttachedClusterAsync, grpcClient.GetAttachedCluster, effectiveSettings.GetAttachedClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAttachedCluster);
            Modify_GetAttachedClusterApiCall(ref _callGetAttachedCluster);
            _callListAttachedClusters = clientHelper.BuildApiCall<ListAttachedClustersRequest, ListAttachedClustersResponse>("ListAttachedClusters", grpcClient.ListAttachedClustersAsync, grpcClient.ListAttachedClusters, effectiveSettings.ListAttachedClustersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAttachedClusters);
            Modify_ListAttachedClustersApiCall(ref _callListAttachedClusters);
            _callDeleteAttachedCluster = clientHelper.BuildApiCall<DeleteAttachedClusterRequest, lro::Operation>("DeleteAttachedCluster", grpcClient.DeleteAttachedClusterAsync, grpcClient.DeleteAttachedCluster, effectiveSettings.DeleteAttachedClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAttachedCluster);
            Modify_DeleteAttachedClusterApiCall(ref _callDeleteAttachedCluster);
            _callGetAttachedServerConfig = clientHelper.BuildApiCall<GetAttachedServerConfigRequest, AttachedServerConfig>("GetAttachedServerConfig", grpcClient.GetAttachedServerConfigAsync, grpcClient.GetAttachedServerConfig, effectiveSettings.GetAttachedServerConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAttachedServerConfig);
            Modify_GetAttachedServerConfigApiCall(ref _callGetAttachedServerConfig);
            _callGenerateAttachedClusterInstallManifest = clientHelper.BuildApiCall<GenerateAttachedClusterInstallManifestRequest, GenerateAttachedClusterInstallManifestResponse>("GenerateAttachedClusterInstallManifest", grpcClient.GenerateAttachedClusterInstallManifestAsync, grpcClient.GenerateAttachedClusterInstallManifest, effectiveSettings.GenerateAttachedClusterInstallManifestSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGenerateAttachedClusterInstallManifest);
            Modify_GenerateAttachedClusterInstallManifestApiCall(ref _callGenerateAttachedClusterInstallManifest);
            _callGenerateAttachedClusterAgentToken = clientHelper.BuildApiCall<GenerateAttachedClusterAgentTokenRequest, GenerateAttachedClusterAgentTokenResponse>("GenerateAttachedClusterAgentToken", grpcClient.GenerateAttachedClusterAgentTokenAsync, grpcClient.GenerateAttachedClusterAgentToken, effectiveSettings.GenerateAttachedClusterAgentTokenSettings).WithGoogleRequestParam("attached_cluster", request => request.AttachedCluster);
            Modify_ApiCall(ref _callGenerateAttachedClusterAgentToken);
            Modify_GenerateAttachedClusterAgentTokenApiCall(ref _callGenerateAttachedClusterAgentToken);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateAttachedClusterApiCall(ref gaxgrpc::ApiCall<CreateAttachedClusterRequest, lro::Operation> call);

        partial void Modify_UpdateAttachedClusterApiCall(ref gaxgrpc::ApiCall<UpdateAttachedClusterRequest, lro::Operation> call);

        partial void Modify_ImportAttachedClusterApiCall(ref gaxgrpc::ApiCall<ImportAttachedClusterRequest, lro::Operation> call);

        partial void Modify_GetAttachedClusterApiCall(ref gaxgrpc::ApiCall<GetAttachedClusterRequest, AttachedCluster> call);

        partial void Modify_ListAttachedClustersApiCall(ref gaxgrpc::ApiCall<ListAttachedClustersRequest, ListAttachedClustersResponse> call);

        partial void Modify_DeleteAttachedClusterApiCall(ref gaxgrpc::ApiCall<DeleteAttachedClusterRequest, lro::Operation> call);

        partial void Modify_GetAttachedServerConfigApiCall(ref gaxgrpc::ApiCall<GetAttachedServerConfigRequest, AttachedServerConfig> call);

        partial void Modify_GenerateAttachedClusterInstallManifestApiCall(ref gaxgrpc::ApiCall<GenerateAttachedClusterInstallManifestRequest, GenerateAttachedClusterInstallManifestResponse> call);

        partial void Modify_GenerateAttachedClusterAgentTokenApiCall(ref gaxgrpc::ApiCall<GenerateAttachedClusterAgentTokenRequest, GenerateAttachedClusterAgentTokenResponse> call);

        partial void OnConstruction(AttachedClusters.AttachedClustersClient grpcClient, AttachedClustersSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AttachedClusters client</summary>
        public override AttachedClusters.AttachedClustersClient GrpcClient { get; }

        partial void Modify_CreateAttachedClusterRequest(ref CreateAttachedClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAttachedClusterRequest(ref UpdateAttachedClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportAttachedClusterRequest(ref ImportAttachedClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAttachedClusterRequest(ref GetAttachedClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAttachedClustersRequest(ref ListAttachedClustersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAttachedClusterRequest(ref DeleteAttachedClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAttachedServerConfigRequest(ref GetAttachedServerConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateAttachedClusterInstallManifestRequest(ref GenerateAttachedClusterInstallManifestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateAttachedClusterAgentTokenRequest(ref GenerateAttachedClusterAgentTokenRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateAttachedCluster</c>.</summary>
        public override lro::OperationsClient CreateAttachedClusterOperationsClient { get; }

        /// <summary>
        /// Creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AttachedCluster, OperationMetadata> CreateAttachedCluster(CreateAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAttachedClusterRequest(ref request, ref callSettings);
            return new lro::Operation<AttachedCluster, OperationMetadata>(_callCreateAttachedCluster.Sync(request, callSettings), CreateAttachedClusterOperationsClient);
        }

        /// <summary>
        /// Creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// on a given Google Cloud Platform project and region.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> CreateAttachedClusterAsync(CreateAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAttachedClusterRequest(ref request, ref callSettings);
            return new lro::Operation<AttachedCluster, OperationMetadata>(await _callCreateAttachedCluster.Async(request, callSettings).ConfigureAwait(false), CreateAttachedClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAttachedCluster</c>.</summary>
        public override lro::OperationsClient UpdateAttachedClusterOperationsClient { get; }

        /// <summary>
        /// Updates an
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AttachedCluster, OperationMetadata> UpdateAttachedCluster(UpdateAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAttachedClusterRequest(ref request, ref callSettings);
            return new lro::Operation<AttachedCluster, OperationMetadata>(_callUpdateAttachedCluster.Sync(request, callSettings), UpdateAttachedClusterOperationsClient);
        }

        /// <summary>
        /// Updates an
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> UpdateAttachedClusterAsync(UpdateAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAttachedClusterRequest(ref request, ref callSettings);
            return new lro::Operation<AttachedCluster, OperationMetadata>(await _callUpdateAttachedCluster.Async(request, callSettings).ConfigureAwait(false), UpdateAttachedClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportAttachedCluster</c>.</summary>
        public override lro::OperationsClient ImportAttachedClusterOperationsClient { get; }

        /// <summary>
        /// Imports creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// by importing an existing Fleet Membership resource.
        /// 
        /// Attached Clusters created before the introduction of the Anthos Multi-Cloud
        /// API can be imported through this method.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AttachedCluster, OperationMetadata> ImportAttachedCluster(ImportAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportAttachedClusterRequest(ref request, ref callSettings);
            return new lro::Operation<AttachedCluster, OperationMetadata>(_callImportAttachedCluster.Sync(request, callSettings), ImportAttachedClusterOperationsClient);
        }

        /// <summary>
        /// Imports creates a new
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource
        /// by importing an existing Fleet Membership resource.
        /// 
        /// Attached Clusters created before the introduction of the Anthos Multi-Cloud
        /// API can be imported through this method.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AttachedCluster, OperationMetadata>> ImportAttachedClusterAsync(ImportAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportAttachedClusterRequest(ref request, ref callSettings);
            return new lro::Operation<AttachedCluster, OperationMetadata>(await _callImportAttachedCluster.Async(request, callSettings).ConfigureAwait(false), ImportAttachedClusterOperationsClient);
        }

        /// <summary>
        /// Describes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AttachedCluster GetAttachedCluster(GetAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAttachedClusterRequest(ref request, ref callSettings);
            return _callGetAttachedCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Describes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AttachedCluster> GetAttachedClusterAsync(GetAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAttachedClusterRequest(ref request, ref callSettings);
            return _callGetAttachedCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AttachedCluster"/> resources.</returns>
        public override gax::PagedEnumerable<ListAttachedClustersResponse, AttachedCluster> ListAttachedClusters(ListAttachedClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAttachedClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAttachedClustersRequest, ListAttachedClustersResponse, AttachedCluster>(_callListAttachedClusters, request, callSettings);
        }

        /// <summary>
        /// Lists all [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster]
        /// resources on a given Google Cloud project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AttachedCluster"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAttachedClustersResponse, AttachedCluster> ListAttachedClustersAsync(ListAttachedClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAttachedClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAttachedClustersRequest, ListAttachedClustersResponse, AttachedCluster>(_callListAttachedClusters, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteAttachedCluster</c>.</summary>
        public override lro::OperationsClient DeleteAttachedClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAttachedCluster(DeleteAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAttachedClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAttachedCluster.Sync(request, callSettings), DeleteAttachedClusterOperationsClient);
        }

        /// <summary>
        /// Deletes a specific
        /// [AttachedCluster][google.cloud.gkemulticloud.v1.AttachedCluster] resource.
        /// 
        /// If successful, the response contains a newly created
        /// [Operation][google.longrunning.Operation] resource that can be
        /// described to track the status of the operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAttachedClusterAsync(DeleteAttachedClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAttachedClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAttachedCluster.Async(request, callSettings).ConfigureAwait(false), DeleteAttachedClusterOperationsClient);
        }

        /// <summary>
        /// Returns information, such as supported Kubernetes versions, on a given
        /// Google Cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AttachedServerConfig GetAttachedServerConfig(GetAttachedServerConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAttachedServerConfigRequest(ref request, ref callSettings);
            return _callGetAttachedServerConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information, such as supported Kubernetes versions, on a given
        /// Google Cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AttachedServerConfig> GetAttachedServerConfigAsync(GetAttachedServerConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAttachedServerConfigRequest(ref request, ref callSettings);
            return _callGetAttachedServerConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Generates the install manifest to be installed on the target cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateAttachedClusterInstallManifestResponse GenerateAttachedClusterInstallManifest(GenerateAttachedClusterInstallManifestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAttachedClusterInstallManifestRequest(ref request, ref callSettings);
            return _callGenerateAttachedClusterInstallManifest.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates the install manifest to be installed on the target cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateAttachedClusterInstallManifestResponse> GenerateAttachedClusterInstallManifestAsync(GenerateAttachedClusterInstallManifestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAttachedClusterInstallManifestRequest(ref request, ref callSettings);
            return _callGenerateAttachedClusterInstallManifest.Async(request, callSettings);
        }

        /// <summary>
        /// Generates an access token for a cluster agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateAttachedClusterAgentTokenResponse GenerateAttachedClusterAgentToken(GenerateAttachedClusterAgentTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAttachedClusterAgentTokenRequest(ref request, ref callSettings);
            return _callGenerateAttachedClusterAgentToken.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates an access token for a cluster agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateAttachedClusterAgentTokenResponse> GenerateAttachedClusterAgentTokenAsync(GenerateAttachedClusterAgentTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAttachedClusterAgentTokenRequest(ref request, ref callSettings);
            return _callGenerateAttachedClusterAgentToken.Async(request, callSettings);
        }
    }

    public partial class ListAttachedClustersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAttachedClustersResponse : gaxgrpc::IPageResponse<AttachedCluster>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AttachedCluster> GetEnumerator() => AttachedClusters.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AttachedClusters
    {
        public partial class AttachedClustersClient
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
