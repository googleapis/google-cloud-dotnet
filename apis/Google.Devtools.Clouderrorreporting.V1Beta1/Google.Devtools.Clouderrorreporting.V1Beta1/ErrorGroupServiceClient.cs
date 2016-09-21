// Copyright 2016 Google Inc. All Rights Reserved.
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
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Devtools.Clouderrorreporting.V1Beta1
{

    /// <summary>
    /// Extension methods to assist with using <see cref="ErrorGroupServiceClient"/>.
    /// </summary>
    public static partial class ErrorGroupServiceExtensions
    {
        /// <summary>
        /// Wrap a GRPC ErrorGroupService client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="ErrorGroupServiceSettings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="ErrorGroupServiceClient"/> that wraps the specified GRPC client.</returns>
        public static ErrorGroupServiceClient ToClient(
            this ErrorGroupService.ErrorGroupServiceClient grpcClient,
            ErrorGroupServiceSettings settings = null
        ) => new ErrorGroupServiceClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a ErrorGroupService wrapper.
    /// </summary>
    public sealed partial class ErrorGroupServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ErrorGroupServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default ErrorGroupServiceSettings.</returns>
        public static ErrorGroupServiceSettings GetDefault() => new ErrorGroupServiceSettings();

        /// <summary>
        /// Constructs a new ErrorGroupServiceSettings object with default settings.
        /// </summary>
        public ErrorGroupServiceSettings() { }

        private ErrorGroupServiceSettings(ErrorGroupServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetGroupSettings = existing.GetGroupSettings?.Clone();
            UpdateGroupSettings = existing.UpdateGroupSettings?.Clone();
        }

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
        /// <returns>The "Default" retry backoff for <see cref="ErrorGroupServiceClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ErrorGroupServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(100),
            DelayMultiplier = 1.3,
            MaxDelay = TimeSpan.FromMilliseconds(60000),
        };

        /// <summary>
        /// "Default" timeout backoff for <see cref="ErrorGroupServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" timeout backoff for <see cref="ErrorGroupServiceClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ErrorGroupServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(20000),
            DelayMultiplier = 1.0,
            MaxDelay = TimeSpan.FromMilliseconds(20000),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="ErrorGroupServiceClient.GetGroup"/> and <see cref="ErrorGroupServiceClient.GetGroupAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="ErrorGroupServiceClient.GetGroup"/> and
        /// <see cref="ErrorGroupServiceClient.GetGroupAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings GetGroupSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="ErrorGroupServiceClient.UpdateGroup"/> and <see cref="ErrorGroupServiceClient.UpdateGroupAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="ErrorGroupServiceClient.UpdateGroup"/> and
        /// <see cref="ErrorGroupServiceClient.UpdateGroupAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings UpdateGroupSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };


        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of ErrorGroupService settings.</returns>
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
        /// The default ErrorGroupService scopes
        /// </summary>
        /// <remarks>
        /// The default ErrorGroupService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        /// <summary>
        /// Path template for a group resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>group</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate GroupTemplate { get; } = new PathTemplate("projects/{project}/groups/{group}");

        /// <summary>
        /// Creates a group resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <returns>The full group resource name.</returns>
        public static string FormatGroupName(string projectId, string groupId) => GroupTemplate.Expand(projectId, groupId);

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
        /// The underlying GRPC ErrorGroupService client.
        /// </summary>
        public virtual ErrorGroupService.ErrorGroupServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<ErrorGroup> GetGroupAsync(
            string groupName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<ErrorGroup> GetGroupAsync(
            string groupName,
            CancellationToken cancellationToken) => GetGroupAsync(
                groupName,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        ///
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ErrorGroup GetGroup(
            string groupName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="group"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<ErrorGroup> UpdateGroupAsync(
            ErrorGroup group,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="group"></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<ErrorGroup> UpdateGroupAsync(
            ErrorGroup group,
            CancellationToken cancellationToken) => UpdateGroupAsync(
                group,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        ///
        /// </summary>
        /// <param name="group"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ErrorGroup UpdateGroup(
            ErrorGroup group,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class ErrorGroupServiceClientImpl : ErrorGroupServiceClient
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<GetGroupRequest, ErrorGroup> _callGetGroup;
        private readonly ApiCall<UpdateGroupRequest, ErrorGroup> _callUpdateGroup;

        public ErrorGroupServiceClientImpl(ErrorGroupService.ErrorGroupServiceClient grpcClient, ErrorGroupServiceSettings settings)
        {
            this.GrpcClient = grpcClient;
            ErrorGroupServiceSettings effectiveSettings = settings ?? ErrorGroupServiceSettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callGetGroup = _clientHelper.BuildApiCall<GetGroupRequest, ErrorGroup>(
                GrpcClient.GetGroupAsync, GrpcClient.GetGroup, effectiveSettings.GetGroupSettings);
            _callUpdateGroup = _clientHelper.BuildApiCall<UpdateGroupRequest, ErrorGroup>(
                GrpcClient.UpdateGroupAsync, GrpcClient.UpdateGroup, effectiveSettings.UpdateGroupSettings);
        }

        public override ErrorGroupService.ErrorGroupServiceClient GrpcClient { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<ErrorGroup> GetGroupAsync(
            string groupName,
            CallSettings callSettings = null) => _callGetGroup.Async(
                new GetGroupRequest
                {
                    GroupName = groupName,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ErrorGroup GetGroup(
            string groupName,
            CallSettings callSettings = null) => _callGetGroup.Sync(
                new GetGroupRequest
                {
                    GroupName = groupName,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="group"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<ErrorGroup> UpdateGroupAsync(
            ErrorGroup group,
            CallSettings callSettings = null) => _callUpdateGroup.Async(
                new UpdateGroupRequest
                {
                    Group = group,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="group"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ErrorGroup UpdateGroup(
            ErrorGroup group,
            CallSettings callSettings = null) => _callUpdateGroup.Sync(
                new UpdateGroupRequest
                {
                    Group = group,
                },
                callSettings);

    }

    // Partial classes to enable page-streaming

}