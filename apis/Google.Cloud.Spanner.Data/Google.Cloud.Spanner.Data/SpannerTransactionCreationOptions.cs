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
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using System;
using static Google.Cloud.Spanner.V1.TransactionOptions.Types;
using IsolationLevel = System.Data.IsolationLevel;
using SpannerIsolationLevel = Google.Cloud.Spanner.V1.TransactionOptions.Types.IsolationLevel;

namespace Google.Cloud.Spanner.Data;

/// <summary>
/// Options that may be provided when creating a <see cref="SpannerTransaction"/>.
/// Instances of this class are immutable.
/// </summary>
public sealed class SpannerTransactionCreationOptions
{
    /// <summary>
    /// Options that will result in a read-write transaction.
    /// </summary>
    public static SpannerTransactionCreationOptions ReadWrite { get; } = new SpannerTransactionCreationOptions(
        timestampBound: null, transactionId: null, isDetached: false, isSingleUse: false, isPartitionedDml: false, excludeFromChangeStreams: false, isolationLevel: IsolationLevel.Unspecified, readLockMode: ReadLockMode.Unspecified);

    /// <summary>
    /// Options that will result in a read-write transaction suitable for executing partioned DML.
    /// </summary>
    public static SpannerTransactionCreationOptions PartitionedDml { get; } = new SpannerTransactionCreationOptions(
        timestampBound: null, transactionId: null, isDetached: false, isSingleUse: false, isPartitionedDml: true, excludeFromChangeStreams: false, isolationLevel: IsolationLevel.Unspecified, readLockMode: ReadLockMode.Unspecified);

    /// <summary>
    /// Options that will result in a read-only transaction bound by <see cref="TimestampBound.Strong"/>.
    /// </summary>
    public static SpannerTransactionCreationOptions ReadOnly { get; } = new SpannerTransactionCreationOptions(
        TimestampBound.Strong, transactionId: null, isDetached: false, isSingleUse: false, isPartitionedDml: false, excludeFromChangeStreams: false, isolationLevel: IsolationLevel.Unspecified, readLockMode: ReadLockMode.Unspecified);

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
    /// Isolation level for a read-write transaction.
    /// This will always be <see cref="IsolationLevel.Unspecified"/> for read-only transactions.
    /// </summary>
    public IsolationLevel IsolationLevel {  get; }

    /// <summary>
    /// Whether changes executed within this transaction are recorded in change streams or not.
    /// This will always be false for read-only transactions.
    /// </summary>
    /// <remarks>
    /// A change stream may allow or not transaction exclusion. Setting this value to true will only
    /// have effect on change streams that allow transaction exclusion. That is, if this value is set to true
    /// changes executed withing this transaction will be excluded from change streams that
    /// allow transaction exclusion but will be tracked by change streams that do not explicitly
    /// allow transaction exclusion.
    /// </remarks>
    public bool ExcludeFromChangeStreams { get; }

    /// <summary>
    /// Read lock modes for the transaction.
    /// Check <see cref="TransactionOptions.Types.ReadWrite.ReadLockMode"/> for enum values and their intended behaviours.
    /// </summary>
    public ReadLockMode ReadLockMode { get; }

    /// <summary>
    /// This will only be set by RetriableTransaction and is needed for Multiplex Sessions to work correctly during retries.
    /// </summary>
    internal ByteString PreviousTransactionId { get; set; }

