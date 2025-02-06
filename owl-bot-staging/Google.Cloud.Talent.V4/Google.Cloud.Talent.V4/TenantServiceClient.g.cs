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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Talent.V4
{
    /// <summary>Settings for <see cref="TenantServiceClient"/> instances.</summary>
    public sealed partial class TenantServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TenantServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TenantServiceSettings"/>.</returns>
        public static TenantServiceSettings GetDefault() => new TenantServiceSettings();

        /// <summary>Constructs a new <see cref="TenantServiceSettings"/> object with default settings.</summary>
        public TenantServiceSettings()
        {
        }

        private TenantServiceSettings(TenantServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateTenantSettings = existing.CreateTenantSettings;
            GetTenantSettings = existing.GetTenantSettings;
            UpdateTenantSettings = existing.UpdateTenantSettings;
            DeleteTenantSettings = existing.DeleteTenantSettings;
            ListTenantsSettings = existing.ListTenantsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TenantServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TenantServiceClient.CreateTenant</c> and <c>TenantServiceClient.CreateTenantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTenantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TenantServiceClient.GetTenant</c> and <c>TenantServiceClient.GetTenantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTenantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TenantServiceClient.UpdateTenant</c> and <c>TenantServiceClient.UpdateTenantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTenantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TenantServiceClient.DeleteTenant</c> and <c>TenantServiceClient.DeleteTenantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTenantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TenantServiceClient.ListTenants</c> and <c>TenantServiceClient.ListTenantsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTenantsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TenantServiceSettings"/> object.</returns>
        public TenantServiceSettings Clone() => new TenantServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TenantServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class TenantServiceClientBuilder : gaxgrpc::ClientBuilderBase<TenantServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TenantServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TenantServiceClientBuilder() : base(TenantServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TenantServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TenantServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TenantServiceClient Build()
        {
            TenantServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TenantServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TenantServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TenantServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TenantServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TenantServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TenantServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TenantServiceClient.ChannelPool;
    }

    /// <summary>TenantService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service that handles tenant management, including CRUD and enumeration.
    /// </remarks>
    public abstract partial class TenantServiceClient
    {
        /// <summary>
        /// The default endpoint for the TenantService service, which is a host of "jobs.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "jobs.googleapis.com:443";

        /// <summary>The default TenantService scopes.</summary>
        /// <remarks>
        /// The default TenantService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/jobs</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/jobs",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TenantService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TenantServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TenantServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TenantServiceClient"/>.</returns>
        public static stt::Task<TenantServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TenantServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TenantServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TenantServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TenantServiceClient"/>.</returns>
        public static TenantServiceClient Create() => new TenantServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TenantServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TenantServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TenantServiceClient"/>.</returns>
        internal static TenantServiceClient Create(grpccore::CallInvoker callInvoker, TenantServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TenantService.TenantServiceClient grpcClient = new TenantService.TenantServiceClient(callInvoker);
            return new TenantServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TenantService client</summary>
        public virtual TenantService.TenantServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tenant CreateTenant(CreateTenantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> CreateTenantAsync(CreateTenantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> CreateTenantAsync(CreateTenantRequest request, st::CancellationToken cancellationToken) =>
            CreateTenantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project under which the tenant is created.
        /// 
        /// The format is "projects/{project_id}", for example,
        /// "projects/foo".
        /// </param>
        /// <param name="tenant">
        /// Required. The tenant to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tenant CreateTenant(string parent, Tenant tenant, gaxgrpc::CallSettings callSettings = null) =>
            CreateTenant(new CreateTenantRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
            }, callSettings);

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project under which the tenant is created.
        /// 
        /// The format is "projects/{project_id}", for example,
        /// "projects/foo".
        /// </param>
        /// <param name="tenant">
        /// Required. The tenant to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> CreateTenantAsync(string parent, Tenant tenant, gaxgrpc::CallSettings callSettings = null) =>
            CreateTenantAsync(new CreateTenantRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
            }, callSettings);

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project under which the tenant is created.
        /// 
        /// The format is "projects/{project_id}", for example,
        /// "projects/foo".
        /// </param>
        /// <param name="tenant">
        /// Required. The tenant to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> CreateTenantAsync(string parent, Tenant tenant, st::CancellationToken cancellationToken) =>
            CreateTenantAsync(parent, tenant, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project under which the tenant is created.
        /// 
        /// The format is "projects/{project_id}", for example,
        /// "projects/foo".
        /// </param>
        /// <param name="tenant">
        /// Required. The tenant to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tenant CreateTenant(gagr::ProjectName parent, Tenant tenant, gaxgrpc::CallSettings callSettings = null) =>
            CreateTenant(new CreateTenantRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
            }, callSettings);

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project under which the tenant is created.
        /// 
        /// The format is "projects/{project_id}", for example,
        /// "projects/foo".
        /// </param>
        /// <param name="tenant">
        /// Required. The tenant to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> CreateTenantAsync(gagr::ProjectName parent, Tenant tenant, gaxgrpc::CallSettings callSettings = null) =>
            CreateTenantAsync(new CreateTenantRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
            }, callSettings);

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project under which the tenant is created.
        /// 
        /// The format is "projects/{project_id}", for example,
        /// "projects/foo".
        /// </param>
        /// <param name="tenant">
        /// Required. The tenant to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> CreateTenantAsync(gagr::ProjectName parent, Tenant tenant, st::CancellationToken cancellationToken) =>
            CreateTenantAsync(parent, tenant, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tenant GetTenant(GetTenantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> GetTenantAsync(GetTenantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> GetTenantAsync(GetTenantRequest request, st::CancellationToken cancellationToken) =>
            GetTenantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tenant to be retrieved.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tenant GetTenant(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTenant(new GetTenantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tenant to be retrieved.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> GetTenantAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTenantAsync(new GetTenantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tenant to be retrieved.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> GetTenantAsync(string name, st::CancellationToken cancellationToken) =>
            GetTenantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tenant to be retrieved.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tenant GetTenant(TenantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTenant(new GetTenantRequest
            {
                TenantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tenant to be retrieved.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> GetTenantAsync(TenantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTenantAsync(new GetTenantRequest
            {
                TenantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tenant to be retrieved.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> GetTenantAsync(TenantName name, st::CancellationToken cancellationToken) =>
            GetTenantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates specified tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tenant UpdateTenant(UpdateTenantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates specified tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> UpdateTenantAsync(UpdateTenantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates specified tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> UpdateTenantAsync(UpdateTenantRequest request, st::CancellationToken cancellationToken) =>
            UpdateTenantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates specified tenant.
        /// </summary>
        /// <param name="tenant">
        /// Required. The tenant resource to replace the current resource in the
        /// system.
        /// </param>
        /// <param name="updateMask">
        /// Strongly recommended for the best service experience.
        /// 
        /// If [update_mask][google.cloud.talent.v4.UpdateTenantRequest.update_mask] is
        /// provided, only the specified fields in
        /// [tenant][google.cloud.talent.v4.UpdateTenantRequest.tenant] are updated.
        /// Otherwise all the fields are updated.
        /// 
        /// A field mask to specify the tenant fields to be updated. Only
        /// top level fields of [Tenant][google.cloud.talent.v4.Tenant] are supported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tenant UpdateTenant(Tenant tenant, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTenant(new UpdateTenantRequest
            {
                Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates specified tenant.
        /// </summary>
        /// <param name="tenant">
        /// Required. The tenant resource to replace the current resource in the
        /// system.
        /// </param>
        /// <param name="updateMask">
        /// Strongly recommended for the best service experience.
        /// 
        /// If [update_mask][google.cloud.talent.v4.UpdateTenantRequest.update_mask] is
        /// provided, only the specified fields in
        /// [tenant][google.cloud.talent.v4.UpdateTenantRequest.tenant] are updated.
        /// Otherwise all the fields are updated.
        /// 
        /// A field mask to specify the tenant fields to be updated. Only
        /// top level fields of [Tenant][google.cloud.talent.v4.Tenant] are supported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> UpdateTenantAsync(Tenant tenant, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTenantAsync(new UpdateTenantRequest
            {
                Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates specified tenant.
        /// </summary>
        /// <param name="tenant">
        /// Required. The tenant resource to replace the current resource in the
        /// system.
        /// </param>
        /// <param name="updateMask">
        /// Strongly recommended for the best service experience.
        /// 
        /// If [update_mask][google.cloud.talent.v4.UpdateTenantRequest.update_mask] is
        /// provided, only the specified fields in
        /// [tenant][google.cloud.talent.v4.UpdateTenantRequest.tenant] are updated.
        /// Otherwise all the fields are updated.
        /// 
        /// A field mask to specify the tenant fields to be updated. Only
        /// top level fields of [Tenant][google.cloud.talent.v4.Tenant] are supported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> UpdateTenantAsync(Tenant tenant, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTenantAsync(tenant, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTenant(DeleteTenantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTenantAsync(DeleteTenantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTenantAsync(DeleteTenantRequest request, st::CancellationToken cancellationToken) =>
            DeleteTenantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tenant to be deleted.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTenant(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTenant(new DeleteTenantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tenant to be deleted.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTenantAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTenantAsync(new DeleteTenantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tenant to be deleted.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTenantAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTenantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tenant to be deleted.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTenant(TenantName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTenant(new DeleteTenantRequest
            {
                TenantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tenant to be deleted.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTenantAsync(TenantName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTenantAsync(new DeleteTenantRequest
            {
                TenantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the tenant to be deleted.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTenantAsync(TenantName name, st::CancellationToken cancellationToken) =>
            DeleteTenantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all tenants associated with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Tenant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTenantsResponse, Tenant> ListTenants(ListTenantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all tenants associated with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Tenant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTenantsResponse, Tenant> ListTenantsAsync(ListTenantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all tenants associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project under which the tenant is created.
        /// 
        /// The format is "projects/{project_id}", for example,
        /// "projects/foo".
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
        /// <returns>A pageable sequence of <see cref="Tenant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTenantsResponse, Tenant> ListTenants(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTenantsRequest request = new ListTenantsRequest
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
            return ListTenants(request, callSettings);
        }

        /// <summary>
        /// Lists all tenants associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project under which the tenant is created.
        /// 
        /// The format is "projects/{project_id}", for example,
        /// "projects/foo".
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
        /// <returns>A pageable asynchronous sequence of <see cref="Tenant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTenantsResponse, Tenant> ListTenantsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTenantsRequest request = new ListTenantsRequest
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
            return ListTenantsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all tenants associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project under which the tenant is created.
        /// 
        /// The format is "projects/{project_id}", for example,
        /// "projects/foo".
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
        /// <returns>A pageable sequence of <see cref="Tenant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTenantsResponse, Tenant> ListTenants(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTenantsRequest request = new ListTenantsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTenants(request, callSettings);
        }

        /// <summary>
        /// Lists all tenants associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project under which the tenant is created.
        /// 
        /// The format is "projects/{project_id}", for example,
        /// "projects/foo".
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
        /// <returns>A pageable asynchronous sequence of <see cref="Tenant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTenantsResponse, Tenant> ListTenantsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTenantsRequest request = new ListTenantsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTenantsAsync(request, callSettings);
        }
    }

    /// <summary>TenantService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service that handles tenant management, including CRUD and enumeration.
    /// </remarks>
    public sealed partial class TenantServiceClientImpl : TenantServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateTenantRequest, Tenant> _callCreateTenant;

        private readonly gaxgrpc::ApiCall<GetTenantRequest, Tenant> _callGetTenant;

        private readonly gaxgrpc::ApiCall<UpdateTenantRequest, Tenant> _callUpdateTenant;

        private readonly gaxgrpc::ApiCall<DeleteTenantRequest, wkt::Empty> _callDeleteTenant;

        private readonly gaxgrpc::ApiCall<ListTenantsRequest, ListTenantsResponse> _callListTenants;

        /// <summary>
        /// Constructs a client wrapper for the TenantService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TenantServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TenantServiceClientImpl(TenantService.TenantServiceClient grpcClient, TenantServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TenantServiceSettings effectiveSettings = settings ?? TenantServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateTenant = clientHelper.BuildApiCall<CreateTenantRequest, Tenant>("CreateTenant", grpcClient.CreateTenantAsync, grpcClient.CreateTenant, effectiveSettings.CreateTenantSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTenant);
            Modify_CreateTenantApiCall(ref _callCreateTenant);
            _callGetTenant = clientHelper.BuildApiCall<GetTenantRequest, Tenant>("GetTenant", grpcClient.GetTenantAsync, grpcClient.GetTenant, effectiveSettings.GetTenantSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTenant);
            Modify_GetTenantApiCall(ref _callGetTenant);
            _callUpdateTenant = clientHelper.BuildApiCall<UpdateTenantRequest, Tenant>("UpdateTenant", grpcClient.UpdateTenantAsync, grpcClient.UpdateTenant, effectiveSettings.UpdateTenantSettings).WithGoogleRequestParam("tenant.name", request => request.Tenant?.Name);
            Modify_ApiCall(ref _callUpdateTenant);
            Modify_UpdateTenantApiCall(ref _callUpdateTenant);
            _callDeleteTenant = clientHelper.BuildApiCall<DeleteTenantRequest, wkt::Empty>("DeleteTenant", grpcClient.DeleteTenantAsync, grpcClient.DeleteTenant, effectiveSettings.DeleteTenantSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTenant);
            Modify_DeleteTenantApiCall(ref _callDeleteTenant);
            _callListTenants = clientHelper.BuildApiCall<ListTenantsRequest, ListTenantsResponse>("ListTenants", grpcClient.ListTenantsAsync, grpcClient.ListTenants, effectiveSettings.ListTenantsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTenants);
            Modify_ListTenantsApiCall(ref _callListTenants);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateTenantApiCall(ref gaxgrpc::ApiCall<CreateTenantRequest, Tenant> call);

        partial void Modify_GetTenantApiCall(ref gaxgrpc::ApiCall<GetTenantRequest, Tenant> call);

        partial void Modify_UpdateTenantApiCall(ref gaxgrpc::ApiCall<UpdateTenantRequest, Tenant> call);

        partial void Modify_DeleteTenantApiCall(ref gaxgrpc::ApiCall<DeleteTenantRequest, wkt::Empty> call);

        partial void Modify_ListTenantsApiCall(ref gaxgrpc::ApiCall<ListTenantsRequest, ListTenantsResponse> call);

        partial void OnConstruction(TenantService.TenantServiceClient grpcClient, TenantServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TenantService client</summary>
        public override TenantService.TenantServiceClient GrpcClient { get; }

        partial void Modify_CreateTenantRequest(ref CreateTenantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTenantRequest(ref GetTenantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTenantRequest(ref UpdateTenantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTenantRequest(ref DeleteTenantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTenantsRequest(ref ListTenantsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tenant CreateTenant(CreateTenantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTenantRequest(ref request, ref callSettings);
            return _callCreateTenant.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tenant> CreateTenantAsync(CreateTenantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTenantRequest(ref request, ref callSettings);
            return _callCreateTenant.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tenant GetTenant(GetTenantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTenantRequest(ref request, ref callSettings);
            return _callGetTenant.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tenant> GetTenantAsync(GetTenantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTenantRequest(ref request, ref callSettings);
            return _callGetTenant.Async(request, callSettings);
        }

        /// <summary>
        /// Updates specified tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tenant UpdateTenant(UpdateTenantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTenantRequest(ref request, ref callSettings);
            return _callUpdateTenant.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates specified tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tenant> UpdateTenantAsync(UpdateTenantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTenantRequest(ref request, ref callSettings);
            return _callUpdateTenant.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTenant(DeleteTenantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTenantRequest(ref request, ref callSettings);
            _callDeleteTenant.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTenantAsync(DeleteTenantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTenantRequest(ref request, ref callSettings);
            return _callDeleteTenant.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all tenants associated with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Tenant"/> resources.</returns>
        public override gax::PagedEnumerable<ListTenantsResponse, Tenant> ListTenants(ListTenantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTenantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTenantsRequest, ListTenantsResponse, Tenant>(_callListTenants, request, callSettings);
        }

        /// <summary>
        /// Lists all tenants associated with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Tenant"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTenantsResponse, Tenant> ListTenantsAsync(ListTenantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTenantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTenantsRequest, ListTenantsResponse, Tenant>(_callListTenants, request, callSettings);
        }
    }

    public partial class ListTenantsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTenantsResponse : gaxgrpc::IPageResponse<Tenant>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Tenant> GetEnumerator() => Tenants.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
