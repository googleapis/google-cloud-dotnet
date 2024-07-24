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
    /// <summary>Settings for <see cref="CompanyServiceClient"/> instances.</summary>
    public sealed partial class CompanyServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CompanyServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CompanyServiceSettings"/>.</returns>
        public static CompanyServiceSettings GetDefault() => new CompanyServiceSettings();

        /// <summary>Constructs a new <see cref="CompanyServiceSettings"/> object with default settings.</summary>
        public CompanyServiceSettings()
        {
        }

        private CompanyServiceSettings(CompanyServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateCompanySettings = existing.CreateCompanySettings;
            GetCompanySettings = existing.GetCompanySettings;
            UpdateCompanySettings = existing.UpdateCompanySettings;
            DeleteCompanySettings = existing.DeleteCompanySettings;
            ListCompaniesSettings = existing.ListCompaniesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CompanyServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanyServiceClient.CreateCompany</c> and <c>CompanyServiceClient.CreateCompanyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCompanySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanyServiceClient.GetCompany</c> and <c>CompanyServiceClient.GetCompanyAsync</c>.
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
        public gaxgrpc::CallSettings GetCompanySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanyServiceClient.UpdateCompany</c> and <c>CompanyServiceClient.UpdateCompanyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCompanySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanyServiceClient.DeleteCompany</c> and <c>CompanyServiceClient.DeleteCompanyAsync</c>.
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
        public gaxgrpc::CallSettings DeleteCompanySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanyServiceClient.ListCompanies</c> and <c>CompanyServiceClient.ListCompaniesAsync</c>.
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
        public gaxgrpc::CallSettings ListCompaniesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CompanyServiceSettings"/> object.</returns>
        public CompanyServiceSettings Clone() => new CompanyServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CompanyServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CompanyServiceClientBuilder : gaxgrpc::ClientBuilderBase<CompanyServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CompanyServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CompanyServiceClientBuilder() : base(CompanyServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CompanyServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CompanyServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CompanyServiceClient Build()
        {
            CompanyServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CompanyServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CompanyServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CompanyServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CompanyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CompanyServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CompanyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CompanyServiceClient.ChannelPool;
    }

    /// <summary>CompanyService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service that handles company management, including CRUD and enumeration.
    /// </remarks>
    public abstract partial class CompanyServiceClient
    {
        /// <summary>
        /// The default endpoint for the CompanyService service, which is a host of "jobs.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "jobs.googleapis.com:443";

        /// <summary>The default CompanyService scopes.</summary>
        /// <remarks>
        /// The default CompanyService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CompanyService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CompanyServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CompanyServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CompanyServiceClient"/>.</returns>
        public static stt::Task<CompanyServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CompanyServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CompanyServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CompanyServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CompanyServiceClient"/>.</returns>
        public static CompanyServiceClient Create() => new CompanyServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CompanyServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CompanyServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CompanyServiceClient"/>.</returns>
        internal static CompanyServiceClient Create(grpccore::CallInvoker callInvoker, CompanyServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CompanyService.CompanyServiceClient grpcClient = new CompanyService.CompanyServiceClient(callInvoker);
            return new CompanyServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CompanyService client</summary>
        public virtual CompanyService.CompanyServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Company CreateCompany(CreateCompanyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> CreateCompanyAsync(CreateCompanyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> CreateCompanyAsync(CreateCompanyRequest request, st::CancellationToken cancellationToken) =>
            CreateCompanyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the tenant under which the company is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="company">
        /// Required. The company to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Company CreateCompany(string parent, Company company, gaxgrpc::CallSettings callSettings = null) =>
            CreateCompany(new CreateCompanyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Company = gax::GaxPreconditions.CheckNotNull(company, nameof(company)),
            }, callSettings);

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the tenant under which the company is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="company">
        /// Required. The company to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> CreateCompanyAsync(string parent, Company company, gaxgrpc::CallSettings callSettings = null) =>
            CreateCompanyAsync(new CreateCompanyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Company = gax::GaxPreconditions.CheckNotNull(company, nameof(company)),
            }, callSettings);

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the tenant under which the company is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="company">
        /// Required. The company to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> CreateCompanyAsync(string parent, Company company, st::CancellationToken cancellationToken) =>
            CreateCompanyAsync(parent, company, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the tenant under which the company is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="company">
        /// Required. The company to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Company CreateCompany(TenantName parent, Company company, gaxgrpc::CallSettings callSettings = null) =>
            CreateCompany(new CreateCompanyRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Company = gax::GaxPreconditions.CheckNotNull(company, nameof(company)),
            }, callSettings);

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the tenant under which the company is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="company">
        /// Required. The company to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> CreateCompanyAsync(TenantName parent, Company company, gaxgrpc::CallSettings callSettings = null) =>
            CreateCompanyAsync(new CreateCompanyRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Company = gax::GaxPreconditions.CheckNotNull(company, nameof(company)),
            }, callSettings);

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the tenant under which the company is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="company">
        /// Required. The company to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> CreateCompanyAsync(TenantName parent, Company company, st::CancellationToken cancellationToken) =>
            CreateCompanyAsync(parent, company, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Company GetCompany(GetCompanyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> GetCompanyAsync(GetCompanyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> GetCompanyAsync(GetCompanyRequest request, st::CancellationToken cancellationToken) =>
            GetCompanyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the company to be retrieved.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Company GetCompany(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompany(new GetCompanyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the company to be retrieved.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> GetCompanyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompanyAsync(new GetCompanyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the company to be retrieved.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> GetCompanyAsync(string name, st::CancellationToken cancellationToken) =>
            GetCompanyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the company to be retrieved.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Company GetCompany(CompanyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompany(new GetCompanyRequest
            {
                CompanyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the company to be retrieved.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> GetCompanyAsync(CompanyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompanyAsync(new GetCompanyRequest
            {
                CompanyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the company to be retrieved.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> GetCompanyAsync(CompanyName name, st::CancellationToken cancellationToken) =>
            GetCompanyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates specified company.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Company UpdateCompany(UpdateCompanyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates specified company.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> UpdateCompanyAsync(UpdateCompanyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates specified company.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> UpdateCompanyAsync(UpdateCompanyRequest request, st::CancellationToken cancellationToken) =>
            UpdateCompanyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates specified company.
        /// </summary>
        /// <param name="company">
        /// Required. The company resource to replace the current resource in the
        /// system.
        /// </param>
        /// <param name="updateMask">
        /// Strongly recommended for the best service experience.
        /// 
        /// If [update_mask][google.cloud.talent.v4.UpdateCompanyRequest.update_mask]
        /// is provided, only the specified fields in
        /// [company][google.cloud.talent.v4.UpdateCompanyRequest.company] are updated.
        /// Otherwise all the fields are updated.
        /// 
        /// A field mask to specify the company fields to be updated. Only
        /// top level fields of [Company][google.cloud.talent.v4.Company] are
        /// supported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Company UpdateCompany(Company company, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCompany(new UpdateCompanyRequest
            {
                Company = gax::GaxPreconditions.CheckNotNull(company, nameof(company)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates specified company.
        /// </summary>
        /// <param name="company">
        /// Required. The company resource to replace the current resource in the
        /// system.
        /// </param>
        /// <param name="updateMask">
        /// Strongly recommended for the best service experience.
        /// 
        /// If [update_mask][google.cloud.talent.v4.UpdateCompanyRequest.update_mask]
        /// is provided, only the specified fields in
        /// [company][google.cloud.talent.v4.UpdateCompanyRequest.company] are updated.
        /// Otherwise all the fields are updated.
        /// 
        /// A field mask to specify the company fields to be updated. Only
        /// top level fields of [Company][google.cloud.talent.v4.Company] are
        /// supported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> UpdateCompanyAsync(Company company, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCompanyAsync(new UpdateCompanyRequest
            {
                Company = gax::GaxPreconditions.CheckNotNull(company, nameof(company)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates specified company.
        /// </summary>
        /// <param name="company">
        /// Required. The company resource to replace the current resource in the
        /// system.
        /// </param>
        /// <param name="updateMask">
        /// Strongly recommended for the best service experience.
        /// 
        /// If [update_mask][google.cloud.talent.v4.UpdateCompanyRequest.update_mask]
        /// is provided, only the specified fields in
        /// [company][google.cloud.talent.v4.UpdateCompanyRequest.company] are updated.
        /// Otherwise all the fields are updated.
        /// 
        /// A field mask to specify the company fields to be updated. Only
        /// top level fields of [Company][google.cloud.talent.v4.Company] are
        /// supported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> UpdateCompanyAsync(Company company, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCompanyAsync(company, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCompany(DeleteCompanyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCompanyAsync(DeleteCompanyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCompanyAsync(DeleteCompanyRequest request, st::CancellationToken cancellationToken) =>
            DeleteCompanyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the company to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/foo/tenants/bar/companies/baz".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCompany(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCompany(new DeleteCompanyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the company to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/foo/tenants/bar/companies/baz".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCompanyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCompanyAsync(new DeleteCompanyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the company to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/foo/tenants/bar/companies/baz".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCompanyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCompanyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the company to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/foo/tenants/bar/companies/baz".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCompany(CompanyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCompany(new DeleteCompanyRequest
            {
                CompanyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the company to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/foo/tenants/bar/companies/baz".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCompanyAsync(CompanyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCompanyAsync(new DeleteCompanyRequest
            {
                CompanyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the company to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/foo/tenants/bar/companies/baz".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCompanyAsync(CompanyName name, st::CancellationToken cancellationToken) =>
            DeleteCompanyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all companies associated with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Company"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCompaniesResponse, Company> ListCompanies(ListCompaniesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all companies associated with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Company"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCompaniesResponse, Company> ListCompaniesAsync(ListCompaniesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all companies associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the tenant under which the company is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
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
        /// <returns>A pageable sequence of <see cref="Company"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCompaniesResponse, Company> ListCompanies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCompaniesRequest request = new ListCompaniesRequest
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
            return ListCompanies(request, callSettings);
        }

        /// <summary>
        /// Lists all companies associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the tenant under which the company is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
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
        /// <returns>A pageable asynchronous sequence of <see cref="Company"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCompaniesResponse, Company> ListCompaniesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCompaniesRequest request = new ListCompaniesRequest
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
            return ListCompaniesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all companies associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the tenant under which the company is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
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
        /// <returns>A pageable sequence of <see cref="Company"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCompaniesResponse, Company> ListCompanies(TenantName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCompaniesRequest request = new ListCompaniesRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCompanies(request, callSettings);
        }

        /// <summary>
        /// Lists all companies associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the tenant under which the company is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
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
        /// <returns>A pageable asynchronous sequence of <see cref="Company"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCompaniesResponse, Company> ListCompaniesAsync(TenantName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCompaniesRequest request = new ListCompaniesRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCompaniesAsync(request, callSettings);
        }
    }

    /// <summary>CompanyService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service that handles company management, including CRUD and enumeration.
    /// </remarks>
    public sealed partial class CompanyServiceClientImpl : CompanyServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateCompanyRequest, Company> _callCreateCompany;

        private readonly gaxgrpc::ApiCall<GetCompanyRequest, Company> _callGetCompany;

        private readonly gaxgrpc::ApiCall<UpdateCompanyRequest, Company> _callUpdateCompany;

        private readonly gaxgrpc::ApiCall<DeleteCompanyRequest, wkt::Empty> _callDeleteCompany;

        private readonly gaxgrpc::ApiCall<ListCompaniesRequest, ListCompaniesResponse> _callListCompanies;

        /// <summary>
        /// Constructs a client wrapper for the CompanyService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CompanyServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CompanyServiceClientImpl(CompanyService.CompanyServiceClient grpcClient, CompanyServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CompanyServiceSettings effectiveSettings = settings ?? CompanyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateCompany = clientHelper.BuildApiCall<CreateCompanyRequest, Company>("CreateCompany", grpcClient.CreateCompanyAsync, grpcClient.CreateCompany, effectiveSettings.CreateCompanySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCompany);
            Modify_CreateCompanyApiCall(ref _callCreateCompany);
            _callGetCompany = clientHelper.BuildApiCall<GetCompanyRequest, Company>("GetCompany", grpcClient.GetCompanyAsync, grpcClient.GetCompany, effectiveSettings.GetCompanySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCompany);
            Modify_GetCompanyApiCall(ref _callGetCompany);
            _callUpdateCompany = clientHelper.BuildApiCall<UpdateCompanyRequest, Company>("UpdateCompany", grpcClient.UpdateCompanyAsync, grpcClient.UpdateCompany, effectiveSettings.UpdateCompanySettings).WithGoogleRequestParam("company.name", request => request.Company?.Name);
            Modify_ApiCall(ref _callUpdateCompany);
            Modify_UpdateCompanyApiCall(ref _callUpdateCompany);
            _callDeleteCompany = clientHelper.BuildApiCall<DeleteCompanyRequest, wkt::Empty>("DeleteCompany", grpcClient.DeleteCompanyAsync, grpcClient.DeleteCompany, effectiveSettings.DeleteCompanySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCompany);
            Modify_DeleteCompanyApiCall(ref _callDeleteCompany);
            _callListCompanies = clientHelper.BuildApiCall<ListCompaniesRequest, ListCompaniesResponse>("ListCompanies", grpcClient.ListCompaniesAsync, grpcClient.ListCompanies, effectiveSettings.ListCompaniesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCompanies);
            Modify_ListCompaniesApiCall(ref _callListCompanies);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateCompanyApiCall(ref gaxgrpc::ApiCall<CreateCompanyRequest, Company> call);

        partial void Modify_GetCompanyApiCall(ref gaxgrpc::ApiCall<GetCompanyRequest, Company> call);

        partial void Modify_UpdateCompanyApiCall(ref gaxgrpc::ApiCall<UpdateCompanyRequest, Company> call);

        partial void Modify_DeleteCompanyApiCall(ref gaxgrpc::ApiCall<DeleteCompanyRequest, wkt::Empty> call);

        partial void Modify_ListCompaniesApiCall(ref gaxgrpc::ApiCall<ListCompaniesRequest, ListCompaniesResponse> call);

        partial void OnConstruction(CompanyService.CompanyServiceClient grpcClient, CompanyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CompanyService client</summary>
        public override CompanyService.CompanyServiceClient GrpcClient { get; }

        partial void Modify_CreateCompanyRequest(ref CreateCompanyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCompanyRequest(ref GetCompanyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCompanyRequest(ref UpdateCompanyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCompanyRequest(ref DeleteCompanyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCompaniesRequest(ref ListCompaniesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Company CreateCompany(CreateCompanyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCompanyRequest(ref request, ref callSettings);
            return _callCreateCompany.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Company> CreateCompanyAsync(CreateCompanyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCompanyRequest(ref request, ref callSettings);
            return _callCreateCompany.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Company GetCompany(GetCompanyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCompanyRequest(ref request, ref callSettings);
            return _callGetCompany.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Company> GetCompanyAsync(GetCompanyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCompanyRequest(ref request, ref callSettings);
            return _callGetCompany.Async(request, callSettings);
        }

        /// <summary>
        /// Updates specified company.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Company UpdateCompany(UpdateCompanyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCompanyRequest(ref request, ref callSettings);
            return _callUpdateCompany.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates specified company.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Company> UpdateCompanyAsync(UpdateCompanyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCompanyRequest(ref request, ref callSettings);
            return _callUpdateCompany.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteCompany(DeleteCompanyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCompanyRequest(ref request, ref callSettings);
            _callDeleteCompany.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteCompanyAsync(DeleteCompanyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCompanyRequest(ref request, ref callSettings);
            return _callDeleteCompany.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all companies associated with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Company"/> resources.</returns>
        public override gax::PagedEnumerable<ListCompaniesResponse, Company> ListCompanies(ListCompaniesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCompaniesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCompaniesRequest, ListCompaniesResponse, Company>(_callListCompanies, request, callSettings);
        }

        /// <summary>
        /// Lists all companies associated with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Company"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCompaniesResponse, Company> ListCompaniesAsync(ListCompaniesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCompaniesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCompaniesRequest, ListCompaniesResponse, Company>(_callListCompanies, request, callSettings);
        }
    }

    public partial class ListCompaniesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCompaniesResponse : gaxgrpc::IPageResponse<Company>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Company> GetEnumerator() => Companies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
