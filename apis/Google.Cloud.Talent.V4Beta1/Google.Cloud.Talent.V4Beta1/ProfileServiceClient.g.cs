// Copyright 2022 Google LLC
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
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Talent.V4Beta1
{
    /// <summary>Settings for <see cref="ProfileServiceClient"/> instances.</summary>
    public sealed partial class ProfileServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProfileServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProfileServiceSettings"/>.</returns>
        public static ProfileServiceSettings GetDefault() => new ProfileServiceSettings();

        /// <summary>Constructs a new <see cref="ProfileServiceSettings"/> object with default settings.</summary>
        public ProfileServiceSettings()
        {
        }

        private ProfileServiceSettings(ProfileServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListProfilesSettings = existing.ListProfilesSettings;
            CreateProfileSettings = existing.CreateProfileSettings;
            GetProfileSettings = existing.GetProfileSettings;
            UpdateProfileSettings = existing.UpdateProfileSettings;
            DeleteProfileSettings = existing.DeleteProfileSettings;
            SearchProfilesSettings = existing.SearchProfilesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProfileServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProfileServiceClient.ListProfiles</c> and <c>ProfileServiceClient.ListProfilesAsync</c>.
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
        public gaxgrpc::CallSettings ListProfilesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProfileServiceClient.CreateProfile</c> and <c>ProfileServiceClient.CreateProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProfileServiceClient.GetProfile</c> and <c>ProfileServiceClient.GetProfileAsync</c>.
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
        public gaxgrpc::CallSettings GetProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProfileServiceClient.UpdateProfile</c> and <c>ProfileServiceClient.UpdateProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProfileServiceClient.DeleteProfile</c> and <c>ProfileServiceClient.DeleteProfileAsync</c>.
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
        public gaxgrpc::CallSettings DeleteProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProfileServiceClient.SearchProfiles</c> and <c>ProfileServiceClient.SearchProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchProfilesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProfileServiceSettings"/> object.</returns>
        public ProfileServiceSettings Clone() => new ProfileServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProfileServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ProfileServiceClientBuilder : gaxgrpc::ClientBuilderBase<ProfileServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProfileServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProfileServiceClientBuilder() : base(ProfileServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProfileServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProfileServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProfileServiceClient Build()
        {
            ProfileServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProfileServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProfileServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProfileServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProfileServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<ProfileServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProfileServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProfileServiceClient.ChannelPool;
    }

    /// <summary>ProfileService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service that handles profile management, including profile CRUD,
    /// enumeration and search.
    /// </remarks>
    public abstract partial class ProfileServiceClient
    {
        /// <summary>
        /// The default endpoint for the ProfileService service, which is a host of "jobs.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "jobs.googleapis.com:443";

        /// <summary>The default ProfileService scopes.</summary>
        /// <remarks>
        /// The default ProfileService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ProfileService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProfileServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProfileServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProfileServiceClient"/>.</returns>
        public static stt::Task<ProfileServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProfileServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProfileServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProfileServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProfileServiceClient"/>.</returns>
        public static ProfileServiceClient Create() => new ProfileServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProfileServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProfileServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProfileServiceClient"/>.</returns>
        internal static ProfileServiceClient Create(grpccore::CallInvoker callInvoker, ProfileServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProfileService.ProfileServiceClient grpcClient = new ProfileService.ProfileServiceClient(callInvoker);
            return new ProfileServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ProfileService client</summary>
        public virtual ProfileService.ProfileServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists profiles by filter. The order is unspecified.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Profile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProfilesResponse, Profile> ListProfiles(ListProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists profiles by filter. The order is unspecified.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Profile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProfilesResponse, Profile> ListProfilesAsync(ListProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists profiles by filter. The order is unspecified.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the profile is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
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
        /// <returns>A pageable sequence of <see cref="Profile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProfilesResponse, Profile> ListProfiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListProfiles(new ListProfilesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists profiles by filter. The order is unspecified.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the profile is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
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
        /// <returns>A pageable asynchronous sequence of <see cref="Profile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProfilesResponse, Profile> ListProfilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListProfilesAsync(new ListProfilesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists profiles by filter. The order is unspecified.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the profile is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
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
        /// <returns>A pageable sequence of <see cref="Profile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProfilesResponse, Profile> ListProfiles(TenantName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListProfiles(new ListProfilesRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists profiles by filter. The order is unspecified.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the profile is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
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
        /// <returns>A pageable asynchronous sequence of <see cref="Profile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProfilesResponse, Profile> ListProfilesAsync(TenantName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListProfilesAsync(new ListProfilesRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile CreateProfile(CreateProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> CreateProfileAsync(CreateProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> CreateProfileAsync(CreateProfileRequest request, st::CancellationToken cancellationToken) =>
            CreateProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the tenant this profile belongs to.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="profile">
        /// Required. The profile to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile CreateProfile(string parent, Profile profile, gaxgrpc::CallSettings callSettings = null) =>
            CreateProfile(new CreateProfileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Profile = gax::GaxPreconditions.CheckNotNull(profile, nameof(profile)),
            }, callSettings);

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the tenant this profile belongs to.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="profile">
        /// Required. The profile to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> CreateProfileAsync(string parent, Profile profile, gaxgrpc::CallSettings callSettings = null) =>
            CreateProfileAsync(new CreateProfileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Profile = gax::GaxPreconditions.CheckNotNull(profile, nameof(profile)),
            }, callSettings);

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the tenant this profile belongs to.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="profile">
        /// Required. The profile to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> CreateProfileAsync(string parent, Profile profile, st::CancellationToken cancellationToken) =>
            CreateProfileAsync(parent, profile, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the tenant this profile belongs to.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="profile">
        /// Required. The profile to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile CreateProfile(TenantName parent, Profile profile, gaxgrpc::CallSettings callSettings = null) =>
            CreateProfile(new CreateProfileRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Profile = gax::GaxPreconditions.CheckNotNull(profile, nameof(profile)),
            }, callSettings);

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the tenant this profile belongs to.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="profile">
        /// Required. The profile to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> CreateProfileAsync(TenantName parent, Profile profile, gaxgrpc::CallSettings callSettings = null) =>
            CreateProfileAsync(new CreateProfileRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Profile = gax::GaxPreconditions.CheckNotNull(profile, nameof(profile)),
            }, callSettings);

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the tenant this profile belongs to.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="profile">
        /// Required. The profile to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> CreateProfileAsync(TenantName parent, Profile profile, st::CancellationToken cancellationToken) =>
            CreateProfileAsync(parent, profile, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile GetProfile(GetProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> GetProfileAsync(GetProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> GetProfileAsync(GetProfileRequest request, st::CancellationToken cancellationToken) =>
            GetProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the profile to get.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}". For
        /// example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile GetProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProfile(new GetProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the profile to get.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}". For
        /// example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> GetProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProfileAsync(new GetProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the profile to get.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}". For
        /// example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> GetProfileAsync(string name, st::CancellationToken cancellationToken) =>
            GetProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the profile to get.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}". For
        /// example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile GetProfile(ProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProfile(new GetProfileRequest
            {
                ProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the profile to get.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}". For
        /// example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> GetProfileAsync(ProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProfileAsync(new GetProfileRequest
            {
                ProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the profile to get.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}". For
        /// example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> GetProfileAsync(ProfileName name, st::CancellationToken cancellationToken) =>
            GetProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified profile and returns the updated result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile UpdateProfile(UpdateProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified profile and returns the updated result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> UpdateProfileAsync(UpdateProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified profile and returns the updated result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> UpdateProfileAsync(UpdateProfileRequest request, st::CancellationToken cancellationToken) =>
            UpdateProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified profile and returns the updated result.
        /// </summary>
        /// <param name="profile">
        /// Required. Profile to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile UpdateProfile(Profile profile, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProfile(new UpdateProfileRequest
            {
                Profile = gax::GaxPreconditions.CheckNotNull(profile, nameof(profile)),
            }, callSettings);

        /// <summary>
        /// Updates the specified profile and returns the updated result.
        /// </summary>
        /// <param name="profile">
        /// Required. Profile to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> UpdateProfileAsync(Profile profile, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProfileAsync(new UpdateProfileRequest
            {
                Profile = gax::GaxPreconditions.CheckNotNull(profile, nameof(profile)),
            }, callSettings);

        /// <summary>
        /// Updates the specified profile and returns the updated result.
        /// </summary>
        /// <param name="profile">
        /// Required. Profile to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> UpdateProfileAsync(Profile profile, st::CancellationToken cancellationToken) =>
            UpdateProfileAsync(profile, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProfile(DeleteProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProfileAsync(DeleteProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProfileAsync(DeleteProfileRequest request, st::CancellationToken cancellationToken) =>
            DeleteProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the profile to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}". For
        /// example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProfile(new DeleteProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the profile to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}". For
        /// example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProfileAsync(new DeleteProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the profile to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}". For
        /// example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProfileAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the profile to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}". For
        /// example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProfile(ProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProfile(new DeleteProfileRequest
            {
                ProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the profile to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}". For
        /// example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProfileAsync(ProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProfileAsync(new DeleteProfileRequest
            {
                ProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the profile to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}". For
        /// example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProfileAsync(ProfileName name, st::CancellationToken cancellationToken) =>
            DeleteProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches for profiles within a tenant.
        /// 
        /// For example, search by raw queries "software engineer in Mountain View" or
        /// search by structured filters (location filter, education filter, etc.).
        /// 
        /// See [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest] for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchProfilesResponse SearchProfiles(SearchProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for profiles within a tenant.
        /// 
        /// For example, search by raw queries "software engineer in Mountain View" or
        /// search by structured filters (location filter, education filter, etc.).
        /// 
        /// See [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest] for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchProfilesResponse> SearchProfilesAsync(SearchProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for profiles within a tenant.
        /// 
        /// For example, search by raw queries "software engineer in Mountain View" or
        /// search by structured filters (location filter, education filter, etc.).
        /// 
        /// See [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest] for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchProfilesResponse> SearchProfilesAsync(SearchProfilesRequest request, st::CancellationToken cancellationToken) =>
            SearchProfilesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ProfileService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service that handles profile management, including profile CRUD,
    /// enumeration and search.
    /// </remarks>
    public sealed partial class ProfileServiceClientImpl : ProfileServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListProfilesRequest, ListProfilesResponse> _callListProfiles;

        private readonly gaxgrpc::ApiCall<CreateProfileRequest, Profile> _callCreateProfile;

        private readonly gaxgrpc::ApiCall<GetProfileRequest, Profile> _callGetProfile;

        private readonly gaxgrpc::ApiCall<UpdateProfileRequest, Profile> _callUpdateProfile;

        private readonly gaxgrpc::ApiCall<DeleteProfileRequest, wkt::Empty> _callDeleteProfile;

        private readonly gaxgrpc::ApiCall<SearchProfilesRequest, SearchProfilesResponse> _callSearchProfiles;

        /// <summary>
        /// Constructs a client wrapper for the ProfileService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProfileServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProfileServiceClientImpl(ProfileService.ProfileServiceClient grpcClient, ProfileServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProfileServiceSettings effectiveSettings = settings ?? ProfileServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callListProfiles = clientHelper.BuildApiCall<ListProfilesRequest, ListProfilesResponse>("ListProfiles", grpcClient.ListProfilesAsync, grpcClient.ListProfiles, effectiveSettings.ListProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProfiles);
            Modify_ListProfilesApiCall(ref _callListProfiles);
            _callCreateProfile = clientHelper.BuildApiCall<CreateProfileRequest, Profile>("CreateProfile", grpcClient.CreateProfileAsync, grpcClient.CreateProfile, effectiveSettings.CreateProfileSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateProfile);
            Modify_CreateProfileApiCall(ref _callCreateProfile);
            _callGetProfile = clientHelper.BuildApiCall<GetProfileRequest, Profile>("GetProfile", grpcClient.GetProfileAsync, grpcClient.GetProfile, effectiveSettings.GetProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProfile);
            Modify_GetProfileApiCall(ref _callGetProfile);
            _callUpdateProfile = clientHelper.BuildApiCall<UpdateProfileRequest, Profile>("UpdateProfile", grpcClient.UpdateProfileAsync, grpcClient.UpdateProfile, effectiveSettings.UpdateProfileSettings).WithGoogleRequestParam("profile.name", request => request.Profile?.Name);
            Modify_ApiCall(ref _callUpdateProfile);
            Modify_UpdateProfileApiCall(ref _callUpdateProfile);
            _callDeleteProfile = clientHelper.BuildApiCall<DeleteProfileRequest, wkt::Empty>("DeleteProfile", grpcClient.DeleteProfileAsync, grpcClient.DeleteProfile, effectiveSettings.DeleteProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteProfile);
            Modify_DeleteProfileApiCall(ref _callDeleteProfile);
            _callSearchProfiles = clientHelper.BuildApiCall<SearchProfilesRequest, SearchProfilesResponse>("SearchProfiles", grpcClient.SearchProfilesAsync, grpcClient.SearchProfiles, effectiveSettings.SearchProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchProfiles);
            Modify_SearchProfilesApiCall(ref _callSearchProfiles);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListProfilesApiCall(ref gaxgrpc::ApiCall<ListProfilesRequest, ListProfilesResponse> call);

        partial void Modify_CreateProfileApiCall(ref gaxgrpc::ApiCall<CreateProfileRequest, Profile> call);

        partial void Modify_GetProfileApiCall(ref gaxgrpc::ApiCall<GetProfileRequest, Profile> call);

        partial void Modify_UpdateProfileApiCall(ref gaxgrpc::ApiCall<UpdateProfileRequest, Profile> call);

        partial void Modify_DeleteProfileApiCall(ref gaxgrpc::ApiCall<DeleteProfileRequest, wkt::Empty> call);

        partial void Modify_SearchProfilesApiCall(ref gaxgrpc::ApiCall<SearchProfilesRequest, SearchProfilesResponse> call);

        partial void OnConstruction(ProfileService.ProfileServiceClient grpcClient, ProfileServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProfileService client</summary>
        public override ProfileService.ProfileServiceClient GrpcClient { get; }

        partial void Modify_ListProfilesRequest(ref ListProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateProfileRequest(ref CreateProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProfileRequest(ref GetProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProfileRequest(ref UpdateProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteProfileRequest(ref DeleteProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchProfilesRequest(ref SearchProfilesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists profiles by filter. The order is unspecified.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Profile"/> resources.</returns>
        public override gax::PagedEnumerable<ListProfilesResponse, Profile> ListProfiles(ListProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProfilesRequest, ListProfilesResponse, Profile>(_callListProfiles, request, callSettings);
        }

        /// <summary>
        /// Lists profiles by filter. The order is unspecified.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Profile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProfilesResponse, Profile> ListProfilesAsync(ListProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProfilesRequest, ListProfilesResponse, Profile>(_callListProfiles, request, callSettings);
        }

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Profile CreateProfile(CreateProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProfileRequest(ref request, ref callSettings);
            return _callCreateProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Profile> CreateProfileAsync(CreateProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProfileRequest(ref request, ref callSettings);
            return _callCreateProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Profile GetProfile(GetProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProfileRequest(ref request, ref callSettings);
            return _callGetProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Profile> GetProfileAsync(GetProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProfileRequest(ref request, ref callSettings);
            return _callGetProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified profile and returns the updated result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Profile UpdateProfile(UpdateProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProfileRequest(ref request, ref callSettings);
            return _callUpdateProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified profile and returns the updated result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Profile> UpdateProfileAsync(UpdateProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProfileRequest(ref request, ref callSettings);
            return _callUpdateProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteProfile(DeleteProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProfileRequest(ref request, ref callSettings);
            _callDeleteProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteProfileAsync(DeleteProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProfileRequest(ref request, ref callSettings);
            return _callDeleteProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Searches for profiles within a tenant.
        /// 
        /// For example, search by raw queries "software engineer in Mountain View" or
        /// search by structured filters (location filter, education filter, etc.).
        /// 
        /// See [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest] for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchProfilesResponse SearchProfiles(SearchProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchProfilesRequest(ref request, ref callSettings);
            return _callSearchProfiles.Sync(request, callSettings);
        }

        /// <summary>
        /// Searches for profiles within a tenant.
        /// 
        /// For example, search by raw queries "software engineer in Mountain View" or
        /// search by structured filters (location filter, education filter, etc.).
        /// 
        /// See [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest] for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchProfilesResponse> SearchProfilesAsync(SearchProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchProfilesRequest(ref request, ref callSettings);
            return _callSearchProfiles.Async(request, callSettings);
        }
    }

    public partial class ListProfilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProfilesResponse : gaxgrpc::IPageResponse<Profile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Profile> GetEnumerator() => Profiles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
