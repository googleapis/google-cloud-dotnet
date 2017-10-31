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
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.Admin.V2
{
    /// <summary>
    /// Settings for a <see cref="BigtableTableAdminClient"/>.
    /// </summary>
    public sealed partial class BigtableTableAdminSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="BigtableTableAdminSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="BigtableTableAdminSettings"/>.
        /// </returns>
        public static BigtableTableAdminSettings GetDefault() => new BigtableTableAdminSettings();

        /// <summary>
        /// Constructs a new <see cref="BigtableTableAdminSettings"/> object with default settings.
        /// </summary>
        public BigtableTableAdminSettings() { }

        private BigtableTableAdminSettings(BigtableTableAdminSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateTableSettings = existing.CreateTableSettings;
            ListTablesSettings = existing.ListTablesSettings;
            GetTableSettings = existing.GetTableSettings;
            DeleteTableSettings = existing.DeleteTableSettings;
            ModifyColumnFamiliesSettings = existing.ModifyColumnFamiliesSettings;
            DropRowRangeSettings = existing.DropRowRangeSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BigtableTableAdminSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="BigtableTableAdminClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods is defined as:
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
        /// <c>BigtableTableAdminClient.CreateTable</c> and <c>BigtableTableAdminClient.CreateTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.CreateTable</c> and
        /// <c>BigtableTableAdminClient.CreateTableAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateTableSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.ListTables</c> and <c>BigtableTableAdminClient.ListTablesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.ListTables</c> and
        /// <c>BigtableTableAdminClient.ListTablesAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListTablesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.GetTable</c> and <c>BigtableTableAdminClient.GetTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.GetTable</c> and
        /// <c>BigtableTableAdminClient.GetTableAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetTableSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.DeleteTable</c> and <c>BigtableTableAdminClient.DeleteTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.DeleteTable</c> and
        /// <c>BigtableTableAdminClient.DeleteTableAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteTableSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.ModifyColumnFamilies</c> and <c>BigtableTableAdminClient.ModifyColumnFamiliesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.ModifyColumnFamilies</c> and
        /// <c>BigtableTableAdminClient.ModifyColumnFamiliesAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ModifyColumnFamiliesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.DropRowRange</c> and <c>BigtableTableAdminClient.DropRowRangeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.DropRowRange</c> and
        /// <c>BigtableTableAdminClient.DropRowRangeAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DropRowRangeSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="BigtableTableAdminSettings"/> object.</returns>
        public BigtableTableAdminSettings Clone() => new BigtableTableAdminSettings(this);
    }

    /// <summary>
    /// BigtableTableAdmin client wrapper, for convenient use.
    /// </summary>
    public abstract partial class BigtableTableAdminClient
    {
        /// <summary>
        /// The default endpoint for the BigtableTableAdmin service, which is a host of "bigtableadmin.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("bigtableadmin.googleapis.com", 443);

        /// <summary>
        /// The default BigtableTableAdmin scopes.
        /// </summary>
        /// <remarks>
        /// The default BigtableTableAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin.cluster"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin.instance"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin.table"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.admin.cluster"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.admin.table"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform.read-only"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/bigtable.admin",
            "https://www.googleapis.com/auth/bigtable.admin.cluster",
            "https://www.googleapis.com/auth/bigtable.admin.instance",
            "https://www.googleapis.com/auth/bigtable.admin.table",
            "https://www.googleapis.com/auth/cloud-bigtable.admin",
            "https://www.googleapis.com/auth/cloud-bigtable.admin.cluster",
            "https://www.googleapis.com/auth/cloud-bigtable.admin.table",
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
        /// Asynchronously creates a <see cref="BigtableTableAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableTableAdminSettings"/>.</param>
        /// <returns>The task representing the created <see cref="BigtableTableAdminClient"/>.</returns>
        public static async Task<BigtableTableAdminClient> CreateAsync(ServiceEndpoint endpoint = null, BigtableTableAdminSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="BigtableTableAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableTableAdminSettings"/>.</param>
        /// <returns>The created <see cref="BigtableTableAdminClient"/>.</returns>
        public static BigtableTableAdminClient Create(ServiceEndpoint endpoint = null, BigtableTableAdminSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="BigtableTableAdminClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BigtableTableAdminSettings"/>.</param>
        /// <returns>The created <see cref="BigtableTableAdminClient"/>.</returns>
        public static BigtableTableAdminClient Create(Channel channel, BigtableTableAdminSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            BigtableTableAdmin.BigtableTableAdminClient grpcClient = new BigtableTableAdmin.BigtableTableAdminClient(channel);
            return new BigtableTableAdminClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, BigtableTableAdminSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, BigtableTableAdminSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, BigtableTableAdminSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, BigtableTableAdminSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC BigtableTableAdmin client.
        /// </summary>
        public virtual BigtableTableAdmin.BigtableTableAdminClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the table.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="tableId">
        /// The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `&lt;parent&gt;/tables/foobar`.
        /// </param>
        /// <param name="table">
        /// The Table to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Table> CreateTableAsync(
            InstanceName parent,
            string tableId,
            Table table,
            CallSettings callSettings = null) => CreateTableAsync(
                new CreateTableRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    TableId = GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                    Table = GaxPreconditions.CheckNotNull(table, nameof(table)),
                },
                callSettings);

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the table.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="tableId">
        /// The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `&lt;parent&gt;/tables/foobar`.
        /// </param>
        /// <param name="table">
        /// The Table to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Table> CreateTableAsync(
            InstanceName parent,
            string tableId,
            Table table,
            CancellationToken cancellationToken) => CreateTableAsync(
                parent,
                tableId,
                table,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the table.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="tableId">
        /// The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `&lt;parent&gt;/tables/foobar`.
        /// </param>
        /// <param name="table">
        /// The Table to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Table CreateTable(
            InstanceName parent,
            string tableId,
            Table table,
            CallSettings callSettings = null) => CreateTable(
                new CreateTableRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    TableId = GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                    Table = GaxPreconditions.CheckNotNull(table, nameof(table)),
                },
                callSettings);

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
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
        public virtual Task<Table> CreateTableAsync(
            CreateTableRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
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
        public virtual Table CreateTable(
            CreateTableRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which tables should be listed.
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
        /// A pageable asynchronous sequence of <see cref="Table"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListTablesResponse, Table> ListTablesAsync(
            InstanceName parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTablesAsync(
                new ListTablesRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which tables should be listed.
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
        /// A pageable sequence of <see cref="Table"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListTablesResponse, Table> ListTables(
            InstanceName parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTables(
                new ListTablesRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Table"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListTablesResponse, Table> ListTablesAsync(
            ListTablesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Table"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListTablesResponse, Table> ListTables(
            ListTablesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested table.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Table> GetTableAsync(
            TableName name,
            CallSettings callSettings = null) => GetTableAsync(
                new GetTableRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested table.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Table> GetTableAsync(
            TableName name,
            CancellationToken cancellationToken) => GetTableAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested table.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Table GetTable(
            TableName name,
            CallSettings callSettings = null) => GetTable(
                new GetTableRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets metadata information about the specified table.
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
        public virtual Task<Table> GetTableAsync(
            GetTableRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets metadata information about the specified table.
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
        public virtual Table GetTable(
            GetTableRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table to be deleted.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteTableAsync(
            TableName name,
            CallSettings callSettings = null) => DeleteTableAsync(
                new DeleteTableRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table to be deleted.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteTableAsync(
            TableName name,
            CancellationToken cancellationToken) => DeleteTableAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table to be deleted.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteTable(
            TableName name,
            CallSettings callSettings = null) => DeleteTable(
                new DeleteTableRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
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
        public virtual Task DeleteTableAsync(
            DeleteTableRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
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
        public virtual void DeleteTable(
            DeleteTableRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table whose families should be modified.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="modifications">
        /// Modifications to be atomically applied to the specified table's families.
        /// Entries are applied in order, meaning that earlier modifications can be
        /// masked by later ones (in the case of repeated updates to the same family,
        /// for example).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Table> ModifyColumnFamiliesAsync(
            TableName name,
            IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications,
            CallSettings callSettings = null) => ModifyColumnFamiliesAsync(
                new ModifyColumnFamiliesRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Modifications = { GaxPreconditions.CheckNotNull(modifications, nameof(modifications)) },
                },
                callSettings);

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table whose families should be modified.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="modifications">
        /// Modifications to be atomically applied to the specified table's families.
        /// Entries are applied in order, meaning that earlier modifications can be
        /// masked by later ones (in the case of repeated updates to the same family,
        /// for example).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Table> ModifyColumnFamiliesAsync(
            TableName name,
            IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications,
            CancellationToken cancellationToken) => ModifyColumnFamiliesAsync(
                name,
                modifications,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table whose families should be modified.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="modifications">
        /// Modifications to be atomically applied to the specified table's families.
        /// Entries are applied in order, meaning that earlier modifications can be
        /// masked by later ones (in the case of repeated updates to the same family,
        /// for example).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Table ModifyColumnFamilies(
            TableName name,
            IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications,
            CallSettings callSettings = null) => ModifyColumnFamilies(
                new ModifyColumnFamiliesRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Modifications = { GaxPreconditions.CheckNotNull(modifications, nameof(modifications)) },
                },
                callSettings);

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
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
        public virtual Task<Table> ModifyColumnFamiliesAsync(
            ModifyColumnFamiliesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
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
        public virtual Table ModifyColumnFamilies(
            ModifyColumnFamiliesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table on which to drop a range of rows.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKeyPrefix">
        /// Delete all rows that start with this row key prefix. Prefix cannot be
        /// zero length.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DropRowRangeAsync(
            string name,
            ByteString rowKeyPrefix,
            CallSettings callSettings = null) => DropRowRangeAsync(
                new DropRowRangeRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    RowKeyPrefix = rowKeyPrefix ?? ByteString.Empty, // Optional
                },
                callSettings);

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table on which to drop a range of rows.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKeyPrefix">
        /// Delete all rows that start with this row key prefix. Prefix cannot be
        /// zero length.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DropRowRangeAsync(
            string name,
            ByteString rowKeyPrefix,
            CancellationToken cancellationToken) => DropRowRangeAsync(
                name,
                rowKeyPrefix,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table on which to drop a range of rows.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKeyPrefix">
        /// Delete all rows that start with this row key prefix. Prefix cannot be
        /// zero length.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DropRowRange(
            string name,
            ByteString rowKeyPrefix,
            CallSettings callSettings = null) => DropRowRange(
                new DropRowRangeRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    RowKeyPrefix = rowKeyPrefix ?? ByteString.Empty, // Optional
                },
                callSettings);

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
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
        public virtual Task DropRowRangeAsync(
            DropRowRangeRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
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
        public virtual void DropRowRange(
            DropRowRangeRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// BigtableTableAdmin client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class BigtableTableAdminClientImpl : BigtableTableAdminClient
    {
        private readonly ApiCall<CreateTableRequest, Table> _callCreateTable;
        private readonly ApiCall<ListTablesRequest, ListTablesResponse> _callListTables;
        private readonly ApiCall<GetTableRequest, Table> _callGetTable;
        private readonly ApiCall<DeleteTableRequest, Empty> _callDeleteTable;
        private readonly ApiCall<ModifyColumnFamiliesRequest, Table> _callModifyColumnFamilies;
        private readonly ApiCall<DropRowRangeRequest, Empty> _callDropRowRange;

        /// <summary>
        /// Constructs a client wrapper for the BigtableTableAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigtableTableAdminSettings"/> used within this client </param>
        public BigtableTableAdminClientImpl(BigtableTableAdmin.BigtableTableAdminClient grpcClient, BigtableTableAdminSettings settings)
        {
            GrpcClient = grpcClient;
            BigtableTableAdminSettings effectiveSettings = settings ?? BigtableTableAdminSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callCreateTable = clientHelper.BuildApiCall<CreateTableRequest, Table>(
                GrpcClient.CreateTableAsync, GrpcClient.CreateTable, effectiveSettings.CreateTableSettings);
            _callListTables = clientHelper.BuildApiCall<ListTablesRequest, ListTablesResponse>(
                GrpcClient.ListTablesAsync, GrpcClient.ListTables, effectiveSettings.ListTablesSettings);
            _callGetTable = clientHelper.BuildApiCall<GetTableRequest, Table>(
                GrpcClient.GetTableAsync, GrpcClient.GetTable, effectiveSettings.GetTableSettings);
            _callDeleteTable = clientHelper.BuildApiCall<DeleteTableRequest, Empty>(
                GrpcClient.DeleteTableAsync, GrpcClient.DeleteTable, effectiveSettings.DeleteTableSettings);
            _callModifyColumnFamilies = clientHelper.BuildApiCall<ModifyColumnFamiliesRequest, Table>(
                GrpcClient.ModifyColumnFamiliesAsync, GrpcClient.ModifyColumnFamilies, effectiveSettings.ModifyColumnFamiliesSettings);
            _callDropRowRange = clientHelper.BuildApiCall<DropRowRangeRequest, Empty>(
                GrpcClient.DropRowRangeAsync, GrpcClient.DropRowRange, effectiveSettings.DropRowRangeSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(BigtableTableAdmin.BigtableTableAdminClient grpcClient, BigtableTableAdminSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC BigtableTableAdmin client.
        /// </summary>
        public override BigtableTableAdmin.BigtableTableAdminClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_CreateTableRequest(ref CreateTableRequest request, ref CallSettings settings);
        partial void Modify_ListTablesRequest(ref ListTablesRequest request, ref CallSettings settings);
        partial void Modify_GetTableRequest(ref GetTableRequest request, ref CallSettings settings);
        partial void Modify_DeleteTableRequest(ref DeleteTableRequest request, ref CallSettings settings);
        partial void Modify_ModifyColumnFamiliesRequest(ref ModifyColumnFamiliesRequest request, ref CallSettings settings);
        partial void Modify_DropRowRangeRequest(ref DropRowRangeRequest request, ref CallSettings settings);

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
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
        public override Task<Table> CreateTableAsync(
            CreateTableRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateTableRequest(ref request, ref callSettings);
            return _callCreateTable.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
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
        public override Table CreateTable(
            CreateTableRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateTableRequest(ref request, ref callSettings);
            return _callCreateTable.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Table"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListTablesResponse, Table> ListTablesAsync(
            ListTablesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTablesRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListTablesRequest, ListTablesResponse, Table>(_callListTables, request, callSettings);
        }

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Table"/> resources.
        /// </returns>
        public override PagedEnumerable<ListTablesResponse, Table> ListTables(
            ListTablesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTablesRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListTablesRequest, ListTablesResponse, Table>(_callListTables, request, callSettings);
        }

        /// <summary>
        /// Gets metadata information about the specified table.
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
        public override Task<Table> GetTableAsync(
            GetTableRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetTableRequest(ref request, ref callSettings);
            return _callGetTable.Async(request, callSettings);
        }

        /// <summary>
        /// Gets metadata information about the specified table.
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
        public override Table GetTable(
            GetTableRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetTableRequest(ref request, ref callSettings);
            return _callGetTable.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
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
        public override Task DeleteTableAsync(
            DeleteTableRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteTableRequest(ref request, ref callSettings);
            return _callDeleteTable.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
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
        public override void DeleteTable(
            DeleteTableRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteTableRequest(ref request, ref callSettings);
            _callDeleteTable.Sync(request, callSettings);
        }

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
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
        public override Task<Table> ModifyColumnFamiliesAsync(
            ModifyColumnFamiliesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ModifyColumnFamiliesRequest(ref request, ref callSettings);
            return _callModifyColumnFamilies.Async(request, callSettings);
        }

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
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
        public override Table ModifyColumnFamilies(
            ModifyColumnFamiliesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ModifyColumnFamiliesRequest(ref request, ref callSettings);
            return _callModifyColumnFamilies.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
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
        public override Task DropRowRangeAsync(
            DropRowRangeRequest request,
            CallSettings callSettings = null)
        {
            Modify_DropRowRangeRequest(ref request, ref callSettings);
            return _callDropRowRange.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
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
        public override void DropRowRange(
            DropRowRangeRequest request,
            CallSettings callSettings = null)
        {
            Modify_DropRowRangeRequest(ref request, ref callSettings);
            _callDropRowRange.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListTablesRequest : IPageRequest { }
    public partial class ListTablesResponse : IPageResponse<Table>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<Table> GetEnumerator() => Tables.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
