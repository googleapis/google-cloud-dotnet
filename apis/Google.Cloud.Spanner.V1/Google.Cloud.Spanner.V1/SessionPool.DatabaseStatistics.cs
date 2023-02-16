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


using Google.Cloud.Spanner.Common.V1;
using System;

namespace Google.Cloud.Spanner.V1
{
    public partial class SessionPool
    {
        /// <summary>
        /// A snapshot of statistics for a <see cref="SessionPoolSegmentKey"/> within a <see cref="SessionPool"/>.
        /// </summary>
        [Obsolete($"Use Google.Cloud.Spanner.V1.SessionPool.{nameof(SessionPoolSegmentStatistics)} instead. The behavior of both classes is the same, but the new class name better reflects the fact that sessions are now pooled by aspects other than database name.")]
        public sealed class DatabaseStatistics
        {
            /// <summary>
            /// The database this set of statistics corresponds to.
            /// </summary>
            public DatabaseName DatabaseName => SegmentStatistics.DatabaseName;

            /// <summary>
            /// The database role of the sessions in the session pool this set of statistics corresponds to. May be null
            /// in which case the default (public) database role is used if fine grained access control
            /// is enabled; otherwise the database role is ignored.
            /// </summary>
            public string DatabaseRole => SegmentStatistics.DatabaseRole;

            private SessionPoolSegmentStatistics SegmentStatistics { get; }

            /// <summary>
            /// The number of read-only sessions in the pool.
            /// </summary>
            public int ReadPoolCount => SegmentStatistics.ReadPoolCount;

            /// <summary>
            /// The number of read/write sessions in the pool.
            /// </summary>
            public int ReadWritePoolCount => SegmentStatistics.ReadWritePoolCount;

            /// <summary>
            /// The number of active or requested sessions. This is the difference between the number of successful or
            /// pending session acquisition requests and the number of released sessions. If this exceeds
            /// <see cref="SessionPoolOptions.MaximumActiveSessions"/> it indicates that some acquisition calls are currently
            /// pending; the limit is obeyed separately, in terms of how many session creation requests the pool has made to the server.
            /// </summary>
            public int ActiveSessionCount => SegmentStatistics.ActiveSessionCount;

            /// <summary>
            /// The number of session creation (or refresh, or transaction creation) requests in flight.
            /// </summary>
            public int InFlightCreationCount => SegmentStatistics.InFlightCreationCount;

            /// <summary>
            /// The number of client calls awaiting sessions.
            /// </summary>
            public int PendingAcquisitionCount => SegmentStatistics.PendingAcquisitionCount;

            /// <summary>
            /// The number of times a read/write transaction was requested.
            /// </summary>
            public long ReadWriteTransactionRequests => SegmentStatistics.ReadWriteTransactionRequests;

            /// <summary>
            /// The number of times a read/write transaction was satisfied with a pre-warmed transaction.
            /// </summary>
            public long ReadWriteTransactionRequestsPrewarmed => SegmentStatistics.ReadWriteTransactionRequestsPrewarmed;

            /// <summary>
            /// Whether the pool is healthy or not.
            /// </summary>
            public bool Healthy => SegmentStatistics.Healthy;

            /// <summary>
            /// Whether the pool has been shut down or not. (This indicates the start
            /// of shutdown, not necessarily the end.)
            /// </summary>
            public bool Shutdown => SegmentStatistics.Shutdown;

            /// <summary>
            /// Constructs a new instance.
            /// </summary>
            internal DatabaseStatistics(SessionPoolSegmentStatistics sessionPoolSegmentStatistics) =>
                SegmentStatistics = sessionPoolSegmentStatistics;
            
            /// <inheritdoc />
            public override string ToString() => SegmentStatistics.ToString();
        }
    }
}
