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
/// Options that may be applied to a transaction after creation, usually before committing the transaction
/// or before executing the first transactional statement.
/// </summary>
/// <remarks>
/// As opposed to <see cref="SpannerTransactionCreationOptions"/>, instances of this class are mutable.
/// This is useful for ORM and similar implementations that depend on ADO.NET for transaction and command
/// creation, which does not know about these Spanner specific options. These implementations may still
/// access transaction and commands after creation and change these options.
/// </remarks>
public sealed class SpannerTransactionOptions
{
    private TimeSpan? _maxCommitDelay;

    /// <summary>
    /// Creates an instance of <see cref="SpannerTransactionOptions"/> with default values.
    /// </summary>
    public SpannerTransactionOptions()
    { }

    /// <summary>
    /// Creates an instance of <see cref="SpannerTransactionOptions"/> with the same values as <paramref name="other"/>.
    /// </summary>
    /// <param name="other">The options to create this instance from. Must not be null.</param>
    public SpannerTransactionOptions(SpannerTransactionOptions other)
    {
        GaxPreconditions.CheckNotNull(other, nameof(other));

        _maxCommitDelay = other._maxCommitDelay;
    }


    /// <summary>
    /// The maximum amount of time the commit may be delayed server side for batching with other commits.
    /// The bigger the delay, the better the throughput (QPS), but at the expense of commit latency.
    /// If set to <see cref="TimeSpan.Zero"/>, commit batching is disabled.
    /// May be null, in which case commits will continue to be batched as they had been before this configuration
    /// option was made available to Spanner API consumers.
    /// May be set to any value between <see cref="TimeSpan.Zero"/> and 500ms.
    /// Cannot be modified after commit or rollback has been called on the transaction.
    /// </summary>
    public TimeSpan? MaxCommitDelay
    {
        get => _maxCommitDelay;
        set => _maxCommitDelay = SpannerTransaction.CheckMaxCommitDelayRange(value);
    }
}
