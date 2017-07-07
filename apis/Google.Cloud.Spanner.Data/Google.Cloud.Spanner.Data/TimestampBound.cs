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

using System;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Indicates how Spanner will choose a timestamp at which to read the data for read-only
    /// transactions.
    /// </summary>
    public sealed class TimestampBound
    {
        private TimestampBound(TimestampBoundMode mode)
        {
            Mode = mode;
        }

        private TimestampBound(TimestampBoundMode mode, TimeSpan staleness)
        {
            Mode = mode;
            Staleness = staleness;
        }

        private TimestampBound(TimestampBoundMode mode, DateTime timestamp)
        {
            Mode = mode;
            Timestamp = timestamp;
        }

        /// <summary>
        /// The type of timestamp bound.
        /// The types of timestamp bounds are:
        ///  Strong (the default): read the latest data.
        ///  Bounded staleness: read a version of the data that's no staler than a bound.
        ///  Exact staleness: read the version of the data at an exact timestamp.
        /// </summary>
        public TimestampBoundMode Mode { get; }

        /// <summary>
        /// If <see cref="Mode"/> is <see cref="TimestampBoundMode.ExactStaleness"/> or
        /// <see cref="TimestampBoundMode.MaxStaleness"/>, this indicates the duration of time
        /// for the staleness.
        /// </summary>
        public TimeSpan Staleness { get; }

        /// <summary>
        /// If <see cref="Mode"/> is <see cref="TimestampBoundMode.ReadTimestamp"/> or
        /// <see cref="TimestampBoundMode.MinReadTimestamp"/>, this indicates the timestamp to use.
        /// </summary>
        public DateTime Timestamp { get; }

        /// <summary>
        /// Read at a timestamp where all previously committed transactions
        /// are visible.
        /// </summary>
        public static TimestampBound Strong { get; } = new TimestampBound(TimestampBoundMode.Strong);

        /// <summary>
        /// Executes all reads at a timestamp that is <paramref name="duration"/>
        /// old. The timestamp is chosen soon after the read is started.
        ///
        /// Guarantees that all writes that have committed more than the
        /// specified number of seconds ago are visible. Because Cloud Spanner
        /// chooses the exact timestamp, this mode works even if the client's
        /// local clock is substantially skewed from Cloud Spanner commit
        /// timestamps.
        ///
        /// Useful for reading at nearby replicas without the distributed
        /// timestamp negotiation overhead of <see cref="OfMaxStaleness"/>.
        /// </summary>
        /// <param name="duration">The exact staleness to use.</param>
        /// <returns>A created <see cref="TimestampBound"/>.</returns>
        public static TimestampBound OfExactStaleness(TimeSpan duration) => new TimestampBound(
            TimestampBoundMode.ExactStaleness, duration);

        /// <summary>
        /// Read data at a timestamp >= `NOW - <paramref name="duration"/>`. Guarantees that all
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
        /// Note that this option can only be used in single-use
        /// transactions.
        /// </summary>
        /// <param name="duration">The maximum duration of staleness to use.</param>
        /// <returns>A created <see cref="TimestampBound"/>.</returns>
        public static TimestampBound OfMaxStaleness(TimeSpan duration) => new TimestampBound(
            TimestampBoundMode.MaxStaleness, duration);

        /// <summary>
        /// Executes all reads at a timestamp >= <paramref name="minReadTimestamp"/>.
        ///
        /// This is useful for requesting fresher data than some previous
        /// read, or data that is fresh enough to observe the effects of some
        /// previously committed transaction whose timestamp is known.
        ///
        /// Note that this option can only be used in single-use transactions
        /// </summary>
        /// <param name="minReadTimestamp">The earliest timestamp to read from.</param>
        /// <returns>A created <see cref="TimestampBound"/>.</returns>
        public static TimestampBound OfMinReadTimestamp(DateTime minReadTimestamp) => new TimestampBound(
            TimestampBoundMode.MinReadTimestamp, minReadTimestamp);

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
        /// <param name="timestamp">The timestamp to read from.</param>
        /// <returns>A created <see cref="TimestampBound"/>.</returns>
        public static TimestampBound OfReadTimestamp(DateTime timestamp) => new TimestampBound(
            TimestampBoundMode.ReadTimestamp, timestamp);
    }
}
