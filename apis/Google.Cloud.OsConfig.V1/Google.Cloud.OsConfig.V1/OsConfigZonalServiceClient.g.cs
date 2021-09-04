// Copyright 2021 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.OsConfig.V1
{
    /// <summary>Settings for <see cref="OsConfigZonalServiceClient"/> instances.</summary>
    public sealed partial class OsConfigZonalServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OsConfigZonalServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OsConfigZonalServiceSettings"/>.</returns>
        public static OsConfigZonalServiceSettings GetDefault() => new OsConfigZonalServiceSettings();

        /// <summary>Constructs a new <see cref="OsConfigZonalServiceSettings"/> object with default settings.</summary>
        public OsConfigZonalServiceSettings()
        {
        }

        private OsConfigZonalServiceSettings(OsConfigZonalServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetInventorySettings = existing.GetInventorySettings;
            ListInventoriesSettings = existing.ListInventoriesSettings;
            GetVulnerabilityReportSettings = existing.GetVulnerabilityReportSettings;
            ListVulnerabilityReportsSettings = existing.ListVulnerabilityReportsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(OsConfigZonalServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigZonalServiceClient.GetInventory</c> and <c>OsConfigZonalServiceClient.GetInventoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInventorySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigZonalServiceClient.ListInventories</c> and <c>OsConfigZonalServiceClient.ListInventoriesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInventoriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigZonalServiceClient.GetVulnerabilityReport</c> and
        /// <c>OsConfigZonalServiceClient.GetVulnerabilityReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVulnerabilityReportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigZonalServiceClient.ListVulnerabilityReports</c> and
        /// <c>OsConfigZonalServiceClient.ListVulnerabilityReportsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListVulnerabilityReportsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OsConfigZonalServiceSettings"/> object.</returns>
        public OsConfigZonalServiceSettings Clone() => new OsConfigZonalServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OsConfigZonalServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class OsConfigZonalServiceClientBuilder : gaxgrpc::ClientBuilderBase<OsConfigZonalServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OsConfigZonalServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OsConfigZonalServiceClientBuilder()
        {
            UseJwtAccessWithScopes = OsConfigZonalServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref OsConfigZonalServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OsConfigZonalServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OsConfigZonalServiceClient Build()
        {
            OsConfigZonalServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OsConfigZonalServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OsConfigZonalServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OsConfigZonalServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OsConfigZonalServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<OsConfigZonalServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OsConfigZonalServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => OsConfigZonalServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => OsConfigZonalServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OsConfigZonalServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>OsConfigZonalService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Zonal OS Config API
    /// 
    /// The OS Config service is the server-side component that allows users to
    /// manage package installations and patch jobs for Compute Engine VM instances.
    /// </remarks>
    public abstract partial class OsConfigZonalServiceClient
    {
        /// <summary>
        /// The default endpoint for the OsConfigZonalService service, which is a host of "osconfig.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "osconfig.googleapis.com:443";

        /// <summary>The default OsConfigZonalService scopes.</summary>
        /// <remarks>
        /// The default OsConfigZonalService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="OsConfigZonalServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="OsConfigZonalServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OsConfigZonalServiceClient"/>.</returns>
        public static stt::Task<OsConfigZonalServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OsConfigZonalServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OsConfigZonalServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="OsConfigZonalServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OsConfigZonalServiceClient"/>.</returns>
        public static OsConfigZonalServiceClient Create() => new OsConfigZonalServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OsConfigZonalServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OsConfigZonalServiceSettings"/>.</param>
        /// <returns>The created <see cref="OsConfigZonalServiceClient"/>.</returns>
        internal static OsConfigZonalServiceClient Create(grpccore::CallInvoker callInvoker, OsConfigZonalServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OsConfigZonalService.OsConfigZonalServiceClient grpcClient = new OsConfigZonalService.OsConfigZonalServiceClient(callInvoker);
            return new OsConfigZonalServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC OsConfigZonalService client</summary>
        public virtual OsConfigZonalService.OsConfigZonalServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Inventory GetInventory(GetInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Inventory> GetInventoryAsync(GetInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Inventory> GetInventoryAsync(GetInventoryRequest request, st::CancellationToken cancellationToken) =>
            GetInventoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for inventory resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/inventory`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine  `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Inventory GetInventory(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInventory(new GetInventoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for inventory resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/inventory`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine  `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Inventory> GetInventoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInventoryAsync(new GetInventoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for inventory resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/inventory`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine  `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Inventory> GetInventoryAsync(string name, st::CancellationToken cancellationToken) =>
            GetInventoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for inventory resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/inventory`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine  `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Inventory GetInventory(InventoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInventory(new GetInventoryRequest
            {
                InventoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for inventory resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/inventory`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine  `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Inventory> GetInventoryAsync(InventoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInventoryAsync(new GetInventoryRequest
            {
                InventoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for inventory resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/inventory`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine  `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Inventory> GetInventoryAsync(InventoryName name, st::CancellationToken cancellationToken) =>
            GetInventoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List inventory data for all VM instances in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Inventory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInventoriesResponse, Inventory> ListInventories(ListInventoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List inventory data for all VM instances in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Inventory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInventoriesResponse, Inventory> ListInventoriesAsync(ListInventoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List inventory data for all VM instances in the specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}/instances/-`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
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
        /// <returns>A pageable sequence of <see cref="Inventory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInventoriesResponse, Inventory> ListInventories(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInventories(new ListInventoriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List inventory data for all VM instances in the specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}/instances/-`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Inventory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInventoriesResponse, Inventory> ListInventoriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInventoriesAsync(new ListInventoriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List inventory data for all VM instances in the specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}/instances/-`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
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
        /// <returns>A pageable sequence of <see cref="Inventory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInventoriesResponse, Inventory> ListInventories(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInventories(new ListInventoriesRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List inventory data for all VM instances in the specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}/instances/-`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Inventory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInventoriesResponse, Inventory> ListInventoriesAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInventoriesAsync(new ListInventoriesRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VulnerabilityReport GetVulnerabilityReport(GetVulnerabilityReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityReport> GetVulnerabilityReportAsync(GetVulnerabilityReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityReport> GetVulnerabilityReportAsync(GetVulnerabilityReportRequest request, st::CancellationToken cancellationToken) =>
            GetVulnerabilityReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for vulnerability resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/vulnerabilityReport`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VulnerabilityReport GetVulnerabilityReport(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVulnerabilityReport(new GetVulnerabilityReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for vulnerability resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/vulnerabilityReport`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityReport> GetVulnerabilityReportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVulnerabilityReportAsync(new GetVulnerabilityReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for vulnerability resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/vulnerabilityReport`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityReport> GetVulnerabilityReportAsync(string name, st::CancellationToken cancellationToken) =>
            GetVulnerabilityReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for vulnerability resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/vulnerabilityReport`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VulnerabilityReport GetVulnerabilityReport(VulnerabilityReportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVulnerabilityReport(new GetVulnerabilityReportRequest
            {
                VulnerabilityReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for vulnerability resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/vulnerabilityReport`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityReport> GetVulnerabilityReportAsync(VulnerabilityReportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVulnerabilityReportAsync(new GetVulnerabilityReportRequest
            {
                VulnerabilityReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="name">
        /// Required. API resource name for vulnerability resource.
        /// 
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/vulnerabilityReport`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
        /// For `{instance}`, either Compute Engine `instance-id` or `instance-name`
        /// can be provided.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityReport> GetVulnerabilityReportAsync(VulnerabilityReportName name, st::CancellationToken cancellationToken) =>
            GetVulnerabilityReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List vulnerability reports for all VM instances in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VulnerabilityReport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> ListVulnerabilityReports(ListVulnerabilityReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List vulnerability reports for all VM instances in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VulnerabilityReport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> ListVulnerabilityReportsAsync(ListVulnerabilityReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List vulnerability reports for all VM instances in the specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}/instances/-`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
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
        /// <returns>A pageable sequence of <see cref="VulnerabilityReport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> ListVulnerabilityReports(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVulnerabilityReports(new ListVulnerabilityReportsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List vulnerability reports for all VM instances in the specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}/instances/-`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
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
        /// <returns>A pageable asynchronous sequence of <see cref="VulnerabilityReport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> ListVulnerabilityReportsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVulnerabilityReportsAsync(new ListVulnerabilityReportsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List vulnerability reports for all VM instances in the specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}/instances/-`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
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
        /// <returns>A pageable sequence of <see cref="VulnerabilityReport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> ListVulnerabilityReports(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVulnerabilityReports(new ListVulnerabilityReportsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List vulnerability reports for all VM instances in the specified zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// 
        /// Format: `projects/{project}/locations/{location}/instances/-`
        /// 
        /// For `{project}`, either `project-number` or `project-id` can be provided.
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
        /// <returns>A pageable asynchronous sequence of <see cref="VulnerabilityReport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> ListVulnerabilityReportsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVulnerabilityReportsAsync(new ListVulnerabilityReportsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>OsConfigZonalService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Zonal OS Config API
    /// 
    /// The OS Config service is the server-side component that allows users to
    /// manage package installations and patch jobs for Compute Engine VM instances.
    /// </remarks>
    public sealed partial class OsConfigZonalServiceClientImpl : OsConfigZonalServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetInventoryRequest, Inventory> _callGetInventory;

        private readonly gaxgrpc::ApiCall<ListInventoriesRequest, ListInventoriesResponse> _callListInventories;

        private readonly gaxgrpc::ApiCall<GetVulnerabilityReportRequest, VulnerabilityReport> _callGetVulnerabilityReport;

        private readonly gaxgrpc::ApiCall<ListVulnerabilityReportsRequest, ListVulnerabilityReportsResponse> _callListVulnerabilityReports;

        /// <summary>
        /// Constructs a client wrapper for the OsConfigZonalService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="OsConfigZonalServiceSettings"/> used within this client.</param>
        public OsConfigZonalServiceClientImpl(OsConfigZonalService.OsConfigZonalServiceClient grpcClient, OsConfigZonalServiceSettings settings)
        {
            GrpcClient = grpcClient;
            OsConfigZonalServiceSettings effectiveSettings = settings ?? OsConfigZonalServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetInventory = clientHelper.BuildApiCall<GetInventoryRequest, Inventory>(grpcClient.GetInventoryAsync, grpcClient.GetInventory, effectiveSettings.GetInventorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInventory);
            Modify_GetInventoryApiCall(ref _callGetInventory);
            _callListInventories = clientHelper.BuildApiCall<ListInventoriesRequest, ListInventoriesResponse>(grpcClient.ListInventoriesAsync, grpcClient.ListInventories, effectiveSettings.ListInventoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInventories);
            Modify_ListInventoriesApiCall(ref _callListInventories);
            _callGetVulnerabilityReport = clientHelper.BuildApiCall<GetVulnerabilityReportRequest, VulnerabilityReport>(grpcClient.GetVulnerabilityReportAsync, grpcClient.GetVulnerabilityReport, effectiveSettings.GetVulnerabilityReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVulnerabilityReport);
            Modify_GetVulnerabilityReportApiCall(ref _callGetVulnerabilityReport);
            _callListVulnerabilityReports = clientHelper.BuildApiCall<ListVulnerabilityReportsRequest, ListVulnerabilityReportsResponse>(grpcClient.ListVulnerabilityReportsAsync, grpcClient.ListVulnerabilityReports, effectiveSettings.ListVulnerabilityReportsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVulnerabilityReports);
            Modify_ListVulnerabilityReportsApiCall(ref _callListVulnerabilityReports);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetInventoryApiCall(ref gaxgrpc::ApiCall<GetInventoryRequest, Inventory> call);

        partial void Modify_ListInventoriesApiCall(ref gaxgrpc::ApiCall<ListInventoriesRequest, ListInventoriesResponse> call);

        partial void Modify_GetVulnerabilityReportApiCall(ref gaxgrpc::ApiCall<GetVulnerabilityReportRequest, VulnerabilityReport> call);

        partial void Modify_ListVulnerabilityReportsApiCall(ref gaxgrpc::ApiCall<ListVulnerabilityReportsRequest, ListVulnerabilityReportsResponse> call);

        partial void OnConstruction(OsConfigZonalService.OsConfigZonalServiceClient grpcClient, OsConfigZonalServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OsConfigZonalService client</summary>
        public override OsConfigZonalService.OsConfigZonalServiceClient GrpcClient { get; }

        partial void Modify_GetInventoryRequest(ref GetInventoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInventoriesRequest(ref ListInventoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVulnerabilityReportRequest(ref GetVulnerabilityReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVulnerabilityReportsRequest(ref ListVulnerabilityReportsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Inventory GetInventory(GetInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInventoryRequest(ref request, ref callSettings);
            return _callGetInventory.Sync(request, callSettings);
        }

        /// <summary>
        /// Get inventory data for the specified VM instance. If the VM has no
        /// associated inventory, the message `NOT_FOUND` is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Inventory> GetInventoryAsync(GetInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInventoryRequest(ref request, ref callSettings);
            return _callGetInventory.Async(request, callSettings);
        }

        /// <summary>
        /// List inventory data for all VM instances in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Inventory"/> resources.</returns>
        public override gax::PagedEnumerable<ListInventoriesResponse, Inventory> ListInventories(ListInventoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInventoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInventoriesRequest, ListInventoriesResponse, Inventory>(_callListInventories, request, callSettings);
        }

        /// <summary>
        /// List inventory data for all VM instances in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Inventory"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInventoriesResponse, Inventory> ListInventoriesAsync(ListInventoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInventoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInventoriesRequest, ListInventoriesResponse, Inventory>(_callListInventories, request, callSettings);
        }

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VulnerabilityReport GetVulnerabilityReport(GetVulnerabilityReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVulnerabilityReportRequest(ref request, ref callSettings);
            return _callGetVulnerabilityReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the vulnerability report for the specified VM instance. Only VMs with
        /// inventory data have vulnerability reports associated with them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VulnerabilityReport> GetVulnerabilityReportAsync(GetVulnerabilityReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVulnerabilityReportRequest(ref request, ref callSettings);
            return _callGetVulnerabilityReport.Async(request, callSettings);
        }

        /// <summary>
        /// List vulnerability reports for all VM instances in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VulnerabilityReport"/> resources.</returns>
        public override gax::PagedEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> ListVulnerabilityReports(ListVulnerabilityReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVulnerabilityReportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVulnerabilityReportsRequest, ListVulnerabilityReportsResponse, VulnerabilityReport>(_callListVulnerabilityReports, request, callSettings);
        }

        /// <summary>
        /// List vulnerability reports for all VM instances in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VulnerabilityReport"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> ListVulnerabilityReportsAsync(ListVulnerabilityReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVulnerabilityReportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVulnerabilityReportsRequest, ListVulnerabilityReportsResponse, VulnerabilityReport>(_callListVulnerabilityReports, request, callSettings);
        }
    }

    public partial class ListInventoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVulnerabilityReportsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInventoriesResponse : gaxgrpc::IPageResponse<Inventory>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Inventory> GetEnumerator() => Inventories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListVulnerabilityReportsResponse : gaxgrpc::IPageResponse<VulnerabilityReport>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<VulnerabilityReport> GetEnumerator() => VulnerabilityReports.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
