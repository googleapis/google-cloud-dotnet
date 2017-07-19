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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// Settings for a <see cref="BigtableClient"/>.
    /// </summary>
    public sealed partial class BigtableSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="BigtableSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="BigtableSettings"/>.
        /// </returns>
        public static BigtableSettings GetDefault() => new BigtableSettings();

        /// <summary>
        /// Constructs a new <see cref="BigtableSettings"/> object with default settings.
        /// </summary>
        public BigtableSettings() { }

        private BigtableSettings(BigtableSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateRowSettings = existing.MutateRowSettings;
            CheckAndMutateRowSettings = existing.CheckAndMutateRowSettings;
            ReadModifyWriteRowSettings = existing.ReadModifyWriteRowSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BigtableSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="BigtableClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="BigtableClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="BigtableClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="BigtableClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="BigtableClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="BigtableClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="BigtableClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="BigtableClient"/> RPC methods is defined as:
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
        /// <c>BigtableClient.MutateRow</c> and <c>BigtableClient.MutateRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableClient.MutateRow</c> and
        /// <c>BigtableClient.MutateRowAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings MutateRowSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableClient.CheckAndMutateRow</c> and <c>BigtableClient.CheckAndMutateRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableClient.CheckAndMutateRow</c> and
        /// <c>BigtableClient.CheckAndMutateRowAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CheckAndMutateRowSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableClient.ReadModifyWriteRow</c> and <c>BigtableClient.ReadModifyWriteRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableClient.ReadModifyWriteRow</c> and
        /// <c>BigtableClient.ReadModifyWriteRowAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ReadModifyWriteRowSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="BigtableSettings"/> object.</returns>
        public BigtableSettings Clone() => new BigtableSettings(this);
    }

    /// <summary>
    /// Bigtable client wrapper, for convenient use.
    /// </summary>
    public abstract partial class BigtableClient
    {
        /// <summary>
        /// The default endpoint for the Bigtable service, which is a host of "bigtable.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("bigtable.googleapis.com", 443);

        /// <summary>
        /// The default Bigtable scopes.
        /// </summary>
        /// <remarks>
        /// The default Bigtable scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/bigtable.data"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.data.readonly"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.data"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.data.readonly"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform.read-only"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/bigtable.data",
            "https://www.googleapis.com/auth/bigtable.data.readonly",
            "https://www.googleapis.com/auth/cloud-bigtable.data",
            "https://www.googleapis.com/auth/cloud-bigtable.data.readonly",
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
        /// Asynchronously creates a <see cref="BigtableClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableSettings"/>.</param>
        /// <returns>The task representing the created <see cref="BigtableClient"/>.</returns>
        public static async Task<BigtableClient> CreateAsync(ServiceEndpoint endpoint = null, BigtableSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="BigtableClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableSettings"/>.</param>
        /// <returns>The created <see cref="BigtableClient"/>.</returns>
        public static BigtableClient Create(ServiceEndpoint endpoint = null, BigtableSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="BigtableClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BigtableSettings"/>.</param>
        /// <returns>The created <see cref="BigtableClient"/>.</returns>
        public static BigtableClient Create(Channel channel, BigtableSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            Bigtable.BigtableClient grpcClient = new Bigtable.BigtableClient(channel);
            return new BigtableClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, BigtableSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, BigtableSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, BigtableSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, BigtableSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Bigtable client.
        /// </summary>
        public virtual Bigtable.BigtableClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<MutateRowResponse> MutateRowAsync(
            string tableName,
            ByteString rowKey,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null) => MutateRowAsync(
                new MutateRowRequest
                {
                    TableName = GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                    RowKey = GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    Mutations = { GaxPreconditions.CheckNotNull(mutations, nameof(mutations)) },
                },
                callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<MutateRowResponse> MutateRowAsync(
            string tableName,
            ByteString rowKey,
            IEnumerable<Mutation> mutations,
            CancellationToken cancellationToken) => MutateRowAsync(
                tableName,
                rowKey,
                mutations,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateRowResponse MutateRow(
            string tableName,
            ByteString rowKey,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null) => MutateRow(
                new MutateRowRequest
                {
                    TableName = GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                    RowKey = GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    Mutations = { GaxPreconditions.CheckNotNull(mutations, nameof(mutations)) },
                },
                callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
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
        public virtual Task<MutateRowResponse> MutateRowAsync(
            MutateRowRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
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
        public virtual MutateRowResponse MutateRow(
            MutateRowRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            string tableName,
            ByteString rowKey,
            IEnumerable<Mutation> trueMutations,
            IEnumerable<Mutation> falseMutations,
            CallSettings callSettings = null) => CheckAndMutateRowAsync(
                new CheckAndMutateRowRequest
                {
                    TableName = GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                    RowKey = GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    TrueMutations = { trueMutations ?? Enumerable.Empty<Mutation>() }, // Optional
                    FalseMutations = { falseMutations ?? Enumerable.Empty<Mutation>() }, // Optional
                },
                callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            string tableName,
            ByteString rowKey,
            IEnumerable<Mutation> trueMutations,
            IEnumerable<Mutation> falseMutations,
            CancellationToken cancellationToken) => CheckAndMutateRowAsync(
                tableName,
                rowKey,
                trueMutations,
                falseMutations,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(
            string tableName,
            ByteString rowKey,
            IEnumerable<Mutation> trueMutations,
            IEnumerable<Mutation> falseMutations,
            CallSettings callSettings = null) => CheckAndMutateRow(
                new CheckAndMutateRowRequest
                {
                    TableName = GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                    RowKey = GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    TrueMutations = { trueMutations ?? Enumerable.Empty<Mutation>() }, // Optional
                    FalseMutations = { falseMutations ?? Enumerable.Empty<Mutation>() }, // Optional
                },
                callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
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
        public virtual Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            CheckAndMutateRowRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
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
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(
            CheckAndMutateRowRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies a row atomically. The method reads the latest existing timestamp
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the timestamp is the
        /// greater of the existing timestamp or the current server time. The method
        /// returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            string tableName,
            ByteString rowKey,
            IEnumerable<ReadModifyWriteRule> rules,
            CallSettings callSettings = null) => ReadModifyWriteRowAsync(
                new ReadModifyWriteRowRequest
                {
                    TableName = GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                    RowKey = GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    Rules = { GaxPreconditions.CheckNotNull(rules, nameof(rules)) },
                },
                callSettings);

        /// <summary>
        /// Modifies a row atomically. The method reads the latest existing timestamp
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the timestamp is the
        /// greater of the existing timestamp or the current server time. The method
        /// returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            string tableName,
            ByteString rowKey,
            IEnumerable<ReadModifyWriteRule> rules,
            CancellationToken cancellationToken) => ReadModifyWriteRowAsync(
                tableName,
                rowKey,
                rules,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically. The method reads the latest existing timestamp
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the timestamp is the
        /// greater of the existing timestamp or the current server time. The method
        /// returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(
            string tableName,
            ByteString rowKey,
            IEnumerable<ReadModifyWriteRule> rules,
            CallSettings callSettings = null) => ReadModifyWriteRow(
                new ReadModifyWriteRowRequest
                {
                    TableName = GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                    RowKey = GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    Rules = { GaxPreconditions.CheckNotNull(rules, nameof(rules)) },
                },
                callSettings);

        /// <summary>
        /// Modifies a row atomically. The method reads the latest existing timestamp
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the timestamp is the
        /// greater of the existing timestamp or the current server time. The method
        /// returns the new contents of all modified cells.
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
        public virtual Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            ReadModifyWriteRowRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies a row atomically. The method reads the latest existing timestamp
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the timestamp is the
        /// greater of the existing timestamp or the current server time. The method
        /// returns the new contents of all modified cells.
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
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(
            ReadModifyWriteRowRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// Bigtable client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class BigtableClientImpl : BigtableClient
    {
        private readonly ApiCall<MutateRowRequest, MutateRowResponse> _callMutateRow;
        private readonly ApiCall<CheckAndMutateRowRequest, CheckAndMutateRowResponse> _callCheckAndMutateRow;
        private readonly ApiCall<ReadModifyWriteRowRequest, ReadModifyWriteRowResponse> _callReadModifyWriteRow;

        /// <summary>
        /// Constructs a client wrapper for the Bigtable service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigtableSettings"/> used within this client </param>
        public BigtableClientImpl(Bigtable.BigtableClient grpcClient, BigtableSettings settings)
        {
            this.GrpcClient = grpcClient;
            BigtableSettings effectiveSettings = settings ?? BigtableSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callMutateRow = clientHelper.BuildApiCall<MutateRowRequest, MutateRowResponse>(
                GrpcClient.MutateRowAsync, GrpcClient.MutateRow, effectiveSettings.MutateRowSettings);
            _callCheckAndMutateRow = clientHelper.BuildApiCall<CheckAndMutateRowRequest, CheckAndMutateRowResponse>(
                GrpcClient.CheckAndMutateRowAsync, GrpcClient.CheckAndMutateRow, effectiveSettings.CheckAndMutateRowSettings);
            _callReadModifyWriteRow = clientHelper.BuildApiCall<ReadModifyWriteRowRequest, ReadModifyWriteRowResponse>(
                GrpcClient.ReadModifyWriteRowAsync, GrpcClient.ReadModifyWriteRow, effectiveSettings.ReadModifyWriteRowSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(Bigtable.BigtableClient grpcClient, BigtableSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Bigtable client.
        /// </summary>
        public override Bigtable.BigtableClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_MutateRowRequest(ref MutateRowRequest request, ref CallSettings settings);
        partial void Modify_CheckAndMutateRowRequest(ref CheckAndMutateRowRequest request, ref CallSettings settings);
        partial void Modify_ReadModifyWriteRowRequest(ref ReadModifyWriteRowRequest request, ref CallSettings settings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
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
        public override Task<MutateRowResponse> MutateRowAsync(
            MutateRowRequest request,
            CallSettings callSettings = null)
        {
            Modify_MutateRowRequest(ref request, ref callSettings);
            return _callMutateRow.Async(request, callSettings);
        }

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
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
        public override MutateRowResponse MutateRow(
            MutateRowRequest request,
            CallSettings callSettings = null)
        {
            Modify_MutateRowRequest(ref request, ref callSettings);
            return _callMutateRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
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
        public override Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            CheckAndMutateRowRequest request,
            CallSettings callSettings = null)
        {
            Modify_CheckAndMutateRowRequest(ref request, ref callSettings);
            return _callCheckAndMutateRow.Async(request, callSettings);
        }

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
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
        public override CheckAndMutateRowResponse CheckAndMutateRow(
            CheckAndMutateRowRequest request,
            CallSettings callSettings = null)
        {
            Modify_CheckAndMutateRowRequest(ref request, ref callSettings);
            return _callCheckAndMutateRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Modifies a row atomically. The method reads the latest existing timestamp
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the timestamp is the
        /// greater of the existing timestamp or the current server time. The method
        /// returns the new contents of all modified cells.
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
        public override Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            ReadModifyWriteRowRequest request,
            CallSettings callSettings = null)
        {
            Modify_ReadModifyWriteRowRequest(ref request, ref callSettings);
            return _callReadModifyWriteRow.Async(request, callSettings);
        }

        /// <summary>
        /// Modifies a row atomically. The method reads the latest existing timestamp
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the timestamp is the
        /// greater of the existing timestamp or the current server time. The method
        /// returns the new contents of all modified cells.
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
        public override ReadModifyWriteRowResponse ReadModifyWriteRow(
            ReadModifyWriteRowRequest request,
            CallSettings callSettings = null)
        {
            Modify_ReadModifyWriteRowRequest(ref request, ref callSettings);
            return _callReadModifyWriteRow.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

}
