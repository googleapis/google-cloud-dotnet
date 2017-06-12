// Copyright 2017 Google Inc. All Rights Reserved.
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

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// </summary>
    public enum TimestampBoundMode
    {
        /// <summary>
        /// Read at a timestamp where all previously committed transactions
        /// are visible.
        /// </summary>
        Strong,

        /// <summary>
        /// Executes all reads at the given timestamp. Unlike other modes,
        /// reads at a specific timestamp are repeatable; the same read at
        /// the same timestamp always returns the same data. If the
        /// timestamp is in the future, the read will block until the
        /// specified timestamp, modulo the read's deadline.
        ///
        /// Useful for large scale consistent reads such as mapreduces, or
        /// for coordinating many reads against a consistent snapshot of the
        /// data.
        /// </summary>
        ReadTimestamp,

        /// <summary>
        /// Executes all reads at a timestamp >= `minReadTimestamp`.
        ///
        /// This is useful for requesting fresher data than some previous
        /// read, or data that is fresh enough to observe the effects of some
        /// previously committed transaction whose timestamp is known.
        ///
        /// Note that this option can only be used in single-use transactions.
        /// </summary>
        MinReadTimestamp,

        /// <summary>
        /// Executes all reads at a timestamp that is `duration`
        /// old. The timestamp is chosen soon after the read is started.
        ///
        /// Guarantees that all writes that have committed more than the
        /// specified number of seconds ago are visible. Because Cloud Spanner
        /// chooses the exact timestamp, this mode works even if the client's
        /// local clock is substantially skewed from Cloud Spanner commit
        /// timestamps.
        ///
        /// Useful for reading at nearby replicas without the distributed
        /// timestamp negotiation overhead of <see cref="MaxStaleness"/>.
        /// </summary>
        ExactStaleness,

        /// <summary>
        /// Read data at a timestamp >= `NOW - duration`. Guarantees that all
        /// writes that have committed more than the specified number of seconds ago are
        /// visible.
        /// Because Cloud Spanner chooses the exact timestamp, this mode works even if
        /// the client's local clock is substantially skewed from Cloud Spanner
        /// commit timestamps.
        ///
        /// Useful for reading the freshest data available at a nearby
        /// replica, while bounding the possible staleness if the local
        /// replica has fallen behind.
        ///
        /// Note that this option can only be used in single-use.
        /// transactions.
        /// </summary>
        MaxStaleness
    }
}
