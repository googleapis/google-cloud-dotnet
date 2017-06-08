// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.ErrorReporting.V1Beta1
{
    /// <summary>
    /// Settings for a <see cref="ErrorGroupServiceClient"/>.
    /// </summary>
    public sealed partial class ErrorGroupServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ErrorGroupServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ErrorGroupServiceSettings"/>.
        /// </returns>
        public static ErrorGroupServiceSettings GetDefault() => new ErrorGroupServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ErrorGroupServiceSettings"/> object with default settings.
        /// </summary>
        public ErrorGroupServiceSettings() { }

        private ErrorGroupServiceSettings(ErrorGroupServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetGroupSettings = existing.GetGroupSettings;
            UpdateGroupSettings = existing.UpdateGroupSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ErrorGroupServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ErrorGroupServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="ErrorGroupServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ErrorGroupServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ErrorGroupServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ErrorGroupServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="ErrorGroupServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ErrorGroupServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ErrorGroupServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(20000),
            maxDelay: TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ErrorGroupServiceClient.GetGroup</c> and <c>ErrorGroupServiceClient.GetGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ErrorGroupServiceClient.GetGroup</c> and
        /// <c>ErrorGroupServiceClient.GetGroupAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetGroupSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ErrorGroupServiceClient.UpdateGroup</c> and <c>ErrorGroupServiceClient.UpdateGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ErrorGroupServiceClient.UpdateGroup</c> and
        /// <c>ErrorGroupServiceClient.UpdateGroupAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings UpdateGroupSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ErrorGroupServiceSettings"/> object.</returns>
        public ErrorGroupServiceSettings Clone() => new ErrorGroupServiceSettings(this);
    }

    /// <summary>
    /// ErrorGroupService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ErrorGroupServiceClient
    {
        /// <summary>
        /// The default endpoint for the ErrorGroupService service, which is a host of "clouderrorreporting.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("clouderrorreporting.googleapis.com", 443);

        /// <summary>
        /// The default ErrorGroupService scopes.
        /// </summary>
        /// <remarks>
        /// The default ErrorGroupService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="ErrorGroupServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ErrorGroupServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ErrorGroupServiceClient"/>.</returns>
        public static async Task<ErrorGroupServiceClient> CreateAsync(ServiceEndpoint endpoint = null, ErrorGroupServiceSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ErrorGroupServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ErrorGroupServiceSettings"/>.</param>
        /// <returns>The created <see cref="ErrorGroupServiceClient"/>.</returns>
        public static ErrorGroupServiceClient Create(ServiceEndpoint endpoint = null, ErrorGroupServiceSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ErrorGroupServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ErrorGroupServiceSettings"/>.</param>
        /// <returns>The created <see cref="ErrorGroupServiceClient"/>.</returns>
        public static ErrorGroupServiceClient Create(Channel channel, ErrorGroupServiceSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            ErrorGroupService.ErrorGroupServiceClient grpcClient = new ErrorGroupService.ErrorGroupServiceClient(channel);
            return new ErrorGroupServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, ErrorGroupServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, ErrorGroupServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, ErrorGroupServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, ErrorGroupServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ErrorGroupService client.
        /// </summary>
        public virtual ErrorGroupService.ErrorGroupServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Get the specified group.
        /// </summary>
        /// <param name="groupName">
        /// [Required] The group resource name. Written as
        /// &lt;code&gt;projects/&lt;var&gt;projectID&lt;/var&gt;/groups/&lt;var&gt;group_name&lt;/var&gt;&lt;/code&gt;.
        /// Call
        /// &lt;a href="/error-reporting/reference/rest/v1beta1/projects.groupStats/list"&gt;
        /// &lt;code&gt;groupStats.list&lt;/code&gt;&lt;/a&gt; to return a list of groups belonging to
        /// this project.
        ///
        /// Example: &lt;code&gt;projects/my-project-123/groups/my-group&lt;/code&gt;
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ErrorGroup> GetGroupAsync(
            GroupName groupName,
            CallSettings callSettings = null) => GetGroupAsync(
                new GetGroupRequest
                {
                    GroupNameAsGroupName = GaxPreconditions.CheckNotNull(groupName, nameof(groupName)),
                },
                callSettings);

        /// <summary>
        /// Get the specified group.
        /// </summary>
        /// <param name="groupName">
        /// [Required] The group resource name. Written as
        /// &lt;code&gt;projects/&lt;var&gt;projectID&lt;/var&gt;/groups/&lt;var&gt;group_name&lt;/var&gt;&lt;/code&gt;.
        /// Call
        /// &lt;a href="/error-reporting/reference/rest/v1beta1/projects.groupStats/list"&gt;
        /// &lt;code&gt;groupStats.list&lt;/code&gt;&lt;/a&gt; to return a list of groups belonging to
        /// this project.
        ///
        /// Example: &lt;code&gt;projects/my-project-123/groups/my-group&lt;/code&gt;
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ErrorGroup> GetGroupAsync(
            GroupName groupName,
            CancellationToken cancellationToken) => GetGroupAsync(
                groupName,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the specified group.
        /// </summary>
        /// <param name="groupName">
        /// [Required] The group resource name. Written as
        /// &lt;code&gt;projects/&lt;var&gt;projectID&lt;/var&gt;/groups/&lt;var&gt;group_name&lt;/var&gt;&lt;/code&gt;.
        /// Call
        /// &lt;a href="/error-reporting/reference/rest/v1beta1/projects.groupStats/list"&gt;
        /// &lt;code&gt;groupStats.list&lt;/code&gt;&lt;/a&gt; to return a list of groups belonging to
        /// this project.
        ///
        /// Example: &lt;code&gt;projects/my-project-123/groups/my-group&lt;/code&gt;
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ErrorGroup GetGroup(
            GroupName groupName,
            CallSettings callSettings = null) => GetGroup(
                new GetGroupRequest
                {
                    GroupNameAsGroupName = GaxPreconditions.CheckNotNull(groupName, nameof(groupName)),
                },
                callSettings);

        /// <summary>
        /// Get the specified group.
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
        public virtual Task<ErrorGroup> GetGroupAsync(
            GetGroupRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the specified group.
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
        public virtual ErrorGroup GetGroup(
            GetGroupRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Replace the data for the specified group.
        /// Fails if the group does not exist.
        /// </summary>
        /// <param name="group">
        /// [Required] The group which replaces the resource on the server.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ErrorGroup> UpdateGroupAsync(
            ErrorGroup group,
            CallSettings callSettings = null) => UpdateGroupAsync(
                new UpdateGroupRequest
                {
                    Group = GaxPreconditions.CheckNotNull(group, nameof(group)),
                },
                callSettings);

        /// <summary>
        /// Replace the data for the specified group.
        /// Fails if the group does not exist.
        /// </summary>
        /// <param name="group">
        /// [Required] The group which replaces the resource on the server.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ErrorGroup> UpdateGroupAsync(
            ErrorGroup group,
            CancellationToken cancellationToken) => UpdateGroupAsync(
                group,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Replace the data for the specified group.
        /// Fails if the group does not exist.
        /// </summary>
        /// <param name="group">
        /// [Required] The group which replaces the resource on the server.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ErrorGroup UpdateGroup(
            ErrorGroup group,
            CallSettings callSettings = null) => UpdateGroup(
                new UpdateGroupRequest
                {
                    Group = GaxPreconditions.CheckNotNull(group, nameof(group)),
                },
                callSettings);

        /// <summary>
        /// Replace the data for the specified group.
        /// Fails if the group does not exist.
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
        public virtual Task<ErrorGroup> UpdateGroupAsync(
            UpdateGroupRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Replace the data for the specified group.
        /// Fails if the group does not exist.
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
        public virtual ErrorGroup UpdateGroup(
            UpdateGroupRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// ErrorGroupService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ErrorGroupServiceClientImpl : ErrorGroupServiceClient
    {
        private readonly ApiCall<GetGroupRequest, ErrorGroup> _callGetGroup;
        private readonly ApiCall<UpdateGroupRequest, ErrorGroup> _callUpdateGroup;

        /// <summary>
        /// Constructs a client wrapper for the ErrorGroupService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ErrorGroupServiceSettings"/> used within this client </param>
        public ErrorGroupServiceClientImpl(ErrorGroupService.ErrorGroupServiceClient grpcClient, ErrorGroupServiceSettings settings)
        {
            this.GrpcClient = grpcClient;
            ErrorGroupServiceSettings effectiveSettings = settings ?? ErrorGroupServiceSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callGetGroup = clientHelper.BuildApiCall<GetGroupRequest, ErrorGroup>(
                GrpcClient.GetGroupAsync, GrpcClient.GetGroup, effectiveSettings.GetGroupSettings);
            _callUpdateGroup = clientHelper.BuildApiCall<UpdateGroupRequest, ErrorGroup>(
                GrpcClient.UpdateGroupAsync, GrpcClient.UpdateGroup, effectiveSettings.UpdateGroupSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(ErrorGroupService.ErrorGroupServiceClient grpcClient, ErrorGroupServiceSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ErrorGroupService client.
        /// </summary>
        public override ErrorGroupService.ErrorGroupServiceClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_GetGroupRequest(ref GetGroupRequest request, ref CallSettings settings);
        partial void Modify_UpdateGroupRequest(ref UpdateGroupRequest request, ref CallSettings settings);

        /// <summary>
        /// Get the specified group.
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
        public override Task<ErrorGroup> GetGroupAsync(
            GetGroupRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetGroupRequest(ref request, ref callSettings);
            return _callGetGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Get the specified group.
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
        public override ErrorGroup GetGroup(
            GetGroupRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetGroupRequest(ref request, ref callSettings);
            return _callGetGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Replace the data for the specified group.
        /// Fails if the group does not exist.
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
        public override Task<ErrorGroup> UpdateGroupAsync(
            UpdateGroupRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateGroupRequest(ref request, ref callSettings);
            return _callUpdateGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Replace the data for the specified group.
        /// Fails if the group does not exist.
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
        public override ErrorGroup UpdateGroup(
            UpdateGroupRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateGroupRequest(ref request, ref callSettings);
            return _callUpdateGroup.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

}
