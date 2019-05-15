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
    /// Settings for a <see cref="ProfileServiceClient"/>.
    /// </summary>
    public sealed partial class ProfileServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ProfileServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ProfileServiceSettings"/>.
        /// </returns>
        public static ProfileServiceSettings GetDefault() => new ProfileServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ProfileServiceSettings"/> object with default settings.
        /// </summary>
        public ProfileServiceSettings() { }

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
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ProfileServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ProfileServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ProfileServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ProfileServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ProfileServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="ProfileServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ProfileServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ProfileServiceClient"/> RPC methods is defined as:
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
        /// <c>ProfileServiceClient.ListProfiles</c> and <c>ProfileServiceClient.ListProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProfileServiceClient.ListProfiles</c> and
        /// <c>ProfileServiceClient.ListProfilesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListProfilesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProfileServiceClient.CreateProfile</c> and <c>ProfileServiceClient.CreateProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProfileServiceClient.CreateProfile</c> and
        /// <c>ProfileServiceClient.CreateProfileAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateProfileSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProfileServiceClient.GetProfile</c> and <c>ProfileServiceClient.GetProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProfileServiceClient.GetProfile</c> and
        /// <c>ProfileServiceClient.GetProfileAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetProfileSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProfileServiceClient.UpdateProfile</c> and <c>ProfileServiceClient.UpdateProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProfileServiceClient.UpdateProfile</c> and
        /// <c>ProfileServiceClient.UpdateProfileAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateProfileSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProfileServiceClient.DeleteProfile</c> and <c>ProfileServiceClient.DeleteProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProfileServiceClient.DeleteProfile</c> and
        /// <c>ProfileServiceClient.DeleteProfileAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteProfileSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProfileServiceClient.SearchProfiles</c> and <c>ProfileServiceClient.SearchProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProfileServiceClient.SearchProfiles</c> and
        /// <c>ProfileServiceClient.SearchProfilesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SearchProfilesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ProfileServiceSettings"/> object.</returns>
        public ProfileServiceSettings Clone() => new ProfileServiceSettings(this);
    }

    /// <summary>
    /// ProfileService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ProfileServiceClient
    {
        /// <summary>
        /// The default endpoint for the ProfileService service, which is a host of "jobs.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("jobs.googleapis.com", 443);

        /// <summary>
        /// The default ProfileService scopes.
        /// </summary>
        /// <remarks>
        /// The default ProfileService scopes are:
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
        /// Asynchronously creates a <see cref="ProfileServiceClient"/>, applying defaults for all unspecified settings,
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
        /// ProfileServiceClient client = await ProfileServiceClient.CreateAsync();
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
        ///     ProfileServiceClient.DefaultEndpoint.Host, ProfileServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ProfileServiceClient client = ProfileServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ProfileServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ProfileServiceClient"/>.</returns>
        public static async stt::Task<ProfileServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ProfileServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ProfileServiceClient"/>, applying defaults for all unspecified settings,
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
        /// ProfileServiceClient client = ProfileServiceClient.Create();
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
        ///     ProfileServiceClient.DefaultEndpoint.Host, ProfileServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ProfileServiceClient client = ProfileServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ProfileServiceSettings"/>.</param>
        /// <returns>The created <see cref="ProfileServiceClient"/>.</returns>
        public static ProfileServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ProfileServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ProfileServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ProfileServiceSettings"/>.</param>
        /// <returns>The created <see cref="ProfileServiceClient"/>.</returns>
        public static ProfileServiceClient Create(grpccore::Channel channel, ProfileServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ProfileServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ProfileServiceSettings"/>.</param>
        /// <returns>The created <see cref="ProfileServiceClient"/>.</returns>
        public static ProfileServiceClient Create(grpccore::CallInvoker callInvoker, ProfileServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProfileService.ProfileServiceClient grpcClient = new ProfileService.ProfileServiceClient(callInvoker);
            return new ProfileServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ProfileServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ProfileServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ProfileServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ProfileServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ProfileService client.
        /// </summary>
        public virtual ProfileService.ProfileServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Lists profiles by filter. The order is unspecified.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
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
        /// A pageable asynchronous sequence of <see cref="Profile"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListProfilesResponse, Profile> ListProfilesAsync(
            TenantName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListProfilesAsync(
                new ListProfilesRequest
                {
                    ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists profiles by filter. The order is unspecified.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
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
        /// A pageable sequence of <see cref="Profile"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListProfilesResponse, Profile> ListProfiles(
            TenantName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListProfiles(
                new ListProfilesRequest
                {
                    ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists profiles by filter. The order is unspecified.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
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
        /// A pageable asynchronous sequence of <see cref="Profile"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListProfilesResponse, Profile> ListProfilesAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListProfilesAsync(
                new ListProfilesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists profiles by filter. The order is unspecified.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
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
        /// A pageable sequence of <see cref="Profile"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListProfilesResponse, Profile> ListProfiles(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListProfiles(
                new ListProfilesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists profiles by filter. The order is unspecified.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Profile"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListProfilesResponse, Profile> ListProfilesAsync(
            ListProfilesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists profiles by filter. The order is unspecified.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Profile"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListProfilesResponse, Profile> ListProfiles(
            ListProfilesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The name of the tenant this profile belongs to.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="profile">
        /// Required.
        ///
        /// The profile to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Profile> CreateProfileAsync(
            TenantName parent,
            Profile profile,
            gaxgrpc::CallSettings callSettings = null) => CreateProfileAsync(
                new CreateProfileRequest
                {
                    ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Profile = gax::GaxPreconditions.CheckNotNull(profile, nameof(profile)),
                },
                callSettings);

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The name of the tenant this profile belongs to.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="profile">
        /// Required.
        ///
        /// The profile to be created.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Profile> CreateProfileAsync(
            TenantName parent,
            Profile profile,
            st::CancellationToken cancellationToken) => CreateProfileAsync(
                parent,
                profile,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The name of the tenant this profile belongs to.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="profile">
        /// Required.
        ///
        /// The profile to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Profile CreateProfile(
            TenantName parent,
            Profile profile,
            gaxgrpc::CallSettings callSettings = null) => CreateProfile(
                new CreateProfileRequest
                {
                    ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Profile = gax::GaxPreconditions.CheckNotNull(profile, nameof(profile)),
                },
                callSettings);

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The name of the tenant this profile belongs to.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="profile">
        /// Required.
        ///
        /// The profile to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Profile> CreateProfileAsync(
            string parent,
            Profile profile,
            gaxgrpc::CallSettings callSettings = null) => CreateProfileAsync(
                new CreateProfileRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Profile = gax::GaxPreconditions.CheckNotNull(profile, nameof(profile)),
                },
                callSettings);

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The name of the tenant this profile belongs to.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="profile">
        /// Required.
        ///
        /// The profile to be created.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Profile> CreateProfileAsync(
            string parent,
            Profile profile,
            st::CancellationToken cancellationToken) => CreateProfileAsync(
                parent,
                profile,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new profile.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The name of the tenant this profile belongs to.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenants/foo".
        /// </param>
        /// <param name="profile">
        /// Required.
        ///
        /// The profile to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Profile CreateProfile(
            string parent,
            Profile profile,
            gaxgrpc::CallSettings callSettings = null) => CreateProfile(
                new CreateProfileRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Profile = gax::GaxPreconditions.CheckNotNull(profile, nameof(profile)),
                },
                callSettings);

        /// <summary>
        /// Creates and returns a new profile.
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
        public virtual stt::Task<Profile> CreateProfileAsync(
            CreateProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates and returns a new profile.
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
        public virtual stt::Task<Profile> CreateProfileAsync(
            CreateProfileRequest request,
            st::CancellationToken cancellationToken) => CreateProfileAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new profile.
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
        public virtual Profile CreateProfile(
            CreateProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// Resource name of the profile to get.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}",
        /// for example, "projects/api-test-project/tenants/foo/profiles/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Profile> GetProfileAsync(
            ProfileName name,
            gaxgrpc::CallSettings callSettings = null) => GetProfileAsync(
                new GetProfileRequest
                {
                    ProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// Resource name of the profile to get.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}",
        /// for example, "projects/api-test-project/tenants/foo/profiles/bar".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Profile> GetProfileAsync(
            ProfileName name,
            st::CancellationToken cancellationToken) => GetProfileAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// Resource name of the profile to get.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}",
        /// for example, "projects/api-test-project/tenants/foo/profiles/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Profile GetProfile(
            ProfileName name,
            gaxgrpc::CallSettings callSettings = null) => GetProfile(
                new GetProfileRequest
                {
                    ProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// Resource name of the profile to get.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}",
        /// for example, "projects/api-test-project/tenants/foo/profiles/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Profile> GetProfileAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetProfileAsync(
                new GetProfileRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// Resource name of the profile to get.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}",
        /// for example, "projects/api-test-project/tenants/foo/profiles/bar".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Profile> GetProfileAsync(
            string name,
            st::CancellationToken cancellationToken) => GetProfileAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified profile.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// Resource name of the profile to get.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}",
        /// for example, "projects/api-test-project/tenants/foo/profiles/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Profile GetProfile(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetProfile(
                new GetProfileRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified profile.
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
        public virtual stt::Task<Profile> GetProfileAsync(
            GetProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the specified profile.
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
        public virtual stt::Task<Profile> GetProfileAsync(
            GetProfileRequest request,
            st::CancellationToken cancellationToken) => GetProfileAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified profile.
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
        public virtual Profile GetProfile(
            GetProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified profile and returns the updated result.
        /// </summary>
        /// <param name="profile">
        /// Required.
        ///
        /// Profile to be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Profile> UpdateProfileAsync(
            Profile profile,
            gaxgrpc::CallSettings callSettings = null) => UpdateProfileAsync(
                new UpdateProfileRequest
                {
                    Profile = gax::GaxPreconditions.CheckNotNull(profile, nameof(profile)),
                },
                callSettings);

        /// <summary>
        /// Updates the specified profile and returns the updated result.
        /// </summary>
        /// <param name="profile">
        /// Required.
        ///
        /// Profile to be updated.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Profile> UpdateProfileAsync(
            Profile profile,
            st::CancellationToken cancellationToken) => UpdateProfileAsync(
                profile,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified profile and returns the updated result.
        /// </summary>
        /// <param name="profile">
        /// Required.
        ///
        /// Profile to be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Profile UpdateProfile(
            Profile profile,
            gaxgrpc::CallSettings callSettings = null) => UpdateProfile(
                new UpdateProfileRequest
                {
                    Profile = gax::GaxPreconditions.CheckNotNull(profile, nameof(profile)),
                },
                callSettings);

        /// <summary>
        /// Updates the specified profile and returns the updated result.
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
        public virtual stt::Task<Profile> UpdateProfileAsync(
            UpdateProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified profile and returns the updated result.
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
        public virtual stt::Task<Profile> UpdateProfileAsync(
            UpdateProfileRequest request,
            st::CancellationToken cancellationToken) => UpdateProfileAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified profile and returns the updated result.
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
        public virtual Profile UpdateProfile(
            UpdateProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// Resource name of the profile to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}",
        /// for example, "projects/api-test-project/tenants/foo/profiles/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteProfileAsync(
            ProfileName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteProfileAsync(
                new DeleteProfileRequest
                {
                    ProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// Resource name of the profile to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}",
        /// for example, "projects/api-test-project/tenants/foo/profiles/bar".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteProfileAsync(
            ProfileName name,
            st::CancellationToken cancellationToken) => DeleteProfileAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// Resource name of the profile to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}",
        /// for example, "projects/api-test-project/tenants/foo/profiles/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteProfile(
            ProfileName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteProfile(
                new DeleteProfileRequest
                {
                    ProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// Resource name of the profile to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}",
        /// for example, "projects/api-test-project/tenants/foo/profiles/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteProfileAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteProfileAsync(
                new DeleteProfileRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// Resource name of the profile to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}",
        /// for example, "projects/api-test-project/tenants/foo/profiles/bar".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteProfileAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteProfileAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// Resource name of the profile to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}",
        /// for example, "projects/api-test-project/tenants/foo/profiles/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteProfile(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteProfile(
                new DeleteProfileRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
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
        public virtual stt::Task DeleteProfileAsync(
            DeleteProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
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
        public virtual stt::Task DeleteProfileAsync(
            DeleteProfileRequest request,
            st::CancellationToken cancellationToken) => DeleteProfileAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteProfile(
            DeleteProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Searches for profiles within a tenant.
        ///
        /// For example, search by raw queries "software engineer in Mountain View" or
        /// search by structured filters (location filter, education filter, etc.).
        ///
        /// See [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest] for more information.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SummarizedProfile"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchProfilesResponse, SummarizedProfile> SearchProfilesAsync(
            SearchProfilesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Searches for profiles within a tenant.
        ///
        /// For example, search by raw queries "software engineer in Mountain View" or
        /// search by structured filters (location filter, education filter, etc.).
        ///
        /// See [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest] for more information.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="SummarizedProfile"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchProfilesResponse, SummarizedProfile> SearchProfiles(
            SearchProfilesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// ProfileService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ProfileServiceClientImpl : ProfileServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListProfilesRequest, ListProfilesResponse> _callListProfiles;
        private readonly gaxgrpc::ApiCall<CreateProfileRequest, Profile> _callCreateProfile;
        private readonly gaxgrpc::ApiCall<GetProfileRequest, Profile> _callGetProfile;
        private readonly gaxgrpc::ApiCall<UpdateProfileRequest, Profile> _callUpdateProfile;
        private readonly gaxgrpc::ApiCall<DeleteProfileRequest, pbwkt::Empty> _callDeleteProfile;
        private readonly gaxgrpc::ApiCall<SearchProfilesRequest, SearchProfilesResponse> _callSearchProfiles;

        /// <summary>
        /// Constructs a client wrapper for the ProfileService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProfileServiceSettings"/> used within this client </param>
        public ProfileServiceClientImpl(ProfileService.ProfileServiceClient grpcClient, ProfileServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ProfileServiceSettings effectiveSettings = settings ?? ProfileServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListProfiles = clientHelper.BuildApiCall<ListProfilesRequest, ListProfilesResponse>(
                GrpcClient.ListProfilesAsync, GrpcClient.ListProfiles, effectiveSettings.ListProfilesSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callCreateProfile = clientHelper.BuildApiCall<CreateProfileRequest, Profile>(
                GrpcClient.CreateProfileAsync, GrpcClient.CreateProfile, effectiveSettings.CreateProfileSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callGetProfile = clientHelper.BuildApiCall<GetProfileRequest, Profile>(
                GrpcClient.GetProfileAsync, GrpcClient.GetProfile, effectiveSettings.GetProfileSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callUpdateProfile = clientHelper.BuildApiCall<UpdateProfileRequest, Profile>(
                GrpcClient.UpdateProfileAsync, GrpcClient.UpdateProfile, effectiveSettings.UpdateProfileSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"profile.name={request.Profile.Name}"));
            _callDeleteProfile = clientHelper.BuildApiCall<DeleteProfileRequest, pbwkt::Empty>(
                GrpcClient.DeleteProfileAsync, GrpcClient.DeleteProfile, effectiveSettings.DeleteProfileSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callSearchProfiles = clientHelper.BuildApiCall<SearchProfilesRequest, SearchProfilesResponse>(
                GrpcClient.SearchProfilesAsync, GrpcClient.SearchProfiles, effectiveSettings.SearchProfilesSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            Modify_ApiCall(ref _callListProfiles);
            Modify_ListProfilesApiCall(ref _callListProfiles);
            Modify_ApiCall(ref _callCreateProfile);
            Modify_CreateProfileApiCall(ref _callCreateProfile);
            Modify_ApiCall(ref _callGetProfile);
            Modify_GetProfileApiCall(ref _callGetProfile);
            Modify_ApiCall(ref _callUpdateProfile);
            Modify_UpdateProfileApiCall(ref _callUpdateProfile);
            Modify_ApiCall(ref _callDeleteProfile);
            Modify_DeleteProfileApiCall(ref _callDeleteProfile);
            Modify_ApiCall(ref _callSearchProfiles);
            Modify_SearchProfilesApiCall(ref _callSearchProfiles);
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
        partial void Modify_ListProfilesApiCall(ref gaxgrpc::ApiCall<ListProfilesRequest, ListProfilesResponse> call);
        partial void Modify_CreateProfileApiCall(ref gaxgrpc::ApiCall<CreateProfileRequest, Profile> call);
        partial void Modify_GetProfileApiCall(ref gaxgrpc::ApiCall<GetProfileRequest, Profile> call);
        partial void Modify_UpdateProfileApiCall(ref gaxgrpc::ApiCall<UpdateProfileRequest, Profile> call);
        partial void Modify_DeleteProfileApiCall(ref gaxgrpc::ApiCall<DeleteProfileRequest, pbwkt::Empty> call);
        partial void Modify_SearchProfilesApiCall(ref gaxgrpc::ApiCall<SearchProfilesRequest, SearchProfilesResponse> call);
        partial void OnConstruction(ProfileService.ProfileServiceClient grpcClient, ProfileServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ProfileService client.
        /// </summary>
        public override ProfileService.ProfileServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListProfilesRequest(ref ListProfilesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateProfileRequest(ref CreateProfileRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetProfileRequest(ref GetProfileRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateProfileRequest(ref UpdateProfileRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteProfileRequest(ref DeleteProfileRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SearchProfilesRequest(ref SearchProfilesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists profiles by filter. The order is unspecified.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Profile"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListProfilesResponse, Profile> ListProfilesAsync(
            ListProfilesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProfilesRequest, ListProfilesResponse, Profile>(_callListProfiles, request, callSettings);
        }

        /// <summary>
        /// Lists profiles by filter. The order is unspecified.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Profile"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListProfilesResponse, Profile> ListProfiles(
            ListProfilesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProfilesRequest, ListProfilesResponse, Profile>(_callListProfiles, request, callSettings);
        }

        /// <summary>
        /// Creates and returns a new profile.
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
        public override stt::Task<Profile> CreateProfileAsync(
            CreateProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProfileRequest(ref request, ref callSettings);
            return _callCreateProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Creates and returns a new profile.
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
        public override Profile CreateProfile(
            CreateProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProfileRequest(ref request, ref callSettings);
            return _callCreateProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified profile.
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
        public override stt::Task<Profile> GetProfileAsync(
            GetProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProfileRequest(ref request, ref callSettings);
            return _callGetProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the specified profile.
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
        public override Profile GetProfile(
            GetProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProfileRequest(ref request, ref callSettings);
            return _callGetProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified profile and returns the updated result.
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
        public override stt::Task<Profile> UpdateProfileAsync(
            UpdateProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProfileRequest(ref request, ref callSettings);
            return _callUpdateProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified profile and returns the updated result.
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
        public override Profile UpdateProfile(
            UpdateProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProfileRequest(ref request, ref callSettings);
            return _callUpdateProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
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
        public override stt::Task DeleteProfileAsync(
            DeleteProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProfileRequest(ref request, ref callSettings);
            return _callDeleteProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified profile.
        /// Prerequisite: The profile has no associated applications or assignments
        /// associated.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteProfile(
            DeleteProfileRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProfileRequest(ref request, ref callSettings);
            _callDeleteProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Searches for profiles within a tenant.
        ///
        /// For example, search by raw queries "software engineer in Mountain View" or
        /// search by structured filters (location filter, education filter, etc.).
        ///
        /// See [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest] for more information.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SummarizedProfile"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<SearchProfilesResponse, SummarizedProfile> SearchProfilesAsync(
            SearchProfilesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchProfilesRequest, SearchProfilesResponse, SummarizedProfile>(_callSearchProfiles, request, callSettings);
        }

        /// <summary>
        /// Searches for profiles within a tenant.
        ///
        /// For example, search by raw queries "software engineer in Mountain View" or
        /// search by structured filters (location filter, education filter, etc.).
        ///
        /// See [SearchProfilesRequest][google.cloud.talent.v4beta1.SearchProfilesRequest] for more information.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="SummarizedProfile"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<SearchProfilesResponse, SummarizedProfile> SearchProfiles(
            SearchProfilesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchProfilesRequest, SearchProfilesResponse, SummarizedProfile>(_callSearchProfiles, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListProfilesRequest : gaxgrpc::IPageRequest { }
    public partial class ListProfilesResponse : gaxgrpc::IPageResponse<Profile>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Profile> GetEnumerator() => Profiles.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchProfilesRequest : gaxgrpc::IPageRequest { }
    public partial class SearchProfilesResponse : gaxgrpc::IPageResponse<SummarizedProfile>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<SummarizedProfile> GetEnumerator() => SummarizedProfiles.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
