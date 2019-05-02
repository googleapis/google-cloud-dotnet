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
using gaxres = Google.Api.Gax.ResourceNames;
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
    /// Settings for a <see cref="TenantServiceClient"/>.
    /// </summary>
    public sealed partial class TenantServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="TenantServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="TenantServiceSettings"/>.
        /// </returns>
        public static TenantServiceSettings GetDefault() => new TenantServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="TenantServiceSettings"/> object with default settings.
        /// </summary>
        public TenantServiceSettings() { }

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
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="TenantServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="TenantServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="TenantServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="TenantServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="TenantServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="TenantServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="TenantServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="TenantServiceClient"/> RPC methods is defined as:
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
        /// <c>TenantServiceClient.CreateTenant</c> and <c>TenantServiceClient.CreateTenantAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TenantServiceClient.CreateTenant</c> and
        /// <c>TenantServiceClient.CreateTenantAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateTenantSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TenantServiceClient.GetTenant</c> and <c>TenantServiceClient.GetTenantAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TenantServiceClient.GetTenant</c> and
        /// <c>TenantServiceClient.GetTenantAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetTenantSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TenantServiceClient.UpdateTenant</c> and <c>TenantServiceClient.UpdateTenantAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TenantServiceClient.UpdateTenant</c> and
        /// <c>TenantServiceClient.UpdateTenantAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateTenantSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TenantServiceClient.DeleteTenant</c> and <c>TenantServiceClient.DeleteTenantAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TenantServiceClient.DeleteTenant</c> and
        /// <c>TenantServiceClient.DeleteTenantAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteTenantSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TenantServiceClient.ListTenants</c> and <c>TenantServiceClient.ListTenantsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TenantServiceClient.ListTenants</c> and
        /// <c>TenantServiceClient.ListTenantsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListTenantsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="TenantServiceSettings"/> object.</returns>
        public TenantServiceSettings Clone() => new TenantServiceSettings(this);
    }

    /// <summary>
    /// TenantService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class TenantServiceClient
    {
        /// <summary>
        /// The default endpoint for the TenantService service, which is a host of "jobs.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("jobs.googleapis.com", 443);

        /// <summary>
        /// The default TenantService scopes.
        /// </summary>
        /// <remarks>
        /// The default TenantService scopes are:
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
        /// Asynchronously creates a <see cref="TenantServiceClient"/>, applying defaults for all unspecified settings,
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
        /// TenantServiceClient client = await TenantServiceClient.CreateAsync();
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
        ///     TenantServiceClient.DefaultEndpoint.Host, TenantServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// TenantServiceClient client = TenantServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="TenantServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="TenantServiceClient"/>.</returns>
        public static async stt::Task<TenantServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, TenantServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="TenantServiceClient"/>, applying defaults for all unspecified settings,
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
        /// TenantServiceClient client = TenantServiceClient.Create();
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
        ///     TenantServiceClient.DefaultEndpoint.Host, TenantServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// TenantServiceClient client = TenantServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="TenantServiceSettings"/>.</param>
        /// <returns>The created <see cref="TenantServiceClient"/>.</returns>
        public static TenantServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, TenantServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="TenantServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="TenantServiceSettings"/>.</param>
        /// <returns>The created <see cref="TenantServiceClient"/>.</returns>
        public static TenantServiceClient Create(grpccore::Channel channel, TenantServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="TenantServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="TenantServiceSettings"/>.</param>
        /// <returns>The created <see cref="TenantServiceClient"/>.</returns>
        public static TenantServiceClient Create(grpccore::CallInvoker callInvoker, TenantServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TenantService.TenantServiceClient grpcClient = new TenantService.TenantServiceClient(callInvoker);
            return new TenantServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, TenantServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, TenantServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, TenantServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, TenantServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC TenantService client.
        /// </summary>
        public virtual TenantService.TenantServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the project under which the tenant is created.
        ///
        /// The format is "projects/{project_id}", for example,
        /// "projects/api-test-project".
        /// </param>
        /// <param name="tenant">
        /// Required.
        ///
        /// The tenant to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Tenant> CreateTenantAsync(
            gaxres::ProjectName parent,
            Tenant tenant,
            gaxgrpc::CallSettings callSettings = null) => CreateTenantAsync(
                new CreateTenantRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
                },
                callSettings);

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the project under which the tenant is created.
        ///
        /// The format is "projects/{project_id}", for example,
        /// "projects/api-test-project".
        /// </param>
        /// <param name="tenant">
        /// Required.
        ///
        /// The tenant to be created.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Tenant> CreateTenantAsync(
            gaxres::ProjectName parent,
            Tenant tenant,
            st::CancellationToken cancellationToken) => CreateTenantAsync(
                parent,
                tenant,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the project under which the tenant is created.
        ///
        /// The format is "projects/{project_id}", for example,
        /// "projects/api-test-project".
        /// </param>
        /// <param name="tenant">
        /// Required.
        ///
        /// The tenant to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Tenant CreateTenant(
            gaxres::ProjectName parent,
            Tenant tenant,
            gaxgrpc::CallSettings callSettings = null) => CreateTenant(
                new CreateTenantRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
                },
                callSettings);

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the project under which the tenant is created.
        ///
        /// The format is "projects/{project_id}", for example,
        /// "projects/api-test-project".
        /// </param>
        /// <param name="tenant">
        /// Required.
        ///
        /// The tenant to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Tenant> CreateTenantAsync(
            string parent,
            Tenant tenant,
            gaxgrpc::CallSettings callSettings = null) => CreateTenantAsync(
                new CreateTenantRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
                },
                callSettings);

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the project under which the tenant is created.
        ///
        /// The format is "projects/{project_id}", for example,
        /// "projects/api-test-project".
        /// </param>
        /// <param name="tenant">
        /// Required.
        ///
        /// The tenant to be created.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Tenant> CreateTenantAsync(
            string parent,
            Tenant tenant,
            st::CancellationToken cancellationToken) => CreateTenantAsync(
                parent,
                tenant,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new tenant entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the project under which the tenant is created.
        ///
        /// The format is "projects/{project_id}", for example,
        /// "projects/api-test-project".
        /// </param>
        /// <param name="tenant">
        /// Required.
        ///
        /// The tenant to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Tenant CreateTenant(
            string parent,
            Tenant tenant,
            gaxgrpc::CallSettings callSettings = null) => CreateTenant(
                new CreateTenantRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
                },
                callSettings);

        /// <summary>
        /// Creates a new tenant entity.
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
        public virtual stt::Task<Tenant> CreateTenantAsync(
            CreateTenantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new tenant entity.
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
        public virtual stt::Task<Tenant> CreateTenantAsync(
            CreateTenantRequest request,
            st::CancellationToken cancellationToken) => CreateTenantAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new tenant entity.
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
        public virtual Tenant CreateTenant(
            CreateTenantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the tenant to be retrieved.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Tenant> GetTenantAsync(
            TenantName name,
            gaxgrpc::CallSettings callSettings = null) => GetTenantAsync(
                new GetTenantRequest
                {
                    TenantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the tenant to be retrieved.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Tenant> GetTenantAsync(
            TenantName name,
            st::CancellationToken cancellationToken) => GetTenantAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the tenant to be retrieved.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Tenant GetTenant(
            TenantName name,
            gaxgrpc::CallSettings callSettings = null) => GetTenant(
                new GetTenantRequest
                {
                    TenantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the tenant to be retrieved.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Tenant> GetTenantAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetTenantAsync(
                new GetTenantRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the tenant to be retrieved.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Tenant> GetTenantAsync(
            string name,
            st::CancellationToken cancellationToken) => GetTenantAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the tenant to be retrieved.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Tenant GetTenant(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetTenant(
                new GetTenantRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves specified tenant.
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
        public virtual stt::Task<Tenant> GetTenantAsync(
            GetTenantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves specified tenant.
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
        public virtual stt::Task<Tenant> GetTenantAsync(
            GetTenantRequest request,
            st::CancellationToken cancellationToken) => GetTenantAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified tenant.
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
        public virtual Tenant GetTenant(
            GetTenantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates specified tenant.
        /// </summary>
        /// <param name="tenant">
        /// Required.
        ///
        /// The tenant resource to replace the current resource in the system.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Tenant> UpdateTenantAsync(
            Tenant tenant,
            gaxgrpc::CallSettings callSettings = null) => UpdateTenantAsync(
                new UpdateTenantRequest
                {
                    Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
                },
                callSettings);

        /// <summary>
        /// Updates specified tenant.
        /// </summary>
        /// <param name="tenant">
        /// Required.
        ///
        /// The tenant resource to replace the current resource in the system.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Tenant> UpdateTenantAsync(
            Tenant tenant,
            st::CancellationToken cancellationToken) => UpdateTenantAsync(
                tenant,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates specified tenant.
        /// </summary>
        /// <param name="tenant">
        /// Required.
        ///
        /// The tenant resource to replace the current resource in the system.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Tenant UpdateTenant(
            Tenant tenant,
            gaxgrpc::CallSettings callSettings = null) => UpdateTenant(
                new UpdateTenantRequest
                {
                    Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
                },
                callSettings);

        /// <summary>
        /// Updates specified tenant.
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
        public virtual stt::Task<Tenant> UpdateTenantAsync(
            UpdateTenantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates specified tenant.
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
        public virtual stt::Task<Tenant> UpdateTenantAsync(
            UpdateTenantRequest request,
            st::CancellationToken cancellationToken) => UpdateTenantAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates specified tenant.
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
        public virtual Tenant UpdateTenant(
            UpdateTenantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the tenant to be deleted.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTenantAsync(
            TenantName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteTenantAsync(
                new DeleteTenantRequest
                {
                    TenantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the tenant to be deleted.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTenantAsync(
            TenantName name,
            st::CancellationToken cancellationToken) => DeleteTenantAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the tenant to be deleted.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteTenant(
            TenantName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteTenant(
                new DeleteTenantRequest
                {
                    TenantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the tenant to be deleted.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTenantAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteTenantAsync(
                new DeleteTenantRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the tenant to be deleted.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTenantAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteTenantAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the tenant to be deleted.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteTenant(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteTenant(
                new DeleteTenantRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes specified tenant.
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
        public virtual stt::Task DeleteTenantAsync(
            DeleteTenantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes specified tenant.
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
        public virtual stt::Task DeleteTenantAsync(
            DeleteTenantRequest request,
            st::CancellationToken cancellationToken) => DeleteTenantAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteTenant(
            DeleteTenantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists all tenants associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the project under which the tenant is created.
        ///
        /// The format is "projects/{project_id}", for example,
        /// "projects/api-test-project".
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
        /// A pageable asynchronous sequence of <see cref="Tenant"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListTenantsResponse, Tenant> ListTenantsAsync(
            gaxres::ProjectName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTenantsAsync(
                new ListTenantsRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all tenants associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the project under which the tenant is created.
        ///
        /// The format is "projects/{project_id}", for example,
        /// "projects/api-test-project".
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
        /// A pageable sequence of <see cref="Tenant"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListTenantsResponse, Tenant> ListTenants(
            gaxres::ProjectName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTenants(
                new ListTenantsRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all tenants associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the project under which the tenant is created.
        ///
        /// The format is "projects/{project_id}", for example,
        /// "projects/api-test-project".
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
        /// A pageable asynchronous sequence of <see cref="Tenant"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListTenantsResponse, Tenant> ListTenantsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTenantsAsync(
                new ListTenantsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all tenants associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the project under which the tenant is created.
        ///
        /// The format is "projects/{project_id}", for example,
        /// "projects/api-test-project".
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
        /// A pageable sequence of <see cref="Tenant"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListTenantsResponse, Tenant> ListTenants(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTenants(
                new ListTenantsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all tenants associated with the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Tenant"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListTenantsResponse, Tenant> ListTenantsAsync(
            ListTenantsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists all tenants associated with the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Tenant"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListTenantsResponse, Tenant> ListTenants(
            ListTenantsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// TenantService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class TenantServiceClientImpl : TenantServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateTenantRequest, Tenant> _callCreateTenant;
        private readonly gaxgrpc::ApiCall<GetTenantRequest, Tenant> _callGetTenant;
        private readonly gaxgrpc::ApiCall<UpdateTenantRequest, Tenant> _callUpdateTenant;
        private readonly gaxgrpc::ApiCall<DeleteTenantRequest, pbwkt::Empty> _callDeleteTenant;
        private readonly gaxgrpc::ApiCall<ListTenantsRequest, ListTenantsResponse> _callListTenants;

        /// <summary>
        /// Constructs a client wrapper for the TenantService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TenantServiceSettings"/> used within this client </param>
        public TenantServiceClientImpl(TenantService.TenantServiceClient grpcClient, TenantServiceSettings settings)
        {
            GrpcClient = grpcClient;
            TenantServiceSettings effectiveSettings = settings ?? TenantServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateTenant = clientHelper.BuildApiCall<CreateTenantRequest, Tenant>(
                GrpcClient.CreateTenantAsync, GrpcClient.CreateTenant, effectiveSettings.CreateTenantSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callGetTenant = clientHelper.BuildApiCall<GetTenantRequest, Tenant>(
                GrpcClient.GetTenantAsync, GrpcClient.GetTenant, effectiveSettings.GetTenantSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callUpdateTenant = clientHelper.BuildApiCall<UpdateTenantRequest, Tenant>(
                GrpcClient.UpdateTenantAsync, GrpcClient.UpdateTenant, effectiveSettings.UpdateTenantSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"tenant.name={request.Tenant.Name}"));
            _callDeleteTenant = clientHelper.BuildApiCall<DeleteTenantRequest, pbwkt::Empty>(
                GrpcClient.DeleteTenantAsync, GrpcClient.DeleteTenant, effectiveSettings.DeleteTenantSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callListTenants = clientHelper.BuildApiCall<ListTenantsRequest, ListTenantsResponse>(
                GrpcClient.ListTenantsAsync, GrpcClient.ListTenants, effectiveSettings.ListTenantsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            Modify_ApiCall(ref _callCreateTenant);
            Modify_CreateTenantApiCall(ref _callCreateTenant);
            Modify_ApiCall(ref _callGetTenant);
            Modify_GetTenantApiCall(ref _callGetTenant);
            Modify_ApiCall(ref _callUpdateTenant);
            Modify_UpdateTenantApiCall(ref _callUpdateTenant);
            Modify_ApiCall(ref _callDeleteTenant);
            Modify_DeleteTenantApiCall(ref _callDeleteTenant);
            Modify_ApiCall(ref _callListTenants);
            Modify_ListTenantsApiCall(ref _callListTenants);
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
        partial void Modify_CreateTenantApiCall(ref gaxgrpc::ApiCall<CreateTenantRequest, Tenant> call);
        partial void Modify_GetTenantApiCall(ref gaxgrpc::ApiCall<GetTenantRequest, Tenant> call);
        partial void Modify_UpdateTenantApiCall(ref gaxgrpc::ApiCall<UpdateTenantRequest, Tenant> call);
        partial void Modify_DeleteTenantApiCall(ref gaxgrpc::ApiCall<DeleteTenantRequest, pbwkt::Empty> call);
        partial void Modify_ListTenantsApiCall(ref gaxgrpc::ApiCall<ListTenantsRequest, ListTenantsResponse> call);
        partial void OnConstruction(TenantService.TenantServiceClient grpcClient, TenantServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC TenantService client.
        /// </summary>
        public override TenantService.TenantServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateTenantRequest(ref CreateTenantRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetTenantRequest(ref GetTenantRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateTenantRequest(ref UpdateTenantRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteTenantRequest(ref DeleteTenantRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListTenantsRequest(ref ListTenantsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new tenant entity.
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
        public override stt::Task<Tenant> CreateTenantAsync(
            CreateTenantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTenantRequest(ref request, ref callSettings);
            return _callCreateTenant.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new tenant entity.
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
        public override Tenant CreateTenant(
            CreateTenantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTenantRequest(ref request, ref callSettings);
            return _callCreateTenant.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves specified tenant.
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
        public override stt::Task<Tenant> GetTenantAsync(
            GetTenantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTenantRequest(ref request, ref callSettings);
            return _callGetTenant.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves specified tenant.
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
        public override Tenant GetTenant(
            GetTenantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTenantRequest(ref request, ref callSettings);
            return _callGetTenant.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates specified tenant.
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
        public override stt::Task<Tenant> UpdateTenantAsync(
            UpdateTenantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTenantRequest(ref request, ref callSettings);
            return _callUpdateTenant.Async(request, callSettings);
        }

        /// <summary>
        /// Updates specified tenant.
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
        public override Tenant UpdateTenant(
            UpdateTenantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTenantRequest(ref request, ref callSettings);
            return _callUpdateTenant.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes specified tenant.
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
        public override stt::Task DeleteTenantAsync(
            DeleteTenantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTenantRequest(ref request, ref callSettings);
            return _callDeleteTenant.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes specified tenant.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteTenant(
            DeleteTenantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTenantRequest(ref request, ref callSettings);
            _callDeleteTenant.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all tenants associated with the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Tenant"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListTenantsResponse, Tenant> ListTenantsAsync(
            ListTenantsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTenantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTenantsRequest, ListTenantsResponse, Tenant>(_callListTenants, request, callSettings);
        }

        /// <summary>
        /// Lists all tenants associated with the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Tenant"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListTenantsResponse, Tenant> ListTenants(
            ListTenantsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTenantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTenantsRequest, ListTenantsResponse, Tenant>(_callListTenants, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListTenantsRequest : gaxgrpc::IPageRequest { }
    public partial class ListTenantsResponse : gaxgrpc::IPageResponse<Tenant>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Tenant> GetEnumerator() => Tenants.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