    private SpannerTransactionCreationOptions(TimestampBound timestampBound, TransactionId transactionId, bool isDetached, bool isSingleUse, bool isPartitionedDml, bool excludeFromChangeStreams, IsolationLevel isolationLevel, ReadLockMode readLockMode)
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
        GaxPreconditions.CheckArgument(
            TransactionMode == TransactionMode.ReadWrite || !excludeFromChangeStreams,
            nameof(excludeFromChangeStreams),
            "Only read-write and partioned DML transactions can be marked for change stream exclusion.");
        ExcludeFromChangeStreams = excludeFromChangeStreams;
        GaxPreconditions.CheckArgument(
            TransactionMode == TransactionMode.ReadWrite || isolationLevel == IsolationLevel.Unspecified,
            nameof(isolationLevel),
            $"Isolation Level can only be specified for read-write transactions. This transaction would be {TransactionMode} and the specified level is {isolationLevel}");
        IsolationLevel = isolationLevel;
        GaxPreconditions.CheckArgument(
            (TransactionMode == TransactionMode.ReadWrite && !isPartitionedDml) || readLockMode == ReadLockMode.Unspecified,
            nameof(readLockMode),
            $"Read lock mode can only be specified for read-write and non partitioned DML transactions. {TransactionMode}, {readLockMode}");
        ReadLockMode = readLockMode;
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
            isPartitionedDml: false,
            excludeFromChangeStreams: false,
            isolationLevel: IsolationLevel.Unspecified,
            readLockMode: ReadLockMode.Unspecified);

    /// <summary>
    /// Creates transaction options with the given <paramref name="transactionId"/>.
    /// </summary>
    /// <param name="transactionId">
    /// The transaction ID to use for the transaction. Must not be null.
    /// </param>
    public static SpannerTransactionCreationOptions FromReadOnlyTransactionId(TransactionId transactionId) =>
        new SpannerTransactionCreationOptions(
            timestampBound: null,
            transactionId: GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId)),
            isDetached: true,
            isSingleUse: false,
            isPartitionedDml: false,
            excludeFromChangeStreams: false,
            isolationLevel: IsolationLevel.Unspecified,
             readLockMode: ReadLockMode.Unspecified);

    /// <summary>
    /// Options used to acquire the transaction's underlying session.
    /// </summary>
    internal TransactionOptions GetTransactionOptions()
    {
        var options = IsPartitionedDml ? new TransactionOptions { PartitionedDml = new PartitionedDml() } :
            TransactionMode == TransactionMode.ReadWrite ? new TransactionOptions { ReadWrite = new ReadWrite() } :
            TimestampBound?.ToTransactionOptions();
        if (options is not null)
        {
            options.ExcludeTxnFromChangeStreams = ExcludeFromChangeStreams;
            options.IsolationLevel = ConvertToSpannerIsolatonLevel(IsolationLevel);

            if(options.ReadWrite is not null)
            {
                options.ReadWrite.ReadLockMode = ReadLockModeConverter.ToProto(ReadLockMode);
                if(PreviousTransactionId != null)
                {
                    options.ReadWrite.MultiplexedSessionPreviousTransactionId = PreviousTransactionId;
                }
            }
        }

        SpannerIsolationLevel ConvertToSpannerIsolatonLevel(IsolationLevel isolationLevel) => isolationLevel switch
        {
            IsolationLevel.Unspecified => SpannerIsolationLevel.Unspecified,
            IsolationLevel.Serializable => SpannerIsolationLevel.Serializable,
            IsolationLevel.RepeatableRead => SpannerIsolationLevel.RepeatableRead,
            IsolationLevel.Snapshot => SpannerIsolationLevel.RepeatableRead,
            _ => throw new NotSupportedException(
                $"Cloud Spanner currently does not support {nameof(isolationLevel)}"),
        };

        return options;
    }

    /// <summary>
    /// Returns a new instance identical to this one except for the value of <see cref="IsDetached"/>.
    /// If <see cref="TransactionId"/> is set, <see cref="IsDetached"/> cannot be false.
    /// </summary>
    public SpannerTransactionCreationOptions WithIsDetached(bool isDetached) =>
        isDetached == IsDetached ? this : new SpannerTransactionCreationOptions(TimestampBound, TransactionId, isDetached, IsSingleUse, IsPartitionedDml, ExcludeFromChangeStreams, IsolationLevel, ReadLockMode);

    /// <summary>
    /// Returns a new instance identical to this one except for the value of <see cref="IsSingleUse"/>.
    /// <see cref="IsSingleUse"/> can only be true for timestamp bound transactions.
    /// If timestamp bounds are of <see cref="TimestampBoundMode.MinReadTimestamp"/> or <see cref="TimestampBoundMode.MaxStaleness"/>,
    /// <see cref="IsSingleUse"/> cannot be false.
    /// </summary>
    public SpannerTransactionCreationOptions WithIsSingleUse(bool isSingleUse) =>
        isSingleUse == IsSingleUse ? this : new SpannerTransactionCreationOptions(TimestampBound, TransactionId, IsDetached, isSingleUse, IsPartitionedDml, ExcludeFromChangeStreams, IsolationLevel, ReadLockMode);

    /// <summary>
    /// Returns a new instance identical to this one except for the value of <see cref="ExcludeFromChangeStreams"/>.
    /// <see cref="ExcludeFromChangeStreams"/> can only be true for read-write transactions.
    /// </summary>
    public SpannerTransactionCreationOptions WithExcludeFromChangeStreams(bool excludeFromChangeStreams) =>
        excludeFromChangeStreams == ExcludeFromChangeStreams ? this : new SpannerTransactionCreationOptions(TimestampBound, TransactionId, IsDetached, IsSingleUse, IsPartitionedDml, excludeFromChangeStreams, IsolationLevel, ReadLockMode);

    /// <summary>
    /// Returns a new instance identical to this one except for the value of <see cref="IsolationLevel"/>.
    /// <see cref="IsolationLevel"/> can only be set for read-write transactions.
    /// </summary>
    public SpannerTransactionCreationOptions WithIsolationLevel(IsolationLevel isolationLevel) =>
        isolationLevel == IsolationLevel ? this : new SpannerTransactionCreationOptions(TimestampBound, TransactionId, IsDetached, IsSingleUse, IsPartitionedDml, ExcludeFromChangeStreams, isolationLevel, ReadLockMode);

    /// <summary>
    /// Returns a new instance identical to this one except for the value of <see cref="ReadLockMode"/>.
    /// <see cref="ReadLockMode"/> can only be set for read-write transactions.
    /// </summary>
    public SpannerTransactionCreationOptions WithReadLockMode(ReadLockMode readLockMode) =>
        readLockMode == ReadLockMode ? this : new SpannerTransactionCreationOptions(TimestampBound, TransactionId, IsDetached, IsSingleUse, IsPartitionedDml, ExcludeFromChangeStreams, IsolationLevel, readLockMode);

    internal SpannerTransactionCreationOptions WithPreviousTransactionId(ByteString previousTransactionId = null)
    {
        GaxPreconditions.CheckState(
            TransactionMode == TransactionMode.ReadWrite,
            "PreviousTransactionId is only settable on a ReadWrite transaction");

        var options = new SpannerTransactionCreationOptions(TimestampBound, TransactionId, IsDetached, IsSingleUse, IsPartitionedDml, ExcludeFromChangeStreams, IsolationLevel, ReadLockMode);
        options.PreviousTransactionId = previousTransactionId;
        return options;
    }
}

/// <summary>
/// `ReadLockMode` is used to set the read lock mode for read-write
/// transactions executed on Spanner. See <see cref="ReadWrite.Types.ReadLockMode"/> for more details.
/// </summary>
public enum ReadLockMode
{
    /// <summary>
    /// Default Value. This has different effects for different combinations of <see cref="IsolationLevel"/> used.
    /// Check <see cref="ReadWrite.Types.ReadLockMode.Unspecified"/> for more details.
    /// </summary>
    Unspecified = 0,

    /// <summary>
    /// Read locks are acquired immediately on read.
    /// </summary>
    Pessimistic = 1,

    /// <summary>
    /// Locks acquired on Commit.
    /// </summary>
    Optimistic = 2,
}

internal static class ReadLockModeConverter
{
    internal static ReadWrite.Types.ReadLockMode ToProto(ReadLockMode readLockMode) => (ReadWrite.Types.ReadLockMode) (int) readLockMode;
}
