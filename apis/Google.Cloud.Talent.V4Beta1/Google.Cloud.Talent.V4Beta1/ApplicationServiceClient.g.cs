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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Talent.V4Beta1
{
    /// <summary>Settings for <see cref="ApplicationServiceClient"/> instances.</summary>
    public sealed partial class ApplicationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ApplicationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ApplicationServiceSettings"/>.</returns>
        public static ApplicationServiceSettings GetDefault() => new ApplicationServiceSettings();

        /// <summary>Constructs a new <see cref="ApplicationServiceSettings"/> object with default settings.</summary>
        public ApplicationServiceSettings()
        {
        }

        private ApplicationServiceSettings(ApplicationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateApplicationSettings = existing.CreateApplicationSettings;
            GetApplicationSettings = existing.GetApplicationSettings;
            UpdateApplicationSettings = existing.UpdateApplicationSettings;
            DeleteApplicationSettings = existing.DeleteApplicationSettings;
            ListApplicationsSettings = existing.ListApplicationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ApplicationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApplicationServiceClient.CreateApplication</c> and <c>ApplicationServiceClient.CreateApplicationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApplicationServiceClient.GetApplication</c> and <c>ApplicationServiceClient.GetApplicationAsync</c>.
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
        public gaxgrpc::CallSettings GetApplicationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApplicationServiceClient.UpdateApplication</c> and <c>ApplicationServiceClient.UpdateApplicationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApplicationServiceClient.DeleteApplication</c> and <c>ApplicationServiceClient.DeleteApplicationAsync</c>
        /// .
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
        public gaxgrpc::CallSettings DeleteApplicationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApplicationServiceClient.ListApplications</c> and <c>ApplicationServiceClient.ListApplicationsAsync</c>.
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
        public gaxgrpc::CallSettings ListApplicationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ApplicationServiceSettings"/> object.</returns>
        public ApplicationServiceSettings Clone() => new ApplicationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ApplicationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ApplicationServiceClientBuilder : gaxgrpc::ClientBuilderBase<ApplicationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ApplicationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ApplicationServiceClientBuilder()
        {
            UseJwtAccessWithScopes = ApplicationServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref ApplicationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ApplicationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ApplicationServiceClient Build()
        {
            ApplicationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ApplicationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ApplicationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ApplicationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ApplicationServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ApplicationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ApplicationServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ApplicationServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ApplicationServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ApplicationServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ApplicationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service that handles application management, including CRUD and
    /// enumeration.
    /// </remarks>
    public abstract partial class ApplicationServiceClient
    {
        /// <summary>
        /// The default endpoint for the ApplicationService service, which is a host of "jobs.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "jobs.googleapis.com:443";

        /// <summary>The default ApplicationService scopes.</summary>
        /// <remarks>
        /// The default ApplicationService scopes are:
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
        /// Asynchronously creates a <see cref="ApplicationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApplicationServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ApplicationServiceClient"/>.</returns>
        public static stt::Task<ApplicationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ApplicationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ApplicationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApplicationServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="ApplicationServiceClient"/>.</returns>
        public static ApplicationServiceClient Create() => new ApplicationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ApplicationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ApplicationServiceSettings"/>.</param>
        /// <returns>The created <see cref="ApplicationServiceClient"/>.</returns>
        internal static ApplicationServiceClient Create(grpccore::CallInvoker callInvoker, ApplicationServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ApplicationService.ApplicationServiceClient grpcClient = new ApplicationService.ApplicationServiceClient(callInvoker);
            return new ApplicationServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ApplicationService client</summary>
        public virtual ApplicationService.ApplicationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application CreateApplication(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> CreateApplicationAsync(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> CreateApplicationAsync(CreateApplicationRequest request, st::CancellationToken cancellationToken) =>
            CreateApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the profile under which the application is created.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="application">
        /// Required. The application to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application CreateApplication(string parent, Application application, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplication(new CreateApplicationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the profile under which the application is created.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="application">
        /// Required. The application to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> CreateApplicationAsync(string parent, Application application, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplicationAsync(new CreateApplicationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the profile under which the application is created.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="application">
        /// Required. The application to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> CreateApplicationAsync(string parent, Application application, st::CancellationToken cancellationToken) =>
            CreateApplicationAsync(parent, application, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the profile under which the application is created.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="application">
        /// Required. The application to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application CreateApplication(ProfileName parent, Application application, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplication(new CreateApplicationRequest
            {
                ParentAsProfileName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the profile under which the application is created.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="application">
        /// Required. The application to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> CreateApplicationAsync(ProfileName parent, Application application, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplicationAsync(new CreateApplicationRequest
            {
                ParentAsProfileName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the profile under which the application is created.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz".
        /// </param>
        /// <param name="application">
        /// Required. The application to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> CreateApplicationAsync(ProfileName parent, Application application, st::CancellationToken cancellationToken) =>
            CreateApplicationAsync(parent, application, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the application to be retrieved.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz/applications/qux".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplication(new GetApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the application to be retrieved.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz/applications/qux".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationAsync(new GetApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the application to be retrieved.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz/applications/qux".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(string name, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the application to be retrieved.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz/applications/qux".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplication(new GetApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the application to be retrieved.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz/applications/qux".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationAsync(new GetApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the application to be retrieved.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz/applications/qux".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates specified application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application UpdateApplication(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates specified application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> UpdateApplicationAsync(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates specified application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> UpdateApplicationAsync(UpdateApplicationRequest request, st::CancellationToken cancellationToken) =>
            UpdateApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates specified application.
        /// </summary>
        /// <param name="application">
        /// Required. The application resource to replace the current resource in the system.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application UpdateApplication(Application application, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplication(new UpdateApplicationRequest
            {
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Updates specified application.
        /// </summary>
        /// <param name="application">
        /// Required. The application resource to replace the current resource in the system.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> UpdateApplicationAsync(Application application, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplicationAsync(new UpdateApplicationRequest
            {
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Updates specified application.
        /// </summary>
        /// <param name="application">
        /// Required. The application resource to replace the current resource in the system.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> UpdateApplicationAsync(Application application, st::CancellationToken cancellationToken) =>
            UpdateApplicationAsync(application, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApplication(DeleteApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationAsync(DeleteApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationAsync(DeleteApplicationRequest request, st::CancellationToken cancellationToken) =>
            DeleteApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the application to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz/applications/qux".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplication(new DeleteApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the application to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz/applications/qux".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationAsync(new DeleteApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the application to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz/applications/qux".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the application to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz/applications/qux".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApplication(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplication(new DeleteApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the application to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz/applications/qux".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationAsync(new DeleteApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the application to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}".
        /// For example, "projects/foo/tenants/bar/profiles/baz/applications/qux".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            DeleteApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all applications associated with the profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all applications associated with the profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all applications associated with the profile.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the profile under which the application is created.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}", for
        /// example, "projects/foo/tenants/bar/profiles/baz".
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
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListApplications(new ListApplicationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all applications associated with the profile.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the profile under which the application is created.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}", for
        /// example, "projects/foo/tenants/bar/profiles/baz".
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
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListApplicationsAsync(new ListApplicationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all applications associated with the profile.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the profile under which the application is created.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}", for
        /// example, "projects/foo/tenants/bar/profiles/baz".
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
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(ProfileName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListApplications(new ListApplicationsRequest
            {
                ParentAsProfileName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all applications associated with the profile.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the profile under which the application is created.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}", for
        /// example, "projects/foo/tenants/bar/profiles/baz".
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
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(ProfileName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListApplicationsAsync(new ListApplicationsRequest
            {
                ParentAsProfileName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>ApplicationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service that handles application management, including CRUD and
    /// enumeration.
    /// </remarks>
    public sealed partial class ApplicationServiceClientImpl : ApplicationServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateApplicationRequest, Application> _callCreateApplication;

        private readonly gaxgrpc::ApiCall<GetApplicationRequest, Application> _callGetApplication;

        private readonly gaxgrpc::ApiCall<UpdateApplicationRequest, Application> _callUpdateApplication;

        private readonly gaxgrpc::ApiCall<DeleteApplicationRequest, wkt::Empty> _callDeleteApplication;

        private readonly gaxgrpc::ApiCall<ListApplicationsRequest, ListApplicationsResponse> _callListApplications;

        /// <summary>
        /// Constructs a client wrapper for the ApplicationService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ApplicationServiceSettings"/> used within this client.</param>
        public ApplicationServiceClientImpl(ApplicationService.ApplicationServiceClient grpcClient, ApplicationServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ApplicationServiceSettings effectiveSettings = settings ?? ApplicationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateApplication = clientHelper.BuildApiCall<CreateApplicationRequest, Application>(grpcClient.CreateApplicationAsync, grpcClient.CreateApplication, effectiveSettings.CreateApplicationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateApplication);
            Modify_CreateApplicationApiCall(ref _callCreateApplication);
            _callGetApplication = clientHelper.BuildApiCall<GetApplicationRequest, Application>(grpcClient.GetApplicationAsync, grpcClient.GetApplication, effectiveSettings.GetApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApplication);
            Modify_GetApplicationApiCall(ref _callGetApplication);
            _callUpdateApplication = clientHelper.BuildApiCall<UpdateApplicationRequest, Application>(grpcClient.UpdateApplicationAsync, grpcClient.UpdateApplication, effectiveSettings.UpdateApplicationSettings).WithGoogleRequestParam("application.name", request => request.Application?.Name);
            Modify_ApiCall(ref _callUpdateApplication);
            Modify_UpdateApplicationApiCall(ref _callUpdateApplication);
            _callDeleteApplication = clientHelper.BuildApiCall<DeleteApplicationRequest, wkt::Empty>(grpcClient.DeleteApplicationAsync, grpcClient.DeleteApplication, effectiveSettings.DeleteApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApplication);
            Modify_DeleteApplicationApiCall(ref _callDeleteApplication);
            _callListApplications = clientHelper.BuildApiCall<ListApplicationsRequest, ListApplicationsResponse>(grpcClient.ListApplicationsAsync, grpcClient.ListApplications, effectiveSettings.ListApplicationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApplications);
            Modify_ListApplicationsApiCall(ref _callListApplications);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateApplicationApiCall(ref gaxgrpc::ApiCall<CreateApplicationRequest, Application> call);

        partial void Modify_GetApplicationApiCall(ref gaxgrpc::ApiCall<GetApplicationRequest, Application> call);

        partial void Modify_UpdateApplicationApiCall(ref gaxgrpc::ApiCall<UpdateApplicationRequest, Application> call);

        partial void Modify_DeleteApplicationApiCall(ref gaxgrpc::ApiCall<DeleteApplicationRequest, wkt::Empty> call);

        partial void Modify_ListApplicationsApiCall(ref gaxgrpc::ApiCall<ListApplicationsRequest, ListApplicationsResponse> call);

        partial void OnConstruction(ApplicationService.ApplicationServiceClient grpcClient, ApplicationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ApplicationService client</summary>
        public override ApplicationService.ApplicationServiceClient GrpcClient { get; }

        partial void Modify_CreateApplicationRequest(ref CreateApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApplicationRequest(ref GetApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateApplicationRequest(ref UpdateApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteApplicationRequest(ref DeleteApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListApplicationsRequest(ref ListApplicationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Application CreateApplication(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApplicationRequest(ref request, ref callSettings);
            return _callCreateApplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Application> CreateApplicationAsync(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApplicationRequest(ref request, ref callSettings);
            return _callCreateApplication.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Application GetApplication(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationRequest(ref request, ref callSettings);
            return _callGetApplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationRequest(ref request, ref callSettings);
            return _callGetApplication.Async(request, callSettings);
        }

        /// <summary>
        /// Updates specified application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Application UpdateApplication(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationRequest(ref request, ref callSettings);
            return _callUpdateApplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates specified application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Application> UpdateApplicationAsync(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationRequest(ref request, ref callSettings);
            return _callUpdateApplication.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteApplication(DeleteApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApplicationRequest(ref request, ref callSettings);
            _callDeleteApplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteApplicationAsync(DeleteApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApplicationRequest(ref request, ref callSettings);
            return _callDeleteApplication.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all applications associated with the profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public override gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApplicationsRequest, ListApplicationsResponse, Application>(_callListApplications, request, callSettings);
        }

        /// <summary>
        /// Lists all applications associated with the profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApplicationsRequest, ListApplicationsResponse, Application>(_callListApplications, request, callSettings);
        }
    }

    public partial class ListApplicationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApplicationsResponse : gaxgrpc::IPageResponse<Application>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Application> GetEnumerator() => Applications.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
