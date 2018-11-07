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
            /// The total of <see cref="DatabaseStatistics.ReadPoolCount"/> values across all databases in the pool.
            /// </summary>
            public int TotalReadPoolCount => PerDatabaseStatistics.Sum(d => d.ReadPoolCount);

            /// <summary>
            /// The total of <see cref="DatabaseStatistics.ReadWritePoolCount"/> values across all databases in the pool.
            /// </summary>
            public int TotalReadWritePoolCount => PerDatabaseStatistics.Sum(d => d.ReadWritePoolCount);

            /// <summary>
            /// The total of <see cref="DatabaseStatistics.ActiveSessionCount"/> values across all databases in the pool.
            /// </summary>
            public int TotalActiveSessionCount => PerDatabaseStatistics.Sum(d => d.ActiveSessionCount);

            /// <summary>
            /// The total of <see cref="DatabaseStatistics.InFlightCreationCount"/> values across all databases in the pool.
            /// </summary>
            public int TotalInFlightCreationCount => PerDatabaseStatistics.Sum(d => d.InFlightCreationCount);

            /// <summary>
            /// The total of <see cref="DatabaseStatistics.PendingAcquisitionCount"/> values across all databases in the pool.
            /// </summary>
            public int TotalPendingAcquisitionCount => PerDatabaseStatistics.Sum(d => d.PendingAcquisitionCount);

            /// <summary>
            /// The statistics broken down by database. This is never null, but may be empty.
            /// </summary>
            public IReadOnlyList<DatabaseStatistics> PerDatabaseStatistics { get; }

            internal Statistics(IReadOnlyList<DatabaseStatistics> perDatabaseStatistics) =>
                PerDatabaseStatistics = perDatabaseStatistics;
        }
    }
}
