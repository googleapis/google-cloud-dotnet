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

namespace Google.Ads.MarketingPlatform.Admin.V1Alpha
{
    /// <summary>Settings for <see cref="MarketingplatformAdminServiceClient"/> instances.</summary>
    public sealed partial class MarketingplatformAdminServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MarketingplatformAdminServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MarketingplatformAdminServiceSettings"/>.</returns>
        public static MarketingplatformAdminServiceSettings GetDefault() => new MarketingplatformAdminServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="MarketingplatformAdminServiceSettings"/> object with default settings.
        /// </summary>
        public MarketingplatformAdminServiceSettings()
        {
        }

        private MarketingplatformAdminServiceSettings(MarketingplatformAdminServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetOrganizationSettings = existing.GetOrganizationSettings;
            ListAnalyticsAccountLinksSettings = existing.ListAnalyticsAccountLinksSettings;
            CreateAnalyticsAccountLinkSettings = existing.CreateAnalyticsAccountLinkSettings;
            DeleteAnalyticsAccountLinkSettings = existing.DeleteAnalyticsAccountLinkSettings;
            SetPropertyServiceLevelSettings = existing.SetPropertyServiceLevelSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MarketingplatformAdminServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.GetOrganization</c> and
        /// <c>MarketingplatformAdminServiceClient.GetOrganizationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetOrganizationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.ListAnalyticsAccountLinks</c> and
        /// <c>MarketingplatformAdminServiceClient.ListAnalyticsAccountLinksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAnalyticsAccountLinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.CreateAnalyticsAccountLink</c> and
        /// <c>MarketingplatformAdminServiceClient.CreateAnalyticsAccountLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAnalyticsAccountLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.DeleteAnalyticsAccountLink</c> and
        /// <c>MarketingplatformAdminServiceClient.DeleteAnalyticsAccountLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAnalyticsAccountLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MarketingplatformAdminServiceClient.SetPropertyServiceLevel</c> and
        /// <c>MarketingplatformAdminServiceClient.SetPropertyServiceLevelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetPropertyServiceLevelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MarketingplatformAdminServiceSettings"/> object.</returns>
        public MarketingplatformAdminServiceSettings Clone() => new MarketingplatformAdminServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MarketingplatformAdminServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class MarketingplatformAdminServiceClientBuilder : gaxgrpc::ClientBuilderBase<MarketingplatformAdminServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MarketingplatformAdminServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MarketingplatformAdminServiceClientBuilder() : base(MarketingplatformAdminServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MarketingplatformAdminServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MarketingplatformAdminServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MarketingplatformAdminServiceClient Build()
        {
            MarketingplatformAdminServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MarketingplatformAdminServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MarketingplatformAdminServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MarketingplatformAdminServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MarketingplatformAdminServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MarketingplatformAdminServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MarketingplatformAdminServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MarketingplatformAdminServiceClient.ChannelPool;
    }

    /// <summary>MarketingplatformAdminService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service Interface for the Google Marketing Platform Admin API.
    /// </remarks>
    public abstract partial class MarketingplatformAdminServiceClient
    {
        /// <summary>
        /// The default endpoint for the MarketingplatformAdminService service, which is a host of
        /// "marketingplatformadmin.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "marketingplatformadmin.googleapis.com:443";

        /// <summary>The default MarketingplatformAdminService scopes.</summary>
        /// <remarks>
        /// The default MarketingplatformAdminService scopes are:
        /// <list type="bullet">
        /// <item>
        /// <description>https://www.googleapis.com/auth/marketingplatformadmin.analytics.read</description>
        /// </item>
        /// <item>
        /// <description>https://www.googleapis.com/auth/marketingplatformadmin.analytics.update</description>
        /// </item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/marketingplatformadmin.analytics.read",
            "https://www.googleapis.com/auth/marketingplatformadmin.analytics.update",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MarketingplatformAdminService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MarketingplatformAdminServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="MarketingplatformAdminServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MarketingplatformAdminServiceClient"/>.</returns>
        public static stt::Task<MarketingplatformAdminServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MarketingplatformAdminServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MarketingplatformAdminServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="MarketingplatformAdminServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MarketingplatformAdminServiceClient"/>.</returns>
        public static MarketingplatformAdminServiceClient Create() =>
            new MarketingplatformAdminServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MarketingplatformAdminServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MarketingplatformAdminServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MarketingplatformAdminServiceClient"/>.</returns>
        internal static MarketingplatformAdminServiceClient Create(grpccore::CallInvoker callInvoker, MarketingplatformAdminServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MarketingplatformAdminService.MarketingplatformAdminServiceClient grpcClient = new MarketingplatformAdminService.MarketingplatformAdminServiceClient(callInvoker);
            return new MarketingplatformAdminServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MarketingplatformAdminService client</summary>
        public virtual MarketingplatformAdminService.MarketingplatformAdminServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Organization GetOrganization(GetOrganizationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(GetOrganizationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup for a single organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(GetOrganizationRequest request, st::CancellationToken cancellationToken) =>
            GetOrganizationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Organization to retrieve.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Organization GetOrganization(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganization(new GetOrganizationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Organization to retrieve.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationAsync(new GetOrganizationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Organization to retrieve.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(string name, st::CancellationToken cancellationToken) =>
            GetOrganizationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup for a single organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Organization to retrieve.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Organization GetOrganization(OrganizationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganization(new GetOrganizationRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Organization to retrieve.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(OrganizationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationAsync(new GetOrganizationRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lookup for a single organization.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Organization to retrieve.
        /// Format: organizations/{org_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Organization> GetOrganizationAsync(OrganizationName name, st::CancellationToken cancellationToken) =>
            GetOrganizationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the Google Analytics accounts link to the specified Google Marketing
        /// Platform organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnalyticsAccountLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> ListAnalyticsAccountLinks(ListAnalyticsAccountLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Google Analytics accounts link to the specified Google Marketing
        /// Platform organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnalyticsAccountLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> ListAnalyticsAccountLinksAsync(ListAnalyticsAccountLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Google Analytics accounts link to the specified Google Marketing
        /// Platform organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this collection of Analytics
        /// account links. Format: organizations/{org_id}
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
        /// <returns>A pageable sequence of <see cref="AnalyticsAccountLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> ListAnalyticsAccountLinks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalyticsAccountLinksRequest request = new ListAnalyticsAccountLinksRequest
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
            return ListAnalyticsAccountLinks(request, callSettings);
        }

        /// <summary>
        /// Lists the Google Analytics accounts link to the specified Google Marketing
        /// Platform organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this collection of Analytics
        /// account links. Format: organizations/{org_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="AnalyticsAccountLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> ListAnalyticsAccountLinksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalyticsAccountLinksRequest request = new ListAnalyticsAccountLinksRequest
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
            return ListAnalyticsAccountLinksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the Google Analytics accounts link to the specified Google Marketing
        /// Platform organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this collection of Analytics
        /// account links. Format: organizations/{org_id}
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
        /// <returns>A pageable sequence of <see cref="AnalyticsAccountLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> ListAnalyticsAccountLinks(OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalyticsAccountLinksRequest request = new ListAnalyticsAccountLinksRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAnalyticsAccountLinks(request, callSettings);
        }

        /// <summary>
        /// Lists the Google Analytics accounts link to the specified Google Marketing
        /// Platform organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent organization, which owns this collection of Analytics
        /// account links. Format: organizations/{org_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="AnalyticsAccountLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> ListAnalyticsAccountLinksAsync(OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalyticsAccountLinksRequest request = new ListAnalyticsAccountLinksRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAnalyticsAccountLinksAsync(request, callSettings);
        }

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyticsAccountLink CreateAnalyticsAccountLink(CreateAnalyticsAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyticsAccountLink> CreateAnalyticsAccountLinkAsync(CreateAnalyticsAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyticsAccountLink> CreateAnalyticsAccountLinkAsync(CreateAnalyticsAccountLinkRequest request, st::CancellationToken cancellationToken) =>
            CreateAnalyticsAccountLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Analytics account link will be
        /// created. Format: organizations/{org_id}
        /// </param>
        /// <param name="analyticsAccountLink">
        /// Required. The Analytics account link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyticsAccountLink CreateAnalyticsAccountLink(string parent, AnalyticsAccountLink analyticsAccountLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalyticsAccountLink(new CreateAnalyticsAccountLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AnalyticsAccountLink = gax::GaxPreconditions.CheckNotNull(analyticsAccountLink, nameof(analyticsAccountLink)),
            }, callSettings);

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Analytics account link will be
        /// created. Format: organizations/{org_id}
        /// </param>
        /// <param name="analyticsAccountLink">
        /// Required. The Analytics account link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyticsAccountLink> CreateAnalyticsAccountLinkAsync(string parent, AnalyticsAccountLink analyticsAccountLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalyticsAccountLinkAsync(new CreateAnalyticsAccountLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AnalyticsAccountLink = gax::GaxPreconditions.CheckNotNull(analyticsAccountLink, nameof(analyticsAccountLink)),
            }, callSettings);

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Analytics account link will be
        /// created. Format: organizations/{org_id}
        /// </param>
        /// <param name="analyticsAccountLink">
        /// Required. The Analytics account link to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyticsAccountLink> CreateAnalyticsAccountLinkAsync(string parent, AnalyticsAccountLink analyticsAccountLink, st::CancellationToken cancellationToken) =>
            CreateAnalyticsAccountLinkAsync(parent, analyticsAccountLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Analytics account link will be
        /// created. Format: organizations/{org_id}
        /// </param>
        /// <param name="analyticsAccountLink">
        /// Required. The Analytics account link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyticsAccountLink CreateAnalyticsAccountLink(OrganizationName parent, AnalyticsAccountLink analyticsAccountLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalyticsAccountLink(new CreateAnalyticsAccountLinkRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AnalyticsAccountLink = gax::GaxPreconditions.CheckNotNull(analyticsAccountLink, nameof(analyticsAccountLink)),
            }, callSettings);

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Analytics account link will be
        /// created. Format: organizations/{org_id}
        /// </param>
        /// <param name="analyticsAccountLink">
        /// Required. The Analytics account link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyticsAccountLink> CreateAnalyticsAccountLinkAsync(OrganizationName parent, AnalyticsAccountLink analyticsAccountLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalyticsAccountLinkAsync(new CreateAnalyticsAccountLinkRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AnalyticsAccountLink = gax::GaxPreconditions.CheckNotNull(analyticsAccountLink, nameof(analyticsAccountLink)),
            }, callSettings);

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Analytics account link will be
        /// created. Format: organizations/{org_id}
        /// </param>
        /// <param name="analyticsAccountLink">
        /// Required. The Analytics account link to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyticsAccountLink> CreateAnalyticsAccountLinkAsync(OrganizationName parent, AnalyticsAccountLink analyticsAccountLink, st::CancellationToken cancellationToken) =>
            CreateAnalyticsAccountLinkAsync(parent, analyticsAccountLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnalyticsAccountLink(DeleteAnalyticsAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalyticsAccountLinkAsync(DeleteAnalyticsAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalyticsAccountLinkAsync(DeleteAnalyticsAccountLinkRequest request, st::CancellationToken cancellationToken) =>
            DeleteAnalyticsAccountLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Analytics account link to delete.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnalyticsAccountLink(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalyticsAccountLink(new DeleteAnalyticsAccountLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Analytics account link to delete.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalyticsAccountLinkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalyticsAccountLinkAsync(new DeleteAnalyticsAccountLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Analytics account link to delete.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalyticsAccountLinkAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAnalyticsAccountLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Analytics account link to delete.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnalyticsAccountLink(AnalyticsAccountLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalyticsAccountLink(new DeleteAnalyticsAccountLinkRequest
            {
                AnalyticsAccountLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Analytics account link to delete.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalyticsAccountLinkAsync(AnalyticsAccountLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalyticsAccountLinkAsync(new DeleteAnalyticsAccountLinkRequest
            {
                AnalyticsAccountLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Analytics account link to delete.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnalyticsAccountLinkAsync(AnalyticsAccountLinkName name, st::CancellationToken cancellationToken) =>
            DeleteAnalyticsAccountLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the service level for an Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SetPropertyServiceLevelResponse SetPropertyServiceLevel(SetPropertyServiceLevelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the service level for an Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SetPropertyServiceLevelResponse> SetPropertyServiceLevelAsync(SetPropertyServiceLevelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the service level for an Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SetPropertyServiceLevelResponse> SetPropertyServiceLevelAsync(SetPropertyServiceLevelRequest request, st::CancellationToken cancellationToken) =>
            SetPropertyServiceLevelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the service level for an Analytics property.
        /// </summary>
        /// <param name="analyticsAccountLink">
        /// Required. The parent AnalyticsAccountLink scope where this property is in.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SetPropertyServiceLevelResponse SetPropertyServiceLevel(string analyticsAccountLink, gaxgrpc::CallSettings callSettings = null) =>
            SetPropertyServiceLevel(new SetPropertyServiceLevelRequest
            {
                AnalyticsAccountLink = gax::GaxPreconditions.CheckNotNullOrEmpty(analyticsAccountLink, nameof(analyticsAccountLink)),
            }, callSettings);

        /// <summary>
        /// Updates the service level for an Analytics property.
        /// </summary>
        /// <param name="analyticsAccountLink">
        /// Required. The parent AnalyticsAccountLink scope where this property is in.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SetPropertyServiceLevelResponse> SetPropertyServiceLevelAsync(string analyticsAccountLink, gaxgrpc::CallSettings callSettings = null) =>
            SetPropertyServiceLevelAsync(new SetPropertyServiceLevelRequest
            {
                AnalyticsAccountLink = gax::GaxPreconditions.CheckNotNullOrEmpty(analyticsAccountLink, nameof(analyticsAccountLink)),
            }, callSettings);

        /// <summary>
        /// Updates the service level for an Analytics property.
        /// </summary>
        /// <param name="analyticsAccountLink">
        /// Required. The parent AnalyticsAccountLink scope where this property is in.
        /// Format:
        /// organizations/{org_id}/analyticsAccountLinks/{analytics_account_link_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SetPropertyServiceLevelResponse> SetPropertyServiceLevelAsync(string analyticsAccountLink, st::CancellationToken cancellationToken) =>
            SetPropertyServiceLevelAsync(analyticsAccountLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MarketingplatformAdminService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service Interface for the Google Marketing Platform Admin API.
    /// </remarks>
    public sealed partial class MarketingplatformAdminServiceClientImpl : MarketingplatformAdminServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetOrganizationRequest, Organization> _callGetOrganization;

        private readonly gaxgrpc::ApiCall<ListAnalyticsAccountLinksRequest, ListAnalyticsAccountLinksResponse> _callListAnalyticsAccountLinks;

        private readonly gaxgrpc::ApiCall<CreateAnalyticsAccountLinkRequest, AnalyticsAccountLink> _callCreateAnalyticsAccountLink;

        private readonly gaxgrpc::ApiCall<DeleteAnalyticsAccountLinkRequest, wkt::Empty> _callDeleteAnalyticsAccountLink;

        private readonly gaxgrpc::ApiCall<SetPropertyServiceLevelRequest, SetPropertyServiceLevelResponse> _callSetPropertyServiceLevel;

        /// <summary>
        /// Constructs a client wrapper for the MarketingplatformAdminService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="MarketingplatformAdminServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MarketingplatformAdminServiceClientImpl(MarketingplatformAdminService.MarketingplatformAdminServiceClient grpcClient, MarketingplatformAdminServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MarketingplatformAdminServiceSettings effectiveSettings = settings ?? MarketingplatformAdminServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetOrganization = clientHelper.BuildApiCall<GetOrganizationRequest, Organization>("GetOrganization", grpcClient.GetOrganizationAsync, grpcClient.GetOrganization, effectiveSettings.GetOrganizationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOrganization);
            Modify_GetOrganizationApiCall(ref _callGetOrganization);
            _callListAnalyticsAccountLinks = clientHelper.BuildApiCall<ListAnalyticsAccountLinksRequest, ListAnalyticsAccountLinksResponse>("ListAnalyticsAccountLinks", grpcClient.ListAnalyticsAccountLinksAsync, grpcClient.ListAnalyticsAccountLinks, effectiveSettings.ListAnalyticsAccountLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAnalyticsAccountLinks);
            Modify_ListAnalyticsAccountLinksApiCall(ref _callListAnalyticsAccountLinks);
            _callCreateAnalyticsAccountLink = clientHelper.BuildApiCall<CreateAnalyticsAccountLinkRequest, AnalyticsAccountLink>("CreateAnalyticsAccountLink", grpcClient.CreateAnalyticsAccountLinkAsync, grpcClient.CreateAnalyticsAccountLink, effectiveSettings.CreateAnalyticsAccountLinkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAnalyticsAccountLink);
            Modify_CreateAnalyticsAccountLinkApiCall(ref _callCreateAnalyticsAccountLink);
            _callDeleteAnalyticsAccountLink = clientHelper.BuildApiCall<DeleteAnalyticsAccountLinkRequest, wkt::Empty>("DeleteAnalyticsAccountLink", grpcClient.DeleteAnalyticsAccountLinkAsync, grpcClient.DeleteAnalyticsAccountLink, effectiveSettings.DeleteAnalyticsAccountLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAnalyticsAccountLink);
            Modify_DeleteAnalyticsAccountLinkApiCall(ref _callDeleteAnalyticsAccountLink);
            _callSetPropertyServiceLevel = clientHelper.BuildApiCall<SetPropertyServiceLevelRequest, SetPropertyServiceLevelResponse>("SetPropertyServiceLevel", grpcClient.SetPropertyServiceLevelAsync, grpcClient.SetPropertyServiceLevel, effectiveSettings.SetPropertyServiceLevelSettings).WithGoogleRequestParam("analytics_account_link", request => request.AnalyticsAccountLink);
            Modify_ApiCall(ref _callSetPropertyServiceLevel);
            Modify_SetPropertyServiceLevelApiCall(ref _callSetPropertyServiceLevel);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetOrganizationApiCall(ref gaxgrpc::ApiCall<GetOrganizationRequest, Organization> call);

        partial void Modify_ListAnalyticsAccountLinksApiCall(ref gaxgrpc::ApiCall<ListAnalyticsAccountLinksRequest, ListAnalyticsAccountLinksResponse> call);

        partial void Modify_CreateAnalyticsAccountLinkApiCall(ref gaxgrpc::ApiCall<CreateAnalyticsAccountLinkRequest, AnalyticsAccountLink> call);

        partial void Modify_DeleteAnalyticsAccountLinkApiCall(ref gaxgrpc::ApiCall<DeleteAnalyticsAccountLinkRequest, wkt::Empty> call);

        partial void Modify_SetPropertyServiceLevelApiCall(ref gaxgrpc::ApiCall<SetPropertyServiceLevelRequest, SetPropertyServiceLevelResponse> call);

        partial void OnConstruction(MarketingplatformAdminService.MarketingplatformAdminServiceClient grpcClient, MarketingplatformAdminServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MarketingplatformAdminService client</summary>
        public override MarketingplatformAdminService.MarketingplatformAdminServiceClient GrpcClient { get; }

        partial void Modify_GetOrganizationRequest(ref GetOrganizationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAnalyticsAccountLinksRequest(ref ListAnalyticsAccountLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAnalyticsAccountLinkRequest(ref CreateAnalyticsAccountLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAnalyticsAccountLinkRequest(ref DeleteAnalyticsAccountLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetPropertyServiceLevelRequest(ref SetPropertyServiceLevelRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lookup for a single organization.
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
        /// Lookup for a single organization.
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
        /// Lists the Google Analytics accounts link to the specified Google Marketing
        /// Platform organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnalyticsAccountLink"/> resources.</returns>
        public override gax::PagedEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> ListAnalyticsAccountLinks(ListAnalyticsAccountLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnalyticsAccountLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAnalyticsAccountLinksRequest, ListAnalyticsAccountLinksResponse, AnalyticsAccountLink>(_callListAnalyticsAccountLinks, request, callSettings);
        }

        /// <summary>
        /// Lists the Google Analytics accounts link to the specified Google Marketing
        /// Platform organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnalyticsAccountLink"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> ListAnalyticsAccountLinksAsync(ListAnalyticsAccountLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnalyticsAccountLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAnalyticsAccountLinksRequest, ListAnalyticsAccountLinksResponse, AnalyticsAccountLink>(_callListAnalyticsAccountLinks, request, callSettings);
        }

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalyticsAccountLink CreateAnalyticsAccountLink(CreateAnalyticsAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnalyticsAccountLinkRequest(ref request, ref callSettings);
            return _callCreateAnalyticsAccountLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates the link between the Analytics account and the Google Marketing
        /// Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account to create
        /// the link. If the account is already linked to an organization, user needs
        /// to unlink the account from the current organization, then try link again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnalyticsAccountLink> CreateAnalyticsAccountLinkAsync(CreateAnalyticsAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnalyticsAccountLinkRequest(ref request, ref callSettings);
            return _callCreateAnalyticsAccountLink.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAnalyticsAccountLink(DeleteAnalyticsAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnalyticsAccountLinkRequest(ref request, ref callSettings);
            _callDeleteAnalyticsAccountLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the AnalyticsAccountLink, which detaches the Analytics account from
        /// the Google Marketing Platform organization.
        /// 
        /// User needs to be an org user, and admin on the Analytics account in order
        /// to delete the link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAnalyticsAccountLinkAsync(DeleteAnalyticsAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnalyticsAccountLinkRequest(ref request, ref callSettings);
            return _callDeleteAnalyticsAccountLink.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the service level for an Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SetPropertyServiceLevelResponse SetPropertyServiceLevel(SetPropertyServiceLevelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetPropertyServiceLevelRequest(ref request, ref callSettings);
            return _callSetPropertyServiceLevel.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the service level for an Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SetPropertyServiceLevelResponse> SetPropertyServiceLevelAsync(SetPropertyServiceLevelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetPropertyServiceLevelRequest(ref request, ref callSettings);
            return _callSetPropertyServiceLevel.Async(request, callSettings);
        }
    }

    public partial class ListAnalyticsAccountLinksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAnalyticsAccountLinksResponse : gaxgrpc::IPageResponse<AnalyticsAccountLink>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AnalyticsAccountLink> GetEnumerator() => AnalyticsAccountLinks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
