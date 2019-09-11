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

using ga = Google.Api;
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

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>
    /// Settings for a <see cref="GroupServiceClient"/>.
    /// </summary>
    public sealed partial class GroupServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="GroupServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="GroupServiceSettings"/>.
        /// </returns>
        public static GroupServiceSettings GetDefault() => new GroupServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="GroupServiceSettings"/> object with default settings.
        /// </summary>
        public GroupServiceSettings() { }

        private GroupServiceSettings(GroupServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListGroupsSettings = existing.ListGroupsSettings;
            GetGroupSettings = existing.GetGroupSettings;
            CreateGroupSettings = existing.CreateGroupSettings;
            UpdateGroupSettings = existing.UpdateGroupSettings;
            DeleteGroupSettings = existing.DeleteGroupSettings;
            ListGroupMembersSettings = existing.ListGroupMembersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GroupServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="GroupServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="GroupServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="GroupServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="GroupServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="GroupServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="GroupServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="GroupServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="GroupServiceClient"/> RPC methods is defined as:
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
        /// <c>GroupServiceClient.ListGroups</c> and <c>GroupServiceClient.ListGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GroupServiceClient.ListGroups</c> and
        /// <c>GroupServiceClient.ListGroupsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupServiceClient.GetGroup</c> and <c>GroupServiceClient.GetGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GroupServiceClient.GetGroup</c> and
        /// <c>GroupServiceClient.GetGroupAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetGroupSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupServiceClient.CreateGroup</c> and <c>GroupServiceClient.CreateGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GroupServiceClient.CreateGroup</c> and
        /// <c>GroupServiceClient.CreateGroupAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateGroupSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupServiceClient.UpdateGroup</c> and <c>GroupServiceClient.UpdateGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GroupServiceClient.UpdateGroup</c> and
        /// <c>GroupServiceClient.UpdateGroupAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateGroupSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupServiceClient.DeleteGroup</c> and <c>GroupServiceClient.DeleteGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GroupServiceClient.DeleteGroup</c> and
        /// <c>GroupServiceClient.DeleteGroupAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteGroupSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupServiceClient.ListGroupMembers</c> and <c>GroupServiceClient.ListGroupMembersAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GroupServiceClient.ListGroupMembers</c> and
        /// <c>GroupServiceClient.ListGroupMembersAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListGroupMembersSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="GroupServiceSettings"/> object.</returns>
        public GroupServiceSettings Clone() => new GroupServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GroupServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class GroupServiceClientBuilder : gaxgrpc::ClientBuilderBase<GroupServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public GroupServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override GroupServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GroupServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<GroupServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GroupServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => GroupServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => GroupServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => GroupServiceClient.ChannelPool;
    }

    /// <summary>
    /// GroupService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class GroupServiceClient
    {
        /// <summary>
        /// The default endpoint for the GroupService service, which is a host of "monitoring.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("monitoring.googleapis.com", 443);

        /// <summary>
        /// The default GroupService scopes.
        /// </summary>
        /// <remarks>
        /// The default GroupService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring.read"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring.write"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
            "https://www.googleapis.com/auth/monitoring.write",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="GroupServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// GroupServiceClient client = await GroupServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     GroupServiceClient.DefaultEndpoint.Host, GroupServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// GroupServiceClient client = GroupServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="GroupServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="GroupServiceClient"/>.</returns>
        public static async stt::Task<GroupServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, GroupServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="GroupServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// GroupServiceClient client = GroupServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     GroupServiceClient.DefaultEndpoint.Host, GroupServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// GroupServiceClient client = GroupServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="GroupServiceSettings"/>.</param>
        /// <returns>The created <see cref="GroupServiceClient"/>.</returns>
        public static GroupServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, GroupServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="GroupServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="GroupServiceSettings"/>.</param>
        /// <returns>The created <see cref="GroupServiceClient"/>.</returns>
        public static GroupServiceClient Create(grpccore::Channel channel, GroupServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="GroupServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="GroupServiceSettings"/>.</param>
        /// <returns>The created <see cref="GroupServiceClient"/>.</returns>
        public static GroupServiceClient Create(grpccore::CallInvoker callInvoker, GroupServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GroupService.GroupServiceClient grpcClient = new GroupService.GroupServiceClient(callInvoker);
            return new GroupServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, GroupServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, GroupServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, GroupServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, GroupServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC GroupService client.
        /// </summary>
        public virtual GroupService.GroupServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="name">
        /// The project whose groups are to be listed. The format is
        /// `"projects/{project_id_or_number}"`.
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
        /// A pageable asynchronous sequence of <see cref="Group"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListGroupsAsync(
                new ListGroupsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="name">
        /// The project whose groups are to be listed. The format is
        /// `"projects/{project_id_or_number}"`.
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
        /// A pageable sequence of <see cref="Group"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListGroups(
                new ListGroupsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="name">
        /// The project whose groups are to be listed. The format is
        /// `"projects/{project_id_or_number}"`.
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
        /// A pageable asynchronous sequence of <see cref="Group"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(
            string name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListGroupsAsync(
                new ListGroupsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="name">
        /// The project whose groups are to be listed. The format is
        /// `"projects/{project_id_or_number}"`.
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
        /// A pageable sequence of <see cref="Group"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(
            string name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListGroups(
                new ListGroupsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Group"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(
            ListGroupsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Group"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(
            ListGroupsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// The group to retrieve. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Group> GetGroupAsync(
            GroupName name,
            gaxgrpc::CallSettings callSettings = null) => GetGroupAsync(
                new GetGroupRequest
                {
                    GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// The group to retrieve. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Group> GetGroupAsync(
            GroupName name,
            st::CancellationToken cancellationToken) => GetGroupAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// The group to retrieve. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Group GetGroup(
            GroupName name,
            gaxgrpc::CallSettings callSettings = null) => GetGroup(
                new GetGroupRequest
                {
                    GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// The group to retrieve. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Group> GetGroupAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetGroupAsync(
                new GetGroupRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// The group to retrieve. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Group> GetGroupAsync(
            string name,
            st::CancellationToken cancellationToken) => GetGroupAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// The group to retrieve. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Group GetGroup(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetGroup(
                new GetGroupRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single group.
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
        public virtual stt::Task<Group> GetGroupAsync(
            GetGroupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a single group.
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
        public virtual stt::Task<Group> GetGroupAsync(
            GetGroupRequest request,
            st::CancellationToken cancellationToken) => GetGroupAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single group.
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
        public virtual Group GetGroup(
            GetGroupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// The project in which to create the group. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="group">
        /// A group definition. It is an error to define the `name` field because
        /// the system assigns the name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Group> CreateGroupAsync(
            ProjectName name,
            Group group,
            gaxgrpc::CallSettings callSettings = null) => CreateGroupAsync(
                new CreateGroupRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
                },
                callSettings);

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// The project in which to create the group. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="group">
        /// A group definition. It is an error to define the `name` field because
        /// the system assigns the name.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Group> CreateGroupAsync(
            ProjectName name,
            Group group,
            st::CancellationToken cancellationToken) => CreateGroupAsync(
                name,
                group,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// The project in which to create the group. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="group">
        /// A group definition. It is an error to define the `name` field because
        /// the system assigns the name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Group CreateGroup(
            ProjectName name,
            Group group,
            gaxgrpc::CallSettings callSettings = null) => CreateGroup(
                new CreateGroupRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
                },
                callSettings);

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// The project in which to create the group. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="group">
        /// A group definition. It is an error to define the `name` field because
        /// the system assigns the name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Group> CreateGroupAsync(
            string name,
            Group group,
            gaxgrpc::CallSettings callSettings = null) => CreateGroupAsync(
                new CreateGroupRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
                },
                callSettings);

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// The project in which to create the group. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="group">
        /// A group definition. It is an error to define the `name` field because
        /// the system assigns the name.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Group> CreateGroupAsync(
            string name,
            Group group,
            st::CancellationToken cancellationToken) => CreateGroupAsync(
                name,
                group,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// The project in which to create the group. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="group">
        /// A group definition. It is an error to define the `name` field because
        /// the system assigns the name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Group CreateGroup(
            string name,
            Group group,
            gaxgrpc::CallSettings callSettings = null) => CreateGroup(
                new CreateGroupRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
                },
                callSettings);

        /// <summary>
        /// Creates a new group.
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
        public virtual stt::Task<Group> CreateGroupAsync(
            CreateGroupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new group.
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
        public virtual stt::Task<Group> CreateGroupAsync(
            CreateGroupRequest request,
            st::CancellationToken cancellationToken) => CreateGroupAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new group.
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
        public virtual Group CreateGroup(
            CreateGroupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
        /// </summary>
        /// <param name="group">
        /// The new definition of the group.  All fields of the existing group,
        /// excepting `name`, are replaced with the corresponding fields of this group.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Group> UpdateGroupAsync(
            Group group,
            gaxgrpc::CallSettings callSettings = null) => UpdateGroupAsync(
                new UpdateGroupRequest
                {
                    Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
                },
                callSettings);

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
        /// </summary>
        /// <param name="group">
        /// The new definition of the group.  All fields of the existing group,
        /// excepting `name`, are replaced with the corresponding fields of this group.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Group> UpdateGroupAsync(
            Group group,
            st::CancellationToken cancellationToken) => UpdateGroupAsync(
                group,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
        /// </summary>
        /// <param name="group">
        /// The new definition of the group.  All fields of the existing group,
        /// excepting `name`, are replaced with the corresponding fields of this group.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Group UpdateGroup(
            Group group,
            gaxgrpc::CallSettings callSettings = null) => UpdateGroup(
                new UpdateGroupRequest
                {
                    Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
                },
                callSettings);

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
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
        public virtual stt::Task<Group> UpdateGroupAsync(
            UpdateGroupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
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
        public virtual stt::Task<Group> UpdateGroupAsync(
            UpdateGroupRequest request,
            st::CancellationToken cancellationToken) => UpdateGroupAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
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
        public virtual Group UpdateGroup(
            UpdateGroupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// The group to delete. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteGroupAsync(
            GroupName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteGroupAsync(
                new DeleteGroupRequest
                {
                    GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// The group to delete. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteGroupAsync(
            GroupName name,
            st::CancellationToken cancellationToken) => DeleteGroupAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// The group to delete. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteGroup(
            GroupName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteGroup(
                new DeleteGroupRequest
                {
                    GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// The group to delete. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteGroupAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteGroupAsync(
                new DeleteGroupRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// The group to delete. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteGroupAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteGroupAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// The group to delete. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteGroup(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteGroup(
                new DeleteGroupRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an existing group.
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
        public virtual stt::Task DeleteGroupAsync(
            DeleteGroupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing group.
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
        public virtual stt::Task DeleteGroupAsync(
            DeleteGroupRequest request,
            st::CancellationToken cancellationToken) => DeleteGroupAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteGroup(
            DeleteGroupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="name">
        /// The group whose members are listed. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
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
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResource"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembersAsync(
            GroupName name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListGroupMembersAsync(
                new ListGroupMembersRequest
                {
                    GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="name">
        /// The group whose members are listed. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
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
        /// A pageable sequence of <see cref="ga::MonitoredResource"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembers(
            GroupName name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListGroupMembers(
                new ListGroupMembersRequest
                {
                    GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="name">
        /// The group whose members are listed. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
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
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResource"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembersAsync(
            string name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListGroupMembersAsync(
                new ListGroupMembersRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="name">
        /// The group whose members are listed. The format is
        /// `"projects/{project_id_or_number}/groups/{group_id}"`.
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
        /// A pageable sequence of <see cref="ga::MonitoredResource"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembers(
            string name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListGroupMembers(
                new ListGroupMembersRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResource"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembersAsync(
            ListGroupMembersRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ga::MonitoredResource"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembers(
            ListGroupMembersRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// GroupService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class GroupServiceClientImpl : GroupServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListGroupsRequest, ListGroupsResponse> _callListGroups;
        private readonly gaxgrpc::ApiCall<GetGroupRequest, Group> _callGetGroup;
        private readonly gaxgrpc::ApiCall<CreateGroupRequest, Group> _callCreateGroup;
        private readonly gaxgrpc::ApiCall<UpdateGroupRequest, Group> _callUpdateGroup;
        private readonly gaxgrpc::ApiCall<DeleteGroupRequest, pbwkt::Empty> _callDeleteGroup;
        private readonly gaxgrpc::ApiCall<ListGroupMembersRequest, ListGroupMembersResponse> _callListGroupMembers;

        /// <summary>
        /// Constructs a client wrapper for the GroupService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GroupServiceSettings"/> used within this client </param>
        public GroupServiceClientImpl(GroupService.GroupServiceClient grpcClient, GroupServiceSettings settings)
        {
            GrpcClient = grpcClient;
            GroupServiceSettings effectiveSettings = settings ?? GroupServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListGroups = clientHelper.BuildApiCall<ListGroupsRequest, ListGroupsResponse>(
                GrpcClient.ListGroupsAsync, GrpcClient.ListGroups, effectiveSettings.ListGroupsSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetGroup = clientHelper.BuildApiCall<GetGroupRequest, Group>(
                GrpcClient.GetGroupAsync, GrpcClient.GetGroup, effectiveSettings.GetGroupSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateGroup = clientHelper.BuildApiCall<CreateGroupRequest, Group>(
                GrpcClient.CreateGroupAsync, GrpcClient.CreateGroup, effectiveSettings.CreateGroupSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callUpdateGroup = clientHelper.BuildApiCall<UpdateGroupRequest, Group>(
                GrpcClient.UpdateGroupAsync, GrpcClient.UpdateGroup, effectiveSettings.UpdateGroupSettings)
                .WithGoogleRequestParam("group.name", request => request.Group?.Name);
            _callDeleteGroup = clientHelper.BuildApiCall<DeleteGroupRequest, pbwkt::Empty>(
                GrpcClient.DeleteGroupAsync, GrpcClient.DeleteGroup, effectiveSettings.DeleteGroupSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListGroupMembers = clientHelper.BuildApiCall<ListGroupMembersRequest, ListGroupMembersResponse>(
                GrpcClient.ListGroupMembersAsync, GrpcClient.ListGroupMembers, effectiveSettings.ListGroupMembersSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListGroups);
            Modify_ListGroupsApiCall(ref _callListGroups);
            Modify_ApiCall(ref _callGetGroup);
            Modify_GetGroupApiCall(ref _callGetGroup);
            Modify_ApiCall(ref _callCreateGroup);
            Modify_CreateGroupApiCall(ref _callCreateGroup);
            Modify_ApiCall(ref _callUpdateGroup);
            Modify_UpdateGroupApiCall(ref _callUpdateGroup);
            Modify_ApiCall(ref _callDeleteGroup);
            Modify_DeleteGroupApiCall(ref _callDeleteGroup);
            Modify_ApiCall(ref _callListGroupMembers);
            Modify_ListGroupMembersApiCall(ref _callListGroupMembers);
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
        partial void Modify_ListGroupsApiCall(ref gaxgrpc::ApiCall<ListGroupsRequest, ListGroupsResponse> call);
        partial void Modify_GetGroupApiCall(ref gaxgrpc::ApiCall<GetGroupRequest, Group> call);
        partial void Modify_CreateGroupApiCall(ref gaxgrpc::ApiCall<CreateGroupRequest, Group> call);
        partial void Modify_UpdateGroupApiCall(ref gaxgrpc::ApiCall<UpdateGroupRequest, Group> call);
        partial void Modify_DeleteGroupApiCall(ref gaxgrpc::ApiCall<DeleteGroupRequest, pbwkt::Empty> call);
        partial void Modify_ListGroupMembersApiCall(ref gaxgrpc::ApiCall<ListGroupMembersRequest, ListGroupMembersResponse> call);
        partial void OnConstruction(GroupService.GroupServiceClient grpcClient, GroupServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC GroupService client.
        /// </summary>
        public override GroupService.GroupServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListGroupsRequest(ref ListGroupsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetGroupRequest(ref GetGroupRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateGroupRequest(ref CreateGroupRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateGroupRequest(ref UpdateGroupRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteGroupRequest(ref DeleteGroupRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListGroupMembersRequest(ref ListGroupMembersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Group"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(
            ListGroupsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGroupsRequest, ListGroupsResponse, Group>(_callListGroups, request, callSettings);
        }

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Group"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(
            ListGroupsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGroupsRequest, ListGroupsResponse, Group>(_callListGroups, request, callSettings);
        }

        /// <summary>
        /// Gets a single group.
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
        public override stt::Task<Group> GetGroupAsync(
            GetGroupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGroupRequest(ref request, ref callSettings);
            return _callGetGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a single group.
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
        public override Group GetGroup(
            GetGroupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGroupRequest(ref request, ref callSettings);
            return _callGetGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new group.
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
        public override stt::Task<Group> CreateGroupAsync(
            CreateGroupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGroupRequest(ref request, ref callSettings);
            return _callCreateGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new group.
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
        public override Group CreateGroup(
            CreateGroupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGroupRequest(ref request, ref callSettings);
            return _callCreateGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
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
        public override stt::Task<Group> UpdateGroupAsync(
            UpdateGroupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGroupRequest(ref request, ref callSettings);
            return _callUpdateGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
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
        public override Group UpdateGroup(
            UpdateGroupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGroupRequest(ref request, ref callSettings);
            return _callUpdateGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing group.
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
        public override stt::Task DeleteGroupAsync(
            DeleteGroupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGroupRequest(ref request, ref callSettings);
            return _callDeleteGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteGroup(
            DeleteGroupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGroupRequest(ref request, ref callSettings);
            _callDeleteGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResource"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembersAsync(
            ListGroupMembersRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGroupMembersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGroupMembersRequest, ListGroupMembersResponse, ga::MonitoredResource>(_callListGroupMembers, request, callSettings);
        }

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ga::MonitoredResource"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembers(
            ListGroupMembersRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGroupMembersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGroupMembersRequest, ListGroupMembersResponse, ga::MonitoredResource>(_callListGroupMembers, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListGroupsRequest : gaxgrpc::IPageRequest { }
    public partial class ListGroupsResponse : gaxgrpc::IPageResponse<Group>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Group> GetEnumerator() => Group.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGroupMembersRequest : gaxgrpc::IPageRequest { }
    public partial class ListGroupMembersResponse : gaxgrpc::IPageResponse<ga::MonitoredResource>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<ga::MonitoredResource> GetEnumerator() => Members.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
