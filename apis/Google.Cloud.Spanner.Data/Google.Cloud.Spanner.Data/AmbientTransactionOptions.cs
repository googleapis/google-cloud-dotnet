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
using System;

namespace Google.Cloud.Spanner.Data;

/// <summary>
/// Options for a <see cref="SpannerTransaction"/> that is enlisted in <see cref="System.Transactions.Transaction"/>.
/// </summary>
public sealed class AmbientTransactionOptions
{
    /// <summary>
    /// Default options for an ambient transaction. Using these options will result in a read-write transaction
    /// with no <see cref="MaxCommitDelay"/> value set.
    /// </summary>
    public static AmbientTransactionOptions Default { get; } = new AmbientTransactionOptions(maxCommitDelay: null, timestampBound: null, transactionId: null);

    /// <summary>
    /// The maximum amount of time the commit may be delayed server side for batching with other commits.
    /// The bigger the delay, the better the throughput (QPS), but at the expense of commit latency.
    /// If set to <see cref="TimeSpan.Zero"/>, commit batching is disabled.
    /// May be null, in which case commits will continue to be batched as they had been before this configuration
    /// option was made available to Spanner API consumers.
    /// May be set to any value between <see cref="TimeSpan.Zero"/> and 500ms.
    /// </summary>
    public TimeSpan? MaxCommitDelay { get; }

    /// <summary>
    /// Timestamp bound settings for the ambient transaction. May be null.
    /// When set, the ambient transaction will be read-only.
    /// At most, one of <see cref="TimestampBound"/> and <see cref="TransactionId"/> may be set.
    /// If none of <see cref="TimestampBound"/> and <see cref="TransactionId"/> are set,
    /// the ambient transaction will be a read-write transaction.
    /// </summary>
    public TimestampBound TimestampBound { get; }

    /// <summary>
    /// The transaction ID of an active read-only transaction to use for the ambient transaction. May be null.
    /// At most, one of <see cref="TimestampBound"/> and <see cref="TransactionId"/> may be set.
    /// If none of <see cref="TimestampBound"/> and <see cref="TransactionId"/> are set,
    /// the ambient transaction will be a read-write transaction.
    /// </summary>
    public TransactionId TransactionId { get; }

    private AmbientTransactionOptions(TimeSpan? maxCommitDelay, TimestampBound timestampBound, TransactionId transactionId)
    {
        GaxPreconditions.CheckArgument(
            timestampBound is null || transactionId is null,
            nameof(timestampBound),
            $"At most one of {nameof(timestampBound)} and {nameof(transactionId)} may be set.");
        MaxCommitDelay = SpannerTransaction.CheckMaxCommitDelayRange(maxCommitDelay);
        TimestampBound = timestampBound;
        TransactionId = transactionId;
    }

    /// <summary>
    /// Creates a new set of ambient transaction options with the given <paramref name="timestampBound"/> options.
    /// </summary>
    /// <param name="timestampBound">
    /// The timestamp bound options to be used for the ambient transaction. May be null, in which case
    /// <see cref="TimestampBound.Strong"/> will be used.
    /// </param>
    public static AmbientTransactionOptions ForTimestampBoundReadOnly(TimestampBound timestampBound = null) =>
        new AmbientTransactionOptions(maxCommitDelay: null, timestampBound ?? TimestampBound.Strong, transactionId: null);

    /// <summary>
    /// Creates a new set of ambient transaction options with the given <paramref name="transactionId"/>.
    /// </summary>
    /// <param name="transactionId">
    /// The transaction ID to use for the ambient transaction. Must not be null.
    /// </param>
    public static AmbientTransactionOptions FromReadOnlyTransactionId(TransactionId transactionId) =>
        new AmbientTransactionOptions(maxCommitDelay: null, timestampBound: null, transactionId: GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId)));

    /// <summary>
    /// Returns a new set of options equal to these, except for the specified <paramref name="maxCommitDelay"/>.
    /// </summary>
    public AmbientTransactionOptions WithMaxCommitDelay(TimeSpan? maxCommitDelay) =>
        new AmbientTransactionOptions(maxCommitDelay, TimestampBound, TransactionId);
}
