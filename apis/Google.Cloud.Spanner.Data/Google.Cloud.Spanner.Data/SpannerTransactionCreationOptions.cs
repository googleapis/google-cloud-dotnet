// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Google.Api.Gax;
using Google.Cloud.Spanner.V1;
using static Google.Cloud.Spanner.V1.TransactionOptions.Types;

namespace Google.Cloud.Spanner.Data;

/// <summary>
/// Options that may be provided when creating a <see cref="SpannerTransaction"/>.
/// Instances of this class are immutable.
/// </summary>
public sealed class SpannerTransactionCreationOptions
{
    // Transaction options; no additional state, so can be reused.
    internal static TransactionOptions ReadWriteTransactionOptions { get; } = new TransactionOptions { ReadWrite = new ReadWrite() };
    internal static TransactionOptions PartitionedDmlTransactionOptions { get; } = new TransactionOptions { PartitionedDml = new PartitionedDml() };

    /// <summary>
    /// Options that will result in a read-write transaction.
    /// </summary>
    public static SpannerTransactionCreationOptions ReadWrite { get; } = new SpannerTransactionCreationOptions(timestampBound: null, transactionId: null, isDetached: false, isSingleUse: false, isPartitionedDml: false);

    /// <summary>
    /// Options that will result in a read-write transaction suitable for executing partioned DML.
    /// </summary>
    public static SpannerTransactionCreationOptions PartitionedDml { get; } = new SpannerTransactionCreationOptions(timestampBound: null, transactionId: null, isDetached: false, isSingleUse: false, isPartitionedDml: true);

    /// <summary>
    /// Options that will result in a read-only transaction bound by <see cref="TimestampBound.Strong"/>.
    /// </summary>
    public static SpannerTransactionCreationOptions ReadOnly { get; } = new SpannerTransactionCreationOptions(TimestampBound.Strong, transactionId: null, isDetached: false, isSingleUse: false, isPartitionedDml: false);

    /// <summary>
    /// Timestamp bound settings for the transaction. May be null.
    /// When set, the transaction will be read-only.
    /// At most, one of <see cref="TimestampBound"/> and <see cref="TransactionId"/> may be set.
    /// If none of <see cref="TimestampBound"/> and <see cref="TransactionId"/> are set,
    /// the transaction will be a read-write transaction.
    /// </summary>
    public TimestampBound TimestampBound { get; }

    /// <summary>
    /// The transaction ID of an active read-only transaction to use for the transaction. May be null.
    /// At most, one of <see cref="TimestampBound"/> and <see cref="TransactionId"/> may be set.
    /// If none of <see cref="TimestampBound"/> and <see cref="TransactionId"/> are set,
    /// the transaction will be a read-write transaction.
    /// </summary>
    public TransactionId TransactionId { get; }

    /// <summary>
    /// Whether these options should result in a detached transaction or in one that's tracked by a session pool.
    /// This will always be true when <see cref="TransactionId"/> is set. Otherwise it will be false unless explicitly
    /// set via <see cref="WithIsDetached(bool)"/>.
    /// </summary>
    /// <remarks>
    /// Resources of transactions that are tracked by a session pool will be returned to the pool once the
    /// transaction is committed or rolled back, for later re-use.
    /// Alternatively, a transaction that will be shared across processes, for instance for partitioned reads,
    /// should be detached so that resources are not returned to a local pool and attempted to be re-used there.
    /// </remarks>
    public bool IsDetached { get; }

    /// <summary>
    /// Whether these options should result in a single-use transaction or not.
    /// Only timestamp bound transactions may be single-use.
    /// A read-only transaction of <see cref="TimestampBoundMode.MinReadTimestamp"/> or <see cref="TimestampBoundMode.MaxStaleness"/>
    /// is always single-use.
    /// All other transactions are not single-use by default.
    /// </summary>
    public bool IsSingleUse { get; }

    /// <summary>
    /// The read-only or read-write mode for the resulting transaction.
    /// </summary>
    internal TransactionMode TransactionMode => TransactionId is null && TimestampBound is null ? TransactionMode.ReadWrite : TransactionMode.ReadOnly;

    /// <summary>
    /// Whether the resulting transaction is suitable for executing partioned DML queries.
    /// When this is true, <see cref="TransactionMode"/> will always be <see cref="TransactionMode.ReadWrite"/>.
    /// </summary>
    public bool IsPartitionedDml { get; }

