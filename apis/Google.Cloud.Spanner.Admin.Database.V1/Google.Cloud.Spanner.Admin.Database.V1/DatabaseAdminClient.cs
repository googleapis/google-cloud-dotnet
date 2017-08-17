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

namespace Google.Cloud.Spanner.Admin.Database.V1
{
    /// <summary>
    /// Settings for a <see cref="DatabaseAdminClient"/>.
    /// </summary>
    public sealed partial class DatabaseAdminSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="DatabaseAdminSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="DatabaseAdminSettings"/>.
        /// </returns>
        public static DatabaseAdminSettings GetDefault() => new DatabaseAdminSettings();

        /// <summary>
        /// Constructs a new <see cref="DatabaseAdminSettings"/> object with default settings.
        /// </summary>
        public DatabaseAdminSettings() { }

        private DatabaseAdminSettings(DatabaseAdminSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListDatabasesSettings = existing.ListDatabasesSettings;
            CreateDatabaseSettings = existing.CreateDatabaseSettings;
            CreateDatabaseOperationsSettings = existing.CreateDatabaseOperationsSettings?.Clone();
            GetDatabaseSettings = existing.GetDatabaseSettings;
            UpdateDatabaseDdlSettings = existing.UpdateDatabaseDdlSettings;
            UpdateDatabaseDdlOperationsSettings = existing.UpdateDatabaseDdlOperationsSettings?.Clone();
            DropDatabaseSettings = existing.DropDatabaseSettings;
            GetDatabaseDdlSettings = existing.GetDatabaseDdlSettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DatabaseAdminSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="DatabaseAdminClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="DatabaseAdminClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="DatabaseAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="DatabaseAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="DatabaseAdminClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="DatabaseAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="DatabaseAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="DatabaseAdminClient"/> RPC methods is defined as:
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
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.ListDatabases</c> and <c>DatabaseAdminClient.ListDatabasesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.ListDatabases</c> and
        /// <c>DatabaseAdminClient.ListDatabasesAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListDatabasesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.CreateDatabase</c> and <c>DatabaseAdminClient.CreateDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.CreateDatabase</c> and
        /// <c>DatabaseAdminClient.CreateDatabaseAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CreateDatabaseSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatabaseAdminClient.CreateDatabase</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45000 milliseconds</description></item>
        /// <item><description>Total timeout: 86400000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings CreateDatabaseOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(86400000L)),
                TimeSpan.FromMilliseconds(20000L),
                1.5,
                TimeSpan.FromMilliseconds(45000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.GetDatabase</c> and <c>DatabaseAdminClient.GetDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.GetDatabase</c> and
        /// <c>DatabaseAdminClient.GetDatabaseAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetDatabaseSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.UpdateDatabaseDdl</c> and <c>DatabaseAdminClient.UpdateDatabaseDdlAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.UpdateDatabaseDdl</c> and
        /// <c>DatabaseAdminClient.UpdateDatabaseDdlAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings UpdateDatabaseDdlSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatabaseAdminClient.UpdateDatabaseDdl</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45000 milliseconds</description></item>
        /// <item><description>Total timeout: 86400000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings UpdateDatabaseDdlOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(86400000L)),
                TimeSpan.FromMilliseconds(20000L),
                1.5,
                TimeSpan.FromMilliseconds(45000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.DropDatabase</c> and <c>DatabaseAdminClient.DropDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.DropDatabase</c> and
        /// <c>DatabaseAdminClient.DropDatabaseAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DropDatabaseSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.GetDatabaseDdl</c> and <c>DatabaseAdminClient.GetDatabaseDdlAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.GetDatabaseDdl</c> and
        /// <c>DatabaseAdminClient.GetDatabaseDdlAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetDatabaseDdlSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.SetIamPolicy</c> and <c>DatabaseAdminClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.SetIamPolicy</c> and
        /// <c>DatabaseAdminClient.SetIamPolicyAsync</c> <see cref="RetrySettings"/> are:
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
        /// <c>DatabaseAdminClient.GetIamPolicy</c> and <c>DatabaseAdminClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.GetIamPolicy</c> and
        /// <c>DatabaseAdminClient.GetIamPolicyAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetIamPolicySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseAdminClient.TestIamPermissions</c> and <c>DatabaseAdminClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatabaseAdminClient.TestIamPermissions</c> and
        /// <c>DatabaseAdminClient.TestIamPermissionsAsync</c> <see cref="RetrySettings"/> are:
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
        /// <returns>A deep clone of this <see cref="DatabaseAdminSettings"/> object.</returns>
        public DatabaseAdminSettings Clone() => new DatabaseAdminSettings(this);
    }

    /// <summary>
    /// DatabaseAdmin client wrapper, for convenient use.
    /// </summary>
    public abstract partial class DatabaseAdminClient
    {
        /// <summary>
        /// The default endpoint for the DatabaseAdmin service, which is a host of "spanner.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("spanner.googleapis.com", 443);

        /// <summary>
        /// The default DatabaseAdmin scopes.
        /// </summary>
        /// <remarks>
        /// The default DatabaseAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/spanner.admin"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/spanner.admin",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="DatabaseAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DatabaseAdminSettings"/>.</param>
        /// <returns>The task representing the created <see cref="DatabaseAdminClient"/>.</returns>
        public static async Task<DatabaseAdminClient> CreateAsync(ServiceEndpoint endpoint = null, DatabaseAdminSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="DatabaseAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DatabaseAdminSettings"/>.</param>
        /// <returns>The created <see cref="DatabaseAdminClient"/>.</returns>
        public static DatabaseAdminClient Create(ServiceEndpoint endpoint = null, DatabaseAdminSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="DatabaseAdminClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="DatabaseAdminSettings"/>.</param>
        /// <returns>The created <see cref="DatabaseAdminClient"/>.</returns>
        public static DatabaseAdminClient Create(Channel channel, DatabaseAdminSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            DatabaseAdmin.DatabaseAdminClient grpcClient = new DatabaseAdmin.DatabaseAdminClient(channel);
            return new DatabaseAdminClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, DatabaseAdminSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, DatabaseAdminSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, DatabaseAdminSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, DatabaseAdminSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC DatabaseAdmin client.
        /// </summary>
        public virtual DatabaseAdmin.DatabaseAdminClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Lists Cloud Spanner databases.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance whose databases should be listed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// A pageable asynchronous sequence of <see cref="Database"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListDatabasesResponse, Database> ListDatabasesAsync(
            InstanceName parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListDatabasesAsync(
                new ListDatabasesRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists Cloud Spanner databases.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance whose databases should be listed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// A pageable sequence of <see cref="Database"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListDatabasesResponse, Database> ListDatabases(
            InstanceName parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListDatabases(
                new ListDatabasesRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists Cloud Spanner databases.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Database"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListDatabasesResponse, Database> ListDatabasesAsync(
            ListDatabasesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists Cloud Spanner databases.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Database"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListDatabasesResponse, Database> ListDatabases(
            ListDatabasesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the instance that will serve the new database.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="createStatement">
        /// Required. A `CREATE DATABASE` statement, which specifies the ID of the
        /// new database.  The database ID must conform to the regular expression
        /// `[a-z][a-z0-9_\-]*[a-z0-9]` and be between 2 and 30 characters in length.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Database, CreateDatabaseMetadata>> CreateDatabaseAsync(
            InstanceName parent,
            string createStatement,
            CallSettings callSettings = null) => CreateDatabaseAsync(
                new CreateDatabaseRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    CreateStatement = GaxPreconditions.CheckNotNullOrEmpty(createStatement, nameof(createStatement)),
                },
                callSettings);

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the instance that will serve the new database.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="createStatement">
        /// Required. A `CREATE DATABASE` statement, which specifies the ID of the
        /// new database.  The database ID must conform to the regular expression
        /// `[a-z][a-z0-9_\-]*[a-z0-9]` and be between 2 and 30 characters in length.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Database, CreateDatabaseMetadata>> CreateDatabaseAsync(
            InstanceName parent,
            string createStatement,
            CancellationToken cancellationToken) => CreateDatabaseAsync(
                parent,
                createStatement,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the instance that will serve the new database.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="createStatement">
        /// Required. A `CREATE DATABASE` statement, which specifies the ID of the
        /// new database.  The database ID must conform to the regular expression
        /// `[a-z][a-z0-9_\-]*[a-z0-9]` and be between 2 and 30 characters in length.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Database, CreateDatabaseMetadata> CreateDatabase(
            InstanceName parent,
            string createStatement,
            CallSettings callSettings = null) => CreateDatabase(
                new CreateDatabaseRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    CreateStatement = GaxPreconditions.CheckNotNullOrEmpty(createStatement, nameof(createStatement)),
                },
                callSettings);

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
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
        public virtual Task<Operation<Database, CreateDatabaseMetadata>> CreateDatabaseAsync(
            CreateDatabaseRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDatabaseAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Database, CreateDatabaseMetadata>> PollOnceCreateDatabaseAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Database, CreateDatabaseMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateDatabaseOperationsClient,
                callSettings);

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
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
        public virtual Operation<Database, CreateDatabaseMetadata> CreateDatabase(
            CreateDatabaseRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateDatabase</c>.
        /// </summary>
        public virtual OperationsClient CreateDatabaseOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDatabase</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Database, CreateDatabaseMetadata> PollOnceCreateDatabase(
            string operationName,
            CallSettings callSettings = null) => Operation<Database, CreateDatabaseMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateDatabaseOperationsClient,
                callSettings);

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested database. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/databases/&lt;database&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Database> GetDatabaseAsync(
            DatabaseName name,
            CallSettings callSettings = null) => GetDatabaseAsync(
                new GetDatabaseRequest
                {
                    DatabaseName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested database. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/databases/&lt;database&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Database> GetDatabaseAsync(
            DatabaseName name,
            CancellationToken cancellationToken) => GetDatabaseAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested database. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/databases/&lt;database&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Database GetDatabase(
            DatabaseName name,
            CallSettings callSettings = null) => GetDatabase(
                new GetDatabaseRequest
                {
                    DatabaseName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
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
        public virtual Task<Database> GetDatabaseAsync(
            GetDatabaseRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
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
        public virtual Database GetDatabase(
            GetDatabaseRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].  The operation has no response.
        /// </summary>
        /// <param name="database">
        /// Required. The database to update.
        /// </param>
        /// <param name="statements">
        /// DDL statements to be applied to the database.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Empty, UpdateDatabaseDdlMetadata>> UpdateDatabaseDdlAsync(
            DatabaseName database,
            IEnumerable<string> statements,
            CallSettings callSettings = null) => UpdateDatabaseDdlAsync(
                new UpdateDatabaseDdlRequest
                {
                    DatabaseAsDatabaseName = GaxPreconditions.CheckNotNull(database, nameof(database)),
                    Statements = { GaxPreconditions.CheckNotNull(statements, nameof(statements)) },
                },
                callSettings);

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].  The operation has no response.
        /// </summary>
        /// <param name="database">
        /// Required. The database to update.
        /// </param>
        /// <param name="statements">
        /// DDL statements to be applied to the database.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Empty, UpdateDatabaseDdlMetadata>> UpdateDatabaseDdlAsync(
            DatabaseName database,
            IEnumerable<string> statements,
            CancellationToken cancellationToken) => UpdateDatabaseDdlAsync(
                database,
                statements,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].  The operation has no response.
        /// </summary>
        /// <param name="database">
        /// Required. The database to update.
        /// </param>
        /// <param name="statements">
        /// DDL statements to be applied to the database.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Empty, UpdateDatabaseDdlMetadata> UpdateDatabaseDdl(
            DatabaseName database,
            IEnumerable<string> statements,
            CallSettings callSettings = null) => UpdateDatabaseDdl(
                new UpdateDatabaseDdlRequest
                {
                    DatabaseAsDatabaseName = GaxPreconditions.CheckNotNull(database, nameof(database)),
                    Statements = { GaxPreconditions.CheckNotNull(statements, nameof(statements)) },
                },
                callSettings);

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].  The operation has no response.
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
        public virtual Task<Operation<Empty, UpdateDatabaseDdlMetadata>> UpdateDatabaseDdlAsync(
            UpdateDatabaseDdlRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDatabaseDdlAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Empty, UpdateDatabaseDdlMetadata>> PollOnceUpdateDatabaseDdlAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Empty, UpdateDatabaseDdlMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateDatabaseDdlOperationsClient,
                callSettings);

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].  The operation has no response.
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
        public virtual Operation<Empty, UpdateDatabaseDdlMetadata> UpdateDatabaseDdl(
            UpdateDatabaseDdlRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateDatabaseDdl</c>.
        /// </summary>
        public virtual OperationsClient UpdateDatabaseDdlOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDatabaseDdl</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Empty, UpdateDatabaseDdlMetadata> PollOnceUpdateDatabaseDdl(
            string operationName,
            CallSettings callSettings = null) => Operation<Empty, UpdateDatabaseDdlMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateDatabaseDdlOperationsClient,
                callSettings);

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
        /// </summary>
        /// <param name="database">
        /// Required. The database to be dropped.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DropDatabaseAsync(
            DatabaseName database,
            CallSettings callSettings = null) => DropDatabaseAsync(
                new DropDatabaseRequest
                {
                    DatabaseAsDatabaseName = GaxPreconditions.CheckNotNull(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
        /// </summary>
        /// <param name="database">
        /// Required. The database to be dropped.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DropDatabaseAsync(
            DatabaseName database,
            CancellationToken cancellationToken) => DropDatabaseAsync(
                database,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
        /// </summary>
        /// <param name="database">
        /// Required. The database to be dropped.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DropDatabase(
            DatabaseName database,
            CallSettings callSettings = null) => DropDatabase(
                new DropDatabaseRequest
                {
                    DatabaseAsDatabaseName = GaxPreconditions.CheckNotNull(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
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
        public virtual Task DropDatabaseAsync(
            DropDatabaseRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
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
        public virtual void DropDatabase(
            DropDatabaseRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
        /// </summary>
        /// <param name="database">
        /// Required. The database whose schema we wish to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<GetDatabaseDdlResponse> GetDatabaseDdlAsync(
            DatabaseName database,
            CallSettings callSettings = null) => GetDatabaseDdlAsync(
                new GetDatabaseDdlRequest
                {
                    DatabaseAsDatabaseName = GaxPreconditions.CheckNotNull(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
        /// </summary>
        /// <param name="database">
        /// Required. The database whose schema we wish to get.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<GetDatabaseDdlResponse> GetDatabaseDdlAsync(
            DatabaseName database,
            CancellationToken cancellationToken) => GetDatabaseDdlAsync(
                database,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
        /// </summary>
        /// <param name="database">
        /// Required. The database whose schema we wish to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual GetDatabaseDdlResponse GetDatabaseDdl(
            DatabaseName database,
            CallSettings callSettings = null) => GetDatabaseDdl(
                new GetDatabaseDdlRequest
                {
                    DatabaseAsDatabaseName = GaxPreconditions.CheckNotNull(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
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
        public virtual Task<GetDatabaseDdlResponse> GetDatabaseDdlAsync(
            GetDatabaseDdlRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
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
        public virtual GetDatabaseDdlResponse GetDatabaseDdl(
            GetDatabaseDdlRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on a database resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.databases.setIamPolicy` permission on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        /// Sets the access control policy on a database resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.databases.setIamPolicy` permission on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        /// Sets the access control policy on a database resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.databases.setIamPolicy` permission on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        /// Sets the access control policy on a database resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.databases.setIamPolicy` permission on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        /// Sets the access control policy on a database resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.databases.setIamPolicy` permission on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        /// Gets the access control policy for a database resource. Returns an empty
        /// policy if a database exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.databases.getIamPolicy` permission on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        /// Gets the access control policy for a database resource. Returns an empty
        /// policy if a database exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.databases.getIamPolicy` permission on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        /// Gets the access control policy for a database resource. Returns an empty
        /// policy if a database exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.databases.getIamPolicy` permission on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        /// Gets the access control policy for a database resource. Returns an empty
        /// policy if a database exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.databases.getIamPolicy` permission on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        /// Gets the access control policy for a database resource. Returns an empty
        /// policy if a database exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.databases.getIamPolicy` permission on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        /// Returns permissions that the caller has on the specified database resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner database will result in
        /// a NOT_FOUND error if the user has `spanner.databases.list` permission on
        /// the containing Cloud Spanner instance. Otherwise returns an empty set of
        /// permissions.
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
        /// Returns permissions that the caller has on the specified database resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner database will result in
        /// a NOT_FOUND error if the user has `spanner.databases.list` permission on
        /// the containing Cloud Spanner instance. Otherwise returns an empty set of
        /// permissions.
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
        /// Returns permissions that the caller has on the specified database resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner database will result in
        /// a NOT_FOUND error if the user has `spanner.databases.list` permission on
        /// the containing Cloud Spanner instance. Otherwise returns an empty set of
        /// permissions.
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
        /// Returns permissions that the caller has on the specified database resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner database will result in
        /// a NOT_FOUND error if the user has `spanner.databases.list` permission on
        /// the containing Cloud Spanner instance. Otherwise returns an empty set of
        /// permissions.
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
        /// Returns permissions that the caller has on the specified database resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner database will result in
        /// a NOT_FOUND error if the user has `spanner.databases.list` permission on
        /// the containing Cloud Spanner instance. Otherwise returns an empty set of
        /// permissions.
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
    /// DatabaseAdmin client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class DatabaseAdminClientImpl : DatabaseAdminClient
    {
        private readonly ApiCall<ListDatabasesRequest, ListDatabasesResponse> _callListDatabases;
        private readonly ApiCall<CreateDatabaseRequest, Operation> _callCreateDatabase;
        private readonly ApiCall<GetDatabaseRequest, Database> _callGetDatabase;
        private readonly ApiCall<UpdateDatabaseDdlRequest, Operation> _callUpdateDatabaseDdl;
        private readonly ApiCall<DropDatabaseRequest, Empty> _callDropDatabase;
        private readonly ApiCall<GetDatabaseDdlRequest, GetDatabaseDdlResponse> _callGetDatabaseDdl;
        private readonly ApiCall<SetIamPolicyRequest, Policy> _callSetIamPolicy;
        private readonly ApiCall<GetIamPolicyRequest, Policy> _callGetIamPolicy;
        private readonly ApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the DatabaseAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DatabaseAdminSettings"/> used within this client </param>
        public DatabaseAdminClientImpl(DatabaseAdmin.DatabaseAdminClient grpcClient, DatabaseAdminSettings settings)
        {
            GrpcClient = grpcClient;
            DatabaseAdminSettings effectiveSettings = settings ?? DatabaseAdminSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            CreateDatabaseOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateDatabaseOperationsSettings);
            UpdateDatabaseDdlOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDatabaseDdlOperationsSettings);
            _callListDatabases = clientHelper.BuildApiCall<ListDatabasesRequest, ListDatabasesResponse>(
                GrpcClient.ListDatabasesAsync, GrpcClient.ListDatabases, effectiveSettings.ListDatabasesSettings);
            _callCreateDatabase = clientHelper.BuildApiCall<CreateDatabaseRequest, Operation>(
                GrpcClient.CreateDatabaseAsync, GrpcClient.CreateDatabase, effectiveSettings.CreateDatabaseSettings);
            _callGetDatabase = clientHelper.BuildApiCall<GetDatabaseRequest, Database>(
                GrpcClient.GetDatabaseAsync, GrpcClient.GetDatabase, effectiveSettings.GetDatabaseSettings);
            _callUpdateDatabaseDdl = clientHelper.BuildApiCall<UpdateDatabaseDdlRequest, Operation>(
                GrpcClient.UpdateDatabaseDdlAsync, GrpcClient.UpdateDatabaseDdl, effectiveSettings.UpdateDatabaseDdlSettings);
            _callDropDatabase = clientHelper.BuildApiCall<DropDatabaseRequest, Empty>(
                GrpcClient.DropDatabaseAsync, GrpcClient.DropDatabase, effectiveSettings.DropDatabaseSettings);
            _callGetDatabaseDdl = clientHelper.BuildApiCall<GetDatabaseDdlRequest, GetDatabaseDdlResponse>(
                GrpcClient.GetDatabaseDdlAsync, GrpcClient.GetDatabaseDdl, effectiveSettings.GetDatabaseDdlSettings);
            _callSetIamPolicy = clientHelper.BuildApiCall<SetIamPolicyRequest, Policy>(
                GrpcClient.SetIamPolicyAsync, GrpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings);
            _callGetIamPolicy = clientHelper.BuildApiCall<GetIamPolicyRequest, Policy>(
                GrpcClient.GetIamPolicyAsync, GrpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings);
            _callTestIamPermissions = clientHelper.BuildApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse>(
                GrpcClient.TestIamPermissionsAsync, GrpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(DatabaseAdmin.DatabaseAdminClient grpcClient, DatabaseAdminSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC DatabaseAdmin client.
        /// </summary>
        public override DatabaseAdmin.DatabaseAdminClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_ListDatabasesRequest(ref ListDatabasesRequest request, ref CallSettings settings);
        partial void Modify_CreateDatabaseRequest(ref CreateDatabaseRequest request, ref CallSettings settings);
        partial void Modify_GetDatabaseRequest(ref GetDatabaseRequest request, ref CallSettings settings);
        partial void Modify_UpdateDatabaseDdlRequest(ref UpdateDatabaseDdlRequest request, ref CallSettings settings);
        partial void Modify_DropDatabaseRequest(ref DropDatabaseRequest request, ref CallSettings settings);
        partial void Modify_GetDatabaseDdlRequest(ref GetDatabaseDdlRequest request, ref CallSettings settings);
        partial void Modify_SetIamPolicyRequest(ref SetIamPolicyRequest request, ref CallSettings settings);
        partial void Modify_GetIamPolicyRequest(ref GetIamPolicyRequest request, ref CallSettings settings);
        partial void Modify_TestIamPermissionsRequest(ref TestIamPermissionsRequest request, ref CallSettings settings);

        /// <summary>
        /// Lists Cloud Spanner databases.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Database"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListDatabasesResponse, Database> ListDatabasesAsync(
            ListDatabasesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListDatabasesRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListDatabasesRequest, ListDatabasesResponse, Database>(_callListDatabases, request, callSettings);
        }

        /// <summary>
        /// Lists Cloud Spanner databases.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Database"/> resources.
        /// </returns>
        public override PagedEnumerable<ListDatabasesResponse, Database> ListDatabases(
            ListDatabasesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListDatabasesRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListDatabasesRequest, ListDatabasesResponse, Database>(_callListDatabases, request, callSettings);
        }

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
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
        public override async Task<Operation<Database, CreateDatabaseMetadata>> CreateDatabaseAsync(
            CreateDatabaseRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateDatabaseRequest(ref request, ref callSettings);
            return new Operation<Database, CreateDatabaseMetadata>(
                await _callCreateDatabase.Async(request, callSettings).ConfigureAwait(false), CreateDatabaseOperationsClient);
        }

        /// <summary>
        /// Creates a new Cloud Spanner database and starts to prepare it for serving.
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track preparation of the database. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateDatabaseMetadata][google.spanner.admin.database.v1.CreateDatabaseMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Database][google.spanner.admin.database.v1.Database], if successful.
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
        public override Operation<Database, CreateDatabaseMetadata> CreateDatabase(
            CreateDatabaseRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateDatabaseRequest(ref request, ref callSettings);
            return new Operation<Database, CreateDatabaseMetadata>(
                _callCreateDatabase.Sync(request, callSettings), CreateDatabaseOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateDatabase</c>.
        /// </summary>
        public override OperationsClient CreateDatabaseOperationsClient { get; }

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
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
        public override Task<Database> GetDatabaseAsync(
            GetDatabaseRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetDatabaseRequest(ref request, ref callSettings);
            return _callGetDatabase.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the state of a Cloud Spanner database.
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
        public override Database GetDatabase(
            GetDatabaseRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetDatabaseRequest(ref request, ref callSettings);
            return _callGetDatabase.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].  The operation has no response.
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
        public override async Task<Operation<Empty, UpdateDatabaseDdlMetadata>> UpdateDatabaseDdlAsync(
            UpdateDatabaseDdlRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateDatabaseDdlRequest(ref request, ref callSettings);
            return new Operation<Empty, UpdateDatabaseDdlMetadata>(
                await _callUpdateDatabaseDdl.Async(request, callSettings).ConfigureAwait(false), UpdateDatabaseDdlOperationsClient);
        }

        /// <summary>
        /// Updates the schema of a Cloud Spanner database by
        /// creating/altering/dropping tables, columns, indexes, etc. The returned
        /// [long-running operation][google.longrunning.Operation] will have a name of
        /// the format `&lt;database_name&gt;/operations/&lt;operation_id&gt;` and can be used to
        /// track execution of the schema change(s). The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateDatabaseDdlMetadata][google.spanner.admin.database.v1.UpdateDatabaseDdlMetadata].  The operation has no response.
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
        public override Operation<Empty, UpdateDatabaseDdlMetadata> UpdateDatabaseDdl(
            UpdateDatabaseDdlRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateDatabaseDdlRequest(ref request, ref callSettings);
            return new Operation<Empty, UpdateDatabaseDdlMetadata>(
                _callUpdateDatabaseDdl.Sync(request, callSettings), UpdateDatabaseDdlOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateDatabaseDdl</c>.
        /// </summary>
        public override OperationsClient UpdateDatabaseDdlOperationsClient { get; }

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
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
        public override Task DropDatabaseAsync(
            DropDatabaseRequest request,
            CallSettings callSettings = null)
        {
            Modify_DropDatabaseRequest(ref request, ref callSettings);
            return _callDropDatabase.Async(request, callSettings);
        }

        /// <summary>
        /// Drops (aka deletes) a Cloud Spanner database.
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
        public override void DropDatabase(
            DropDatabaseRequest request,
            CallSettings callSettings = null)
        {
            Modify_DropDatabaseRequest(ref request, ref callSettings);
            _callDropDatabase.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
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
        public override Task<GetDatabaseDdlResponse> GetDatabaseDdlAsync(
            GetDatabaseDdlRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetDatabaseDdlRequest(ref request, ref callSettings);
            return _callGetDatabaseDdl.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the schema of a Cloud Spanner database as a list of formatted
        /// DDL statements. This method does not show pending schema updates, those may
        /// be queried using the [Operations][google.longrunning.Operations] API.
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
        public override GetDatabaseDdlResponse GetDatabaseDdl(
            GetDatabaseDdlRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetDatabaseDdlRequest(ref request, ref callSettings);
            return _callGetDatabaseDdl.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on a database resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.databases.setIamPolicy` permission on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        /// Sets the access control policy on a database resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.databases.setIamPolicy` permission on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        /// Gets the access control policy for a database resource. Returns an empty
        /// policy if a database exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.databases.getIamPolicy` permission on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        /// Gets the access control policy for a database resource. Returns an empty
        /// policy if a database exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.databases.getIamPolicy` permission on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        /// Returns permissions that the caller has on the specified database resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner database will result in
        /// a NOT_FOUND error if the user has `spanner.databases.list` permission on
        /// the containing Cloud Spanner instance. Otherwise returns an empty set of
        /// permissions.
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
        /// Returns permissions that the caller has on the specified database resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner database will result in
        /// a NOT_FOUND error if the user has `spanner.databases.list` permission on
        /// the containing Cloud Spanner instance. Otherwise returns an empty set of
        /// permissions.
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

    public partial class ListDatabasesRequest : IPageRequest { }
    public partial class ListDatabasesResponse : IPageResponse<Database>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<Database> GetEnumerator() => Databases.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class DatabaseAdmin
    {
        public partial class DatabaseAdminClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual Operations.OperationsClient CreateOperationsClient() => new Operations.OperationsClient(CallInvoker);
        }
    }


}
