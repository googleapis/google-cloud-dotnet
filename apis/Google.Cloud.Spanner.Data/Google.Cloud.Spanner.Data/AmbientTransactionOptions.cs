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

using System;

namespace Google.Cloud.Spanner.Data;

/// <summary>
/// Options for a <see cref="SpannerTransaction"/> that is enlisted in <see cref="System.Transactions.Transaction"/>.
/// </summary>
public sealed class AmbientTransactionOptions
{
    /// <summary>
    /// Default options for an ambient transaction. Using these options will result in a read-write transaction
    /// with no <see cref="CommitDelay"/> value set.
    /// </summary>
    public static AmbientTransactionOptions Default { get; } = new AmbientTransactionOptions(null);

    /// <summary>
    /// The maximum amount of time the commit may be delayed server side for batching with other commits.
    /// The bigger the delay, the better the throughput (QPS), but at the expense of commit latency.
    /// If set to <see cref="TimeSpan.Zero"/>, commit batching is disabled.
    /// May be null, in which case commits will continue to be batched as they had been before this configuration
    /// option was made available to Spanner API consumers.
    /// May be set to any value between <see cref="TimeSpan.Zero"/> and 500ms.
    /// </summary>
    public TimeSpan? CommitDelay { get; }

    private AmbientTransactionOptions(TimeSpan? commitDelay) =>
        CommitDelay = SpannerTransaction.CheckCommitDelayRange(commitDelay);

    /// <summary>
    /// Returns a new set of options equal to these, except for the specified <paramref name="commitDelay"/>.
    /// </summary>
    public AmbientTransactionOptions WithCommitDelay(TimeSpan? commitDelay) =>
        new AmbientTransactionOptions(commitDelay);
}
