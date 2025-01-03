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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Dataflow.V1Beta3
{
    /// <summary>Settings for <see cref="SnapshotsV1Beta3Client"/> instances.</summary>
    public sealed partial class SnapshotsV1Beta3Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SnapshotsV1Beta3Settings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SnapshotsV1Beta3Settings"/>.</returns>
        public static SnapshotsV1Beta3Settings GetDefault() => new SnapshotsV1Beta3Settings();

        /// <summary>Constructs a new <see cref="SnapshotsV1Beta3Settings"/> object with default settings.</summary>
        public SnapshotsV1Beta3Settings()
        {
        }

        private SnapshotsV1Beta3Settings(SnapshotsV1Beta3Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSnapshotSettings = existing.GetSnapshotSettings;
            DeleteSnapshotSettings = existing.DeleteSnapshotSettings;
            ListSnapshotsSettings = existing.ListSnapshotsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SnapshotsV1Beta3Settings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SnapshotsV1Beta3Client.GetSnapshot</c> and <c>SnapshotsV1Beta3Client.GetSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SnapshotsV1Beta3Client.DeleteSnapshot</c> and <c>SnapshotsV1Beta3Client.DeleteSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SnapshotsV1Beta3Client.ListSnapshots</c> and <c>SnapshotsV1Beta3Client.ListSnapshotsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSnapshotsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SnapshotsV1Beta3Settings"/> object.</returns>
        public SnapshotsV1Beta3Settings Clone() => new SnapshotsV1Beta3Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SnapshotsV1Beta3Client"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SnapshotsV1Beta3ClientBuilder : gaxgrpc::ClientBuilderBase<SnapshotsV1Beta3Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SnapshotsV1Beta3Settings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SnapshotsV1Beta3ClientBuilder() : base(SnapshotsV1Beta3Client.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SnapshotsV1Beta3Client client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SnapshotsV1Beta3Client> task);

        /// <summary>Builds the resulting client.</summary>
        public override SnapshotsV1Beta3Client Build()
        {
            SnapshotsV1Beta3Client client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SnapshotsV1Beta3Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SnapshotsV1Beta3Client> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SnapshotsV1Beta3Client BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SnapshotsV1Beta3Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SnapshotsV1Beta3Client> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SnapshotsV1Beta3Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SnapshotsV1Beta3Client.ChannelPool;
    }

    /// <summary>SnapshotsV1Beta3 client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods to manage snapshots of Google Cloud Dataflow jobs.
    /// </remarks>
    public abstract partial class SnapshotsV1Beta3Client
    {
        /// <summary>
        /// The default endpoint for the SnapshotsV1Beta3 service, which is a host of "dataflow.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataflow.googleapis.com:443";

        /// <summary>The default SnapshotsV1Beta3 scopes.</summary>
        /// <remarks>
        /// The default SnapshotsV1Beta3 scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/compute.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/userinfo.email</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/compute.readonly",
            "https://www.googleapis.com/auth/userinfo.email",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SnapshotsV1Beta3.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SnapshotsV1Beta3Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SnapshotsV1Beta3ClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SnapshotsV1Beta3Client"/>.</returns>
        public static stt::Task<SnapshotsV1Beta3Client> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SnapshotsV1Beta3ClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SnapshotsV1Beta3Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SnapshotsV1Beta3ClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SnapshotsV1Beta3Client"/>.</returns>
        public static SnapshotsV1Beta3Client Create() => new SnapshotsV1Beta3ClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SnapshotsV1Beta3Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SnapshotsV1Beta3Settings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SnapshotsV1Beta3Client"/>.</returns>
        internal static SnapshotsV1Beta3Client Create(grpccore::CallInvoker callInvoker, SnapshotsV1Beta3Settings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SnapshotsV1Beta3.SnapshotsV1Beta3Client grpcClient = new SnapshotsV1Beta3.SnapshotsV1Beta3Client(callInvoker);
            return new SnapshotsV1Beta3ClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SnapshotsV1Beta3 client</summary>
        public virtual SnapshotsV1Beta3.SnapshotsV1Beta3Client GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snapshot GetSnapshot(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(GetSnapshotRequest request, st::CancellationToken cancellationToken) =>
            GetSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, st::CancellationToken cancellationToken) =>
            DeleteSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListSnapshotsResponse ListSnapshots(ListSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListSnapshotsResponse> ListSnapshotsAsync(ListSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListSnapshotsResponse> ListSnapshotsAsync(ListSnapshotsRequest request, st::CancellationToken cancellationToken) =>
            ListSnapshotsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SnapshotsV1Beta3 client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods to manage snapshots of Google Cloud Dataflow jobs.
    /// </remarks>
    public sealed partial class SnapshotsV1Beta3ClientImpl : SnapshotsV1Beta3Client
    {
        private readonly gaxgrpc::ApiCall<GetSnapshotRequest, Snapshot> _callGetSnapshot;

        private readonly gaxgrpc::ApiCall<DeleteSnapshotRequest, DeleteSnapshotResponse> _callDeleteSnapshot;

        private readonly gaxgrpc::ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> _callListSnapshots;

        /// <summary>
        /// Constructs a client wrapper for the SnapshotsV1Beta3 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SnapshotsV1Beta3Settings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SnapshotsV1Beta3ClientImpl(SnapshotsV1Beta3.SnapshotsV1Beta3Client grpcClient, SnapshotsV1Beta3Settings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SnapshotsV1Beta3Settings effectiveSettings = settings ?? SnapshotsV1Beta3Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetSnapshot = clientHelper.BuildApiCall<GetSnapshotRequest, Snapshot>("GetSnapshot", grpcClient.GetSnapshotAsync, grpcClient.GetSnapshot, effectiveSettings.GetSnapshotSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("location", request => request.Location).WithGoogleRequestParam("snapshot_id", request => request.SnapshotId);
            Modify_ApiCall(ref _callGetSnapshot);
            Modify_GetSnapshotApiCall(ref _callGetSnapshot);
            _callDeleteSnapshot = clientHelper.BuildApiCall<DeleteSnapshotRequest, DeleteSnapshotResponse>("DeleteSnapshot", grpcClient.DeleteSnapshotAsync, grpcClient.DeleteSnapshot, effectiveSettings.DeleteSnapshotSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("location", request => request.Location).WithGoogleRequestParam("snapshot_id", request => request.SnapshotId);
            Modify_ApiCall(ref _callDeleteSnapshot);
            Modify_DeleteSnapshotApiCall(ref _callDeleteSnapshot);
            _callListSnapshots = clientHelper.BuildApiCall<ListSnapshotsRequest, ListSnapshotsResponse>("ListSnapshots", grpcClient.ListSnapshotsAsync, grpcClient.ListSnapshots, effectiveSettings.ListSnapshotsSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("location", request => request.Location).WithGoogleRequestParam("job_id", request => request.JobId);
            Modify_ApiCall(ref _callListSnapshots);
            Modify_ListSnapshotsApiCall(ref _callListSnapshots);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetSnapshotApiCall(ref gaxgrpc::ApiCall<GetSnapshotRequest, Snapshot> call);

        partial void Modify_DeleteSnapshotApiCall(ref gaxgrpc::ApiCall<DeleteSnapshotRequest, DeleteSnapshotResponse> call);

        partial void Modify_ListSnapshotsApiCall(ref gaxgrpc::ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> call);

        partial void OnConstruction(SnapshotsV1Beta3.SnapshotsV1Beta3Client grpcClient, SnapshotsV1Beta3Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SnapshotsV1Beta3 client</summary>
        public override SnapshotsV1Beta3.SnapshotsV1Beta3Client GrpcClient { get; }

        partial void Modify_GetSnapshotRequest(ref GetSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSnapshotRequest(ref DeleteSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSnapshotsRequest(ref ListSnapshotsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets information about a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Snapshot GetSnapshot(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSnapshotRequest(ref request, ref callSettings);
            return _callGetSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Snapshot> GetSnapshotAsync(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSnapshotRequest(ref request, ref callSettings);
            return _callGetSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            return _callDeleteSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            return _callDeleteSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// Lists snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListSnapshotsResponse ListSnapshots(ListSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSnapshotsRequest(ref request, ref callSettings);
            return _callListSnapshots.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListSnapshotsResponse> ListSnapshotsAsync(ListSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSnapshotsRequest(ref request, ref callSettings);
            return _callListSnapshots.Async(request, callSettings);
        }
    }
}
