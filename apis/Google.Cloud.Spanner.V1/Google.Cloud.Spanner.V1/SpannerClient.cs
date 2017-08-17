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
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Settings for a <see cref="SpannerClient"/>.
    /// </summary>
    public sealed partial class SpannerSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="SpannerSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="SpannerSettings"/>.
        /// </returns>
        public static SpannerSettings GetDefault() => new SpannerSettings();

        /// <summary>
        /// Constructs a new <see cref="SpannerSettings"/> object with default settings.
        /// </summary>
        public SpannerSettings() { }

        private SpannerSettings(SpannerSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSessionSettings = existing.CreateSessionSettings;
            GetSessionSettings = existing.GetSessionSettings;
            DeleteSessionSettings = existing.DeleteSessionSettings;
            ExecuteSqlSettings = existing.ExecuteSqlSettings;
            ExecuteStreamingSqlSettings = existing.ExecuteStreamingSqlSettings;
            ReadSettings = existing.ReadSettings;
            StreamingReadSettings = existing.StreamingReadSettings;
            BeginTransactionSettings = existing.BeginTransactionSettings;
            CommitSettings = existing.CommitSettings;
            RollbackSettings = existing.RollbackSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SpannerSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="SpannerClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="SpannerClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "LongRunning" <see cref="SpannerClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "LongRunning" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> LongRunningRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.Unavailable);

        /// <summary>
        /// "Default" retry backoff for <see cref="SpannerClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="SpannerClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="SpannerClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 1000 milliseconds</description></item>
        /// <item><description>Maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(1000),
            maxDelay: TimeSpan.FromMilliseconds(32000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="SpannerClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="SpannerClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="SpannerClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(60000),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// "LongRunning" retry backoff for <see cref="SpannerClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "LongRunning" retry backoff for <see cref="SpannerClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "LongRunning" retry backoff for <see cref="SpannerClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 1000 milliseconds</description></item>
        /// <item><description>Maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetLongRunningRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(1000),
            maxDelay: TimeSpan.FromMilliseconds(32000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "LongRunning" timeout backoff for <see cref="SpannerClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "LongRunning" timeout backoff for <see cref="SpannerClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "LongRunning" timeout backoff for <see cref="SpannerClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 3600000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetLongRunningTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(3600000),
            maxDelay: TimeSpan.FromMilliseconds(3600000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.CreateSession</c> and <c>SpannerClient.CreateSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.CreateSession</c> and
        /// <c>SpannerClient.CreateSessionAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CreateSessionSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.GetSession</c> and <c>SpannerClient.GetSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.GetSession</c> and
        /// <c>SpannerClient.GetSessionAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetSessionSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.DeleteSession</c> and <c>SpannerClient.DeleteSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.DeleteSession</c> and
        /// <c>SpannerClient.DeleteSessionAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteSessionSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.ExecuteSql</c> and <c>SpannerClient.ExecuteSqlAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.ExecuteSql</c> and
        /// <c>SpannerClient.ExecuteSqlAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ExecuteSqlSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for calls to <c>SpannerClient.ExecuteStreamingSql</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ExecuteStreamingSqlSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromTimeout(TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.Read</c> and <c>SpannerClient.ReadAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.Read</c> and
        /// <c>SpannerClient.ReadAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ReadSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for calls to <c>SpannerClient.StreamingRead</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings StreamingReadSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromTimeout(TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.BeginTransaction</c> and <c>SpannerClient.BeginTransactionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.BeginTransaction</c> and
        /// <c>SpannerClient.BeginTransactionAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings BeginTransactionSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.Commit</c> and <c>SpannerClient.CommitAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.Commit</c> and
        /// <c>SpannerClient.CommitAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 3600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 36000000 milliseconds.
        /// </remarks>
        public CallSettings CommitSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetLongRunningRetryBackoff(),
                timeoutBackoff: GetLongRunningTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(36000000)),
                retryFilter: LongRunningRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.Rollback</c> and <c>SpannerClient.RollbackAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpannerClient.Rollback</c> and
        /// <c>SpannerClient.RollbackAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings RollbackSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="SpannerSettings"/> object.</returns>
        public SpannerSettings Clone() => new SpannerSettings(this);
    }

    /// <summary>
    /// Spanner client wrapper, for convenient use.
    /// </summary>
    public abstract partial class SpannerClient
    {
        /// <summary>
        /// The default endpoint for the Spanner service, which is a host of "spanner.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("spanner.googleapis.com", 443);

        /// <summary>
        /// The default Spanner scopes.
        /// </summary>
        /// <remarks>
        /// The default Spanner scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/spanner.data"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/spanner.data",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="SpannerClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SpannerSettings"/>.</param>
        /// <returns>The task representing the created <see cref="SpannerClient"/>.</returns>
        public static async Task<SpannerClient> CreateAsync(ServiceEndpoint endpoint = null, SpannerSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="SpannerClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SpannerSettings"/>.</param>
        /// <returns>The created <see cref="SpannerClient"/>.</returns>
        public static SpannerClient Create(ServiceEndpoint endpoint = null, SpannerSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="SpannerClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SpannerSettings"/>.</param>
        /// <returns>The created <see cref="SpannerClient"/>.</returns>
        public static SpannerClient Create(Channel channel, SpannerSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            Spanner.SpannerClient grpcClient = new Spanner.SpannerClient(channel);
            return new SpannerClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, SpannerSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, SpannerSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, SpannerSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, SpannerSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Spanner client.
        /// </summary>
        public virtual Spanner.SpannerClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        ///
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        ///
        /// Cloud Spanner limits the number of sessions that can exist at any given
        /// time; thus, it is a good idea to delete idle and/or unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions for which no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        ///
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, e.g., `"SELECT 1"`.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new session is created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Session> CreateSessionAsync(
            DatabaseName database,
            CallSettings callSettings = null) => CreateSessionAsync(
                new CreateSessionRequest
                {
                    DatabaseAsDatabaseName = GaxPreconditions.CheckNotNull(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        ///
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        ///
        /// Cloud Spanner limits the number of sessions that can exist at any given
        /// time; thus, it is a good idea to delete idle and/or unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions for which no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        ///
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, e.g., `"SELECT 1"`.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new session is created.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Session> CreateSessionAsync(
            DatabaseName database,
            CancellationToken cancellationToken) => CreateSessionAsync(
                database,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        ///
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        ///
        /// Cloud Spanner limits the number of sessions that can exist at any given
        /// time; thus, it is a good idea to delete idle and/or unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions for which no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        ///
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, e.g., `"SELECT 1"`.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new session is created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Session CreateSession(
            DatabaseName database,
            CallSettings callSettings = null) => CreateSession(
                new CreateSessionRequest
                {
                    DatabaseAsDatabaseName = GaxPreconditions.CheckNotNull(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        ///
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        ///
        /// Cloud Spanner limits the number of sessions that can exist at any given
        /// time; thus, it is a good idea to delete idle and/or unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions for which no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        ///
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, e.g., `"SELECT 1"`.
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
        public virtual Task<Session> CreateSessionAsync(
            CreateSessionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        ///
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        ///
        /// Cloud Spanner limits the number of sessions that can exist at any given
        /// time; thus, it is a good idea to delete idle and/or unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions for which no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        ///
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, e.g., `"SELECT 1"`.
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
        public virtual Session CreateSession(
            CreateSessionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session does not exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Session> GetSessionAsync(
            SessionName name,
            CallSettings callSettings = null) => GetSessionAsync(
                new GetSessionRequest
                {
                    SessionName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session does not exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Session> GetSessionAsync(
            SessionName name,
            CancellationToken cancellationToken) => GetSessionAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session does not exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Session GetSession(
            SessionName name,
            CallSettings callSettings = null) => GetSession(
                new GetSessionRequest
                {
                    SessionName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session does not exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
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
        public virtual Task<Session> GetSessionAsync(
            GetSessionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session does not exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
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
        public virtual Session GetSession(
            GetSessionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ends a session, releasing server resources associated with it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to delete.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteSessionAsync(
            SessionName name,
            CallSettings callSettings = null) => DeleteSessionAsync(
                new DeleteSessionRequest
                {
                    SessionName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Ends a session, releasing server resources associated with it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to delete.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteSessionAsync(
            SessionName name,
            CancellationToken cancellationToken) => DeleteSessionAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Ends a session, releasing server resources associated with it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to delete.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteSession(
            SessionName name,
            CallSettings callSettings = null) => DeleteSession(
                new DeleteSessionRequest
                {
                    SessionName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Ends a session, releasing server resources associated with it.
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
        public virtual Task DeleteSessionAsync(
            DeleteSessionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ends a session, releasing server resources associated with it.
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
        public virtual void DeleteSession(
            DeleteSessionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Executes an SQL query, returning all rows in a single reply. This
        /// method cannot be used to return a result set larger than 10 MiB;
        /// if the query yields more data than that, the query fails with
        /// a `FAILED_PRECONDITION` error.
        ///
        /// Queries inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be fetched in streaming fashion by calling
        /// [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] instead.
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
        public virtual Task<ResultSet> ExecuteSqlAsync(
            ExecuteSqlRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Executes an SQL query, returning all rows in a single reply. This
        /// method cannot be used to return a result set larger than 10 MiB;
        /// if the query yields more data than that, the query fails with
        /// a `FAILED_PRECONDITION` error.
        ///
        /// Queries inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be fetched in streaming fashion by calling
        /// [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] instead.
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
        public virtual ResultSet ExecuteSql(
            ExecuteSqlRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Like [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql], except returns the result
        /// set as a stream. Unlike [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql], there
        /// is no limit on the size of the returned result set. However, no
        /// individual row in the result set can exceed 100 MiB, and no
        /// column value can exceed 10 MiB.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual ExecuteStreamingSqlStream ExecuteStreamingSql(
            ExecuteSqlRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Server streaming methods for <c>ExecuteStreamingSql</c>.
        /// </summary>
        public abstract class ExecuteStreamingSqlStream : ServerStreamingBase<PartialResultSet>
        {
        }

        /// <summary>
        /// Reads rows from the database using key lookups and scans, as a
        /// simple key/value style alternative to
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql].  This method cannot be used to
        /// return a result set larger than 10 MiB; if the read matches more
        /// data than that, the read fails with a `FAILED_PRECONDITION`
        /// error.
        ///
        /// Reads inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be yielded in streaming fashion by calling
        /// [StreamingRead][google.spanner.v1.Spanner.StreamingRead] instead.
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
        public virtual Task<ResultSet> ReadAsync(
            ReadRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reads rows from the database using key lookups and scans, as a
        /// simple key/value style alternative to
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql].  This method cannot be used to
        /// return a result set larger than 10 MiB; if the read matches more
        /// data than that, the read fails with a `FAILED_PRECONDITION`
        /// error.
        ///
        /// Reads inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be yielded in streaming fashion by calling
        /// [StreamingRead][google.spanner.v1.Spanner.StreamingRead] instead.
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
        public virtual ResultSet Read(
            ReadRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Like [Read][google.spanner.v1.Spanner.Read], except returns the result set as a
        /// stream. Unlike [Read][google.spanner.v1.Spanner.Read], there is no limit on the
        /// size of the returned result set. However, no individual row in
        /// the result set can exceed 100 MiB, and no column value can exceed
        /// 10 MiB.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual StreamingReadStream StreamingRead(
            ReadRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Server streaming methods for <c>StreamingRead</c>.
        /// </summary>
        public abstract class StreamingReadStream : ServerStreamingBase<PartialResultSet>
        {
        }

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read], [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction runs.
        /// </param>
        /// <param name="options">
        /// Required. Options for the new transaction.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Transaction> BeginTransactionAsync(
            SessionName session,
            TransactionOptions options,
            CallSettings callSettings = null) => BeginTransactionAsync(
                new BeginTransactionRequest
                {
                    SessionAsSessionName = GaxPreconditions.CheckNotNull(session, nameof(session)),
                    Options = GaxPreconditions.CheckNotNull(options, nameof(options)),
                },
                callSettings);

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read], [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction runs.
        /// </param>
        /// <param name="options">
        /// Required. Options for the new transaction.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Transaction> BeginTransactionAsync(
            SessionName session,
            TransactionOptions options,
            CancellationToken cancellationToken) => BeginTransactionAsync(
                session,
                options,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read], [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction runs.
        /// </param>
        /// <param name="options">
        /// Required. Options for the new transaction.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Transaction BeginTransaction(
            SessionName session,
            TransactionOptions options,
            CallSettings callSettings = null) => BeginTransaction(
                new BeginTransactionRequest
                {
                    SessionAsSessionName = GaxPreconditions.CheckNotNull(session, nameof(session)),
                    Options = GaxPreconditions.CheckNotNull(options, nameof(options)),
                },
                callSettings);

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read], [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
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
        public virtual Task<Transaction> BeginTransactionAsync(
            BeginTransactionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read], [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
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
        public virtual Transaction BeginTransaction(
            BeginTransactionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="transactionId">
        /// Commit a previously-started transaction.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CommitResponse> CommitAsync(
            SessionName session,
            ByteString transactionId,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null) => CommitAsync(
                new CommitRequest
                {
                    SessionAsSessionName = GaxPreconditions.CheckNotNull(session, nameof(session)),
                    TransactionId = transactionId ?? ByteString.Empty, // Optional
                    Mutations = { GaxPreconditions.CheckNotNull(mutations, nameof(mutations)) },
                },
                callSettings);

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="transactionId">
        /// Commit a previously-started transaction.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CommitResponse> CommitAsync(
            SessionName session,
            ByteString transactionId,
            IEnumerable<Mutation> mutations,
            CancellationToken cancellationToken) => CommitAsync(
                session,
                transactionId,
                mutations,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="transactionId">
        /// Commit a previously-started transaction.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CommitResponse Commit(
            SessionName session,
            ByteString transactionId,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null) => Commit(
                new CommitRequest
                {
                    SessionAsSessionName = GaxPreconditions.CheckNotNull(session, nameof(session)),
                    TransactionId = transactionId ?? ByteString.Empty, // Optional
                    Mutations = { GaxPreconditions.CheckNotNull(mutations, nameof(mutations)) },
                },
                callSettings);

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="singleUseTransaction">
        /// Execute mutations in a temporary transaction. Note that unlike
        /// commit of a previously-started transaction, commit with a
        /// temporary transaction is non-idempotent. That is, if the
        /// `CommitRequest` is sent to Cloud Spanner more than once (for
        /// instance, due to retries in the application, or in the
        /// transport library), it is possible that the mutations are
        /// executed more than once. If this is undesirable, use
        /// [BeginTransaction][google.spanner.v1.Spanner.BeginTransaction] and
        /// [Commit][google.spanner.v1.Spanner.Commit] instead.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CommitResponse> CommitAsync(
            SessionName session,
            TransactionOptions singleUseTransaction,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null) => CommitAsync(
                new CommitRequest
                {
                    SessionAsSessionName = GaxPreconditions.CheckNotNull(session, nameof(session)),
                    SingleUseTransaction = singleUseTransaction, // Optional
                    Mutations = { GaxPreconditions.CheckNotNull(mutations, nameof(mutations)) },
                },
                callSettings);

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="singleUseTransaction">
        /// Execute mutations in a temporary transaction. Note that unlike
        /// commit of a previously-started transaction, commit with a
        /// temporary transaction is non-idempotent. That is, if the
        /// `CommitRequest` is sent to Cloud Spanner more than once (for
        /// instance, due to retries in the application, or in the
        /// transport library), it is possible that the mutations are
        /// executed more than once. If this is undesirable, use
        /// [BeginTransaction][google.spanner.v1.Spanner.BeginTransaction] and
        /// [Commit][google.spanner.v1.Spanner.Commit] instead.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CommitResponse> CommitAsync(
            SessionName session,
            TransactionOptions singleUseTransaction,
            IEnumerable<Mutation> mutations,
            CancellationToken cancellationToken) => CommitAsync(
                session,
                singleUseTransaction,
                mutations,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="singleUseTransaction">
        /// Execute mutations in a temporary transaction. Note that unlike
        /// commit of a previously-started transaction, commit with a
        /// temporary transaction is non-idempotent. That is, if the
        /// `CommitRequest` is sent to Cloud Spanner more than once (for
        /// instance, due to retries in the application, or in the
        /// transport library), it is possible that the mutations are
        /// executed more than once. If this is undesirable, use
        /// [BeginTransaction][google.spanner.v1.Spanner.BeginTransaction] and
        /// [Commit][google.spanner.v1.Spanner.Commit] instead.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CommitResponse Commit(
            SessionName session,
            TransactionOptions singleUseTransaction,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null) => Commit(
                new CommitRequest
                {
                    SessionAsSessionName = GaxPreconditions.CheckNotNull(session, nameof(session)),
                    SingleUseTransaction = singleUseTransaction, // Optional
                    Mutations = { GaxPreconditions.CheckNotNull(mutations, nameof(mutations)) },
                },
                callSettings);

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
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
        public virtual Task<CommitResponse> CommitAsync(
            CommitRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
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
        public virtual CommitResponse Commit(
            CommitRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It is a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and
        /// ultimately decides not to commit.
        ///
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction is not
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to roll back is running.
        /// </param>
        /// <param name="transactionId">
        /// Required. The transaction to roll back.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task RollbackAsync(
            SessionName session,
            ByteString transactionId,
            CallSettings callSettings = null) => RollbackAsync(
                new RollbackRequest
                {
                    SessionAsSessionName = GaxPreconditions.CheckNotNull(session, nameof(session)),
                    TransactionId = GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId)),
                },
                callSettings);

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It is a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and
        /// ultimately decides not to commit.
        ///
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction is not
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to roll back is running.
        /// </param>
        /// <param name="transactionId">
        /// Required. The transaction to roll back.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task RollbackAsync(
            SessionName session,
            ByteString transactionId,
            CancellationToken cancellationToken) => RollbackAsync(
                session,
                transactionId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It is a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and
        /// ultimately decides not to commit.
        ///
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction is not
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to roll back is running.
        /// </param>
        /// <param name="transactionId">
        /// Required. The transaction to roll back.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void Rollback(
            SessionName session,
            ByteString transactionId,
            CallSettings callSettings = null) => Rollback(
                new RollbackRequest
                {
                    SessionAsSessionName = GaxPreconditions.CheckNotNull(session, nameof(session)),
                    TransactionId = GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId)),
                },
                callSettings);

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It is a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and
        /// ultimately decides not to commit.
        ///
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction is not
        /// found. `Rollback` never returns `ABORTED`.
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
        public virtual Task RollbackAsync(
            RollbackRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It is a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and
        /// ultimately decides not to commit.
        ///
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction is not
        /// found. `Rollback` never returns `ABORTED`.
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
        public virtual void Rollback(
            RollbackRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// Spanner client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class SpannerClientImpl : SpannerClient
    {
        private readonly ApiCall<CreateSessionRequest, Session> _callCreateSession;
        private readonly ApiCall<GetSessionRequest, Session> _callGetSession;
        private readonly ApiCall<DeleteSessionRequest, Empty> _callDeleteSession;
        private readonly ApiCall<ExecuteSqlRequest, ResultSet> _callExecuteSql;
        private readonly ApiServerStreamingCall<ExecuteSqlRequest, PartialResultSet> _callExecuteStreamingSql;
        private readonly ApiCall<ReadRequest, ResultSet> _callRead;
        private readonly ApiServerStreamingCall<ReadRequest, PartialResultSet> _callStreamingRead;
        private readonly ApiCall<BeginTransactionRequest, Transaction> _callBeginTransaction;
        private readonly ApiCall<CommitRequest, CommitResponse> _callCommit;
        private readonly ApiCall<RollbackRequest, Empty> _callRollback;

        /// <summary>
        /// Constructs a client wrapper for the Spanner service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SpannerSettings"/> used within this client </param>
        public SpannerClientImpl(Spanner.SpannerClient grpcClient, SpannerSettings settings)
        {
            GrpcClient = grpcClient;
            SpannerSettings effectiveSettings = settings ?? SpannerSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callCreateSession = clientHelper.BuildApiCall<CreateSessionRequest, Session>(
                GrpcClient.CreateSessionAsync, GrpcClient.CreateSession, effectiveSettings.CreateSessionSettings);
            _callGetSession = clientHelper.BuildApiCall<GetSessionRequest, Session>(
                GrpcClient.GetSessionAsync, GrpcClient.GetSession, effectiveSettings.GetSessionSettings);
            _callDeleteSession = clientHelper.BuildApiCall<DeleteSessionRequest, Empty>(
                GrpcClient.DeleteSessionAsync, GrpcClient.DeleteSession, effectiveSettings.DeleteSessionSettings);
            _callExecuteSql = clientHelper.BuildApiCall<ExecuteSqlRequest, ResultSet>(
                GrpcClient.ExecuteSqlAsync, GrpcClient.ExecuteSql, effectiveSettings.ExecuteSqlSettings);
            _callExecuteStreamingSql = clientHelper.BuildApiCall<ExecuteSqlRequest, PartialResultSet>(
                GrpcClient.ExecuteStreamingSql, effectiveSettings.ExecuteStreamingSqlSettings);
            _callRead = clientHelper.BuildApiCall<ReadRequest, ResultSet>(
                GrpcClient.ReadAsync, GrpcClient.Read, effectiveSettings.ReadSettings);
            _callStreamingRead = clientHelper.BuildApiCall<ReadRequest, PartialResultSet>(
                GrpcClient.StreamingRead, effectiveSettings.StreamingReadSettings);
            _callBeginTransaction = clientHelper.BuildApiCall<BeginTransactionRequest, Transaction>(
                GrpcClient.BeginTransactionAsync, GrpcClient.BeginTransaction, effectiveSettings.BeginTransactionSettings);
            _callCommit = clientHelper.BuildApiCall<CommitRequest, CommitResponse>(
                GrpcClient.CommitAsync, GrpcClient.Commit, effectiveSettings.CommitSettings);
            _callRollback = clientHelper.BuildApiCall<RollbackRequest, Empty>(
                GrpcClient.RollbackAsync, GrpcClient.Rollback, effectiveSettings.RollbackSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(Spanner.SpannerClient grpcClient, SpannerSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Spanner client.
        /// </summary>
        public override Spanner.SpannerClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_CreateSessionRequest(ref CreateSessionRequest request, ref CallSettings settings);
        partial void Modify_GetSessionRequest(ref GetSessionRequest request, ref CallSettings settings);
        partial void Modify_DeleteSessionRequest(ref DeleteSessionRequest request, ref CallSettings settings);
        partial void Modify_ExecuteSqlRequest(ref ExecuteSqlRequest request, ref CallSettings settings);
        partial void Modify_ReadRequest(ref ReadRequest request, ref CallSettings settings);
        partial void Modify_BeginTransactionRequest(ref BeginTransactionRequest request, ref CallSettings settings);
        partial void Modify_CommitRequest(ref CommitRequest request, ref CallSettings settings);
        partial void Modify_RollbackRequest(ref RollbackRequest request, ref CallSettings settings);

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        ///
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        ///
        /// Cloud Spanner limits the number of sessions that can exist at any given
        /// time; thus, it is a good idea to delete idle and/or unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions for which no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        ///
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, e.g., `"SELECT 1"`.
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
        public override Task<Session> CreateSessionAsync(
            CreateSessionRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateSessionRequest(ref request, ref callSettings);
            return _callCreateSession.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        ///
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        ///
        /// Cloud Spanner limits the number of sessions that can exist at any given
        /// time; thus, it is a good idea to delete idle and/or unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions for which no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        ///
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, e.g., `"SELECT 1"`.
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
        public override Session CreateSession(
            CreateSessionRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateSessionRequest(ref request, ref callSettings);
            return _callCreateSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session does not exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
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
        public override Task<Session> GetSessionAsync(
            GetSessionRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetSessionRequest(ref request, ref callSettings);
            return _callGetSession.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session does not exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
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
        public override Session GetSession(
            GetSessionRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetSessionRequest(ref request, ref callSettings);
            return _callGetSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Ends a session, releasing server resources associated with it.
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
        public override Task DeleteSessionAsync(
            DeleteSessionRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteSessionRequest(ref request, ref callSettings);
            return _callDeleteSession.Async(request, callSettings);
        }

        /// <summary>
        /// Ends a session, releasing server resources associated with it.
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
        public override void DeleteSession(
            DeleteSessionRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteSessionRequest(ref request, ref callSettings);
            _callDeleteSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Executes an SQL query, returning all rows in a single reply. This
        /// method cannot be used to return a result set larger than 10 MiB;
        /// if the query yields more data than that, the query fails with
        /// a `FAILED_PRECONDITION` error.
        ///
        /// Queries inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be fetched in streaming fashion by calling
        /// [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] instead.
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
        public override Task<ResultSet> ExecuteSqlAsync(
            ExecuteSqlRequest request,
            CallSettings callSettings = null)
        {
            Modify_ExecuteSqlRequest(ref request, ref callSettings);
            return _callExecuteSql.Async(request, callSettings);
        }

        /// <summary>
        /// Executes an SQL query, returning all rows in a single reply. This
        /// method cannot be used to return a result set larger than 10 MiB;
        /// if the query yields more data than that, the query fails with
        /// a `FAILED_PRECONDITION` error.
        ///
        /// Queries inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be fetched in streaming fashion by calling
        /// [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] instead.
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
        public override ResultSet ExecuteSql(
            ExecuteSqlRequest request,
            CallSettings callSettings = null)
        {
            Modify_ExecuteSqlRequest(ref request, ref callSettings);
            return _callExecuteSql.Sync(request, callSettings);
        }

        /// <summary>
        /// Like [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql], except returns the result
        /// set as a stream. Unlike [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql], there
        /// is no limit on the size of the returned result set. However, no
        /// individual row in the result set can exceed 100 MiB, and no
        /// column value can exceed 10 MiB.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public override ExecuteStreamingSqlStream ExecuteStreamingSql(
            ExecuteSqlRequest request,
            CallSettings callSettings = null)
        {
            Modify_ExecuteSqlRequest(ref request, ref callSettings);
            return new ExecuteStreamingSqlStreamImpl(_callExecuteStreamingSql.Call(request, callSettings));
        }

        internal sealed class ExecuteStreamingSqlStreamImpl : ExecuteStreamingSqlStream
        {
            /// <summary>
            /// Construct the server-streaming method for <c>ExecuteStreamingSql</c>.
            /// </summary>
            /// <param name="call">The underlying gRPC server-streaming call.</param>
            internal ExecuteStreamingSqlStreamImpl(AsyncServerStreamingCall<PartialResultSet> call)
            {
                GrpcCall = call;
            }

            /// <inheritdoc/>
            public override AsyncServerStreamingCall<PartialResultSet> GrpcCall { get; }

            /// <inheritdoc/>
            public override IAsyncEnumerator<PartialResultSet> ResponseStream => GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Reads rows from the database using key lookups and scans, as a
        /// simple key/value style alternative to
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql].  This method cannot be used to
        /// return a result set larger than 10 MiB; if the read matches more
        /// data than that, the read fails with a `FAILED_PRECONDITION`
        /// error.
        ///
        /// Reads inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be yielded in streaming fashion by calling
        /// [StreamingRead][google.spanner.v1.Spanner.StreamingRead] instead.
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
        public override Task<ResultSet> ReadAsync(
            ReadRequest request,
            CallSettings callSettings = null)
        {
            Modify_ReadRequest(ref request, ref callSettings);
            return _callRead.Async(request, callSettings);
        }

        /// <summary>
        /// Reads rows from the database using key lookups and scans, as a
        /// simple key/value style alternative to
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql].  This method cannot be used to
        /// return a result set larger than 10 MiB; if the read matches more
        /// data than that, the read fails with a `FAILED_PRECONDITION`
        /// error.
        ///
        /// Reads inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more details.
        ///
        /// Larger result sets can be yielded in streaming fashion by calling
        /// [StreamingRead][google.spanner.v1.Spanner.StreamingRead] instead.
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
        public override ResultSet Read(
            ReadRequest request,
            CallSettings callSettings = null)
        {
            Modify_ReadRequest(ref request, ref callSettings);
            return _callRead.Sync(request, callSettings);
        }

        /// <summary>
        /// Like [Read][google.spanner.v1.Spanner.Read], except returns the result set as a
        /// stream. Unlike [Read][google.spanner.v1.Spanner.Read], there is no limit on the
        /// size of the returned result set. However, no individual row in
        /// the result set can exceed 100 MiB, and no column value can exceed
        /// 10 MiB.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public override StreamingReadStream StreamingRead(
            ReadRequest request,
            CallSettings callSettings = null)
        {
            Modify_ReadRequest(ref request, ref callSettings);
            return new StreamingReadStreamImpl(_callStreamingRead.Call(request, callSettings));
        }

        internal sealed class StreamingReadStreamImpl : StreamingReadStream
        {
            /// <summary>
            /// Construct the server-streaming method for <c>StreamingRead</c>.
            /// </summary>
            /// <param name="call">The underlying gRPC server-streaming call.</param>
            internal StreamingReadStreamImpl(AsyncServerStreamingCall<PartialResultSet> call)
            {
                GrpcCall = call;
            }

            /// <inheritdoc/>
            public override AsyncServerStreamingCall<PartialResultSet> GrpcCall { get; }

            /// <inheritdoc/>
            public override IAsyncEnumerator<PartialResultSet> ResponseStream => GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read], [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
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
        public override Task<Transaction> BeginTransactionAsync(
            BeginTransactionRequest request,
            CallSettings callSettings = null)
        {
            Modify_BeginTransactionRequest(ref request, ref callSettings);
            return _callBeginTransaction.Async(request, callSettings);
        }

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read], [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
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
        public override Transaction BeginTransaction(
            BeginTransactionRequest request,
            CallSettings callSettings = null)
        {
            Modify_BeginTransactionRequest(ref request, ref callSettings);
            return _callBeginTransaction.Sync(request, callSettings);
        }

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
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
        public override Task<CommitResponse> CommitAsync(
            CommitRequest request,
            CallSettings callSettings = null)
        {
            Modify_CommitRequest(ref request, ref callSettings);
            return _callCommit.Async(request, callSettings);
        }

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        ///
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should re-attempt
        /// the transaction from the beginning, re-using the same session.
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
        public override CommitResponse Commit(
            CommitRequest request,
            CallSettings callSettings = null)
        {
            Modify_CommitRequest(ref request, ref callSettings);
            return _callCommit.Sync(request, callSettings);
        }

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It is a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and
        /// ultimately decides not to commit.
        ///
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction is not
        /// found. `Rollback` never returns `ABORTED`.
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
        public override Task RollbackAsync(
            RollbackRequest request,
            CallSettings callSettings = null)
        {
            Modify_RollbackRequest(ref request, ref callSettings);
            return _callRollback.Async(request, callSettings);
        }

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It is a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and
        /// ultimately decides not to commit.
        ///
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction is not
        /// found. `Rollback` never returns `ABORTED`.
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
        public override void Rollback(
            RollbackRequest request,
            CallSettings callSettings = null)
        {
            Modify_RollbackRequest(ref request, ref callSettings);
            _callRollback.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
