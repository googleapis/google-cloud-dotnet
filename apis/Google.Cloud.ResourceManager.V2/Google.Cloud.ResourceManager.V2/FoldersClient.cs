// Copyright 2017, Google LLC All rights reserved.
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
using Google.Cloud.Iam.V1;
using Google.LongRunning;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.ResourceManager.V2
{
    /// <summary>
    /// Settings for a <see cref="FoldersClient"/>.
    /// </summary>
    public sealed partial class FoldersSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="FoldersSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="FoldersSettings"/>.
        /// </returns>
        public static FoldersSettings GetDefault() => new FoldersSettings();

        /// <summary>
        /// Constructs a new <see cref="FoldersSettings"/> object with default settings.
        /// </summary>
        public FoldersSettings() { }

        private FoldersSettings(FoldersSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListFoldersSettings = existing.ListFoldersSettings;
            SearchFoldersSettings = existing.SearchFoldersSettings;
            GetFolderSettings = existing.GetFolderSettings;
            CreateFolderSettings = existing.CreateFolderSettings;
            UpdateFolderSettings = existing.UpdateFolderSettings;
            MoveFolderSettings = existing.MoveFolderSettings;
            DeleteFolderSettings = existing.DeleteFolderSettings;
            UndeleteFolderSettings = existing.UndeleteFolderSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FoldersSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="FoldersClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="FoldersClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="FoldersClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="FoldersClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="FoldersClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 30000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(30000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="FoldersClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="FoldersClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="FoldersClient"/> RPC methods is defined as:
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
        /// <c>FoldersClient.ListFolders</c> and <c>FoldersClient.ListFoldersAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FoldersClient.ListFolders</c> and
        /// <c>FoldersClient.ListFoldersAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds</description></item>
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
        public CallSettings ListFoldersSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FoldersClient.SearchFolders</c> and <c>FoldersClient.SearchFoldersAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FoldersClient.SearchFolders</c> and
        /// <c>FoldersClient.SearchFoldersAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds</description></item>
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
        public CallSettings SearchFoldersSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FoldersClient.GetFolder</c> and <c>FoldersClient.GetFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FoldersClient.GetFolder</c> and
        /// <c>FoldersClient.GetFolderAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds</description></item>
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
        public CallSettings GetFolderSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FoldersClient.CreateFolder</c> and <c>FoldersClient.CreateFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FoldersClient.CreateFolder</c> and
        /// <c>FoldersClient.CreateFolderAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds</description></item>
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
        public CallSettings CreateFolderSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FoldersClient.UpdateFolder</c> and <c>FoldersClient.UpdateFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FoldersClient.UpdateFolder</c> and
        /// <c>FoldersClient.UpdateFolderAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds</description></item>
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
        public CallSettings UpdateFolderSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FoldersClient.MoveFolder</c> and <c>FoldersClient.MoveFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FoldersClient.MoveFolder</c> and
        /// <c>FoldersClient.MoveFolderAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds</description></item>
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
        public CallSettings MoveFolderSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FoldersClient.DeleteFolder</c> and <c>FoldersClient.DeleteFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FoldersClient.DeleteFolder</c> and
        /// <c>FoldersClient.DeleteFolderAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds</description></item>
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
        public CallSettings DeleteFolderSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FoldersClient.UndeleteFolder</c> and <c>FoldersClient.UndeleteFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FoldersClient.UndeleteFolder</c> and
        /// <c>FoldersClient.UndeleteFolderAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds</description></item>
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
        public CallSettings UndeleteFolderSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FoldersClient.GetIamPolicy</c> and <c>FoldersClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FoldersClient.GetIamPolicy</c> and
        /// <c>FoldersClient.GetIamPolicyAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds</description></item>
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
        public CallSettings GetIamPolicySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FoldersClient.SetIamPolicy</c> and <c>FoldersClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FoldersClient.SetIamPolicy</c> and
        /// <c>FoldersClient.SetIamPolicyAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds</description></item>
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
        public CallSettings SetIamPolicySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FoldersClient.TestIamPermissions</c> and <c>FoldersClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FoldersClient.TestIamPermissions</c> and
        /// <c>FoldersClient.TestIamPermissionsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds</description></item>
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
        public CallSettings TestIamPermissionsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="FoldersSettings"/> object.</returns>
        public FoldersSettings Clone() => new FoldersSettings(this);
    }

    /// <summary>
    /// Folders client wrapper, for convenient use.
    /// </summary>
    public abstract partial class FoldersClient
    {
        /// <summary>
        /// The default endpoint for the Folders service, which is a host of "cloudresourcemanager.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("cloudresourcemanager.googleapis.com", 443);

        /// <summary>
        /// The default Folders scopes.
        /// </summary>
        /// <remarks>
        /// The default Folders scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform.read-only"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="FoldersClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="FoldersSettings"/>.</param>
        /// <returns>The task representing the created <see cref="FoldersClient"/>.</returns>
        public static async Task<FoldersClient> CreateAsync(ServiceEndpoint endpoint = null, FoldersSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="FoldersClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="FoldersSettings"/>.</param>
        /// <returns>The created <see cref="FoldersClient"/>.</returns>
        public static FoldersClient Create(ServiceEndpoint endpoint = null, FoldersSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="FoldersClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="FoldersSettings"/>.</param>
        /// <returns>The created <see cref="FoldersClient"/>.</returns>
        public static FoldersClient Create(Channel channel, FoldersSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            Folders.FoldersClient grpcClient = new Folders.FoldersClient(channel);
            return new FoldersClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, FoldersSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, FoldersSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, FoldersSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, FoldersSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Folders client.
        /// </summary>
        public virtual Folders.FoldersClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Lists the Folders that are direct descendants of supplied parent resource.
        /// List provides a strongly consistent view of the Folders underneath
        /// the specified parent resource.
        /// List returns Folders sorted based upon the (ascending) lexical ordering
        /// of their display_name.
        /// The caller must have `resourcemanager.folders.list` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the Organization or Folder whose Folders are
        /// being listed.
        /// Must be of the form `folders/{folder_id}` or `organizations/{org_id}`.
        /// Access to this method is controlled by checking the
        /// `resourcemanager.folders.list` permission on the `parent`.
        /// </param>
        /// <param name="showDeleted">
        /// Controls whether Folders in the [DELETE_REQUESTED} state should
        /// be returned.
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
        /// A pageable asynchronous sequence of <see cref="Folder"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListFoldersResponse, Folder> ListFoldersAsync(
            ParentNameOneof parent,
            bool? showDeleted,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListFoldersAsync(
                new ListFoldersRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    ShowDeleted = showDeleted ?? false, // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the Folders that are direct descendants of supplied parent resource.
        /// List provides a strongly consistent view of the Folders underneath
        /// the specified parent resource.
        /// List returns Folders sorted based upon the (ascending) lexical ordering
        /// of their display_name.
        /// The caller must have `resourcemanager.folders.list` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the Organization or Folder whose Folders are
        /// being listed.
        /// Must be of the form `folders/{folder_id}` or `organizations/{org_id}`.
        /// Access to this method is controlled by checking the
        /// `resourcemanager.folders.list` permission on the `parent`.
        /// </param>
        /// <param name="showDeleted">
        /// Controls whether Folders in the [DELETE_REQUESTED} state should
        /// be returned.
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
        /// A pageable sequence of <see cref="Folder"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListFoldersResponse, Folder> ListFolders(
            ParentNameOneof parent,
            bool? showDeleted,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListFolders(
                new ListFoldersRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    ShowDeleted = showDeleted ?? false, // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the Folders that are direct descendants of supplied parent resource.
        /// List provides a strongly consistent view of the Folders underneath
        /// the specified parent resource.
        /// List returns Folders sorted based upon the (ascending) lexical ordering
        /// of their display_name.
        /// The caller must have `resourcemanager.folders.list` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the Organization or Folder whose Folders are
        /// being listed.
        /// Must be of the form `folders/{folder_id}` or `organizations/{org_id}`.
        /// Access to this method is controlled by checking the
        /// `resourcemanager.folders.list` permission on the `parent`.
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
        /// A pageable asynchronous sequence of <see cref="Folder"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListFoldersResponse, Folder> ListFoldersAsync(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListFoldersAsync(
                new ListFoldersRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the Folders that are direct descendants of supplied parent resource.
        /// List provides a strongly consistent view of the Folders underneath
        /// the specified parent resource.
        /// List returns Folders sorted based upon the (ascending) lexical ordering
        /// of their display_name.
        /// The caller must have `resourcemanager.folders.list` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the Organization or Folder whose Folders are
        /// being listed.
        /// Must be of the form `folders/{folder_id}` or `organizations/{org_id}`.
        /// Access to this method is controlled by checking the
        /// `resourcemanager.folders.list` permission on the `parent`.
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
        /// A pageable sequence of <see cref="Folder"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListFoldersResponse, Folder> ListFolders(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListFolders(
                new ListFoldersRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the Folders that are direct descendants of supplied parent resource.
        /// List provides a strongly consistent view of the Folders underneath
        /// the specified parent resource.
        /// List returns Folders sorted based upon the (ascending) lexical ordering
        /// of their display_name.
        /// The caller must have `resourcemanager.folders.list` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Folder"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListFoldersResponse, Folder> ListFoldersAsync(
            ListFoldersRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the Folders that are direct descendants of supplied parent resource.
        /// List provides a strongly consistent view of the Folders underneath
        /// the specified parent resource.
        /// List returns Folders sorted based upon the (ascending) lexical ordering
        /// of their display_name.
        /// The caller must have `resourcemanager.folders.list` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Folder"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListFoldersResponse, Folder> ListFolders(
            ListFoldersRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Search for folders that match specific filter criteria.
        /// Search provides an eventually consistent view of the folders a user has
        /// access to which meet the specified filter criteria.
        ///
        /// This will only return folders on which the caller has the
        /// permission `resourcemanager.folders.get`.
        /// </summary>
        /// <param name="query">
        /// Search criteria used to select the Folders to return.
        /// If no search criteria is specified then all accessible folders will be
        /// returned.
        ///
        /// Query expressions can be used to restrict results based upon displayName,
        /// lifecycleState and parent, where the operators `=`, `NOT`, `AND` and `OR`
        /// can be used along with the suffix wildcard symbol `*`.
        ///
        /// Some example queries are:
        /// |Query|Description|
        /// |------|-----------|
        /// |displayName=Test*|Folders whose display name starts with "Test".|
        /// |lifecycleState=ACTIVE|Folders whose lifecycleState is ACTIVE.|
        /// |parent=folders/123|Folders whose parent is "folders/123".|
        /// |parent=folders/123 AND lifecycleState=ACTIVE|Active folders whose
        /// parent is "folders/123".|
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
        /// A pageable asynchronous sequence of <see cref="Folder"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<SearchFoldersResponse, Folder> SearchFoldersAsync(
            string query,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => SearchFoldersAsync(
                new SearchFoldersRequest
                {
                    Query = query ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Search for folders that match specific filter criteria.
        /// Search provides an eventually consistent view of the folders a user has
        /// access to which meet the specified filter criteria.
        ///
        /// This will only return folders on which the caller has the
        /// permission `resourcemanager.folders.get`.
        /// </summary>
        /// <param name="query">
        /// Search criteria used to select the Folders to return.
        /// If no search criteria is specified then all accessible folders will be
        /// returned.
        ///
        /// Query expressions can be used to restrict results based upon displayName,
        /// lifecycleState and parent, where the operators `=`, `NOT`, `AND` and `OR`
        /// can be used along with the suffix wildcard symbol `*`.
        ///
        /// Some example queries are:
        /// |Query|Description|
        /// |------|-----------|
        /// |displayName=Test*|Folders whose display name starts with "Test".|
        /// |lifecycleState=ACTIVE|Folders whose lifecycleState is ACTIVE.|
        /// |parent=folders/123|Folders whose parent is "folders/123".|
        /// |parent=folders/123 AND lifecycleState=ACTIVE|Active folders whose
        /// parent is "folders/123".|
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
        /// A pageable sequence of <see cref="Folder"/> resources.
        /// </returns>
        public virtual PagedEnumerable<SearchFoldersResponse, Folder> SearchFolders(
            string query,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => SearchFolders(
                new SearchFoldersRequest
                {
                    Query = query ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Search for folders that match specific filter criteria.
        /// Search provides an eventually consistent view of the folders a user has
        /// access to which meet the specified filter criteria.
        ///
        /// This will only return folders on which the caller has the
        /// permission `resourcemanager.folders.get`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Folder"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<SearchFoldersResponse, Folder> SearchFoldersAsync(
            SearchFoldersRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Search for folders that match specific filter criteria.
        /// Search provides an eventually consistent view of the folders a user has
        /// access to which meet the specified filter criteria.
        ///
        /// This will only return folders on which the caller has the
        /// permission `resourcemanager.folders.get`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Folder"/> resources.
        /// </returns>
        public virtual PagedEnumerable<SearchFoldersResponse, Folder> SearchFolders(
            SearchFoldersRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves a Folder identified by the supplied resource name.
        /// Valid Folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Folder to retrieve.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Folder> GetFolderAsync(
            FolderName name,
            CallSettings callSettings = null) => GetFolderAsync(
                new GetFolderRequest
                {
                    FolderName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves a Folder identified by the supplied resource name.
        /// Valid Folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Folder to retrieve.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Folder> GetFolderAsync(
            FolderName name,
            CancellationToken cancellationToken) => GetFolderAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a Folder identified by the supplied resource name.
        /// Valid Folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Folder to retrieve.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Folder GetFolder(
            FolderName name,
            CallSettings callSettings = null) => GetFolder(
                new GetFolderRequest
                {
                    FolderName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves a Folder identified by the supplied resource name.
        /// Valid Folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
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
        public virtual Task<Folder> GetFolderAsync(
            GetFolderRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves a Folder identified by the supplied resource name.
        /// Valid Folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
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
        public virtual Folder GetFolder(
            GetFolderRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a Folder in the resource hierarchy.
        /// Returns an Operation which can be used to track the progress of the
        /// folder creation workflow.
        /// Upon success the Operation.response field will be populated with the
        /// created Folder.
        ///
        /// In order to succeed, the addition of this new Folder must not violate
        /// the Folder naming, height or fanout constraints.
        /// + The Folder's display_name must be distinct from all other Folder's that
        /// share its parent.
        /// + The addition of the Folder must not cause the active Folder hierarchy
        /// to exceed a height of 4. Note, the full active + deleted Folder hierarchy
        /// is allowed to reach a height of 8; this provides additional headroom when
        /// moving folders that contain deleted folders.
        /// + The addition of the Folder must not cause the total number of Folders
        /// under its parent to exceed 100.
        ///
        /// If the operation fails due to a folder constraint violation,
        /// a PreconditionFailure explaining the violation will be returned.
        /// If the failure occurs synchronously then the PreconditionFailure
        /// will be returned via the Status.details field and if it occurs
        /// asynchronously then the PreconditionFailure will be returned
        /// via the the Operation.error field.
        ///
        /// The caller must have `resourcemanager.folders.create` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the new Folder's parent.
        /// Must be of the form `folders/{folder_id}` or `organizations/{org_id}`.
        /// </param>
        /// <param name="folder">
        /// The Folder being created, only the display name will be consulted.
        /// All other fields will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> CreateFolderAsync(
            ParentNameOneof parent,
            Folder folder,
            CallSettings callSettings = null) => CreateFolderAsync(
                new CreateFolderRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Folder = GaxPreconditions.CheckNotNull(folder, nameof(folder)),
                },
                callSettings);

        /// <summary>
        /// Creates a Folder in the resource hierarchy.
        /// Returns an Operation which can be used to track the progress of the
        /// folder creation workflow.
        /// Upon success the Operation.response field will be populated with the
        /// created Folder.
        ///
        /// In order to succeed, the addition of this new Folder must not violate
        /// the Folder naming, height or fanout constraints.
        /// + The Folder's display_name must be distinct from all other Folder's that
        /// share its parent.
        /// + The addition of the Folder must not cause the active Folder hierarchy
        /// to exceed a height of 4. Note, the full active + deleted Folder hierarchy
        /// is allowed to reach a height of 8; this provides additional headroom when
        /// moving folders that contain deleted folders.
        /// + The addition of the Folder must not cause the total number of Folders
        /// under its parent to exceed 100.
        ///
        /// If the operation fails due to a folder constraint violation,
        /// a PreconditionFailure explaining the violation will be returned.
        /// If the failure occurs synchronously then the PreconditionFailure
        /// will be returned via the Status.details field and if it occurs
        /// asynchronously then the PreconditionFailure will be returned
        /// via the the Operation.error field.
        ///
        /// The caller must have `resourcemanager.folders.create` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the new Folder's parent.
        /// Must be of the form `folders/{folder_id}` or `organizations/{org_id}`.
        /// </param>
        /// <param name="folder">
        /// The Folder being created, only the display name will be consulted.
        /// All other fields will be ignored.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> CreateFolderAsync(
            ParentNameOneof parent,
            Folder folder,
            CancellationToken cancellationToken) => CreateFolderAsync(
                parent,
                folder,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Folder in the resource hierarchy.
        /// Returns an Operation which can be used to track the progress of the
        /// folder creation workflow.
        /// Upon success the Operation.response field will be populated with the
        /// created Folder.
        ///
        /// In order to succeed, the addition of this new Folder must not violate
        /// the Folder naming, height or fanout constraints.
        /// + The Folder's display_name must be distinct from all other Folder's that
        /// share its parent.
        /// + The addition of the Folder must not cause the active Folder hierarchy
        /// to exceed a height of 4. Note, the full active + deleted Folder hierarchy
        /// is allowed to reach a height of 8; this provides additional headroom when
        /// moving folders that contain deleted folders.
        /// + The addition of the Folder must not cause the total number of Folders
        /// under its parent to exceed 100.
        ///
        /// If the operation fails due to a folder constraint violation,
        /// a PreconditionFailure explaining the violation will be returned.
        /// If the failure occurs synchronously then the PreconditionFailure
        /// will be returned via the Status.details field and if it occurs
        /// asynchronously then the PreconditionFailure will be returned
        /// via the the Operation.error field.
        ///
        /// The caller must have `resourcemanager.folders.create` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the new Folder's parent.
        /// Must be of the form `folders/{folder_id}` or `organizations/{org_id}`.
        /// </param>
        /// <param name="folder">
        /// The Folder being created, only the display name will be consulted.
        /// All other fields will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation CreateFolder(
            ParentNameOneof parent,
            Folder folder,
            CallSettings callSettings = null) => CreateFolder(
                new CreateFolderRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Folder = GaxPreconditions.CheckNotNull(folder, nameof(folder)),
                },
                callSettings);

        /// <summary>
        /// Creates a Folder in the resource hierarchy.
        /// Returns an Operation which can be used to track the progress of the
        /// folder creation workflow.
        /// Upon success the Operation.response field will be populated with the
        /// created Folder.
        ///
        /// In order to succeed, the addition of this new Folder must not violate
        /// the Folder naming, height or fanout constraints.
        /// + The Folder's display_name must be distinct from all other Folder's that
        /// share its parent.
        /// + The addition of the Folder must not cause the active Folder hierarchy
        /// to exceed a height of 4. Note, the full active + deleted Folder hierarchy
        /// is allowed to reach a height of 8; this provides additional headroom when
        /// moving folders that contain deleted folders.
        /// + The addition of the Folder must not cause the total number of Folders
        /// under its parent to exceed 100.
        ///
        /// If the operation fails due to a folder constraint violation,
        /// a PreconditionFailure explaining the violation will be returned.
        /// If the failure occurs synchronously then the PreconditionFailure
        /// will be returned via the Status.details field and if it occurs
        /// asynchronously then the PreconditionFailure will be returned
        /// via the the Operation.error field.
        ///
        /// The caller must have `resourcemanager.folders.create` permission on the
        /// identified parent.
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
        public virtual Task<Operation> CreateFolderAsync(
            CreateFolderRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a Folder in the resource hierarchy.
        /// Returns an Operation which can be used to track the progress of the
        /// folder creation workflow.
        /// Upon success the Operation.response field will be populated with the
        /// created Folder.
        ///
        /// In order to succeed, the addition of this new Folder must not violate
        /// the Folder naming, height or fanout constraints.
        /// + The Folder's display_name must be distinct from all other Folder's that
        /// share its parent.
        /// + The addition of the Folder must not cause the active Folder hierarchy
        /// to exceed a height of 4. Note, the full active + deleted Folder hierarchy
        /// is allowed to reach a height of 8; this provides additional headroom when
        /// moving folders that contain deleted folders.
        /// + The addition of the Folder must not cause the total number of Folders
        /// under its parent to exceed 100.
        ///
        /// If the operation fails due to a folder constraint violation,
        /// a PreconditionFailure explaining the violation will be returned.
        /// If the failure occurs synchronously then the PreconditionFailure
        /// will be returned via the Status.details field and if it occurs
        /// asynchronously then the PreconditionFailure will be returned
        /// via the the Operation.error field.
        ///
        /// The caller must have `resourcemanager.folders.create` permission on the
        /// identified parent.
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
        public virtual Operation CreateFolder(
            CreateFolderRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a Folder, changing its display_name.
        /// Changes to the folder display_name will be rejected if they violate either
        /// the display_name formatting rules or naming constraints described in
        /// the [CreateFolder] documentation.
        /// + The Folder's display name must start and end with a letter or digit,
        /// may contain letters, digits, spaces, hyphens and underscores and can be
        /// no longer than 30 characters. This is captured by the regular expression:
        /// [\p{L}\p{N}]({\p{L}\p{N}_- ]{0,28}[\p{L}\p{N}])?.
        /// The caller must have `resourcemanager.folders.update` permission on the
        /// identified folder.
        ///
        /// If the update fails due to the unique name constraint then a
        /// PreconditionFailure explaining this violation will be returned
        /// in the Status.details field.
        /// </summary>
        /// <param name="folder">
        /// The new definition of the Folder. It must include a
        /// a `name` and `display_name` field. The other fields
        /// will be ignored.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// Only the `display_name` can be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Folder> UpdateFolderAsync(
            Folder folder,
            FieldMask updateMask,
            CallSettings callSettings = null) => UpdateFolderAsync(
                new UpdateFolderRequest
                {
                    Folder = GaxPreconditions.CheckNotNull(folder, nameof(folder)),
                    UpdateMask = GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Updates a Folder, changing its display_name.
        /// Changes to the folder display_name will be rejected if they violate either
        /// the display_name formatting rules or naming constraints described in
        /// the [CreateFolder] documentation.
        /// + The Folder's display name must start and end with a letter or digit,
        /// may contain letters, digits, spaces, hyphens and underscores and can be
        /// no longer than 30 characters. This is captured by the regular expression:
        /// [\p{L}\p{N}]({\p{L}\p{N}_- ]{0,28}[\p{L}\p{N}])?.
        /// The caller must have `resourcemanager.folders.update` permission on the
        /// identified folder.
        ///
        /// If the update fails due to the unique name constraint then a
        /// PreconditionFailure explaining this violation will be returned
        /// in the Status.details field.
        /// </summary>
        /// <param name="folder">
        /// The new definition of the Folder. It must include a
        /// a `name` and `display_name` field. The other fields
        /// will be ignored.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// Only the `display_name` can be updated.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Folder> UpdateFolderAsync(
            Folder folder,
            FieldMask updateMask,
            CancellationToken cancellationToken) => UpdateFolderAsync(
                folder,
                updateMask,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Folder, changing its display_name.
        /// Changes to the folder display_name will be rejected if they violate either
        /// the display_name formatting rules or naming constraints described in
        /// the [CreateFolder] documentation.
        /// + The Folder's display name must start and end with a letter or digit,
        /// may contain letters, digits, spaces, hyphens and underscores and can be
        /// no longer than 30 characters. This is captured by the regular expression:
        /// [\p{L}\p{N}]({\p{L}\p{N}_- ]{0,28}[\p{L}\p{N}])?.
        /// The caller must have `resourcemanager.folders.update` permission on the
        /// identified folder.
        ///
        /// If the update fails due to the unique name constraint then a
        /// PreconditionFailure explaining this violation will be returned
        /// in the Status.details field.
        /// </summary>
        /// <param name="folder">
        /// The new definition of the Folder. It must include a
        /// a `name` and `display_name` field. The other fields
        /// will be ignored.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated.
        /// Only the `display_name` can be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Folder UpdateFolder(
            Folder folder,
            FieldMask updateMask,
            CallSettings callSettings = null) => UpdateFolder(
                new UpdateFolderRequest
                {
                    Folder = GaxPreconditions.CheckNotNull(folder, nameof(folder)),
                    UpdateMask = GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Updates a Folder, changing its display_name.
        /// Changes to the folder display_name will be rejected if they violate either
        /// the display_name formatting rules or naming constraints described in
        /// the [CreateFolder] documentation.
        /// + The Folder's display name must start and end with a letter or digit,
        /// may contain letters, digits, spaces, hyphens and underscores and can be
        /// no longer than 30 characters. This is captured by the regular expression:
        /// [\p{L}\p{N}]({\p{L}\p{N}_- ]{0,28}[\p{L}\p{N}])?.
        /// The caller must have `resourcemanager.folders.update` permission on the
        /// identified folder.
        ///
        /// If the update fails due to the unique name constraint then a
        /// PreconditionFailure explaining this violation will be returned
        /// in the Status.details field.
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
        public virtual Task<Folder> UpdateFolderAsync(
            UpdateFolderRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a Folder, changing its display_name.
        /// Changes to the folder display_name will be rejected if they violate either
        /// the display_name formatting rules or naming constraints described in
        /// the [CreateFolder] documentation.
        /// + The Folder's display name must start and end with a letter or digit,
        /// may contain letters, digits, spaces, hyphens and underscores and can be
        /// no longer than 30 characters. This is captured by the regular expression:
        /// [\p{L}\p{N}]({\p{L}\p{N}_- ]{0,28}[\p{L}\p{N}])?.
        /// The caller must have `resourcemanager.folders.update` permission on the
        /// identified folder.
        ///
        /// If the update fails due to the unique name constraint then a
        /// PreconditionFailure explaining this violation will be returned
        /// in the Status.details field.
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
        public virtual Folder UpdateFolder(
            UpdateFolderRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves a Folder under a new resource parent.
        /// Returns an Operation which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success the Operation.response field will be populated with the
        /// moved Folder.
        /// Upon failure, a FolderOperationError categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// FolderOperationError will be returned via the Status.details field
        /// and if it occurs asynchronously then the FolderOperation will be returned
        /// via the the Operation.error field.
        /// In addition, the Operation.metadata field will be populated with a
        /// FolderOperation message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height
        /// or fanout constraints described in the [CreateFolder] documentation.
        /// The caller must have `resourcemanager.folders.move` permission on the
        /// folder's current and proposed new parent.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Folder to move.
        /// Must be of the form folders/{folder_id}
        /// </param>
        /// <param name="destinationParent">
        /// The resource name of the Folder or Organization to reparent
        /// the folder under.
        /// Must be of the form `folders/{folder_id}` or `organizations/{org_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> MoveFolderAsync(
            FolderName name,
            ParentNameOneof destinationParent,
            CallSettings callSettings = null) => MoveFolderAsync(
                new MoveFolderRequest
                {
                    FolderName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    DestinationParentAsParentNameOneof = GaxPreconditions.CheckNotNull(destinationParent, nameof(destinationParent)),
                },
                callSettings);

        /// <summary>
        /// Moves a Folder under a new resource parent.
        /// Returns an Operation which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success the Operation.response field will be populated with the
        /// moved Folder.
        /// Upon failure, a FolderOperationError categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// FolderOperationError will be returned via the Status.details field
        /// and if it occurs asynchronously then the FolderOperation will be returned
        /// via the the Operation.error field.
        /// In addition, the Operation.metadata field will be populated with a
        /// FolderOperation message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height
        /// or fanout constraints described in the [CreateFolder] documentation.
        /// The caller must have `resourcemanager.folders.move` permission on the
        /// folder's current and proposed new parent.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Folder to move.
        /// Must be of the form folders/{folder_id}
        /// </param>
        /// <param name="destinationParent">
        /// The resource name of the Folder or Organization to reparent
        /// the folder under.
        /// Must be of the form `folders/{folder_id}` or `organizations/{org_id}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> MoveFolderAsync(
            FolderName name,
            ParentNameOneof destinationParent,
            CancellationToken cancellationToken) => MoveFolderAsync(
                name,
                destinationParent,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves a Folder under a new resource parent.
        /// Returns an Operation which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success the Operation.response field will be populated with the
        /// moved Folder.
        /// Upon failure, a FolderOperationError categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// FolderOperationError will be returned via the Status.details field
        /// and if it occurs asynchronously then the FolderOperation will be returned
        /// via the the Operation.error field.
        /// In addition, the Operation.metadata field will be populated with a
        /// FolderOperation message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height
        /// or fanout constraints described in the [CreateFolder] documentation.
        /// The caller must have `resourcemanager.folders.move` permission on the
        /// folder's current and proposed new parent.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Folder to move.
        /// Must be of the form folders/{folder_id}
        /// </param>
        /// <param name="destinationParent">
        /// The resource name of the Folder or Organization to reparent
        /// the folder under.
        /// Must be of the form `folders/{folder_id}` or `organizations/{org_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation MoveFolder(
            FolderName name,
            ParentNameOneof destinationParent,
            CallSettings callSettings = null) => MoveFolder(
                new MoveFolderRequest
                {
                    FolderName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    DestinationParentAsParentNameOneof = GaxPreconditions.CheckNotNull(destinationParent, nameof(destinationParent)),
                },
                callSettings);

        /// <summary>
        /// Moves a Folder under a new resource parent.
        /// Returns an Operation which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success the Operation.response field will be populated with the
        /// moved Folder.
        /// Upon failure, a FolderOperationError categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// FolderOperationError will be returned via the Status.details field
        /// and if it occurs asynchronously then the FolderOperation will be returned
        /// via the the Operation.error field.
        /// In addition, the Operation.metadata field will be populated with a
        /// FolderOperation message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height
        /// or fanout constraints described in the [CreateFolder] documentation.
        /// The caller must have `resourcemanager.folders.move` permission on the
        /// folder's current and proposed new parent.
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
        public virtual Task<Operation> MoveFolderAsync(
            MoveFolderRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves a Folder under a new resource parent.
        /// Returns an Operation which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success the Operation.response field will be populated with the
        /// moved Folder.
        /// Upon failure, a FolderOperationError categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// FolderOperationError will be returned via the Status.details field
        /// and if it occurs asynchronously then the FolderOperation will be returned
        /// via the the Operation.error field.
        /// In addition, the Operation.metadata field will be populated with a
        /// FolderOperation message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height
        /// or fanout constraints described in the [CreateFolder] documentation.
        /// The caller must have `resourcemanager.folders.move` permission on the
        /// folder's current and proposed new parent.
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
        public virtual Operation MoveFolder(
            MoveFolderRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Requests deletion of a Folder. The Folder is moved into the
        /// [DELETE_REQUESTED] state immediately, and is deleted approximately 30 days
        /// later. This method may only be called on an empty Folder in the [ACTIVE]
        /// state, where a Folder is empty if it doesn't contain any Folders or
        /// Projects in the [ACTIVE] state.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// the resource name of the Folder to be deleted.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Folder> DeleteFolderAsync(
            FolderName name,
            CallSettings callSettings = null) => DeleteFolderAsync(
                new DeleteFolderRequest
                {
                    FolderName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Requests deletion of a Folder. The Folder is moved into the
        /// [DELETE_REQUESTED] state immediately, and is deleted approximately 30 days
        /// later. This method may only be called on an empty Folder in the [ACTIVE]
        /// state, where a Folder is empty if it doesn't contain any Folders or
        /// Projects in the [ACTIVE] state.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// the resource name of the Folder to be deleted.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Folder> DeleteFolderAsync(
            FolderName name,
            CancellationToken cancellationToken) => DeleteFolderAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests deletion of a Folder. The Folder is moved into the
        /// [DELETE_REQUESTED] state immediately, and is deleted approximately 30 days
        /// later. This method may only be called on an empty Folder in the [ACTIVE]
        /// state, where a Folder is empty if it doesn't contain any Folders or
        /// Projects in the [ACTIVE] state.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// the resource name of the Folder to be deleted.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Folder DeleteFolder(
            FolderName name,
            CallSettings callSettings = null) => DeleteFolder(
                new DeleteFolderRequest
                {
                    FolderName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Requests deletion of a Folder. The Folder is moved into the
        /// [DELETE_REQUESTED] state immediately, and is deleted approximately 30 days
        /// later. This method may only be called on an empty Folder in the [ACTIVE]
        /// state, where a Folder is empty if it doesn't contain any Folders or
        /// Projects in the [ACTIVE] state.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// the resource name of the Folder to be deleted.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="recursiveDelete">
        /// Instructs DeleteFolderAction to delete a folder even when the folder is not
        /// empty.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Folder> DeleteFolderAsync(
            FolderName name,
            bool? recursiveDelete,
            CallSettings callSettings = null) => DeleteFolderAsync(
                new DeleteFolderRequest
                {
                    FolderName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    RecursiveDelete = recursiveDelete ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Requests deletion of a Folder. The Folder is moved into the
        /// [DELETE_REQUESTED] state immediately, and is deleted approximately 30 days
        /// later. This method may only be called on an empty Folder in the [ACTIVE]
        /// state, where a Folder is empty if it doesn't contain any Folders or
        /// Projects in the [ACTIVE] state.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// the resource name of the Folder to be deleted.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="recursiveDelete">
        /// Instructs DeleteFolderAction to delete a folder even when the folder is not
        /// empty.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Folder> DeleteFolderAsync(
            FolderName name,
            bool? recursiveDelete,
            CancellationToken cancellationToken) => DeleteFolderAsync(
                name,
                recursiveDelete,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests deletion of a Folder. The Folder is moved into the
        /// [DELETE_REQUESTED] state immediately, and is deleted approximately 30 days
        /// later. This method may only be called on an empty Folder in the [ACTIVE]
        /// state, where a Folder is empty if it doesn't contain any Folders or
        /// Projects in the [ACTIVE] state.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// the resource name of the Folder to be deleted.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="recursiveDelete">
        /// Instructs DeleteFolderAction to delete a folder even when the folder is not
        /// empty.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Folder DeleteFolder(
            FolderName name,
            bool? recursiveDelete,
            CallSettings callSettings = null) => DeleteFolder(
                new DeleteFolderRequest
                {
                    FolderName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    RecursiveDelete = recursiveDelete ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Requests deletion of a Folder. The Folder is moved into the
        /// [DELETE_REQUESTED] state immediately, and is deleted approximately 30 days
        /// later. This method may only be called on an empty Folder in the [ACTIVE]
        /// state, where a Folder is empty if it doesn't contain any Folders or
        /// Projects in the [ACTIVE] state.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
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
        public virtual Task<Folder> DeleteFolderAsync(
            DeleteFolderRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Requests deletion of a Folder. The Folder is moved into the
        /// [DELETE_REQUESTED] state immediately, and is deleted approximately 30 days
        /// later. This method may only be called on an empty Folder in the [ACTIVE]
        /// state, where a Folder is empty if it doesn't contain any Folders or
        /// Projects in the [ACTIVE] state.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
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
        public virtual Folder DeleteFolder(
            DeleteFolderRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cancels the deletion request for a Folder. This method may only be
        /// called on a Folder in the [DELETE_REQUESTED] state.
        /// In order to succeed, the Folder's parent must be in the [ACTIVE] state.
        /// In addition, reintroducing the folder into the tree must not violate
        /// folder naming, height and fanout constraints described in the
        /// [CreateFolder] documentation.
        /// The caller must have `resourcemanager.folders.undelete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Folder to undelete.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Folder> UndeleteFolderAsync(
            FolderName name,
            CallSettings callSettings = null) => UndeleteFolderAsync(
                new UndeleteFolderRequest
                {
                    FolderName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Cancels the deletion request for a Folder. This method may only be
        /// called on a Folder in the [DELETE_REQUESTED] state.
        /// In order to succeed, the Folder's parent must be in the [ACTIVE] state.
        /// In addition, reintroducing the folder into the tree must not violate
        /// folder naming, height and fanout constraints described in the
        /// [CreateFolder] documentation.
        /// The caller must have `resourcemanager.folders.undelete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Folder to undelete.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Folder> UndeleteFolderAsync(
            FolderName name,
            CancellationToken cancellationToken) => UndeleteFolderAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels the deletion request for a Folder. This method may only be
        /// called on a Folder in the [DELETE_REQUESTED] state.
        /// In order to succeed, the Folder's parent must be in the [ACTIVE] state.
        /// In addition, reintroducing the folder into the tree must not violate
        /// folder naming, height and fanout constraints described in the
        /// [CreateFolder] documentation.
        /// The caller must have `resourcemanager.folders.undelete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Folder to undelete.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Folder UndeleteFolder(
            FolderName name,
            CallSettings callSettings = null) => UndeleteFolder(
                new UndeleteFolderRequest
                {
                    FolderName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Cancels the deletion request for a Folder. This method may only be
        /// called on a Folder in the [DELETE_REQUESTED] state.
        /// In order to succeed, the Folder's parent must be in the [ACTIVE] state.
        /// In addition, reintroducing the folder into the tree must not violate
        /// folder naming, height and fanout constraints described in the
        /// [CreateFolder] documentation.
        /// The caller must have `resourcemanager.folders.undelete` permission on the
        /// identified folder.
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
        public virtual Task<Folder> UndeleteFolderAsync(
            UndeleteFolderRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cancels the deletion request for a Folder. This method may only be
        /// called on a Folder in the [DELETE_REQUESTED] state.
        /// In order to succeed, the Folder's parent must be in the [ACTIVE] state.
        /// In addition, reintroducing the folder into the tree must not violate
        /// folder naming, height and fanout constraints described in the
        /// [CreateFolder] documentation.
        /// The caller must have `resourcemanager.folders.undelete` permission on the
        /// identified folder.
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
        public virtual Folder UndeleteFolder(
            UndeleteFolderRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for a Folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the Folder's resource name, e.g. "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Policy> GetIamPolicyAsync(
            string resource,
            CallSettings callSettings = null) => GetIamPolicyAsync(
                new GetIamPolicyRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a Folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the Folder's resource name, e.g. "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Policy> GetIamPolicyAsync(
            string resource,
            CancellationToken cancellationToken) => GetIamPolicyAsync(
                resource,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a Folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the Folder's resource name, e.g. "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Policy GetIamPolicy(
            string resource,
            CallSettings callSettings = null) => GetIamPolicy(
                new GetIamPolicyRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a Folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the Folder's resource name, e.g. "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
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
        public virtual Task<Policy> GetIamPolicyAsync(
            GetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for a Folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the Folder's resource name, e.g. "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
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
        public virtual Policy GetIamPolicy(
            GetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on a Folder, replacing any existing policy.
        /// The `resource` field should be the Folder's resource name, e.g.
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Policy> SetIamPolicyAsync(
            string resource,
            Policy policy,
            CallSettings callSettings = null) => SetIamPolicyAsync(
                new SetIamPolicyRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Policy = GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on a Folder, replacing any existing policy.
        /// The `resource` field should be the Folder's resource name, e.g.
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Policy> SetIamPolicyAsync(
            string resource,
            Policy policy,
            CancellationToken cancellationToken) => SetIamPolicyAsync(
                resource,
                policy,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on a Folder, replacing any existing policy.
        /// The `resource` field should be the Folder's resource name, e.g.
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Policy SetIamPolicy(
            string resource,
            Policy policy,
            CallSettings callSettings = null) => SetIamPolicy(
                new SetIamPolicyRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Policy = GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on a Folder, replacing any existing policy.
        /// The `resource` field should be the Folder's resource name, e.g.
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
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
        public virtual Task<Policy> SetIamPolicyAsync(
            SetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on a Folder, replacing any existing policy.
        /// The `resource` field should be the Folder's resource name, e.g.
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
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
        public virtual Policy SetIamPolicy(
            SetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified Folder.
        /// The `resource` field should be the Folder's resource name,
        /// e.g. "folders/1234".
        ///
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            IEnumerable<string> permissions,
            CallSettings callSettings = null) => TestIamPermissionsAsync(
                new TestIamPermissionsRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Permissions = { GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified Folder.
        /// The `resource` field should be the Folder's resource name,
        /// e.g. "folders/1234".
        ///
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            IEnumerable<string> permissions,
            CancellationToken cancellationToken) => TestIamPermissionsAsync(
                resource,
                permissions,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified Folder.
        /// The `resource` field should be the Folder's resource name,
        /// e.g. "folders/1234".
        ///
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual TestIamPermissionsResponse TestIamPermissions(
            string resource,
            IEnumerable<string> permissions,
            CallSettings callSettings = null) => TestIamPermissions(
                new TestIamPermissionsRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Permissions = { GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified Folder.
        /// The `resource` field should be the Folder's resource name,
        /// e.g. "folders/1234".
        ///
        /// There are no permissions required for making this API call.
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
        public virtual Task<TestIamPermissionsResponse> TestIamPermissionsAsync(
            TestIamPermissionsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified Folder.
        /// The `resource` field should be the Folder's resource name,
        /// e.g. "folders/1234".
        ///
        /// There are no permissions required for making this API call.
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
        public virtual TestIamPermissionsResponse TestIamPermissions(
            TestIamPermissionsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// Folders client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class FoldersClientImpl : FoldersClient
    {
        private readonly ApiCall<ListFoldersRequest, ListFoldersResponse> _callListFolders;
        private readonly ApiCall<SearchFoldersRequest, SearchFoldersResponse> _callSearchFolders;
        private readonly ApiCall<GetFolderRequest, Folder> _callGetFolder;
        private readonly ApiCall<CreateFolderRequest, Operation> _callCreateFolder;
        private readonly ApiCall<UpdateFolderRequest, Folder> _callUpdateFolder;
        private readonly ApiCall<MoveFolderRequest, Operation> _callMoveFolder;
        private readonly ApiCall<DeleteFolderRequest, Folder> _callDeleteFolder;
        private readonly ApiCall<UndeleteFolderRequest, Folder> _callUndeleteFolder;
        private readonly ApiCall<GetIamPolicyRequest, Policy> _callGetIamPolicy;
        private readonly ApiCall<SetIamPolicyRequest, Policy> _callSetIamPolicy;
        private readonly ApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the Folders service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FoldersSettings"/> used within this client </param>
        public FoldersClientImpl(Folders.FoldersClient grpcClient, FoldersSettings settings)
        {
            GrpcClient = grpcClient;
            FoldersSettings effectiveSettings = settings ?? FoldersSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callListFolders = clientHelper.BuildApiCall<ListFoldersRequest, ListFoldersResponse>(
                GrpcClient.ListFoldersAsync, GrpcClient.ListFolders, effectiveSettings.ListFoldersSettings);
            _callSearchFolders = clientHelper.BuildApiCall<SearchFoldersRequest, SearchFoldersResponse>(
                GrpcClient.SearchFoldersAsync, GrpcClient.SearchFolders, effectiveSettings.SearchFoldersSettings);
            _callGetFolder = clientHelper.BuildApiCall<GetFolderRequest, Folder>(
                GrpcClient.GetFolderAsync, GrpcClient.GetFolder, effectiveSettings.GetFolderSettings);
            _callCreateFolder = clientHelper.BuildApiCall<CreateFolderRequest, Operation>(
                GrpcClient.CreateFolderAsync, GrpcClient.CreateFolder, effectiveSettings.CreateFolderSettings);
            _callUpdateFolder = clientHelper.BuildApiCall<UpdateFolderRequest, Folder>(
                GrpcClient.UpdateFolderAsync, GrpcClient.UpdateFolder, effectiveSettings.UpdateFolderSettings);
            _callMoveFolder = clientHelper.BuildApiCall<MoveFolderRequest, Operation>(
                GrpcClient.MoveFolderAsync, GrpcClient.MoveFolder, effectiveSettings.MoveFolderSettings);
            _callDeleteFolder = clientHelper.BuildApiCall<DeleteFolderRequest, Folder>(
                GrpcClient.DeleteFolderAsync, GrpcClient.DeleteFolder, effectiveSettings.DeleteFolderSettings);
            _callUndeleteFolder = clientHelper.BuildApiCall<UndeleteFolderRequest, Folder>(
                GrpcClient.UndeleteFolderAsync, GrpcClient.UndeleteFolder, effectiveSettings.UndeleteFolderSettings);
            _callGetIamPolicy = clientHelper.BuildApiCall<GetIamPolicyRequest, Policy>(
                GrpcClient.GetIamPolicyAsync, GrpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings);
            _callSetIamPolicy = clientHelper.BuildApiCall<SetIamPolicyRequest, Policy>(
                GrpcClient.SetIamPolicyAsync, GrpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings);
            _callTestIamPermissions = clientHelper.BuildApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse>(
                GrpcClient.TestIamPermissionsAsync, GrpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(Folders.FoldersClient grpcClient, FoldersSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Folders client.
        /// </summary>
        public override Folders.FoldersClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_ListFoldersRequest(ref ListFoldersRequest request, ref CallSettings settings);
        partial void Modify_SearchFoldersRequest(ref SearchFoldersRequest request, ref CallSettings settings);
        partial void Modify_GetFolderRequest(ref GetFolderRequest request, ref CallSettings settings);
        partial void Modify_CreateFolderRequest(ref CreateFolderRequest request, ref CallSettings settings);
        partial void Modify_UpdateFolderRequest(ref UpdateFolderRequest request, ref CallSettings settings);
        partial void Modify_MoveFolderRequest(ref MoveFolderRequest request, ref CallSettings settings);
        partial void Modify_DeleteFolderRequest(ref DeleteFolderRequest request, ref CallSettings settings);
        partial void Modify_UndeleteFolderRequest(ref UndeleteFolderRequest request, ref CallSettings settings);
        partial void Modify_GetIamPolicyRequest(ref GetIamPolicyRequest request, ref CallSettings settings);
        partial void Modify_SetIamPolicyRequest(ref SetIamPolicyRequest request, ref CallSettings settings);
        partial void Modify_TestIamPermissionsRequest(ref TestIamPermissionsRequest request, ref CallSettings settings);

        /// <summary>
        /// Lists the Folders that are direct descendants of supplied parent resource.
        /// List provides a strongly consistent view of the Folders underneath
        /// the specified parent resource.
        /// List returns Folders sorted based upon the (ascending) lexical ordering
        /// of their display_name.
        /// The caller must have `resourcemanager.folders.list` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Folder"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListFoldersResponse, Folder> ListFoldersAsync(
            ListFoldersRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListFoldersRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListFoldersRequest, ListFoldersResponse, Folder>(_callListFolders, request, callSettings);
        }

        /// <summary>
        /// Lists the Folders that are direct descendants of supplied parent resource.
        /// List provides a strongly consistent view of the Folders underneath
        /// the specified parent resource.
        /// List returns Folders sorted based upon the (ascending) lexical ordering
        /// of their display_name.
        /// The caller must have `resourcemanager.folders.list` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Folder"/> resources.
        /// </returns>
        public override PagedEnumerable<ListFoldersResponse, Folder> ListFolders(
            ListFoldersRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListFoldersRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListFoldersRequest, ListFoldersResponse, Folder>(_callListFolders, request, callSettings);
        }

        /// <summary>
        /// Search for folders that match specific filter criteria.
        /// Search provides an eventually consistent view of the folders a user has
        /// access to which meet the specified filter criteria.
        ///
        /// This will only return folders on which the caller has the
        /// permission `resourcemanager.folders.get`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Folder"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<SearchFoldersResponse, Folder> SearchFoldersAsync(
            SearchFoldersRequest request,
            CallSettings callSettings = null)
        {
            Modify_SearchFoldersRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<SearchFoldersRequest, SearchFoldersResponse, Folder>(_callSearchFolders, request, callSettings);
        }

        /// <summary>
        /// Search for folders that match specific filter criteria.
        /// Search provides an eventually consistent view of the folders a user has
        /// access to which meet the specified filter criteria.
        ///
        /// This will only return folders on which the caller has the
        /// permission `resourcemanager.folders.get`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Folder"/> resources.
        /// </returns>
        public override PagedEnumerable<SearchFoldersResponse, Folder> SearchFolders(
            SearchFoldersRequest request,
            CallSettings callSettings = null)
        {
            Modify_SearchFoldersRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<SearchFoldersRequest, SearchFoldersResponse, Folder>(_callSearchFolders, request, callSettings);
        }

        /// <summary>
        /// Retrieves a Folder identified by the supplied resource name.
        /// Valid Folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
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
        public override Task<Folder> GetFolderAsync(
            GetFolderRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetFolderRequest(ref request, ref callSettings);
            return _callGetFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a Folder identified by the supplied resource name.
        /// Valid Folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
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
        public override Folder GetFolder(
            GetFolderRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetFolderRequest(ref request, ref callSettings);
            return _callGetFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Folder in the resource hierarchy.
        /// Returns an Operation which can be used to track the progress of the
        /// folder creation workflow.
        /// Upon success the Operation.response field will be populated with the
        /// created Folder.
        ///
        /// In order to succeed, the addition of this new Folder must not violate
        /// the Folder naming, height or fanout constraints.
        /// + The Folder's display_name must be distinct from all other Folder's that
        /// share its parent.
        /// + The addition of the Folder must not cause the active Folder hierarchy
        /// to exceed a height of 4. Note, the full active + deleted Folder hierarchy
        /// is allowed to reach a height of 8; this provides additional headroom when
        /// moving folders that contain deleted folders.
        /// + The addition of the Folder must not cause the total number of Folders
        /// under its parent to exceed 100.
        ///
        /// If the operation fails due to a folder constraint violation,
        /// a PreconditionFailure explaining the violation will be returned.
        /// If the failure occurs synchronously then the PreconditionFailure
        /// will be returned via the Status.details field and if it occurs
        /// asynchronously then the PreconditionFailure will be returned
        /// via the the Operation.error field.
        ///
        /// The caller must have `resourcemanager.folders.create` permission on the
        /// identified parent.
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
        public override Task<Operation> CreateFolderAsync(
            CreateFolderRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateFolderRequest(ref request, ref callSettings);
            return _callCreateFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a Folder in the resource hierarchy.
        /// Returns an Operation which can be used to track the progress of the
        /// folder creation workflow.
        /// Upon success the Operation.response field will be populated with the
        /// created Folder.
        ///
        /// In order to succeed, the addition of this new Folder must not violate
        /// the Folder naming, height or fanout constraints.
        /// + The Folder's display_name must be distinct from all other Folder's that
        /// share its parent.
        /// + The addition of the Folder must not cause the active Folder hierarchy
        /// to exceed a height of 4. Note, the full active + deleted Folder hierarchy
        /// is allowed to reach a height of 8; this provides additional headroom when
        /// moving folders that contain deleted folders.
        /// + The addition of the Folder must not cause the total number of Folders
        /// under its parent to exceed 100.
        ///
        /// If the operation fails due to a folder constraint violation,
        /// a PreconditionFailure explaining the violation will be returned.
        /// If the failure occurs synchronously then the PreconditionFailure
        /// will be returned via the Status.details field and if it occurs
        /// asynchronously then the PreconditionFailure will be returned
        /// via the the Operation.error field.
        ///
        /// The caller must have `resourcemanager.folders.create` permission on the
        /// identified parent.
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
        public override Operation CreateFolder(
            CreateFolderRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateFolderRequest(ref request, ref callSettings);
            return _callCreateFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a Folder, changing its display_name.
        /// Changes to the folder display_name will be rejected if they violate either
        /// the display_name formatting rules or naming constraints described in
        /// the [CreateFolder] documentation.
        /// + The Folder's display name must start and end with a letter or digit,
        /// may contain letters, digits, spaces, hyphens and underscores and can be
        /// no longer than 30 characters. This is captured by the regular expression:
        /// [\p{L}\p{N}]({\p{L}\p{N}_- ]{0,28}[\p{L}\p{N}])?.
        /// The caller must have `resourcemanager.folders.update` permission on the
        /// identified folder.
        ///
        /// If the update fails due to the unique name constraint then a
        /// PreconditionFailure explaining this violation will be returned
        /// in the Status.details field.
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
        public override Task<Folder> UpdateFolderAsync(
            UpdateFolderRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateFolderRequest(ref request, ref callSettings);
            return _callUpdateFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a Folder, changing its display_name.
        /// Changes to the folder display_name will be rejected if they violate either
        /// the display_name formatting rules or naming constraints described in
        /// the [CreateFolder] documentation.
        /// + The Folder's display name must start and end with a letter or digit,
        /// may contain letters, digits, spaces, hyphens and underscores and can be
        /// no longer than 30 characters. This is captured by the regular expression:
        /// [\p{L}\p{N}]({\p{L}\p{N}_- ]{0,28}[\p{L}\p{N}])?.
        /// The caller must have `resourcemanager.folders.update` permission on the
        /// identified folder.
        ///
        /// If the update fails due to the unique name constraint then a
        /// PreconditionFailure explaining this violation will be returned
        /// in the Status.details field.
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
        public override Folder UpdateFolder(
            UpdateFolderRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateFolderRequest(ref request, ref callSettings);
            return _callUpdateFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Moves a Folder under a new resource parent.
        /// Returns an Operation which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success the Operation.response field will be populated with the
        /// moved Folder.
        /// Upon failure, a FolderOperationError categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// FolderOperationError will be returned via the Status.details field
        /// and if it occurs asynchronously then the FolderOperation will be returned
        /// via the the Operation.error field.
        /// In addition, the Operation.metadata field will be populated with a
        /// FolderOperation message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height
        /// or fanout constraints described in the [CreateFolder] documentation.
        /// The caller must have `resourcemanager.folders.move` permission on the
        /// folder's current and proposed new parent.
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
        public override Task<Operation> MoveFolderAsync(
            MoveFolderRequest request,
            CallSettings callSettings = null)
        {
            Modify_MoveFolderRequest(ref request, ref callSettings);
            return _callMoveFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Moves a Folder under a new resource parent.
        /// Returns an Operation which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success the Operation.response field will be populated with the
        /// moved Folder.
        /// Upon failure, a FolderOperationError categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// FolderOperationError will be returned via the Status.details field
        /// and if it occurs asynchronously then the FolderOperation will be returned
        /// via the the Operation.error field.
        /// In addition, the Operation.metadata field will be populated with a
        /// FolderOperation message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height
        /// or fanout constraints described in the [CreateFolder] documentation.
        /// The caller must have `resourcemanager.folders.move` permission on the
        /// folder's current and proposed new parent.
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
        public override Operation MoveFolder(
            MoveFolderRequest request,
            CallSettings callSettings = null)
        {
            Modify_MoveFolderRequest(ref request, ref callSettings);
            return _callMoveFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Requests deletion of a Folder. The Folder is moved into the
        /// [DELETE_REQUESTED] state immediately, and is deleted approximately 30 days
        /// later. This method may only be called on an empty Folder in the [ACTIVE]
        /// state, where a Folder is empty if it doesn't contain any Folders or
        /// Projects in the [ACTIVE] state.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
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
        public override Task<Folder> DeleteFolderAsync(
            DeleteFolderRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteFolderRequest(ref request, ref callSettings);
            return _callDeleteFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Requests deletion of a Folder. The Folder is moved into the
        /// [DELETE_REQUESTED] state immediately, and is deleted approximately 30 days
        /// later. This method may only be called on an empty Folder in the [ACTIVE]
        /// state, where a Folder is empty if it doesn't contain any Folders or
        /// Projects in the [ACTIVE] state.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
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
        public override Folder DeleteFolder(
            DeleteFolderRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteFolderRequest(ref request, ref callSettings);
            return _callDeleteFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels the deletion request for a Folder. This method may only be
        /// called on a Folder in the [DELETE_REQUESTED] state.
        /// In order to succeed, the Folder's parent must be in the [ACTIVE] state.
        /// In addition, reintroducing the folder into the tree must not violate
        /// folder naming, height and fanout constraints described in the
        /// [CreateFolder] documentation.
        /// The caller must have `resourcemanager.folders.undelete` permission on the
        /// identified folder.
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
        public override Task<Folder> UndeleteFolderAsync(
            UndeleteFolderRequest request,
            CallSettings callSettings = null)
        {
            Modify_UndeleteFolderRequest(ref request, ref callSettings);
            return _callUndeleteFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Cancels the deletion request for a Folder. This method may only be
        /// called on a Folder in the [DELETE_REQUESTED] state.
        /// In order to succeed, the Folder's parent must be in the [ACTIVE] state.
        /// In addition, reintroducing the folder into the tree must not violate
        /// folder naming, height and fanout constraints described in the
        /// [CreateFolder] documentation.
        /// The caller must have `resourcemanager.folders.undelete` permission on the
        /// identified folder.
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
        public override Folder UndeleteFolder(
            UndeleteFolderRequest request,
            CallSettings callSettings = null)
        {
            Modify_UndeleteFolderRequest(ref request, ref callSettings);
            return _callUndeleteFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a Folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the Folder's resource name, e.g. "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
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
        public override Task<Policy> GetIamPolicyAsync(
            GetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a Folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the Folder's resource name, e.g. "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
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
        public override Policy GetIamPolicy(
            GetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on a Folder, replacing any existing policy.
        /// The `resource` field should be the Folder's resource name, e.g.
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
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
        public override Task<Policy> SetIamPolicyAsync(
            SetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on a Folder, replacing any existing policy.
        /// The `resource` field should be the Folder's resource name, e.g.
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
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
        public override Policy SetIamPolicy(
            SetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified Folder.
        /// The `resource` field should be the Folder's resource name,
        /// e.g. "folders/1234".
        ///
        /// There are no permissions required for making this API call.
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
        public override Task<TestIamPermissionsResponse> TestIamPermissionsAsync(
            TestIamPermissionsRequest request,
            CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified Folder.
        /// The `resource` field should be the Folder's resource name,
        /// e.g. "folders/1234".
        ///
        /// There are no permissions required for making this API call.
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
        public override TestIamPermissionsResponse TestIamPermissions(
            TestIamPermissionsRequest request,
            CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListFoldersRequest : IPageRequest { }
    public partial class ListFoldersResponse : IPageResponse<Folder>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<Folder> GetEnumerator() => Folders.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchFoldersRequest : IPageRequest { }
    public partial class SearchFoldersResponse : IPageResponse<Folder>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<Folder> GetEnumerator() => Folders.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
