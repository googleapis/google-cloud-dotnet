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
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Datastore.V1
{

    /// <summary>
    /// Extension methods to assist with using <see cref="DatastoreClient"/>.
    /// </summary>
    public static partial class DatastoreExtensions
    {
        /// <summary>
        /// Wrap a GRPC Datastore client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="DatastoreSettings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="DatastoreClient"/> that wraps the specified GRPC client.</returns>
        public static DatastoreClient ToClient(
            this Datastore.DatastoreClient grpcClient,
            DatastoreSettings settings = null
        ) => new DatastoreClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a Datastore wrapper.
    /// </summary>
    public sealed partial class DatastoreSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="DatastoreSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default DatastoreSettings.</returns>
        public static DatastoreSettings GetDefault() => new DatastoreSettings();

        /// <summary>
        /// Constructs a new DatastoreSettings object with default settings.
        /// </summary>
        public DatastoreSettings() { }

        private DatastoreSettings(DatastoreSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            LookupSettings = existing.LookupSettings?.Clone();
            RunQuerySettings = existing.RunQuerySettings?.Clone();
            BeginTransactionSettings = existing.BeginTransactionSettings?.Clone();
            CommitSettings = existing.CommitSettings?.Clone();
            RollbackSettings = existing.RollbackSettings?.Clone();
            AllocateIdsSettings = existing.AllocateIdsSettings?.Clone();
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="DatastoreClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="DatastoreClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="DatastoreClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" retry backoff for <see cref="DatastoreClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="DatastoreClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="DatastoreClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" timeout backoff for <see cref="DatastoreClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="DatastoreClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(60000),
            DelayMultiplier = 1.0,
            MaxDelay = TimeSpan.FromMilliseconds(60000),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="DatastoreClient.Lookup"/> and <see cref="DatastoreClient.LookupAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="DatastoreClient.Lookup"/> and
        /// <see cref="DatastoreClient.LookupAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        public CallSettings LookupSettings { get; set; } = new CallSettings
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
        /// <see cref="DatastoreClient.RunQuery"/> and <see cref="DatastoreClient.RunQueryAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="DatastoreClient.RunQuery"/> and
        /// <see cref="DatastoreClient.RunQueryAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        public CallSettings RunQuerySettings { get; set; } = new CallSettings
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
        /// <see cref="DatastoreClient.BeginTransaction"/> and <see cref="DatastoreClient.BeginTransactionAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="DatastoreClient.BeginTransaction"/> and
        /// <see cref="DatastoreClient.BeginTransactionAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        public CallSettings BeginTransactionSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="DatastoreClient.Commit"/> and <see cref="DatastoreClient.CommitAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="DatastoreClient.Commit"/> and
        /// <see cref="DatastoreClient.CommitAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        public CallSettings CommitSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="DatastoreClient.Rollback"/> and <see cref="DatastoreClient.RollbackAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="DatastoreClient.Rollback"/> and
        /// <see cref="DatastoreClient.RollbackAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        public CallSettings RollbackSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="DatastoreClient.AllocateIds"/> and <see cref="DatastoreClient.AllocateIdsAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="DatastoreClient.AllocateIds"/> and
        /// <see cref="DatastoreClient.AllocateIdsAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
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
        public CallSettings AllocateIdsSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };


        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of Datastore settings.</returns>
        public DatastoreSettings Clone() => new DatastoreSettings(this);
    }

    /// <summary>
    /// Datastore client wrapper, for convenient use.
    /// </summary>
    public abstract partial class DatastoreClient
    {
        /// <summary>
        /// The default endpoint for the Datastore service, which is a host of "datastore.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("datastore.googleapis.com", 443);

        /// <summary>
        /// The default Datastore scopes
        /// </summary>
        /// <remarks>
        /// The default Datastore scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/datastore"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/datastore",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="DatastoreClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DatastoreSettings"/>.</param>
        /// <returns>The task representing the created <see cref="DatastoreClient"/>.</returns>
        public static async Task<DatastoreClient> CreateAsync(ServiceEndpoint endpoint = null, DatastoreSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="DatastoreClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DatastoreSettings"/>.</param>
        /// <returns>The created <see cref="DatastoreClient"/>.</returns>
        public static DatastoreClient Create(ServiceEndpoint endpoint = null, DatastoreSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="DatastoreClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="DatastoreSettings"/>.</param>
        /// <returns>The created <see cref="DatastoreClient"/>.</returns>
        public static DatastoreClient Create(Channel channel, DatastoreSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            Datastore.DatastoreClient grpcClient = new Datastore.DatastoreClient(channel);
            return new DatastoreClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, DatastoreSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, DatastoreSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, DatastoreSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, DatastoreSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying GRPC Datastore client.
        /// </summary>
        public virtual Datastore.DatastoreClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Looks up entities by key.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="readOptions">The options for this lookup request.</param>
        /// <param name="keys">Keys of entities to look up.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LookupResponse> LookupAsync(
            string projectId,
            ReadOptions readOptions,
            IEnumerable<Key> keys,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Looks up entities by key.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="readOptions">The options for this lookup request.</param>
        /// <param name="keys">Keys of entities to look up.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LookupResponse> LookupAsync(
            string projectId,
            ReadOptions readOptions,
            IEnumerable<Key> keys,
            CancellationToken cancellationToken) => LookupAsync(
                projectId,
                readOptions,
                keys,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Looks up entities by key.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="readOptions">The options for this lookup request.</param>
        /// <param name="keys">Keys of entities to look up.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupResponse Lookup(
            string projectId,
            ReadOptions readOptions,
            IEnumerable<Key> keys,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Queries for entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="partitionId">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="readOptions">The options for this query.</param>
        /// <param name="query">The query to run.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<RunQueryResponse> RunQueryAsync(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            Query query,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Queries for entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="partitionId">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="readOptions">The options for this query.</param>
        /// <param name="query">The query to run.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<RunQueryResponse> RunQueryAsync(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            Query query,
            CancellationToken cancellationToken) => RunQueryAsync(
                projectId,
                partitionId,
                readOptions,
                query,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Queries for entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="partitionId">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="readOptions">The options for this query.</param>
        /// <param name="query">The query to run.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunQueryResponse RunQuery(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            Query query,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Queries for entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="partitionId">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="readOptions">The options for this query.</param>
        /// <param name="gqlQuery">The GQL query to run.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<RunQueryResponse> RunQueryAsync(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            GqlQuery gqlQuery,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Queries for entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="partitionId">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="readOptions">The options for this query.</param>
        /// <param name="gqlQuery">The GQL query to run.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<RunQueryResponse> RunQueryAsync(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            GqlQuery gqlQuery,
            CancellationToken cancellationToken) => RunQueryAsync(
                projectId,
                partitionId,
                readOptions,
                gqlQuery,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Queries for entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="partitionId">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="readOptions">The options for this query.</param>
        /// <param name="gqlQuery">The GQL query to run.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunQueryResponse RunQuery(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            GqlQuery gqlQuery,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Begins a new transaction.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<BeginTransactionResponse> BeginTransactionAsync(
            string projectId,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Begins a new transaction.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<BeginTransactionResponse> BeginTransactionAsync(
            string projectId,
            CancellationToken cancellationToken) => BeginTransactionAsync(
                projectId,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Begins a new transaction.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BeginTransactionResponse BeginTransaction(
            string projectId,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="transaction">
        /// The identifier of the transaction associated with the commit. A
        /// transaction identifier is returned by a call to
        /// [Datastore.BeginTransaction][google.datastore.v1.Datastore.BeginTransaction].
        /// </param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        ///
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<CommitResponse> CommitAsync(
            string projectId,
            CommitRequest.Types.Mode mode,
            ByteString transaction,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="transaction">
        /// The identifier of the transaction associated with the commit. A
        /// transaction identifier is returned by a call to
        /// [Datastore.BeginTransaction][google.datastore.v1.Datastore.BeginTransaction].
        /// </param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        ///
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<CommitResponse> CommitAsync(
            string projectId,
            CommitRequest.Types.Mode mode,
            ByteString transaction,
            IEnumerable<Mutation> mutations,
            CancellationToken cancellationToken) => CommitAsync(
                projectId,
                mode,
                transaction,
                mutations,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="transaction">
        /// The identifier of the transaction associated with the commit. A
        /// transaction identifier is returned by a call to
        /// [Datastore.BeginTransaction][google.datastore.v1.Datastore.BeginTransaction].
        /// </param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        ///
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitResponse Commit(
            string projectId,
            CommitRequest.Types.Mode mode,
            ByteString transaction,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        ///
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<CommitResponse> CommitAsync(
            string projectId,
            CommitRequest.Types.Mode mode,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        ///
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<CommitResponse> CommitAsync(
            string projectId,
            CommitRequest.Types.Mode mode,
            IEnumerable<Mutation> mutations,
            CancellationToken cancellationToken) => CommitAsync(
                projectId,
                mode,
                mutations,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        ///
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitResponse Commit(
            string projectId,
            CommitRequest.Types.Mode mode,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="transaction">
        /// The transaction identifier, returned by a call to
        /// [Datastore.BeginTransaction][google.datastore.v1.Datastore.BeginTransaction].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<RollbackResponse> RollbackAsync(
            string projectId,
            ByteString transaction,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="transaction">
        /// The transaction identifier, returned by a call to
        /// [Datastore.BeginTransaction][google.datastore.v1.Datastore.BeginTransaction].
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<RollbackResponse> RollbackAsync(
            string projectId,
            ByteString transaction,
            CancellationToken cancellationToken) => RollbackAsync(
                projectId,
                transaction,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="transaction">
        /// The transaction identifier, returned by a call to
        /// [Datastore.BeginTransaction][google.datastore.v1.Datastore.BeginTransaction].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RollbackResponse Rollback(
            string projectId,
            ByteString transaction,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allocates IDs for the given keys, which is useful for referencing an entity
        /// before it is inserted.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="keys">
        /// A list of keys with incomplete key paths for which to allocate IDs.
        /// No key may be reserved/read-only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<AllocateIdsResponse> AllocateIdsAsync(
            string projectId,
            IEnumerable<Key> keys,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allocates IDs for the given keys, which is useful for referencing an entity
        /// before it is inserted.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="keys">
        /// A list of keys with incomplete key paths for which to allocate IDs.
        /// No key may be reserved/read-only.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<AllocateIdsResponse> AllocateIdsAsync(
            string projectId,
            IEnumerable<Key> keys,
            CancellationToken cancellationToken) => AllocateIdsAsync(
                projectId,
                keys,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Allocates IDs for the given keys, which is useful for referencing an entity
        /// before it is inserted.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="keys">
        /// A list of keys with incomplete key paths for which to allocate IDs.
        /// No key may be reserved/read-only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AllocateIdsResponse AllocateIds(
            string projectId,
            IEnumerable<Key> keys,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class DatastoreClientImpl : DatastoreClient
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<LookupRequest, LookupResponse> _callLookup;
        private readonly ApiCall<RunQueryRequest, RunQueryResponse> _callRunQuery;
        private readonly ApiCall<BeginTransactionRequest, BeginTransactionResponse> _callBeginTransaction;
        private readonly ApiCall<CommitRequest, CommitResponse> _callCommit;
        private readonly ApiCall<RollbackRequest, RollbackResponse> _callRollback;
        private readonly ApiCall<AllocateIdsRequest, AllocateIdsResponse> _callAllocateIds;

        public DatastoreClientImpl(Datastore.DatastoreClient grpcClient, DatastoreSettings settings)
        {
            this.GrpcClient = grpcClient;
            DatastoreSettings effectiveSettings = settings ?? DatastoreSettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callLookup = _clientHelper.BuildApiCall<LookupRequest, LookupResponse>(
                GrpcClient.LookupAsync, GrpcClient.Lookup, effectiveSettings.LookupSettings);
            _callRunQuery = _clientHelper.BuildApiCall<RunQueryRequest, RunQueryResponse>(
                GrpcClient.RunQueryAsync, GrpcClient.RunQuery, effectiveSettings.RunQuerySettings);
            _callBeginTransaction = _clientHelper.BuildApiCall<BeginTransactionRequest, BeginTransactionResponse>(
                GrpcClient.BeginTransactionAsync, GrpcClient.BeginTransaction, effectiveSettings.BeginTransactionSettings);
            _callCommit = _clientHelper.BuildApiCall<CommitRequest, CommitResponse>(
                GrpcClient.CommitAsync, GrpcClient.Commit, effectiveSettings.CommitSettings);
            _callRollback = _clientHelper.BuildApiCall<RollbackRequest, RollbackResponse>(
                GrpcClient.RollbackAsync, GrpcClient.Rollback, effectiveSettings.RollbackSettings);
            _callAllocateIds = _clientHelper.BuildApiCall<AllocateIdsRequest, AllocateIdsResponse>(
                GrpcClient.AllocateIdsAsync, GrpcClient.AllocateIds, effectiveSettings.AllocateIdsSettings);
        }

        public override Datastore.DatastoreClient GrpcClient { get; }

        /// <summary>
        /// Looks up entities by key.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="readOptions">The options for this lookup request.</param>
        /// <param name="keys">Keys of entities to look up.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<LookupResponse> LookupAsync(
            string projectId,
            ReadOptions readOptions,
            IEnumerable<Key> keys,
            CallSettings callSettings = null) => _callLookup.Async(
                new LookupRequest
                {
                    ProjectId = projectId,
                    ReadOptions = readOptions,
                    Keys = { keys },
                },
                callSettings);

        /// <summary>
        /// Looks up entities by key.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="readOptions">The options for this lookup request.</param>
        /// <param name="keys">Keys of entities to look up.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LookupResponse Lookup(
            string projectId,
            ReadOptions readOptions,
            IEnumerable<Key> keys,
            CallSettings callSettings = null) => _callLookup.Sync(
                new LookupRequest
                {
                    ProjectId = projectId,
                    ReadOptions = readOptions,
                    Keys = { keys },
                },
                callSettings);

        /// <summary>
        /// Queries for entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="partitionId">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="readOptions">The options for this query.</param>
        /// <param name="query">The query to run.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<RunQueryResponse> RunQueryAsync(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            Query query,
            CallSettings callSettings = null) => _callRunQuery.Async(
                new RunQueryRequest
                {
                    ProjectId = projectId,
                    PartitionId = partitionId,
                    ReadOptions = readOptions,
                    Query = query,
                },
                callSettings);

        /// <summary>
        /// Queries for entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="partitionId">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="readOptions">The options for this query.</param>
        /// <param name="query">The query to run.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunQueryResponse RunQuery(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            Query query,
            CallSettings callSettings = null) => _callRunQuery.Sync(
                new RunQueryRequest
                {
                    ProjectId = projectId,
                    PartitionId = partitionId,
                    ReadOptions = readOptions,
                    Query = query,
                },
                callSettings);

        /// <summary>
        /// Queries for entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="partitionId">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="readOptions">The options for this query.</param>
        /// <param name="gqlQuery">The GQL query to run.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<RunQueryResponse> RunQueryAsync(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            GqlQuery gqlQuery,
            CallSettings callSettings = null) => _callRunQuery.Async(
                new RunQueryRequest
                {
                    ProjectId = projectId,
                    PartitionId = partitionId,
                    ReadOptions = readOptions,
                    GqlQuery = gqlQuery,
                },
                callSettings);

        /// <summary>
        /// Queries for entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="partitionId">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="readOptions">The options for this query.</param>
        /// <param name="gqlQuery">The GQL query to run.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunQueryResponse RunQuery(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            GqlQuery gqlQuery,
            CallSettings callSettings = null) => _callRunQuery.Sync(
                new RunQueryRequest
                {
                    ProjectId = projectId,
                    PartitionId = partitionId,
                    ReadOptions = readOptions,
                    GqlQuery = gqlQuery,
                },
                callSettings);

        /// <summary>
        /// Begins a new transaction.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<BeginTransactionResponse> BeginTransactionAsync(
            string projectId,
            CallSettings callSettings = null) => _callBeginTransaction.Async(
                new BeginTransactionRequest
                {
                    ProjectId = projectId,
                },
                callSettings);

        /// <summary>
        /// Begins a new transaction.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BeginTransactionResponse BeginTransaction(
            string projectId,
            CallSettings callSettings = null) => _callBeginTransaction.Sync(
                new BeginTransactionRequest
                {
                    ProjectId = projectId,
                },
                callSettings);

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="transaction">
        /// The identifier of the transaction associated with the commit. A
        /// transaction identifier is returned by a call to
        /// [Datastore.BeginTransaction][google.datastore.v1.Datastore.BeginTransaction].
        /// </param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        ///
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<CommitResponse> CommitAsync(
            string projectId,
            CommitRequest.Types.Mode mode,
            ByteString transaction,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null) => _callCommit.Async(
                new CommitRequest
                {
                    ProjectId = projectId,
                    Mode = mode,
                    Transaction = transaction,
                    Mutations = { mutations },
                },
                callSettings);

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="transaction">
        /// The identifier of the transaction associated with the commit. A
        /// transaction identifier is returned by a call to
        /// [Datastore.BeginTransaction][google.datastore.v1.Datastore.BeginTransaction].
        /// </param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        ///
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CommitResponse Commit(
            string projectId,
            CommitRequest.Types.Mode mode,
            ByteString transaction,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null) => _callCommit.Sync(
                new CommitRequest
                {
                    ProjectId = projectId,
                    Mode = mode,
                    Transaction = transaction,
                    Mutations = { mutations },
                },
                callSettings);

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        ///
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<CommitResponse> CommitAsync(
            string projectId,
            CommitRequest.Types.Mode mode,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null) => _callCommit.Async(
                new CommitRequest
                {
                    ProjectId = projectId,
                    Mode = mode,
                    Mutations = { mutations },
                },
                callSettings);

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        ///
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CommitResponse Commit(
            string projectId,
            CommitRequest.Types.Mode mode,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null) => _callCommit.Sync(
                new CommitRequest
                {
                    ProjectId = projectId,
                    Mode = mode,
                    Mutations = { mutations },
                },
                callSettings);

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="transaction">
        /// The transaction identifier, returned by a call to
        /// [Datastore.BeginTransaction][google.datastore.v1.Datastore.BeginTransaction].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<RollbackResponse> RollbackAsync(
            string projectId,
            ByteString transaction,
            CallSettings callSettings = null) => _callRollback.Async(
                new RollbackRequest
                {
                    ProjectId = projectId,
                    Transaction = transaction,
                },
                callSettings);

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="transaction">
        /// The transaction identifier, returned by a call to
        /// [Datastore.BeginTransaction][google.datastore.v1.Datastore.BeginTransaction].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RollbackResponse Rollback(
            string projectId,
            ByteString transaction,
            CallSettings callSettings = null) => _callRollback.Sync(
                new RollbackRequest
                {
                    ProjectId = projectId,
                    Transaction = transaction,
                },
                callSettings);

        /// <summary>
        /// Allocates IDs for the given keys, which is useful for referencing an entity
        /// before it is inserted.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="keys">
        /// A list of keys with incomplete key paths for which to allocate IDs.
        /// No key may be reserved/read-only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<AllocateIdsResponse> AllocateIdsAsync(
            string projectId,
            IEnumerable<Key> keys,
            CallSettings callSettings = null) => _callAllocateIds.Async(
                new AllocateIdsRequest
                {
                    ProjectId = projectId,
                    Keys = { keys },
                },
                callSettings);

        /// <summary>
        /// Allocates IDs for the given keys, which is useful for referencing an entity
        /// before it is inserted.
        /// </summary>
        /// <param name="projectId">The ID of the project against which to make the request.</param>
        /// <param name="keys">
        /// A list of keys with incomplete key paths for which to allocate IDs.
        /// No key may be reserved/read-only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AllocateIdsResponse AllocateIds(
            string projectId,
            IEnumerable<Key> keys,
            CallSettings callSettings = null) => _callAllocateIds.Sync(
                new AllocateIdsRequest
                {
                    ProjectId = projectId,
                    Keys = { keys },
                },
                callSettings);

    }

    // Partial classes to enable page-streaming

}