    /// <summary>
    /// Options used to acquire the transaction's underlying session.
    /// </summary>
    internal TransactionOptions TransactionOptios => IsPartitionedDml
        ? PartitionedDmlTransactionOptions
        : TransactionMode == TransactionMode.ReadWrite
        ? ReadWriteTransactionOptions
        : TimestampBound?.ToTransactionOptions();

    private SpannerTransactionCreationOptions(TimestampBound timestampBound, TransactionId transactionId, bool isDetached, bool isSingleUse, bool isPartitionedDml)
    {
        GaxPreconditions.CheckArgument(
            timestampBound is null || transactionId is null,
            nameof(timestampBound),
            $"At most one of {nameof(timestampBound)} and {nameof(transactionId)} may be set.");
        GaxPreconditions.CheckArgument(
            transactionId is null || isDetached,
            nameof(isDetached),
            $"If {nameof(transactionId)} is set, {nameof(isDetached)} must be true.");
        TimestampBound = timestampBound;
        TransactionId = transactionId;
        IsDetached = isDetached;
        GaxPreconditions.CheckArgument(
            TimestampBound is not null || !isSingleUse,
            nameof(isSingleUse),
            "Only timestamp bound transactions may be single-use.");
        GaxPreconditions.CheckArgument(
            isSingleUse || (TimestampBound?.Mode != TimestampBoundMode.MinReadTimestamp && TimestampBound?.Mode != TimestampBoundMode.MaxStaleness),
            nameof(isSingleUse),
            $"Transaction of {nameof(TimestampBoundMode.MinReadTimestamp)} or {nameof(TimestampBoundMode.MaxStaleness)} must be single-use.");
        IsSingleUse = isSingleUse;
        GaxPreconditions.CheckArgument(
            TransactionMode == TransactionMode.ReadWrite || !isPartitionedDml,
            nameof(isPartitionedDml),
            "Read-only transaction cannot be used for partitioned DML queries.");
        IsPartitionedDml = isPartitionedDml;
    }

    /// <summary>
    /// Creates transaction options with the given <paramref name="timestampBound"/> options.
    /// </summary>
    /// <param name="timestampBound">
    /// The timestamp bound options to be used for the transaction. May be null, this will return <see cref="ReadOnly"/>.
    /// </param>
    public static SpannerTransactionCreationOptions ForTimestampBoundReadOnly(TimestampBound timestampBound) =>
        // TimestampBound?.Mode == TimestampBoundMode.MinReadTimestamp || TimestampBound?.Mode == TimestampBoundMode.MaxStaleness;
        timestampBound is null
        ? ReadOnly
        : new SpannerTransactionCreationOptions(
            timestampBound,
            transactionId: null,
            isDetached: false,
            isSingleUse: timestampBound?.Mode == TimestampBoundMode.MinReadTimestamp || timestampBound?.Mode == TimestampBoundMode.MaxStaleness,
            isPartitionedDml: false);

    /// <summary>
    /// Creates transaction options with the given <paramref name="transactionId"/>.
    /// </summary>
    /// <param name="transactionId">
    /// The transaction ID to use for the transaction. Must not be null.
    /// </param>
    public static SpannerTransactionCreationOptions FromReadOnlyTransactionId(TransactionId transactionId) =>
        new SpannerTransactionCreationOptions(timestampBound: null, transactionId: GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId)), isDetached: true, isSingleUse: false, isPartitionedDml: false);

    /// <summary>
    /// Returns a new instance identical to this one except for the value of <see cref="IsDetached"/>.
    /// If <see cref="TransactionId"/> is set, <see cref="IsDetached"/> cannot be false.
    /// </summary>
    public SpannerTransactionCreationOptions WithIsDetached(bool isDetached) =>
        isDetached == IsDetached ? this : new SpannerTransactionCreationOptions(TimestampBound, TransactionId, isDetached, IsSingleUse, IsPartitionedDml);

    /// <summary>
    /// Returns a new instance identical to this one except for the value of <see cref="IsSingleUse"/>.
    /// <see cref="IsSingleUse"/> can only be true for timestamp bound transactions.
    /// If timestamp bounds are of <see cref="TimestampBoundMode.MinReadTimestamp"/> or <see cref="TimestampBoundMode.MaxStaleness"/>,
    /// <see cref="IsSingleUse"/> cannot be false.
    /// </summary>
    public SpannerTransactionCreationOptions WithIsSingleUse(bool isSingleUse) =>
        isSingleUse == IsSingleUse ? this : new SpannerTransactionCreationOptions(TimestampBound, TransactionId, IsDetached, isSingleUse, IsPartitionedDml);
}
