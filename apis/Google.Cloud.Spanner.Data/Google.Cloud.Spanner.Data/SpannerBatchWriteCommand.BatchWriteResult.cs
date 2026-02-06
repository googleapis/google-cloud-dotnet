// Copyright 2026 Google LLC
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

using Google.Cloud.Spanner.V1;
using Google.Rpc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Spanner.Data;

public sealed partial class SpannerBatchWriteCommand
{
    /// <summary>
    /// Represents the result of a single command group in a BatchWrite operation.
    /// </summary>
    public sealed class BatchWriteResult
    {
        /// <summary>
        /// An `OK` status indicates success. Any other status indicates a failure.
        /// </summary>
        public Status Status { get; }

        /// <summary>
        /// The mutation groups applied in this batch. The values index into the
        /// `mutation_groups` field in the corresponding `BatchWriteRequest`.
        /// </summary>
        public IEnumerable<int> Indexes { get; }

        /// <summary>
        /// The commit timestamp of the transaction that applied this batch.
        /// Present if status is OK and the mutation groups were applied, absent
        /// otherwise.
        ///
        /// For mutation groups with conditions, a status=OK and missing
        /// commit_timestamp means that the mutation groups were not applied due to the
        /// condition not being satisfied after evaluation.
        /// </summary>
        public DateTime? CommitTimestamp { get; }

        internal BatchWriteResult(BatchWriteResponse batchWriteResponse)
        {
            Status = batchWriteResponse.Status;
            Indexes = batchWriteResponse.Indexes;
            CommitTimestamp = batchWriteResponse.CommitTimestamp?.ToDateTime();
        }
    }
}