// Copyright 2020 Google LLC
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

using Google.Api.Gax;
using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Immutable class representing a commit response.
    /// </summary>
    public sealed class CommitResponse
    {
        private const string MISSING_COMMIT_STATS = "The transaction did not return any CommitStats. Set SpannerConnection.ReturnCommitStats=true to request commit statistics.";

        internal CommitResponse(V1.CommitResponse proto)
        {
            Proto = GaxPreconditions.CheckNotNull(proto, nameof(proto));
        }

        /// <summary>
        /// The proto representation of the commit response. Must not be mutated
        /// or exposed publicly.
        /// </summary>
        internal V1.CommitResponse Proto { get; }

        /// <summary>
        /// The commit timestamp of the transaction.
        /// </summary>
        public DateTime CommitTimestamp { get => Proto.CommitTimestamp.ToDateTime(); }

        /// <summary>
        /// The number of mutations that was executed by the transaction. This count may not
        /// exceed 20,000.
        /// 
        /// Insert and update operations count with the multiplicity of the number of columns they affect.
        /// For example, inserting a new record may count as five mutations, if values are inserted into five columns.
        /// 
        /// Delete and delete range operations count as one mutation regardless of the number of columns affected.
        /// 
        /// Deleting a row from a parent table that has the ON DELETE CASCADE annotation is also counted as one mutation
        /// regardless of the number of interleaved child rows present. The exception to this is if there are secondary
        /// indexes defined on rows being deleted, then the changes to the secondary indexes will be counted individually.
        /// 
        /// For example, if a table has 2 secondary indexes, deleting a range of rows in the table will count as 1 mutation
        /// for the table, plus 2 mutations for each row that is deleted because the rows in the secondary index might be
        /// scattered over the key-space, making it impossible for Cloud Spanner to call a single delete range operation on
        /// the secondary indexes. Secondary indexes include the foreign keys backing indexes.
        /// </summary>
        public long MutationCount
        {
            get
            {
                GaxPreconditions.CheckState(Proto.CommitStats != null, MISSING_COMMIT_STATS);
                return Proto.CommitStats.MutationCount;
            }
        }

        /// <summary>
        /// The duration that the commit was delayed due to overloaded servers.
        /// </summary>
        public TimeSpan OverloadDelay
        {
            get
            {
                GaxPreconditions.CheckState(Proto.CommitStats != null, MISSING_COMMIT_STATS);
                return Proto.CommitStats.OverloadDelay.ToTimeSpan();
            }
        }
    }
}
