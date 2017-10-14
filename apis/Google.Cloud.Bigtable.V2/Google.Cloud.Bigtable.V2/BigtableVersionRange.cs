// Copyright 2017 Google Inc. All rights reserved.
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

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// A contiguous range of versions.
    /// </summary>
    public class BigtableVersionRange : IEquatable<BigtableVersionRange>
    {
        /// <summary>
        /// Creates a new <see cref="BigtableVersionRange"/>.
        /// </summary>
        /// <param name="start">Inclusive lower bound. If null, interpreted as 0.</param>
        /// <param name="end">Exclusive upper bound. If null, interpreted as infinity.</param>
        public BigtableVersionRange(BigtableVersion? start, BigtableVersion? end)
        {
            Start = start;
            End = end;
        }

        /// <summary>
        /// Creates a new <see cref="BigtableVersionRange"/>.
        /// </summary>
        /// <param name="start">
        /// Inclusive lower bound non-negative version value, or -1 to initialize from the
        /// microseconds of DateTime.UtcNow. If null, interpreted as 0.
        /// </param>
        /// <param name="end">
        /// Exclusive upper bound non-negative version value, or -1 to initialize from the
        /// microseconds of DateTime.UtcNow. If null, interpreted as infinity.
        /// </param>
        public BigtableVersionRange(long? start, long? end)
            : this(start.ToVersion(), end.ToVersion()) { }

        // TODO: Get clarification on use cases to see how useful this would be.
        /// <summary>
        /// Creates a new <see cref="BigtableVersionRange"/>.
        /// </summary>
        /// <param name="startTimestamp">
        /// Inclusive lower bound timestamp whose microseconds should be used as the version value.
        /// If null, interpreted as 0.  It must be specified in UTC.
        /// </param>
        /// <param name="endTimestamp">
        /// Exclusive upper bound timestamp whose microseconds should be used as the version value.
        /// If null, interpreted as infinity.  It must be specified in UTC.
        /// </param>
        public BigtableVersionRange(DateTime? startTimestamp, DateTime? endTimestamp)
            : this(startTimestamp.ToVersion(), endTimestamp.ToVersion()) { }

        /// <summary>
        /// Gets the inclusive lower bound. If null, interpreted as 0.
        /// </summary>
        public BigtableVersion? Start { get; }

        /// <summary>
        /// Gets the exclusive upper bound. If null, interpreted as infinity.
        /// </summary>
        public BigtableVersion? End { get; }

        /// <inheritdoc />
        public bool Equals(BigtableVersionRange other) =>
            other != null && Start == other.Start && End == other.End;

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as BigtableVersionRange);

        /// <inheritdoc />
        public override int GetHashCode() =>
            Start.HasValue.GetHashCode() ^ End.HasValue.GetHashCode() ^
            Start.GetHashCode() ^ End.GetHashCode();

        /// <inheritdoc />
        public override string ToString() =>
            $"{nameof(BigtableVersionRange)}: Start={Start?.Value.ToString() ?? " "}; End={End?.Value.ToString() ?? " "}";

        internal TimestampRange ToTimestampRange() =>
            new TimestampRange
            {
                StartTimestampMicros = Start.ToTimestampMicros(),
                EndTimestampMicros = End.ToTimestampMicros()
            };
    }
}