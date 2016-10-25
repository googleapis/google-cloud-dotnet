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
using static Google.Datastore.V1.CommitRequest.Types;

namespace Google.Datastore.V1
{
    /// <summary>
    /// Settings for a <see cref="DatastoreClient"/>.
    /// </summary>
    public sealed partial class DatastoreSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="DatastoreSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="DatastoreSettings"/>.
        /// </returns>
        public static DatastoreSettings GetDefault() => new DatastoreSettings();

        /// <summary>
        /// Constructs a new <see cref="DatastoreSettings"/> object with default settings.
        /// </summary>
        public DatastoreSettings() { }

        private DatastoreSettings(DatastoreSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            LookupSettings = existing.LookupSettings;
            RunQuerySettings = existing.RunQuerySettings;
            BeginTransactionSettings = existing.BeginTransactionSettings;
            CommitSettings = existing.CommitSettings;
            RollbackSettings = existing.RollbackSettings;
            AllocateIdsSettings = existing.AllocateIdsSettings;
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
        /// <returns>
        /// The "Default" retry backoff for <see cref="DatastoreClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="DatastoreClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="DatastoreClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="DatastoreClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="DatastoreClient"/> RPC methods is defined as:
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
        /// <c>DatastoreClient.Lookup</c> and <c>DatastoreClient.LookupAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatastoreClient.Lookup</c> and
        /// <c>DatastoreClient.LookupAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings LookupSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastoreClient.RunQuery</c> and <c>DatastoreClient.RunQueryAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatastoreClient.RunQuery</c> and
        /// <c>DatastoreClient.RunQueryAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings RunQuerySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastoreClient.BeginTransaction</c> and <c>DatastoreClient.BeginTransactionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatastoreClient.BeginTransaction</c> and
        /// <c>DatastoreClient.BeginTransactionAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings BeginTransactionSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastoreClient.Commit</c> and <c>DatastoreClient.CommitAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatastoreClient.Commit</c> and
        /// <c>DatastoreClient.CommitAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CommitSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastoreClient.Rollback</c> and <c>DatastoreClient.RollbackAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatastoreClient.Rollback</c> and
        /// <c>DatastoreClient.RollbackAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings RollbackSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastoreClient.AllocateIds</c> and <c>DatastoreClient.AllocateIdsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DatastoreClient.AllocateIds</c> and
        /// <c>DatastoreClient.AllocateIdsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings AllocateIdsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="DatastoreSettings"/> object.</returns>
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
        /// The default Datastore scopes.
        /// </summary>
        /// <remarks>
        /// The default Datastore scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/datastore"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
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
        /// The underlying gRPC Datastore client.
        /// </summary>
        public virtual Datastore.DatastoreClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="readOptions">
        ///
        /// </param>
        /// <param name="keys">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LookupResponse> LookupAsync(
            string projectId,
            ReadOptions readOptions,
            IEnumerable<Key> keys,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="readOptions">
        ///
        /// </param>
        /// <param name="keys">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LookupResponse> LookupAsync(
            string projectId,
            ReadOptions readOptions,
            IEnumerable<Key> keys,
            CancellationToken cancellationToken) => LookupAsync(
                projectId,
                readOptions,
                keys,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="readOptions">
        ///
        /// </param>
        /// <param name="keys">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LookupResponse Lookup(
            string projectId,
            ReadOptions readOptions,
            IEnumerable<Key> keys,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="partitionId">
        ///
        /// </param>
        /// <param name="readOptions">
        ///
        /// </param>
        /// <param name="query">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="partitionId">
        ///
        /// </param>
        /// <param name="readOptions">
        ///
        /// </param>
        /// <param name="query">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
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
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="partitionId">
        ///
        /// </param>
        /// <param name="readOptions">
        ///
        /// </param>
        /// <param name="query">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="partitionId">
        ///
        /// </param>
        /// <param name="readOptions">
        ///
        /// </param>
        /// <param name="gqlQuery">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="partitionId">
        ///
        /// </param>
        /// <param name="readOptions">
        ///
        /// </param>
        /// <param name="gqlQuery">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
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
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="partitionId">
        ///
        /// </param>
        /// <param name="readOptions">
        ///
        /// </param>
        /// <param name="gqlQuery">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<BeginTransactionResponse> BeginTransactionAsync(
            string projectId,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<BeginTransactionResponse> BeginTransactionAsync(
            string projectId,
            CancellationToken cancellationToken) => BeginTransactionAsync(
                projectId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual BeginTransactionResponse BeginTransaction(
            string projectId,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="mode">
        ///
        /// </param>
        /// <param name="transaction">
        ///
        /// </param>
        /// <param name="mutations">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CommitResponse> CommitAsync(
            string projectId,
            Mode mode,
            ByteString transaction,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="mode">
        ///
        /// </param>
        /// <param name="transaction">
        ///
        /// </param>
        /// <param name="mutations">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CommitResponse> CommitAsync(
            string projectId,
            Mode mode,
            ByteString transaction,
            IEnumerable<Mutation> mutations,
            CancellationToken cancellationToken) => CommitAsync(
                projectId,
                mode,
                transaction,
                mutations,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="mode">
        ///
        /// </param>
        /// <param name="transaction">
        ///
        /// </param>
        /// <param name="mutations">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CommitResponse Commit(
            string projectId,
            Mode mode,
            ByteString transaction,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="mode">
        ///
        /// </param>
        /// <param name="mutations">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CommitResponse> CommitAsync(
            string projectId,
            Mode mode,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="mode">
        ///
        /// </param>
        /// <param name="mutations">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CommitResponse> CommitAsync(
            string projectId,
            Mode mode,
            IEnumerable<Mutation> mutations,
            CancellationToken cancellationToken) => CommitAsync(
                projectId,
                mode,
                mutations,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="mode">
        ///
        /// </param>
        /// <param name="mutations">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CommitResponse Commit(
            string projectId,
            Mode mode,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="transaction">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<RollbackResponse> RollbackAsync(
            string projectId,
            ByteString transaction,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="transaction">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<RollbackResponse> RollbackAsync(
            string projectId,
            ByteString transaction,
            CancellationToken cancellationToken) => RollbackAsync(
                projectId,
                transaction,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="transaction">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual RollbackResponse Rollback(
            string projectId,
            ByteString transaction,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="keys">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AllocateIdsResponse> AllocateIdsAsync(
            string projectId,
            IEnumerable<Key> keys,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="keys">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AllocateIdsResponse> AllocateIdsAsync(
            string projectId,
            IEnumerable<Key> keys,
            CancellationToken cancellationToken) => AllocateIdsAsync(
                projectId,
                keys,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="keys">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AllocateIdsResponse AllocateIds(
            string projectId,
            IEnumerable<Key> keys,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// Datastore client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class DatastoreClientImpl : DatastoreClient
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<LookupRequest, LookupResponse> _callLookup;
        private readonly ApiCall<RunQueryRequest, RunQueryResponse> _callRunQuery;
        private readonly ApiCall<BeginTransactionRequest, BeginTransactionResponse> _callBeginTransaction;
        private readonly ApiCall<CommitRequest, CommitResponse> _callCommit;
        private readonly ApiCall<RollbackRequest, RollbackResponse> _callRollback;
        private readonly ApiCall<AllocateIdsRequest, AllocateIdsResponse> _callAllocateIds;

        /// <summary>
        /// Constructs a client wrapper for the Datastore service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DatastoreSettings"/> used within this client </param>
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

        /// <summary>
        /// The underlying gRPC Datastore client.
        /// </summary>
        public override Datastore.DatastoreClient GrpcClient { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="readOptions">
        ///
        /// </param>
        /// <param name="keys">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="readOptions">
        ///
        /// </param>
        /// <param name="keys">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="partitionId">
        ///
        /// </param>
        /// <param name="readOptions">
        ///
        /// </param>
        /// <param name="query">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="partitionId">
        ///
        /// </param>
        /// <param name="readOptions">
        ///
        /// </param>
        /// <param name="query">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="partitionId">
        ///
        /// </param>
        /// <param name="readOptions">
        ///
        /// </param>
        /// <param name="gqlQuery">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="partitionId">
        ///
        /// </param>
        /// <param name="readOptions">
        ///
        /// </param>
        /// <param name="gqlQuery">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<BeginTransactionResponse> BeginTransactionAsync(
            string projectId,
            CallSettings callSettings = null) => _callBeginTransaction.Async(
                new BeginTransactionRequest
                {
                    ProjectId = projectId,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override BeginTransactionResponse BeginTransaction(
            string projectId,
            CallSettings callSettings = null) => _callBeginTransaction.Sync(
                new BeginTransactionRequest
                {
                    ProjectId = projectId,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="mode">
        ///
        /// </param>
        /// <param name="transaction">
        ///
        /// </param>
        /// <param name="mutations">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<CommitResponse> CommitAsync(
            string projectId,
            Mode mode,
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="mode">
        ///
        /// </param>
        /// <param name="transaction">
        ///
        /// </param>
        /// <param name="mutations">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override CommitResponse Commit(
            string projectId,
            Mode mode,
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="mode">
        ///
        /// </param>
        /// <param name="mutations">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<CommitResponse> CommitAsync(
            string projectId,
            Mode mode,
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="mode">
        ///
        /// </param>
        /// <param name="mutations">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override CommitResponse Commit(
            string projectId,
            Mode mode,
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="transaction">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="transaction">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="keys">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
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
        ///
        /// </summary>
        /// <param name="projectId">
        ///
        /// </param>
        /// <param name="keys">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
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
