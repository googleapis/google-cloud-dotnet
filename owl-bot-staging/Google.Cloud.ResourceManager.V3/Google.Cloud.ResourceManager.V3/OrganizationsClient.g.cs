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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.ResourceManager.V3
{
    /// <summary>Settings for <see cref="OrganizationsClient"/> instances.</summary>
    public sealed partial class OrganizationsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OrganizationsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OrganizationsSettings"/>.</returns>
        public static OrganizationsSettings GetDefault() => new OrganizationsSettings();

        /// <summary>Constructs a new <see cref="OrganizationsSettings"/> object with default settings.</summary>
        public OrganizationsSettings()
        {
        }

        private OrganizationsSettings(OrganizationsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetOrganizationSettings = existing.GetOrganizationSettings;
            SearchOrganizationsSettings = existing.SearchOrganizationsSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(OrganizationsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationsClient.GetOrganization</c> and <c>OrganizationsClient.GetOrganizationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetOrganizationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationsClient.SearchOrganizations</c> and <c>OrganizationsClient.SearchOrganizationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchOrganizationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationsClient.GetIamPolicy</c> and <c>OrganizationsClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationsClient.SetIamPolicy</c> and <c>OrganizationsClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationsClient.TestIamPermissions</c> and <c>OrganizationsClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OrganizationsSettings"/> object.</returns>
        public OrganizationsSettings Clone() => new OrganizationsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OrganizationsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class OrganizationsClientBuilder : gaxgrpc::ClientBuilderBase<OrganizationsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OrganizationsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OrganizationsClientBuilder() : base(OrganizationsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref OrganizationsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OrganizationsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OrganizationsClient Build()
        {
            OrganizationsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OrganizationsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OrganizationsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OrganizationsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OrganizationsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<OrganizationsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OrganizationsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OrganizationsClient.ChannelPool;
    }

    /// <summary>Organizations client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Allows users to manage their organization resources.
    /// </remarks>
    public abstract partial class OrganizationsClient
    {
        /// <summary>
        /// The default endpoint for the Organizations service, which is a host of "cloudresourcemanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudresourcemanager.googleapis.com:443";

        /// <summary>The default Organizations scopes.</summary>
        /// <remarks>
        /// The default Organizations scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Organizations.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="OrganizationsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="OrganizationsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OrganizationsClient"/>.</returns>
        public static stt::Task<OrganizationsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OrganizationsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OrganizationsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="OrganizationsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OrganizationsClient"/>.</returns>
        public static OrganizationsClient Create() => new OrganizationsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OrganizationsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OrganizationsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="OrganizationsClient"/>.</returns>
        internal static OrganizationsClient Create(grpccore::CallInvoker callInvoker, OrganizationsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Organizations.OrganizationsClient grpcClient = new Organizations.OrganizationsClient(callInvoker);
            return new OrganizationsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Organizations client</summary>
        public virtual Organizations.OrganizationsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches an organization resource identified by the specified resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Organization GetOrganization(GetOrganizationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches an organization resource identified by the specified resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(GetOrganizationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches an organization resource identified by the specified resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(GetOrganizationRequest request, st::CancellationToken cancellationToken) =>
            GetOrganizationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches an organization resource identified by the specified resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Organization to fetch. This is the
        /// organization's relative path in the API, formatted as
        /// "organizations/[organizationId]". For example, "organizations/1234".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Organization GetOrganization(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganization(new GetOrganizationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches an organization resource identified by the specified resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Organization to fetch. This is the
        /// organization's relative path in the API, formatted as
        /// "organizations/[organizationId]". For example, "organizations/1234".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationAsync(new GetOrganizationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches an organization resource identified by the specified resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Organization to fetch. This is the
        /// organization's relative path in the API, formatted as
        /// "organizations/[organizationId]". For example, "organizations/1234".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(string name, st::CancellationToken cancellationToken) =>
            GetOrganizationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches an organization resource identified by the specified resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Organization to fetch. This is the
        /// organization's relative path in the API, formatted as
        /// "organizations/[organizationId]". For example, "organizations/1234".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Organization GetOrganization(gagr::OrganizationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganization(new GetOrganizationRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches an organization resource identified by the specified resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Organization to fetch. This is the
        /// organization's relative path in the API, formatted as
        /// "organizations/[organizationId]". For example, "organizations/1234".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(gagr::OrganizationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationAsync(new GetOrganizationRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches an organization resource identified by the specified resource name.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Organization to fetch. This is the
        /// organization's relative path in the API, formatted as
        /// "organizations/[organizationId]". For example, "organizations/1234".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(gagr::OrganizationName name, st::CancellationToken cancellationToken) =>
            GetOrganizationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches organization resources that are visible to the user and satisfy
        /// the specified filter. This method returns organizations in an unspecified
        /// order. New organizations do not necessarily appear at the end of the
        /// results, and may take a small amount of time to appear.
        /// 
        /// Search will only return organizations on which the user has the permission
        /// `resourcemanager.organizations.get`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Organization"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchOrganizationsResponse, Organization> SearchOrganizations(SearchOrganizationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches organization resources that are visible to the user and satisfy
        /// the specified filter. This method returns organizations in an unspecified
        /// order. New organizations do not necessarily appear at the end of the
        /// results, and may take a small amount of time to appear.
        /// 
        /// Search will only return organizations on which the user has the permission
        /// `resourcemanager.organizations.get`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Organization"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchOrganizationsResponse, Organization> SearchOrganizationsAsync(SearchOrganizationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches organization resources that are visible to the user and satisfy
        /// the specified filter. This method returns organizations in an unspecified
        /// order. New organizations do not necessarily appear at the end of the
        /// results, and may take a small amount of time to appear.
        /// 
        /// Search will only return organizations on which the user has the permission
        /// `resourcemanager.organizations.get`
        /// </summary>
        /// <param name="query">
        /// Optional. An optional query string used to filter the Organizations to
        /// return in the response. Query rules are case-insensitive.
        /// 
        /// 
        /// ```
        /// | Field            | Description                                |
        /// |------------------|--------------------------------------------|
        /// | directoryCustomerId, owner.directoryCustomerId | Filters by directory
        /// customer id. |
        /// | domain           | Filters by domain.                         |
        /// ```
        /// 
        /// Organizations may be queried by `directoryCustomerId` or by
        /// `domain`, where the domain is a G Suite domain, for example:
        /// 
        /// * Query `directorycustomerid:123456789` returns Organization
        /// resources with `owner.directory_customer_id` equal to `123456789`.
        /// * Query `domain:google.com` returns Organization resources corresponding
        /// to the domain `google.com`.
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
        /// <returns>A pageable sequence of <see cref="Organization"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchOrganizationsResponse, Organization> SearchOrganizations(string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchOrganizationsRequest request = new SearchOrganizationsRequest { Query = query ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchOrganizations(request, callSettings);
        }

        /// <summary>
        /// Searches organization resources that are visible to the user and satisfy
        /// the specified filter. This method returns organizations in an unspecified
        /// order. New organizations do not necessarily appear at the end of the
        /// results, and may take a small amount of time to appear.
        /// 
        /// Search will only return organizations on which the user has the permission
        /// `resourcemanager.organizations.get`
        /// </summary>
        /// <param name="query">
        /// Optional. An optional query string used to filter the Organizations to
        /// return in the response. Query rules are case-insensitive.
        /// 
        /// 
        /// ```
        /// | Field            | Description                                |
        /// |------------------|--------------------------------------------|
        /// | directoryCustomerId, owner.directoryCustomerId | Filters by directory
        /// customer id. |
        /// | domain           | Filters by domain.                         |
        /// ```
        /// 
        /// Organizations may be queried by `directoryCustomerId` or by
        /// `domain`, where the domain is a G Suite domain, for example:
        /// 
        /// * Query `directorycustomerid:123456789` returns Organization
        /// resources with `owner.directory_customer_id` equal to `123456789`.
        /// * Query `domain:google.com` returns Organization resources corresponding
        /// to the domain `google.com`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Organization"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchOrganizationsResponse, Organization> SearchOrganizationsAsync(string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchOrganizationsRequest request = new SearchOrganizationsRequest { Query = query ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchOrganizationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for an organization resource. The policy may
        /// be empty if no such policy or resource exists. The `resource` field should
        /// be the organization's resource name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.getIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for an organization resource. The policy may
        /// be empty if no such policy or resource exists. The `resource` field should
        /// be the organization's resource name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.getIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for an organization resource. The policy may
        /// be empty if no such policy or resource exists. The `resource` field should
        /// be the organization's resource name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.getIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for an organization resource. The policy may
        /// be empty if no such policy or resource exists. The `resource` field should
        /// be the organization's resource name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.getIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for an organization resource. The policy may
        /// be empty if no such policy or resource exists. The `resource` field should
        /// be the organization's resource name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.getIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for an organization resource. The policy may
        /// be empty if no such policy or resource exists. The `resource` field should
        /// be the organization's resource name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.getIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for an organization resource. The policy may
        /// be empty if no such policy or resource exists. The `resource` field should
        /// be the organization's resource name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.getIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for an organization resource. The policy may
        /// be empty if no such policy or resource exists. The `resource` field should
        /// be the organization's resource name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.getIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for an organization resource. The policy may
        /// be empty if no such policy or resource exists. The `resource` field should
        /// be the organization's resource name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.getIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on an organization resource. Replaces any
        /// existing policy. The `resource` field should be the organization's resource
        /// name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.setIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on an organization resource. Replaces any
        /// existing policy. The `resource` field should be the organization's resource
        /// name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.setIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on an organization resource. Replaces any
        /// existing policy. The `resource` field should be the organization's resource
        /// name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.setIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on an organization resource. Replaces any
        /// existing policy. The `resource` field should be the organization's resource
        /// name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.setIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on an organization resource. Replaces any
        /// existing policy. The `resource` field should be the organization's resource
        /// name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.setIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on an organization resource. Replaces any
        /// existing policy. The `resource` field should be the organization's resource
        /// name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.setIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on an organization resource. Replaces any
        /// existing policy. The `resource` field should be the organization's resource
        /// name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.setIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on an organization resource. Replaces any
        /// existing policy. The `resource` field should be the organization's resource
        /// name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.setIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on an organization resource. Replaces any
        /// existing policy. The `resource` field should be the organization's resource
        /// name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.setIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the permissions that a caller has on the specified organization.
        /// The `resource` field should be the organization's resource name,
        /// for example: "organizations/123".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the permissions that a caller has on the specified organization.
        /// The `resource` field should be the organization's resource name,
        /// for example: "organizations/123".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the permissions that a caller has on the specified organization.
        /// The `resource` field should be the organization's resource name,
        /// for example: "organizations/123".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the permissions that a caller has on the specified organization.
        /// The `resource` field should be the organization's resource name,
        /// for example: "organizations/123".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified organization.
        /// The `resource` field should be the organization's resource name,
        /// for example: "organizations/123".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified organization.
        /// The `resource` field should be the organization's resource name,
        /// for example: "organizations/123".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the permissions that a caller has on the specified organization.
        /// The `resource` field should be the organization's resource name,
        /// for example: "organizations/123".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified organization.
        /// The `resource` field should be the organization's resource name,
        /// for example: "organizations/123".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified organization.
        /// The `resource` field should be the organization's resource name,
        /// for example: "organizations/123".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Organizations client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Allows users to manage their organization resources.
    /// </remarks>
    public sealed partial class OrganizationsClientImpl : OrganizationsClient
    {
        private readonly gaxgrpc::ApiCall<GetOrganizationRequest, Organization> _callGetOrganization;

        private readonly gaxgrpc::ApiCall<SearchOrganizationsRequest, SearchOrganizationsResponse> _callSearchOrganizations;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the Organizations service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="OrganizationsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public OrganizationsClientImpl(Organizations.OrganizationsClient grpcClient, OrganizationsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OrganizationsSettings effectiveSettings = settings ?? OrganizationsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetOrganization = clientHelper.BuildApiCall<GetOrganizationRequest, Organization>("GetOrganization", grpcClient.GetOrganizationAsync, grpcClient.GetOrganization, effectiveSettings.GetOrganizationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOrganization);
            Modify_GetOrganizationApiCall(ref _callGetOrganization);
            _callSearchOrganizations = clientHelper.BuildApiCall<SearchOrganizationsRequest, SearchOrganizationsResponse>("SearchOrganizations", grpcClient.SearchOrganizationsAsync, grpcClient.SearchOrganizations, effectiveSettings.SearchOrganizationsSettings);
            Modify_ApiCall(ref _callSearchOrganizations);
            Modify_SearchOrganizationsApiCall(ref _callSearchOrganizations);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetOrganizationApiCall(ref gaxgrpc::ApiCall<GetOrganizationRequest, Organization> call);

        partial void Modify_SearchOrganizationsApiCall(ref gaxgrpc::ApiCall<SearchOrganizationsRequest, SearchOrganizationsResponse> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void OnConstruction(Organizations.OrganizationsClient grpcClient, OrganizationsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Organizations client</summary>
        public override Organizations.OrganizationsClient GrpcClient { get; }

        partial void Modify_GetOrganizationRequest(ref GetOrganizationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchOrganizationsRequest(ref SearchOrganizationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Fetches an organization resource identified by the specified resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Organization GetOrganization(GetOrganizationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrganizationRequest(ref request, ref callSettings);
            return _callGetOrganization.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches an organization resource identified by the specified resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Organization> GetOrganizationAsync(GetOrganizationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrganizationRequest(ref request, ref callSettings);
            return _callGetOrganization.Async(request, callSettings);
        }

        /// <summary>
        /// Searches organization resources that are visible to the user and satisfy
        /// the specified filter. This method returns organizations in an unspecified
        /// order. New organizations do not necessarily appear at the end of the
        /// results, and may take a small amount of time to appear.
        /// 
        /// Search will only return organizations on which the user has the permission
        /// `resourcemanager.organizations.get`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Organization"/> resources.</returns>
        public override gax::PagedEnumerable<SearchOrganizationsResponse, Organization> SearchOrganizations(SearchOrganizationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchOrganizationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchOrganizationsRequest, SearchOrganizationsResponse, Organization>(_callSearchOrganizations, request, callSettings);
        }

        /// <summary>
        /// Searches organization resources that are visible to the user and satisfy
        /// the specified filter. This method returns organizations in an unspecified
        /// order. New organizations do not necessarily appear at the end of the
        /// results, and may take a small amount of time to appear.
        /// 
        /// Search will only return organizations on which the user has the permission
        /// `resourcemanager.organizations.get`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Organization"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchOrganizationsResponse, Organization> SearchOrganizationsAsync(SearchOrganizationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchOrganizationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchOrganizationsRequest, SearchOrganizationsResponse, Organization>(_callSearchOrganizations, request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for an organization resource. The policy may
        /// be empty if no such policy or resource exists. The `resource` field should
        /// be the organization's resource name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.getIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for an organization resource. The policy may
        /// be empty if no such policy or resource exists. The `resource` field should
        /// be the organization's resource name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.getIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on an organization resource. Replaces any
        /// existing policy. The `resource` field should be the organization's resource
        /// name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.setIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on an organization resource. Replaces any
        /// existing policy. The `resource` field should be the organization's resource
        /// name, for example: "organizations/123".
        /// 
        /// Authorization requires the IAM permission
        /// `resourcemanager.organizations.setIamPolicy` on the specified organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the permissions that a caller has on the specified organization.
        /// The `resource` field should be the organization's resource name,
        /// for example: "organizations/123".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the permissions that a caller has on the specified organization.
        /// The `resource` field should be the organization's resource name,
        /// for example: "organizations/123".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }

    public partial class SearchOrganizationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchOrganizationsResponse : gaxgrpc::IPageResponse<Organization>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Organization> GetEnumerator() => Organizations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
