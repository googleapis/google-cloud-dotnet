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
    /// <summary>Settings for <see cref="RegionSnapshotsClient"/> instances.</summary>
    public sealed partial class RegionSnapshotsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegionSnapshotsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegionSnapshotsSettings"/>.</returns>
        public static RegionSnapshotsSettings GetDefault() => new RegionSnapshotsSettings();

        /// <summary>Constructs a new <see cref="RegionSnapshotsSettings"/> object with default settings.</summary>
        public RegionSnapshotsSettings()
        {
        }

        private RegionSnapshotsSettings(RegionSnapshotsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            SetLabelsSettings = existing.SetLabelsSettings;
            SetLabelsOperationsSettings = existing.SetLabelsOperationsSettings.Clone();
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            UpdateKmsKeySettings = existing.UpdateKmsKeySettings;
            UpdateKmsKeyOperationsSettings = existing.UpdateKmsKeyOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(RegionSnapshotsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionSnapshotsClient.Delete</c> and <c>RegionSnapshotsClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionSnapshotsClient.Delete</c> and
        /// <c>RegionSnapshotsClient.DeleteAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionSnapshotsClient.Get</c>
        ///  and <c>RegionSnapshotsClient.GetAsync</c>.
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
        /// <c>RegionSnapshotsClient.GetIamPolicy</c> and <c>RegionSnapshotsClient.GetIamPolicyAsync</c>.
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
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionSnapshotsClient.Insert</c> and <c>RegionSnapshotsClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionSnapshotsClient.Insert</c> and
        /// <c>RegionSnapshotsClient.InsertAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionSnapshotsClient.List</c>
        ///  and <c>RegionSnapshotsClient.ListAsync</c>.
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
        /// <c>RegionSnapshotsClient.SetIamPolicy</c> and <c>RegionSnapshotsClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionSnapshotsClient.SetLabels</c> and <c>RegionSnapshotsClient.SetLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionSnapshotsClient.SetLabels</c> and
        /// <c>RegionSnapshotsClient.SetLabelsAsync</c>.
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
        public lro::OperationsSettings SetLabelsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionSnapshotsClient.TestIamPermissions</c> and <c>RegionSnapshotsClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionSnapshotsClient.UpdateKmsKey</c> and <c>RegionSnapshotsClient.UpdateKmsKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateKmsKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionSnapshotsClient.UpdateKmsKey</c> and
        /// <c>RegionSnapshotsClient.UpdateKmsKeyAsync</c>.
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
        public lro::OperationsSettings UpdateKmsKeyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RegionSnapshotsSettings"/> object.</returns>
        public RegionSnapshotsSettings Clone() => new RegionSnapshotsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegionSnapshotsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class RegionSnapshotsClientBuilder : gaxgrpc::ClientBuilderBase<RegionSnapshotsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegionSnapshotsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RegionSnapshotsClientBuilder() : base(RegionSnapshotsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RegionSnapshotsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegionSnapshotsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegionSnapshotsClient Build()
        {
            RegionSnapshotsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegionSnapshotsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegionSnapshotsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegionSnapshotsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegionSnapshotsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RegionSnapshotsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegionSnapshotsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RegionSnapshotsClient.ChannelPool;
    }

    /// <summary>RegionSnapshots client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The RegionSnapshots API.
    /// </remarks>
    public abstract partial class RegionSnapshotsClient
    {
        /// <summary>
        /// The default endpoint for the RegionSnapshots service, which is a host of "compute.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default RegionSnapshots scopes.</summary>
        /// <remarks>
        /// The default RegionSnapshots scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RegionSnapshots.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RegionSnapshotsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RegionSnapshotsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegionSnapshotsClient"/>.</returns>
        public static stt::Task<RegionSnapshotsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegionSnapshotsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegionSnapshotsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RegionSnapshotsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegionSnapshotsClient"/>.</returns>
        public static RegionSnapshotsClient Create() => new RegionSnapshotsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegionSnapshotsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegionSnapshotsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RegionSnapshotsClient"/>.</returns>
        internal static RegionSnapshotsClient Create(grpccore::CallInvoker callInvoker, RegionSnapshotsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegionSnapshots.RegionSnapshotsClient grpcClient = new RegionSnapshots.RegionSnapshotsClient(callInvoker);
            return new RegionSnapshotsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RegionSnapshots client</summary>
        public virtual RegionSnapshots.RegionSnapshotsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified Snapshot resource. Keep in mind that deleting
        /// a single snapshot might not necessarily delete all the data on that
        /// snapshot. If any data on the snapshot that is marked for deletion is
        /// needed for subsequent snapshots, the data will be moved to the next
        /// corresponding snapshot.
        /// 
        /// For more information, seeDeleting
        /// snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified Snapshot resource. Keep in mind that deleting
        /// a single snapshot might not necessarily delete all the data on that
        /// snapshot. If any data on the snapshot that is marked for deletion is
        /// needed for subsequent snapshots, the data will be moved to the next
        /// corresponding snapshot.
        /// 
        /// For more information, seeDeleting
        /// snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified Snapshot resource. Keep in mind that deleting
        /// a single snapshot might not necessarily delete all the data on that
        /// snapshot. If any data on the snapshot that is marked for deletion is
        /// needed for subsequent snapshots, the data will be moved to the next
        /// corresponding snapshot.
        /// 
        /// For more information, seeDeleting
        /// snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRegionSnapshotRequest request, st::CancellationToken cancellationToken) =>
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
        /// Deletes the specified Snapshot resource. Keep in mind that deleting
        /// a single snapshot might not necessarily delete all the data on that
        /// snapshot. If any data on the snapshot that is marked for deletion is
        /// needed for subsequent snapshots, the data will be moved to the next
        /// corresponding snapshot.
        /// 
        /// For more information, seeDeleting
        /// snapshots.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="snapshot">
        /// Name of the snapshot resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string region, string snapshot, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteRegionSnapshotRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Snapshot = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshot, nameof(snapshot)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified Snapshot resource. Keep in mind that deleting
        /// a single snapshot might not necessarily delete all the data on that
        /// snapshot. If any data on the snapshot that is marked for deletion is
        /// needed for subsequent snapshots, the data will be moved to the next
        /// corresponding snapshot.
        /// 
        /// For more information, seeDeleting
        /// snapshots.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="snapshot">
        /// Name of the snapshot resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string region, string snapshot, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteRegionSnapshotRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Snapshot = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshot, nameof(snapshot)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified Snapshot resource. Keep in mind that deleting
        /// a single snapshot might not necessarily delete all the data on that
        /// snapshot. If any data on the snapshot that is marked for deletion is
        /// needed for subsequent snapshots, the data will be moved to the next
        /// corresponding snapshot.
        /// 
        /// For more information, seeDeleting
        /// snapshots.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="snapshot">
        /// Name of the snapshot resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string region, string snapshot, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, region, snapshot, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified Snapshot resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snapshot Get(GetRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified Snapshot resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetAsync(GetRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified Snapshot resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetAsync(GetRegionSnapshotRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified Snapshot resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="snapshot">
        /// Name of the Snapshot resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snapshot Get(string project, string region, string snapshot, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetRegionSnapshotRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Snapshot = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshot, nameof(snapshot)),
            }, callSettings);

        /// <summary>
        /// Returns the specified Snapshot resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="snapshot">
        /// Name of the Snapshot resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetAsync(string project, string region, string snapshot, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetRegionSnapshotRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Snapshot = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshot, nameof(snapshot)),
            }, callSettings);

        /// <summary>
        /// Returns the specified Snapshot resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="snapshot">
        /// Name of the Snapshot resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetAsync(string project, string region, string snapshot, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, snapshot, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such
        /// policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetIamPolicy(GetIamPolicyRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such
        /// policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such
        /// policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyRegionSnapshotRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such
        /// policy or resource exists.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetIamPolicy(string project, string region, string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new GetIamPolicyRegionSnapshotRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such
        /// policy or resource exists.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(string project, string region, string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new GetIamPolicyRegionSnapshotRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such
        /// policy or resource exists.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(string project, string region, string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(project, region, resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a snapshot in the specified region using the data included
        /// in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a snapshot in the specified region using the data included
        /// in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a snapshot in the specified region using the data included
        /// in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRegionSnapshotRequest request, st::CancellationToken cancellationToken) =>
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
        /// Creates a snapshot in the specified region using the data included
        /// in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="snapshotResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, string region, Snapshot snapshotResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertRegionSnapshotRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                SnapshotResource = gax::GaxPreconditions.CheckNotNull(snapshotResource, nameof(snapshotResource)),
            }, callSettings);

        /// <summary>
        /// Creates a snapshot in the specified region using the data included
        /// in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="snapshotResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string region, Snapshot snapshotResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertRegionSnapshotRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                SnapshotResource = gax::GaxPreconditions.CheckNotNull(snapshotResource, nameof(snapshotResource)),
            }, callSettings);

        /// <summary>
        /// Creates a snapshot in the specified region using the data included
        /// in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="snapshotResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string region, Snapshot snapshotResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, region, snapshotResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of Snapshot resources contained within
        /// the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedEnumerable<SnapshotList, Snapshot> List(ListRegionSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of Snapshot resources contained within
        /// the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SnapshotList, Snapshot> ListAsync(ListRegionSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of Snapshot resources contained within
        /// the specified region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
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
        /// <returns>A pageable sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedEnumerable<SnapshotList, Snapshot> List(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionSnapshotsRequest request = new ListRegionSnapshotsRequest
            {
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
        /// Retrieves the list of Snapshot resources contained within
        /// the specified region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SnapshotList, Snapshot> ListAsync(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionSnapshotsRequest request = new ListRegionSnapshotsRequest
            {
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

        /// <summary>
        /// Sets the access control policy on the specified resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy SetIamPolicy(SetIamPolicyRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyRegionSnapshotRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="regionSetPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy SetIamPolicy(string project, string region, string resource, RegionSetPolicyRequest regionSetPolicyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new SetIamPolicyRegionSnapshotRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionSetPolicyRequestResource = gax::GaxPreconditions.CheckNotNull(regionSetPolicyRequestResource, nameof(regionSetPolicyRequestResource)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="regionSetPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(string project, string region, string resource, RegionSetPolicyRequest regionSetPolicyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new SetIamPolicyRegionSnapshotRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionSetPolicyRequestResource = gax::GaxPreconditions.CheckNotNull(regionSetPolicyRequestResource, nameof(regionSetPolicyRequestResource)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="regionSetPolicyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(string project, string region, string resource, RegionSetPolicyRequest regionSetPolicyRequestResource, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(project, region, resource, regionSetPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the labels on a regional snapshot. To learn more about labels, read
        /// the Labeling Resources
        /// documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetLabels(SetLabelsRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the labels on a regional snapshot. To learn more about labels, read
        /// the Labeling Resources
        /// documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(SetLabelsRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the labels on a regional snapshot. To learn more about labels, read
        /// the Labeling Resources
        /// documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(SetLabelsRegionSnapshotRequest request, st::CancellationToken cancellationToken) =>
            SetLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetLabels</c>.</summary>
        public virtual lro::OperationsClient SetLabelsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetLabels</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetLabels(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetLabelsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetLabels</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetLabelsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetLabelsOperationsClient, callSettings);

        /// <summary>
        /// Sets the labels on a regional snapshot. To learn more about labels, read
        /// the Labeling Resources
        /// documentation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="regionSetLabelsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetLabels(string project, string region, string resource, RegionSetLabelsRequest regionSetLabelsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetLabels(new SetLabelsRegionSnapshotRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionSetLabelsRequestResource = gax::GaxPreconditions.CheckNotNull(regionSetLabelsRequestResource, nameof(regionSetLabelsRequestResource)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the labels on a regional snapshot. To learn more about labels, read
        /// the Labeling Resources
        /// documentation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="regionSetLabelsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(string project, string region, string resource, RegionSetLabelsRequest regionSetLabelsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetLabelsAsync(new SetLabelsRegionSnapshotRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionSetLabelsRequestResource = gax::GaxPreconditions.CheckNotNull(regionSetLabelsRequestResource, nameof(regionSetLabelsRequestResource)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the labels on a regional snapshot. To learn more about labels, read
        /// the Labeling Resources
        /// documentation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="regionSetLabelsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(string project, string region, string resource, RegionSetLabelsRequest regionSetLabelsRequestResource, st::CancellationToken cancellationToken) =>
            SetLabelsAsync(project, region, resource, regionSetLabelsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPermissionsResponse TestIamPermissions(TestIamPermissionsRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsRegionSnapshotRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPermissionsResponse TestIamPermissions(string project, string region, string resource, TestPermissionsRequest testPermissionsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new TestIamPermissionsRegionSnapshotRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                TestPermissionsRequestResource = gax::GaxPreconditions.CheckNotNull(testPermissionsRequestResource, nameof(testPermissionsRequestResource)),
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(string project, string region, string resource, TestPermissionsRequest testPermissionsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new TestIamPermissionsRegionSnapshotRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                TestPermissionsRequestResource = gax::GaxPreconditions.CheckNotNull(testPermissionsRequestResource, nameof(testPermissionsRequestResource)),
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(string project, string region, string resource, TestPermissionsRequest testPermissionsRequestResource, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rotates the customer-managed
        /// encryption key to the latest version for the specified snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> UpdateKmsKey(UpdateKmsKeyRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rotates the customer-managed
        /// encryption key to the latest version for the specified snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateKmsKeyAsync(UpdateKmsKeyRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rotates the customer-managed
        /// encryption key to the latest version for the specified snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateKmsKeyAsync(UpdateKmsKeyRegionSnapshotRequest request, st::CancellationToken cancellationToken) =>
            UpdateKmsKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateKmsKey</c>.</summary>
        public virtual lro::OperationsClient UpdateKmsKeyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateKmsKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceUpdateKmsKey(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateKmsKeyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateKmsKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceUpdateKmsKeyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateKmsKeyOperationsClient, callSettings);

        /// <summary>
        /// Rotates the customer-managed
        /// encryption key to the latest version for the specified snapshot.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="snapshot">
        /// Name of the snapshot resource to update. Should conform to RFC1035.
        /// </param>
        /// <param name="regionSnapshotUpdateKmsKeyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> UpdateKmsKey(string project, string region, string snapshot, RegionSnapshotUpdateKmsKeyRequest regionSnapshotUpdateKmsKeyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateKmsKey(new UpdateKmsKeyRegionSnapshotRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionSnapshotUpdateKmsKeyRequestResource = gax::GaxPreconditions.CheckNotNull(regionSnapshotUpdateKmsKeyRequestResource, nameof(regionSnapshotUpdateKmsKeyRequestResource)),
                Snapshot = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshot, nameof(snapshot)),
            }, callSettings);

        /// <summary>
        /// Rotates the customer-managed
        /// encryption key to the latest version for the specified snapshot.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="snapshot">
        /// Name of the snapshot resource to update. Should conform to RFC1035.
        /// </param>
        /// <param name="regionSnapshotUpdateKmsKeyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateKmsKeyAsync(string project, string region, string snapshot, RegionSnapshotUpdateKmsKeyRequest regionSnapshotUpdateKmsKeyRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateKmsKeyAsync(new UpdateKmsKeyRegionSnapshotRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionSnapshotUpdateKmsKeyRequestResource = gax::GaxPreconditions.CheckNotNull(regionSnapshotUpdateKmsKeyRequestResource, nameof(regionSnapshotUpdateKmsKeyRequestResource)),
                Snapshot = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshot, nameof(snapshot)),
            }, callSettings);

        /// <summary>
        /// Rotates the customer-managed
        /// encryption key to the latest version for the specified snapshot.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="snapshot">
        /// Name of the snapshot resource to update. Should conform to RFC1035.
        /// </param>
        /// <param name="regionSnapshotUpdateKmsKeyRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateKmsKeyAsync(string project, string region, string snapshot, RegionSnapshotUpdateKmsKeyRequest regionSnapshotUpdateKmsKeyRequestResource, st::CancellationToken cancellationToken) =>
            UpdateKmsKeyAsync(project, region, snapshot, regionSnapshotUpdateKmsKeyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RegionSnapshots client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The RegionSnapshots API.
    /// </remarks>
    public sealed partial class RegionSnapshotsClientImpl : RegionSnapshotsClient
    {
        private readonly gaxgrpc::ApiCall<DeleteRegionSnapshotRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetRegionSnapshotRequest, Snapshot> _callGet;

        private readonly gaxgrpc::ApiCall<GetIamPolicyRegionSnapshotRequest, Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<InsertRegionSnapshotRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListRegionSnapshotsRequest, SnapshotList> _callList;

        private readonly gaxgrpc::ApiCall<SetIamPolicyRegionSnapshotRequest, Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<SetLabelsRegionSnapshotRequest, Operation> _callSetLabels;

        private readonly gaxgrpc::ApiCall<TestIamPermissionsRegionSnapshotRequest, TestPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<UpdateKmsKeyRegionSnapshotRequest, Operation> _callUpdateKmsKey;

        /// <summary>
        /// Constructs a client wrapper for the RegionSnapshots service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RegionSnapshotsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RegionSnapshotsClientImpl(RegionSnapshots.RegionSnapshotsClient grpcClient, RegionSnapshotsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RegionSnapshotsSettings effectiveSettings = settings ?? RegionSnapshotsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.InsertOperationsSettings, logger);
            SetLabelsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.SetLabelsOperationsSettings, logger);
            UpdateKmsKeyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.UpdateKmsKeyOperationsSettings, logger);
            _callDelete = clientHelper.BuildApiCall<DeleteRegionSnapshotRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("snapshot", request => request.Snapshot);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetRegionSnapshotRequest, Snapshot>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("snapshot", request => request.Snapshot);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callGetIamPolicy = clientHelper.BuildApiCall<GetIamPolicyRegionSnapshotRequest, Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callInsert = clientHelper.BuildApiCall<InsertRegionSnapshotRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListRegionSnapshotsRequest, SnapshotList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callSetIamPolicy = clientHelper.BuildApiCall<SetIamPolicyRegionSnapshotRequest, Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callSetLabels = clientHelper.BuildApiCall<SetLabelsRegionSnapshotRequest, Operation>("SetLabels", grpcClient.SetLabelsAsync, grpcClient.SetLabels, effectiveSettings.SetLabelsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetLabels);
            Modify_SetLabelsApiCall(ref _callSetLabels);
            _callTestIamPermissions = clientHelper.BuildApiCall<TestIamPermissionsRegionSnapshotRequest, TestPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callUpdateKmsKey = clientHelper.BuildApiCall<UpdateKmsKeyRegionSnapshotRequest, Operation>("UpdateKmsKey", grpcClient.UpdateKmsKeyAsync, grpcClient.UpdateKmsKey, effectiveSettings.UpdateKmsKeySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("snapshot", request => request.Snapshot);
            Modify_ApiCall(ref _callUpdateKmsKey);
            Modify_UpdateKmsKeyApiCall(ref _callUpdateKmsKey);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteRegionSnapshotRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetRegionSnapshotRequest, Snapshot> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<GetIamPolicyRegionSnapshotRequest, Policy> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertRegionSnapshotRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListRegionSnapshotsRequest, SnapshotList> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<SetIamPolicyRegionSnapshotRequest, Policy> call);

        partial void Modify_SetLabelsApiCall(ref gaxgrpc::ApiCall<SetLabelsRegionSnapshotRequest, Operation> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<TestIamPermissionsRegionSnapshotRequest, TestPermissionsResponse> call);

        partial void Modify_UpdateKmsKeyApiCall(ref gaxgrpc::ApiCall<UpdateKmsKeyRegionSnapshotRequest, Operation> call);

        partial void OnConstruction(RegionSnapshots.RegionSnapshotsClient grpcClient, RegionSnapshotsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegionSnapshots client</summary>
        public override RegionSnapshots.RegionSnapshotsClient GrpcClient { get; }

        partial void Modify_DeleteRegionSnapshotRequest(ref DeleteRegionSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRegionSnapshotRequest(ref GetRegionSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRegionSnapshotRequest(ref GetIamPolicyRegionSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertRegionSnapshotRequest(ref InsertRegionSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRegionSnapshotsRequest(ref ListRegionSnapshotsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRegionSnapshotRequest(ref SetIamPolicyRegionSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetLabelsRegionSnapshotRequest(ref SetLabelsRegionSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRegionSnapshotRequest(ref TestIamPermissionsRegionSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateKmsKeyRegionSnapshotRequest(ref UpdateKmsKeyRegionSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified Snapshot resource. Keep in mind that deleting
        /// a single snapshot might not necessarily delete all the data on that
        /// snapshot. If any data on the snapshot that is marked for deletion is
        /// needed for subsequent snapshots, the data will be moved to the next
        /// corresponding snapshot.
        /// 
        /// For more information, seeDeleting
        /// snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionSnapshotRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified Snapshot resource. Keep in mind that deleting
        /// a single snapshot might not necessarily delete all the data on that
        /// snapshot. If any data on the snapshot that is marked for deletion is
        /// needed for subsequent snapshots, the data will be moved to the next
        /// corresponding snapshot.
        /// 
        /// For more information, seeDeleting
        /// snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionSnapshotRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Returns the specified Snapshot resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Snapshot Get(GetRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionSnapshotRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified Snapshot resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Snapshot> GetAsync(GetRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionSnapshotRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such
        /// policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy GetIamPolicy(GetIamPolicyRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRegionSnapshotRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such
        /// policy or resource exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRegionSnapshotRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates a snapshot in the specified region using the data included
        /// in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionSnapshotRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates a snapshot in the specified region using the data included
        /// in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionSnapshotRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Retrieves the list of Snapshot resources contained within
        /// the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Snapshot"/> resources.</returns>
        public override gax::PagedEnumerable<SnapshotList, Snapshot> List(ListRegionSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRegionSnapshotsRequest, SnapshotList, Snapshot>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of Snapshot resources contained within
        /// the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Snapshot"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SnapshotList, Snapshot> ListAsync(ListRegionSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRegionSnapshotsRequest, SnapshotList, Snapshot>(_callList, request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy SetIamPolicy(SetIamPolicyRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRegionSnapshotRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRegionSnapshotRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SetLabels</c>.</summary>
        public override lro::OperationsClient SetLabelsOperationsClient { get; }

        /// <summary>
        /// Sets the labels on a regional snapshot. To learn more about labels, read
        /// the Labeling Resources
        /// documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetLabels(SetLabelsRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLabelsRegionSnapshotRequest(ref request, ref callSettings);
            Operation response = _callSetLabels.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetLabelsOperationsClient);
        }

        /// <summary>
        /// Sets the labels on a regional snapshot. To learn more about labels, read
        /// the Labeling Resources
        /// documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetLabelsAsync(SetLabelsRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLabelsRegionSnapshotRequest(ref request, ref callSettings);
            Operation response = await _callSetLabels.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetLabelsOperationsClient);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TestPermissionsResponse TestIamPermissions(TestIamPermissionsRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRegionSnapshotRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRegionSnapshotRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateKmsKey</c>.</summary>
        public override lro::OperationsClient UpdateKmsKeyOperationsClient { get; }

        /// <summary>
        /// Rotates the customer-managed
        /// encryption key to the latest version for the specified snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> UpdateKmsKey(UpdateKmsKeyRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateKmsKeyRegionSnapshotRequest(ref request, ref callSettings);
            Operation response = _callUpdateKmsKey.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateKmsKeyOperationsClient);
        }

        /// <summary>
        /// Rotates the customer-managed
        /// encryption key to the latest version for the specified snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> UpdateKmsKeyAsync(UpdateKmsKeyRegionSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateKmsKeyRegionSnapshotRequest(ref request, ref callSettings);
            Operation response = await _callUpdateKmsKey.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateKmsKeyOperationsClient);
        }
    }

    public partial class ListRegionSnapshotsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class SnapshotList : gaxgrpc::IPageResponse<Snapshot>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Snapshot> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class RegionSnapshots
    {
        public partial class RegionSnapshotsClient
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
