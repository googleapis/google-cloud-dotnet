// Copyright 2019 Google LLC
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
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Talent.V4Beta1
{
    /// <summary>
    /// Settings for a <see cref="ApplicationServiceClient"/>.
    /// </summary>
    public sealed partial class ApplicationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ApplicationServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ApplicationServiceSettings"/>.
        /// </returns>
        public static ApplicationServiceSettings GetDefault() => new ApplicationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ApplicationServiceSettings"/> object with default settings.
        /// </summary>
        public ApplicationServiceSettings() { }

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
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ApplicationServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="ApplicationServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ApplicationServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ApplicationServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ApplicationServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="ApplicationServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ApplicationServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ApplicationServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApplicationServiceClient.CreateApplication</c> and <c>ApplicationServiceClient.CreateApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ApplicationServiceClient.CreateApplication</c> and
        /// <c>ApplicationServiceClient.CreateApplicationAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApplicationServiceClient.GetApplication</c> and <c>ApplicationServiceClient.GetApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ApplicationServiceClient.GetApplication</c> and
        /// <c>ApplicationServiceClient.GetApplicationAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApplicationServiceClient.UpdateApplication</c> and <c>ApplicationServiceClient.UpdateApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ApplicationServiceClient.UpdateApplication</c> and
        /// <c>ApplicationServiceClient.UpdateApplicationAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApplicationServiceClient.DeleteApplication</c> and <c>ApplicationServiceClient.DeleteApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ApplicationServiceClient.DeleteApplication</c> and
        /// <c>ApplicationServiceClient.DeleteApplicationAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApplicationServiceClient.ListApplications</c> and <c>ApplicationServiceClient.ListApplicationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ApplicationServiceClient.ListApplications</c> and
        /// <c>ApplicationServiceClient.ListApplicationsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListApplicationsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ApplicationServiceSettings"/> object.</returns>
        public ApplicationServiceSettings Clone() => new ApplicationServiceSettings(this);
    }

    /// <summary>
    /// ApplicationService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ApplicationServiceClient
    {
        /// <summary>
        /// The default endpoint for the ApplicationService service, which is a host of "jobs.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("jobs.googleapis.com", 443);

        /// <summary>
        /// The default ApplicationService scopes.
        /// </summary>
        /// <remarks>
        /// The default ApplicationService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/jobs"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/jobs",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ApplicationServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Talent.V4Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ApplicationServiceClient client = await ApplicationServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Talent.V4Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ApplicationServiceClient.DefaultEndpoint.Host, ApplicationServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ApplicationServiceClient client = ApplicationServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ApplicationServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ApplicationServiceClient"/>.</returns>
        public static async stt::Task<ApplicationServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ApplicationServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ApplicationServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Talent.V4Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ApplicationServiceClient client = ApplicationServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Talent.V4Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ApplicationServiceClient.DefaultEndpoint.Host, ApplicationServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ApplicationServiceClient client = ApplicationServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ApplicationServiceSettings"/>.</param>
        /// <returns>The created <see cref="ApplicationServiceClient"/>.</returns>
        public static ApplicationServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ApplicationServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ApplicationServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ApplicationServiceSettings"/>.</param>
        /// <returns>The created <see cref="ApplicationServiceClient"/>.</returns>
        public static ApplicationServiceClient Create(grpccore::Channel channel, ApplicationServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ApplicationServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ApplicationServiceSettings"/>.</param>
        /// <returns>The created <see cref="ApplicationServiceClient"/>.</returns>
        public static ApplicationServiceClient Create(grpccore::CallInvoker callInvoker, ApplicationServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ApplicationService.ApplicationServiceClient grpcClient = new ApplicationService.ApplicationServiceClient(callInvoker);
            return new ApplicationServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ApplicationServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ApplicationServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ApplicationServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ApplicationServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ApplicationService client.
        /// </summary>
        public virtual ApplicationService.ApplicationServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the profile under which the application is created.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}", for
        /// example, "projects/test-project/tenants/test-tenant/profiles/test-profile".
        /// </param>
        /// <param name="application">
        /// Required.
        ///
        /// The application to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Application> CreateApplicationAsync(
            ProfileName parent,
            Application application,
            gaxgrpc::CallSettings callSettings = null) => CreateApplicationAsync(
                new CreateApplicationRequest
                {
                    ParentAsProfileName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
                },
                callSettings);

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the profile under which the application is created.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}", for
        /// example, "projects/test-project/tenants/test-tenant/profiles/test-profile".
        /// </param>
        /// <param name="application">
        /// Required.
        ///
        /// The application to be created.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Application> CreateApplicationAsync(
            ProfileName parent,
            Application application,
            st::CancellationToken cancellationToken) => CreateApplicationAsync(
                parent,
                application,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the profile under which the application is created.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}", for
        /// example, "projects/test-project/tenants/test-tenant/profiles/test-profile".
        /// </param>
        /// <param name="application">
        /// Required.
        ///
        /// The application to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Application CreateApplication(
            ProfileName parent,
            Application application,
            gaxgrpc::CallSettings callSettings = null) => CreateApplication(
                new CreateApplicationRequest
                {
                    ParentAsProfileName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
                },
                callSettings);

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the profile under which the application is created.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}", for
        /// example, "projects/test-project/tenants/test-tenant/profiles/test-profile".
        /// </param>
        /// <param name="application">
        /// Required.
        ///
        /// The application to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Application> CreateApplicationAsync(
            string parent,
            Application application,
            gaxgrpc::CallSettings callSettings = null) => CreateApplicationAsync(
                new CreateApplicationRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
                },
                callSettings);

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the profile under which the application is created.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}", for
        /// example, "projects/test-project/tenants/test-tenant/profiles/test-profile".
        /// </param>
        /// <param name="application">
        /// Required.
        ///
        /// The application to be created.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Application> CreateApplicationAsync(
            string parent,
            Application application,
            st::CancellationToken cancellationToken) => CreateApplicationAsync(
                parent,
                application,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the profile under which the application is created.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}", for
        /// example, "projects/test-project/tenants/test-tenant/profiles/test-profile".
        /// </param>
        /// <param name="application">
        /// Required.
        ///
        /// The application to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Application CreateApplication(
            string parent,
            Application application,
            gaxgrpc::CallSettings callSettings = null) => CreateApplication(
                new CreateApplicationRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
                },
                callSettings);

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Application> CreateApplicationAsync(
            CreateApplicationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Application> CreateApplicationAsync(
            CreateApplicationRequest request,
            st::CancellationToken cancellationToken) => CreateApplicationAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Application CreateApplication(
            CreateApplicationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the application to be retrieved.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}",
        /// for example,
        /// "projects/test-project/tenants/test-tenant/profiles/test-profile/applications/test-application".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Application> GetApplicationAsync(
            ApplicationName name,
            gaxgrpc::CallSettings callSettings = null) => GetApplicationAsync(
                new GetApplicationRequest
                {
                    ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the application to be retrieved.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}",
        /// for example,
        /// "projects/test-project/tenants/test-tenant/profiles/test-profile/applications/test-application".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Application> GetApplicationAsync(
            ApplicationName name,
            st::CancellationToken cancellationToken) => GetApplicationAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the application to be retrieved.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}",
        /// for example,
        /// "projects/test-project/tenants/test-tenant/profiles/test-profile/applications/test-application".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Application GetApplication(
            ApplicationName name,
            gaxgrpc::CallSettings callSettings = null) => GetApplication(
                new GetApplicationRequest
                {
                    ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the application to be retrieved.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}",
        /// for example,
        /// "projects/test-project/tenants/test-tenant/profiles/test-profile/applications/test-application".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Application> GetApplicationAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetApplicationAsync(
                new GetApplicationRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the application to be retrieved.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}",
        /// for example,
        /// "projects/test-project/tenants/test-tenant/profiles/test-profile/applications/test-application".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Application> GetApplicationAsync(
            string name,
            st::CancellationToken cancellationToken) => GetApplicationAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the application to be retrieved.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}",
        /// for example,
        /// "projects/test-project/tenants/test-tenant/profiles/test-profile/applications/test-application".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Application GetApplication(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetApplication(
                new GetApplicationRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Application> GetApplicationAsync(
            GetApplicationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Application> GetApplicationAsync(
            GetApplicationRequest request,
            st::CancellationToken cancellationToken) => GetApplicationAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Application GetApplication(
            GetApplicationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates specified application.
        /// </summary>
        /// <param name="application">
        /// Required.
        ///
        /// The application resource to replace the current resource in the system.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Application> UpdateApplicationAsync(
            Application application,
            gaxgrpc::CallSettings callSettings = null) => UpdateApplicationAsync(
                new UpdateApplicationRequest
                {
                    Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
                },
                callSettings);

        /// <summary>
        /// Updates specified application.
        /// </summary>
        /// <param name="application">
        /// Required.
        ///
        /// The application resource to replace the current resource in the system.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Application> UpdateApplicationAsync(
            Application application,
            st::CancellationToken cancellationToken) => UpdateApplicationAsync(
                application,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates specified application.
        /// </summary>
        /// <param name="application">
        /// Required.
        ///
        /// The application resource to replace the current resource in the system.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Application UpdateApplication(
            Application application,
            gaxgrpc::CallSettings callSettings = null) => UpdateApplication(
                new UpdateApplicationRequest
                {
                    Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
                },
                callSettings);

        /// <summary>
        /// Updates specified application.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Application> UpdateApplicationAsync(
            UpdateApplicationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates specified application.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Application> UpdateApplicationAsync(
            UpdateApplicationRequest request,
            st::CancellationToken cancellationToken) => UpdateApplicationAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates specified application.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Application UpdateApplication(
            UpdateApplicationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the application to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}",
        /// for example,
        /// "projects/test-project/tenants/test-tenant/profiles/test-profile/applications/test-application".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteApplicationAsync(
            ApplicationName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteApplicationAsync(
                new DeleteApplicationRequest
                {
                    ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the application to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}",
        /// for example,
        /// "projects/test-project/tenants/test-tenant/profiles/test-profile/applications/test-application".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteApplicationAsync(
            ApplicationName name,
            st::CancellationToken cancellationToken) => DeleteApplicationAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the application to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}",
        /// for example,
        /// "projects/test-project/tenants/test-tenant/profiles/test-profile/applications/test-application".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteApplication(
            ApplicationName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteApplication(
                new DeleteApplicationRequest
                {
                    ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the application to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}",
        /// for example,
        /// "projects/test-project/tenants/test-tenant/profiles/test-profile/applications/test-application".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteApplicationAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteApplicationAsync(
                new DeleteApplicationRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the application to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}",
        /// for example,
        /// "projects/test-project/tenants/test-tenant/profiles/test-profile/applications/test-application".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteApplicationAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteApplicationAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the application to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}",
        /// for example,
        /// "projects/test-project/tenants/test-tenant/profiles/test-profile/applications/test-application".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteApplication(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteApplication(
                new DeleteApplicationRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteApplicationAsync(
            DeleteApplicationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteApplicationAsync(
            DeleteApplicationRequest request,
            st::CancellationToken cancellationToken) => DeleteApplicationAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteApplication(
            DeleteApplicationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists all applications associated with the profile.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the profile under which the application is created.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}", for
        /// example, "projects/test-project/tenants/test-tenant/profiles/test-profile".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Application"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(
            ProfileName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListApplicationsAsync(
                new ListApplicationsRequest
                {
                    ParentAsProfileName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all applications associated with the profile.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the profile under which the application is created.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}", for
        /// example, "projects/test-project/tenants/test-tenant/profiles/test-profile".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Application"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(
            ProfileName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListApplications(
                new ListApplicationsRequest
                {
                    ParentAsProfileName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all applications associated with the profile.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the profile under which the application is created.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}", for
        /// example, "projects/test-project/tenants/test-tenant/profiles/test-profile".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Application"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListApplicationsAsync(
                new ListApplicationsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all applications associated with the profile.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the profile under which the application is created.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}", for
        /// example, "projects/test-project/tenants/test-tenant/profiles/test-profile".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Application"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListApplications(
                new ListApplicationsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all applications associated with the profile.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Application"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(
            ListApplicationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists all applications associated with the profile.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Application"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(
            ListApplicationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// ApplicationService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ApplicationServiceClientImpl : ApplicationServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateApplicationRequest, Application> _callCreateApplication;
        private readonly gaxgrpc::ApiCall<GetApplicationRequest, Application> _callGetApplication;
        private readonly gaxgrpc::ApiCall<UpdateApplicationRequest, Application> _callUpdateApplication;
        private readonly gaxgrpc::ApiCall<DeleteApplicationRequest, pbwkt::Empty> _callDeleteApplication;
        private readonly gaxgrpc::ApiCall<ListApplicationsRequest, ListApplicationsResponse> _callListApplications;

        /// <summary>
        /// Constructs a client wrapper for the ApplicationService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ApplicationServiceSettings"/> used within this client </param>
        public ApplicationServiceClientImpl(ApplicationService.ApplicationServiceClient grpcClient, ApplicationServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ApplicationServiceSettings effectiveSettings = settings ?? ApplicationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateApplication = clientHelper.BuildApiCall<CreateApplicationRequest, Application>(
                GrpcClient.CreateApplicationAsync, GrpcClient.CreateApplication, effectiveSettings.CreateApplicationSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callGetApplication = clientHelper.BuildApiCall<GetApplicationRequest, Application>(
                GrpcClient.GetApplicationAsync, GrpcClient.GetApplication, effectiveSettings.GetApplicationSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callUpdateApplication = clientHelper.BuildApiCall<UpdateApplicationRequest, Application>(
                GrpcClient.UpdateApplicationAsync, GrpcClient.UpdateApplication, effectiveSettings.UpdateApplicationSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"application.name={request.Application.Name}"));
            _callDeleteApplication = clientHelper.BuildApiCall<DeleteApplicationRequest, pbwkt::Empty>(
                GrpcClient.DeleteApplicationAsync, GrpcClient.DeleteApplication, effectiveSettings.DeleteApplicationSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callListApplications = clientHelper.BuildApiCall<ListApplicationsRequest, ListApplicationsResponse>(
                GrpcClient.ListApplicationsAsync, GrpcClient.ListApplications, effectiveSettings.ListApplicationsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            Modify_ApiCall(ref _callCreateApplication);
            Modify_CreateApplicationApiCall(ref _callCreateApplication);
            Modify_ApiCall(ref _callGetApplication);
            Modify_GetApplicationApiCall(ref _callGetApplication);
            Modify_ApiCall(ref _callUpdateApplication);
            Modify_UpdateApplicationApiCall(ref _callUpdateApplication);
            Modify_ApiCall(ref _callDeleteApplication);
            Modify_DeleteApplicationApiCall(ref _callDeleteApplication);
            Modify_ApiCall(ref _callListApplications);
            Modify_ListApplicationsApiCall(ref _callListApplications);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_CreateApplicationApiCall(ref gaxgrpc::ApiCall<CreateApplicationRequest, Application> call);
        partial void Modify_GetApplicationApiCall(ref gaxgrpc::ApiCall<GetApplicationRequest, Application> call);
        partial void Modify_UpdateApplicationApiCall(ref gaxgrpc::ApiCall<UpdateApplicationRequest, Application> call);
        partial void Modify_DeleteApplicationApiCall(ref gaxgrpc::ApiCall<DeleteApplicationRequest, pbwkt::Empty> call);
        partial void Modify_ListApplicationsApiCall(ref gaxgrpc::ApiCall<ListApplicationsRequest, ListApplicationsResponse> call);
        partial void OnConstruction(ApplicationService.ApplicationServiceClient grpcClient, ApplicationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ApplicationService client.
        /// </summary>
        public override ApplicationService.ApplicationServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateApplicationRequest(ref CreateApplicationRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetApplicationRequest(ref GetApplicationRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateApplicationRequest(ref UpdateApplicationRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteApplicationRequest(ref DeleteApplicationRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListApplicationsRequest(ref ListApplicationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<Application> CreateApplicationAsync(
            CreateApplicationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApplicationRequest(ref request, ref callSettings);
            return _callCreateApplication.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new application entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Application CreateApplication(
            CreateApplicationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApplicationRequest(ref request, ref callSettings);
            return _callCreateApplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<Application> GetApplicationAsync(
            GetApplicationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationRequest(ref request, ref callSettings);
            return _callGetApplication.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves specified application.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Application GetApplication(
            GetApplicationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationRequest(ref request, ref callSettings);
            return _callGetApplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates specified application.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<Application> UpdateApplicationAsync(
            UpdateApplicationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationRequest(ref request, ref callSettings);
            return _callUpdateApplication.Async(request, callSettings);
        }

        /// <summary>
        /// Updates specified application.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Application UpdateApplication(
            UpdateApplicationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationRequest(ref request, ref callSettings);
            return _callUpdateApplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteApplicationAsync(
            DeleteApplicationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApplicationRequest(ref request, ref callSettings);
            return _callDeleteApplication.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes specified application.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteApplication(
            DeleteApplicationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApplicationRequest(ref request, ref callSettings);
            _callDeleteApplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all applications associated with the profile.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Application"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(
            ListApplicationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApplicationsRequest, ListApplicationsResponse, Application>(_callListApplications, request, callSettings);
        }

        /// <summary>
        /// Lists all applications associated with the profile.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Application"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(
            ListApplicationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApplicationsRequest, ListApplicationsResponse, Application>(_callListApplications, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListApplicationsRequest : gaxgrpc::IPageRequest { }
    public partial class ListApplicationsResponse : gaxgrpc::IPageResponse<Application>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Application> GetEnumerator() => Applications.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
