// Copyright 2018 Google LLC
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
    /// Settings for a <see cref="BigtableServiceApiClient"/>.
    /// </summary>
    public sealed partial class BigtableServiceApiSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="BigtableServiceApiSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="BigtableServiceApiSettings"/>.
        /// </returns>
        public static BigtableServiceApiSettings GetDefault() => new BigtableServiceApiSettings();

        /// <summary>
        /// Constructs a new <see cref="BigtableServiceApiSettings"/> object with default settings.
        /// </summary>
        public BigtableServiceApiSettings() { }

        private BigtableServiceApiSettings(BigtableServiceApiSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ReadRowsSettings = existing.ReadRowsSettings;
            SampleRowKeysSettings = existing.SampleRowKeysSettings;
            MutateRowSettings = existing.MutateRowSettings;
            MutateRowsSettings = existing.MutateRowsSettings;
            CheckAndMutateRowSettings = existing.CheckAndMutateRowSettings;
            ReadModifyWriteRowSettings = existing.ReadModifyWriteRowSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BigtableServiceApiSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="BigtableServiceApiClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods is defined as:
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
        /// <see cref="CallSettings"/> for calls to <c>BigtableServiceApiClient.ReadRows</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ReadRowsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromTimeout(TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="CallSettings"/> for calls to <c>BigtableServiceApiClient.SampleRowKeys</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings SampleRowKeysSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromTimeout(TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableServiceApiClient.MutateRow</c> and <c>BigtableServiceApiClient.MutateRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableServiceApiClient.MutateRow</c> and
        /// <c>BigtableServiceApiClient.MutateRowAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings MutateRowSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for calls to <c>BigtableServiceApiClient.MutateRows</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings MutateRowsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromTimeout(TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableServiceApiClient.CheckAndMutateRow</c> and <c>BigtableServiceApiClient.CheckAndMutateRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableServiceApiClient.CheckAndMutateRow</c> and
        /// <c>BigtableServiceApiClient.CheckAndMutateRowAsync</c> <see cref="RetrySettings"/> are:
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
        /// <c>BigtableServiceApiClient.ReadModifyWriteRow</c> and <c>BigtableServiceApiClient.ReadModifyWriteRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableServiceApiClient.ReadModifyWriteRow</c> and
        /// <c>BigtableServiceApiClient.ReadModifyWriteRowAsync</c> <see cref="RetrySettings"/> are:
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
        /// <returns>A deep clone of this <see cref="BigtableServiceApiSettings"/> object.</returns>
        public BigtableServiceApiSettings Clone() => new BigtableServiceApiSettings(this);
    }

    /// <summary>
    /// Bigtable client wrapper, for convenient use.
    /// </summary>
    public abstract partial class BigtableServiceApiClient
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
        /// Asynchronously creates a <see cref="BigtableServiceApiClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableServiceApiSettings"/>.</param>
        /// <returns>The task representing the created <see cref="BigtableServiceApiClient"/>.</returns>
        public static async Task<BigtableServiceApiClient> CreateAsync(ServiceEndpoint endpoint = null, BigtableServiceApiSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="BigtableServiceApiClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableServiceApiSettings"/>.</param>
        /// <returns>The created <see cref="BigtableServiceApiClient"/>.</returns>
        public static BigtableServiceApiClient Create(ServiceEndpoint endpoint = null, BigtableServiceApiSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="BigtableServiceApiClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BigtableServiceApiSettings"/>.</param>
        /// <returns>The created <see cref="BigtableServiceApiClient"/>.</returns>
        public static BigtableServiceApiClient Create(Channel channel, BigtableServiceApiSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            Bigtable.BigtableClient grpcClient = new Bigtable.BigtableClient(channel);
            return new BigtableServiceApiClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, BigtableServiceApiSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, BigtableServiceApiSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, BigtableServiceApiSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, BigtableServiceApiSettings)"/> will create new channels, which could
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
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
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
        public virtual ReadRowsStream ReadRows(
            ReadRowsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Server streaming methods for <c>ReadRows</c>.
        /// </summary>
        public abstract partial class ReadRowsStream : ServerStreamingBase<ReadRowsResponse>
        {
        }

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
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
        public virtual SampleRowKeysStream SampleRowKeys(
            SampleRowKeysRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Server streaming methods for <c>SampleRowKeys</c>.
        /// </summary>
        public abstract partial class SampleRowKeysStream : ServerStreamingBase<SampleRowKeysResponse>
        {
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
            TableName tableName,
            ByteString rowKey,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null) => MutateRowAsync(
                new MutateRowRequest
                {
                    TableNameAsTableName = GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
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
            TableName tableName,
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
            TableName tableName,
            ByteString rowKey,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null) => MutateRow(
                new MutateRowRequest
                {
                    TableNameAsTableName = GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<MutateRowResponse> MutateRowAsync(
            MutateRowRequest request,
            CancellationToken cancellationToken) => MutateRowAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

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
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
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
        public virtual MutateRowsStream MutateRows(
            MutateRowsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Server streaming methods for <c>MutateRows</c>.
        /// </summary>
        public abstract partial class MutateRowsStream : ServerStreamingBase<MutateRowsResponse>
        {
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
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
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
            TableName tableName,
            ByteString rowKey,
            RowFilter predicateFilter,
            IEnumerable<Mutation> trueMutations,
            IEnumerable<Mutation> falseMutations,
            CallSettings callSettings = null) => CheckAndMutateRowAsync(
                new CheckAndMutateRowRequest
                {
                    TableNameAsTableName = GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                    RowKey = GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    PredicateFilter = predicateFilter, // Optional
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
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
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
            TableName tableName,
            ByteString rowKey,
            RowFilter predicateFilter,
            IEnumerable<Mutation> trueMutations,
            IEnumerable<Mutation> falseMutations,
            CancellationToken cancellationToken) => CheckAndMutateRowAsync(
                tableName,
                rowKey,
                predicateFilter,
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
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
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
            TableName tableName,
            ByteString rowKey,
            RowFilter predicateFilter,
            IEnumerable<Mutation> trueMutations,
            IEnumerable<Mutation> falseMutations,
            CallSettings callSettings = null) => CheckAndMutateRow(
                new CheckAndMutateRowRequest
                {
                    TableNameAsTableName = GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                    RowKey = GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    PredicateFilter = predicateFilter, // Optional
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            CheckAndMutateRowRequest request,
            CancellationToken cancellationToken) => CheckAndMutateRowAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

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
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
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
            TableName tableName,
            ByteString rowKey,
            IEnumerable<ReadModifyWriteRule> rules,
            CallSettings callSettings = null) => ReadModifyWriteRowAsync(
                new ReadModifyWriteRowRequest
                {
                    TableNameAsTableName = GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                    RowKey = GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    Rules = { GaxPreconditions.CheckNotNull(rules, nameof(rules)) },
                },
                callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
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
            TableName tableName,
            ByteString rowKey,
            IEnumerable<ReadModifyWriteRule> rules,
            CancellationToken cancellationToken) => ReadModifyWriteRowAsync(
                tableName,
                rowKey,
                rules,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
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
            TableName tableName,
            ByteString rowKey,
            IEnumerable<ReadModifyWriteRule> rules,
            CallSettings callSettings = null) => ReadModifyWriteRow(
                new ReadModifyWriteRowRequest
                {
                    TableNameAsTableName = GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                    RowKey = GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    Rules = { GaxPreconditions.CheckNotNull(rules, nameof(rules)) },
                },
                callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
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
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            ReadModifyWriteRowRequest request,
            CancellationToken cancellationToken) => ReadModifyWriteRowAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
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
    public sealed partial class BigtableServiceApiClientImpl : BigtableServiceApiClient
    {
        private readonly ApiServerStreamingCall<ReadRowsRequest, ReadRowsResponse> _callReadRows;
        private readonly ApiServerStreamingCall<SampleRowKeysRequest, SampleRowKeysResponse> _callSampleRowKeys;
        private readonly ApiCall<MutateRowRequest, MutateRowResponse> _callMutateRow;
        private readonly ApiServerStreamingCall<MutateRowsRequest, MutateRowsResponse> _callMutateRows;
        private readonly ApiCall<CheckAndMutateRowRequest, CheckAndMutateRowResponse> _callCheckAndMutateRow;
        private readonly ApiCall<ReadModifyWriteRowRequest, ReadModifyWriteRowResponse> _callReadModifyWriteRow;

        /// <summary>
        /// Constructs a client wrapper for the Bigtable service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigtableServiceApiSettings"/> used within this client </param>
        public BigtableServiceApiClientImpl(Bigtable.BigtableClient grpcClient, BigtableServiceApiSettings settings)
        {
            GrpcClient = grpcClient;
            BigtableServiceApiSettings effectiveSettings = settings ?? BigtableServiceApiSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callReadRows = clientHelper.BuildApiCall<ReadRowsRequest, ReadRowsResponse>(
                GrpcClient.ReadRows, effectiveSettings.ReadRowsSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"table_name={request.TableName}"));
            _callSampleRowKeys = clientHelper.BuildApiCall<SampleRowKeysRequest, SampleRowKeysResponse>(
                GrpcClient.SampleRowKeys, effectiveSettings.SampleRowKeysSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"table_name={request.TableName}"));
            _callMutateRow = clientHelper.BuildApiCall<MutateRowRequest, MutateRowResponse>(
                GrpcClient.MutateRowAsync, GrpcClient.MutateRow, effectiveSettings.MutateRowSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"table_name={request.TableName}"));
            _callMutateRows = clientHelper.BuildApiCall<MutateRowsRequest, MutateRowsResponse>(
                GrpcClient.MutateRows, effectiveSettings.MutateRowsSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"table_name={request.TableName}"));
            _callCheckAndMutateRow = clientHelper.BuildApiCall<CheckAndMutateRowRequest, CheckAndMutateRowResponse>(
                GrpcClient.CheckAndMutateRowAsync, GrpcClient.CheckAndMutateRow, effectiveSettings.CheckAndMutateRowSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"table_name={request.TableName}"));
            _callReadModifyWriteRow = clientHelper.BuildApiCall<ReadModifyWriteRowRequest, ReadModifyWriteRowResponse>(
                GrpcClient.ReadModifyWriteRowAsync, GrpcClient.ReadModifyWriteRow, effectiveSettings.ReadModifyWriteRowSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"table_name={request.TableName}"));
            Modify_ApiCall(ref _callReadRows);
            Modify_ReadRowsApiCall(ref _callReadRows);
            Modify_ApiCall(ref _callSampleRowKeys);
            Modify_SampleRowKeysApiCall(ref _callSampleRowKeys);
            Modify_ApiCall(ref _callMutateRow);
            Modify_MutateRowApiCall(ref _callMutateRow);
            Modify_ApiCall(ref _callMutateRows);
            Modify_MutateRowsApiCall(ref _callMutateRows);
            Modify_ApiCall(ref _callCheckAndMutateRow);
            Modify_CheckAndMutateRowApiCall(ref _callCheckAndMutateRow);
            Modify_ApiCall(ref _callReadModifyWriteRow);
            Modify_ReadModifyWriteRowApiCall(ref _callReadModifyWriteRow);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref ApiCall<TRequest, TResponse> call)
            where TRequest : class, IMessage<TRequest>
            where TResponse : class, IMessage<TResponse>;
        partial void Modify_ApiCall<TRequest, TResponse>(ref ApiServerStreamingCall<TRequest, TResponse> call)
            where TRequest : class, IMessage<TRequest>
            where TResponse : class, IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_ReadRowsApiCall(ref ApiServerStreamingCall<ReadRowsRequest, ReadRowsResponse> call);
        partial void Modify_SampleRowKeysApiCall(ref ApiServerStreamingCall<SampleRowKeysRequest, SampleRowKeysResponse> call);
        partial void Modify_MutateRowApiCall(ref ApiCall<MutateRowRequest, MutateRowResponse> call);
        partial void Modify_MutateRowsApiCall(ref ApiServerStreamingCall<MutateRowsRequest, MutateRowsResponse> call);
        partial void Modify_CheckAndMutateRowApiCall(ref ApiCall<CheckAndMutateRowRequest, CheckAndMutateRowResponse> call);
        partial void Modify_ReadModifyWriteRowApiCall(ref ApiCall<ReadModifyWriteRowRequest, ReadModifyWriteRowResponse> call);
        partial void OnConstruction(Bigtable.BigtableClient grpcClient, BigtableServiceApiSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Bigtable client.
        /// </summary>
        public override Bigtable.BigtableClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ReadRowsRequest(ref ReadRowsRequest request, ref CallSettings settings);
        partial void Modify_SampleRowKeysRequest(ref SampleRowKeysRequest request, ref CallSettings settings);
        partial void Modify_MutateRowRequest(ref MutateRowRequest request, ref CallSettings settings);
        partial void Modify_MutateRowsRequest(ref MutateRowsRequest request, ref CallSettings settings);
        partial void Modify_CheckAndMutateRowRequest(ref CheckAndMutateRowRequest request, ref CallSettings settings);
        partial void Modify_ReadModifyWriteRowRequest(ref ReadModifyWriteRowRequest request, ref CallSettings settings);

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
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
        public override ReadRowsStream ReadRows(
            ReadRowsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ReadRowsRequest(ref request, ref callSettings);
            return new ReadRowsStreamImpl(_callReadRows.Call(request, callSettings));
        }

        internal sealed partial class ReadRowsStreamImpl : ReadRowsStream
        {
            /// <summary>
            /// Construct the server-streaming method for <c>ReadRows</c>.
            /// </summary>
            /// <param name="call">The underlying gRPC server-streaming call.</param>
            internal ReadRowsStreamImpl(AsyncServerStreamingCall<ReadRowsResponse> call)
            {
                GrpcCall = call;
            }

            /// <inheritdoc/>
            public override AsyncServerStreamingCall<ReadRowsResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override IAsyncEnumerator<ReadRowsResponse> ResponseStream => GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
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
        public override SampleRowKeysStream SampleRowKeys(
            SampleRowKeysRequest request,
            CallSettings callSettings = null)
        {
            Modify_SampleRowKeysRequest(ref request, ref callSettings);
            return new SampleRowKeysStreamImpl(_callSampleRowKeys.Call(request, callSettings));
        }

        internal sealed partial class SampleRowKeysStreamImpl : SampleRowKeysStream
        {
            /// <summary>
            /// Construct the server-streaming method for <c>SampleRowKeys</c>.
            /// </summary>
            /// <param name="call">The underlying gRPC server-streaming call.</param>
            internal SampleRowKeysStreamImpl(AsyncServerStreamingCall<SampleRowKeysResponse> call)
            {
                GrpcCall = call;
            }

            /// <inheritdoc/>
            public override AsyncServerStreamingCall<SampleRowKeysResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override IAsyncEnumerator<SampleRowKeysResponse> ResponseStream => GrpcCall.ResponseStream;
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
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
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
        public override MutateRowsStream MutateRows(
            MutateRowsRequest request,
            CallSettings callSettings = null)
        {
            Modify_MutateRowsRequest(ref request, ref callSettings);
            return new MutateRowsStreamImpl(_callMutateRows.Call(request, callSettings));
        }

        internal sealed partial class MutateRowsStreamImpl : MutateRowsStream
        {
            /// <summary>
            /// Construct the server-streaming method for <c>MutateRows</c>.
            /// </summary>
            /// <param name="call">The underlying gRPC server-streaming call.</param>
            internal MutateRowsStreamImpl(AsyncServerStreamingCall<MutateRowsResponse> call)
            {
                GrpcCall = call;
            }

            /// <inheritdoc/>
            public override AsyncServerStreamingCall<MutateRowsResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override IAsyncEnumerator<MutateRowsResponse> ResponseStream => GrpcCall.ResponseStream;
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
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
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
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
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
