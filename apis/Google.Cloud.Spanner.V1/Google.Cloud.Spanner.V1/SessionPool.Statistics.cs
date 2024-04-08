// Copyright 2018 Google LLC
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

using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Spanner.V1
{
    public partial class SessionPool
    {
        /// <summary>
        /// A snapshot of statistics for a <see cref="SessionPool"/>.
        /// </summary>
        public sealed class Statistics
        {
            /// <summary>
            /// The total of <see cref="SessionPoolSegmentStatistics.PoolCount"/> values across all databases in the pool.
            /// </summary>
            public int TotalPoolCount => PerSegmentStatistics.Sum(d => d.PoolCount);

            /// <summary>
            /// The total of <see cref="SessionPoolSegmentStatistics.ActiveSessionCount"/> values across all databases in the pool.
            /// </summary>
            public int TotalActiveSessionCount => PerSegmentStatistics.Sum(d => d.ActiveSessionCount);

            /// <summary>
            /// The total of <see cref="SessionPoolSegmentStatistics.InFlightCreationCount"/> values across all databases in the pool.
            /// </summary>
            public int TotalInFlightCreationCount => PerSegmentStatistics.Sum(d => d.InFlightCreationCount);

            /// <summary>
            /// The total of <see cref="SessionPoolSegmentStatistics.PendingAcquisitionCount"/> values across all databases in the pool.
            /// </summary>
            public int TotalPendingAcquisitionCount => PerSegmentStatistics.Sum(d => d.PendingAcquisitionCount);

            /// <summary>
            /// The statistics broken down by <see cref="SessionPoolSegmentKey"/>. This is never null, but may be empty.
            ///</summary>
            public IReadOnlyList<SessionPoolSegmentStatistics> PerSegmentStatistics { get; }

            internal Statistics(IReadOnlyList<SessionPoolSegmentStatistics> perSessionPoolSegmentStatistics) =>
                PerSegmentStatistics = perSessionPoolSegmentStatistics;
        }
    }
}
