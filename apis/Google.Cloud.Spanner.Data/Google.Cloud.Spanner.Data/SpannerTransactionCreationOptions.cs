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

namespace Google.Cloud.Spanner.Data;

/// <summary>
/// Options that may be provided when creating a <see cref="SpannerTransaction"/>.
/// Instances of this class are immutable.
/// </summary>
public sealed class SpannerTransactionCreationOptions
{
    /// <summary>
    /// Default options for creating a transaction. Using these options will result in a read-write transaction.
    /// </summary>
    public static SpannerTransactionCreationOptions Default { get; } = new SpannerTransactionCreationOptions(timestampBound: null, transactionId: null);

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

    private SpannerTransactionCreationOptions(TimestampBound timestampBound, TransactionId transactionId)
    {
        GaxPreconditions.CheckArgument(
            timestampBound is null || transactionId is null,
            nameof(timestampBound),
            $"At most one of {nameof(timestampBound)} and {nameof(transactionId)} may be set.");
        TimestampBound = timestampBound;
        TransactionId = transactionId;
    }

    /// <summary>
    /// Creates transaction options with the given <paramref name="timestampBound"/> options.
    /// </summary>
    /// <param name="timestampBound">
    /// The timestamp bound options to be used for the transaction. May be null, in which case
    /// <see cref="TimestampBound.Strong"/> will be used.
    /// </param>
    public static SpannerTransactionCreationOptions ForTimestampBoundReadOnly(TimestampBound timestampBound = null) =>
        new SpannerTransactionCreationOptions(timestampBound ?? TimestampBound.Strong, transactionId: null);

    /// <summary>
    /// Creates transaction options with the given <paramref name="transactionId"/>.
    /// </summary>
    /// <param name="transactionId">
    /// The transaction ID to use for the transaction. Must not be null.
    /// </param>
    public static SpannerTransactionCreationOptions FromReadOnlyTransactionId(TransactionId transactionId) =>
        new SpannerTransactionCreationOptions(timestampBound: null, transactionId: GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId)));
}
