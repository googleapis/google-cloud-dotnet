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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="RegionSnapshotSettingsClient"/> instances.</summary>
    public sealed partial class RegionSnapshotSettingsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegionSnapshotSettingsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegionSnapshotSettingsSettings"/>.</returns>
        public static RegionSnapshotSettingsSettings GetDefault() => new RegionSnapshotSettingsSettings();

        /// <summary>
        /// Constructs a new <see cref="RegionSnapshotSettingsSettings"/> object with default settings.
        /// </summary>
        public RegionSnapshotSettingsSettings()
        {
        }

        private RegionSnapshotSettingsSettings(RegionSnapshotSettingsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSettings = existing.GetSettings;
            PatchSettings = existing.PatchSettings;
            PatchOperationsSettings = existing.PatchOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(RegionSnapshotSettingsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionSnapshotSettingsClient.Get</c> and <c>RegionSnapshotSettingsClient.GetAsync</c>.
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
        /// <c>RegionSnapshotSettingsClient.Patch</c> and <c>RegionSnapshotSettingsClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionSnapshotSettingsClient.Patch</c> and
        /// <c>RegionSnapshotSettingsClient.PatchAsync</c>.
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
        public lro::OperationsSettings PatchOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RegionSnapshotSettingsSettings"/> object.</returns>
        public RegionSnapshotSettingsSettings Clone() => new RegionSnapshotSettingsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegionSnapshotSettingsClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class RegionSnapshotSettingsClientBuilder : gaxgrpc::ClientBuilderBase<RegionSnapshotSettingsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegionSnapshotSettingsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RegionSnapshotSettingsClientBuilder() : base(RegionSnapshotSettingsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RegionSnapshotSettingsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegionSnapshotSettingsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegionSnapshotSettingsClient Build()
        {
            RegionSnapshotSettingsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegionSnapshotSettingsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegionSnapshotSettingsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegionSnapshotSettingsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegionSnapshotSettingsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RegionSnapshotSettingsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegionSnapshotSettingsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RegionSnapshotSettingsClient.ChannelPool;
    }

    /// <summary>RegionSnapshotSettings client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The RegionSnapshotSettings API.
    /// </remarks>
    public abstract partial class RegionSnapshotSettingsClient
    {
        /// <summary>
        /// The default endpoint for the RegionSnapshotSettings service, which is a host of "compute.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default RegionSnapshotSettings scopes.</summary>
        /// <remarks>
        /// The default RegionSnapshotSettings scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RegionSnapshotSettings.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RegionSnapshotSettingsClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionSnapshotSettingsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegionSnapshotSettingsClient"/>.</returns>
        public static stt::Task<RegionSnapshotSettingsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegionSnapshotSettingsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegionSnapshotSettingsClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionSnapshotSettingsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegionSnapshotSettingsClient"/>.</returns>
        public static RegionSnapshotSettingsClient Create() => new RegionSnapshotSettingsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegionSnapshotSettingsClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegionSnapshotSettingsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RegionSnapshotSettingsClient"/>.</returns>
        internal static RegionSnapshotSettingsClient Create(grpccore::CallInvoker callInvoker, RegionSnapshotSettingsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegionSnapshotSettings.RegionSnapshotSettingsClient grpcClient = new RegionSnapshotSettings.RegionSnapshotSettingsClient(callInvoker);
            return new RegionSnapshotSettingsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RegionSnapshotSettings client</summary>
        public virtual RegionSnapshotSettings.RegionSnapshotSettingsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get region snapshot settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SnapshotSettings Get(GetRegionSnapshotSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get region snapshot settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSettings> GetAsync(GetRegionSnapshotSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get region snapshot settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSettings> GetAsync(GetRegionSnapshotSettingRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get region snapshot settings.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SnapshotSettings Get(string project, string region, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetRegionSnapshotSettingRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Get region snapshot settings.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSettings> GetAsync(string project, string region, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetRegionSnapshotSettingRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Get region snapshot settings.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSettings> GetAsync(string project, string region, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patch region snapshot settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Patch(PatchRegionSnapshotSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patch region snapshot settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchRegionSnapshotSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patch region snapshot settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchRegionSnapshotSettingRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Patch</c>.</summary>
        public virtual lro::OperationsClient PatchOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Patch</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOncePatch(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PatchOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Patch</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOncePatchAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PatchOperationsClient, callSettings);

        /// <summary>
        /// Patch region snapshot settings.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="snapshotSettingsResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Patch(string project, string region, SnapshotSettings snapshotSettingsResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchRegionSnapshotSettingRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                SnapshotSettingsResource = gax::GaxPreconditions.CheckNotNull(snapshotSettingsResource, nameof(snapshotSettingsResource)),
            }, callSettings);

        /// <summary>
        /// Patch region snapshot settings.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="snapshotSettingsResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(string project, string region, SnapshotSettings snapshotSettingsResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchRegionSnapshotSettingRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                SnapshotSettingsResource = gax::GaxPreconditions.CheckNotNull(snapshotSettingsResource, nameof(snapshotSettingsResource)),
            }, callSettings);

        /// <summary>
        /// Patch region snapshot settings.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="snapshotSettingsResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(string project, string region, SnapshotSettings snapshotSettingsResource, st::CancellationToken cancellationToken) =>
            PatchAsync(project, region, snapshotSettingsResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RegionSnapshotSettings client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The RegionSnapshotSettings API.
    /// </remarks>
    public sealed partial class RegionSnapshotSettingsClientImpl : RegionSnapshotSettingsClient
    {
        private readonly gaxgrpc::ApiCall<GetRegionSnapshotSettingRequest, SnapshotSettings> _callGet;

        private readonly gaxgrpc::ApiCall<PatchRegionSnapshotSettingRequest, Operation> _callPatch;

        /// <summary>
        /// Constructs a client wrapper for the RegionSnapshotSettings service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RegionSnapshotSettingsSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RegionSnapshotSettingsClientImpl(RegionSnapshotSettings.RegionSnapshotSettingsClient grpcClient, RegionSnapshotSettingsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RegionSnapshotSettingsSettings effectiveSettings = settings ?? RegionSnapshotSettingsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            PatchOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.PatchOperationsSettings, logger);
            _callGet = clientHelper.BuildApiCall<GetRegionSnapshotSettingRequest, SnapshotSettings>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callPatch = clientHelper.BuildApiCall<PatchRegionSnapshotSettingRequest, Operation>("Patch", grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetRegionSnapshotSettingRequest, SnapshotSettings> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchRegionSnapshotSettingRequest, Operation> call);

        partial void OnConstruction(RegionSnapshotSettings.RegionSnapshotSettingsClient grpcClient, RegionSnapshotSettingsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegionSnapshotSettings client</summary>
        public override RegionSnapshotSettings.RegionSnapshotSettingsClient GrpcClient { get; }

        partial void Modify_GetRegionSnapshotSettingRequest(ref GetRegionSnapshotSettingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchRegionSnapshotSettingRequest(ref PatchRegionSnapshotSettingRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get region snapshot settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SnapshotSettings Get(GetRegionSnapshotSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionSnapshotSettingRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Get region snapshot settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SnapshotSettings> GetAsync(GetRegionSnapshotSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionSnapshotSettingRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Patch</c>.</summary>
        public override lro::OperationsClient PatchOperationsClient { get; }

        /// <summary>
        /// Patch region snapshot settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Patch(PatchRegionSnapshotSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchRegionSnapshotSettingRequest(ref request, ref callSettings);
            Operation response = _callPatch.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchOperationsClient);
        }

        /// <summary>
        /// Patch region snapshot settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchRegionSnapshotSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchRegionSnapshotSettingRequest(ref request, ref callSettings);
            Operation response = await _callPatch.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchOperationsClient);
        }
    }

    public static partial class RegionSnapshotSettings
    {
        public partial class RegionSnapshotSettingsClient
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
