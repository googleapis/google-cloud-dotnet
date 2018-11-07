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

namespace Google.Cloud.Spanner.V1
{
    public partial class SessionPool
    {
        /// <summary>
        /// A snapshot of statistics for one database within a <see cref="SessionPool"/>.
        /// </summary>
        public sealed class DatabaseStatistics
        {
            /// <summary>
            /// The database this set of statistics corresponds to.
            /// </summary>
            public DatabaseName DatabaseName { get; }

            /// <summary>
            /// The number of read-only sessions in the pool.
            /// </summary>
            public int ReadPoolCount { get; }

            /// <summary>
            /// The number of read/write sessions in the pool.
            /// </summary>
            public int ReadWritePoolCount { get; }

            /// <summary>
            /// The number of active or requested sessions. This is the difference between the number of successful or
            /// pending session acquisition requests and the number of released sessions. If this exceeds
            /// <see cref="SessionPoolOptions.MaximumActiveSessions"/> it indicates that some acquisition calls are currently
            /// pending; the limit is obeyed separately, in terms of how many session creation requests the pool has made to the server.
            /// </summary>
            public int ActiveSessionCount { get; }

            /// <summary>
            /// The number of session creation (or refresh, or transaction creation) requests in flight.
            /// </summary>
            public int InFlightCreationCount { get; }

            /// <summary>
            /// The number of client calls awaiting sessions.
            /// </summary>
            public int PendingAcquisitionCount { get; }

            /// <summary>
            /// The number of times a read/write transaction was requested.
            /// </summary>
            public long ReadWriteTransactionRequests { get; }

            /// <summary>
            /// The number of times a read/write transaction was satisfied with a pre-warmed transaction.
            /// </summary>
            public long ReadWriteTransactionRequestsPrewarmed { get; }

            /// <summary>
            /// Whether the pool is healthy or not.
            /// </summary>
            public bool Healthy { get; }

            /// <summary>
            /// Whether the pool has been shut down or not. (This indicates the start
            /// of shutdown, not necessarily the end.)
            /// </summary>
            public bool Shutdown { get; }

            /// <summary>
            /// Constructs a new instance.
            /// </summary>
            internal DatabaseStatistics(
                DatabaseName databaseName,
                int activeSessionCount,
                int readPoolCount,
                int readWritePoolCount,
                int inFlightCreationCount,
                int pendingAcquisitionCount,
                long readWriteTransactionRequests,
                long readWriteTransactionRequestsPrewarmed,
                bool healthy,
                bool shutdown)
            {
                DatabaseName = databaseName;
                ActiveSessionCount = activeSessionCount;
                ReadPoolCount = readPoolCount;
                ReadWritePoolCount = readWritePoolCount;
                InFlightCreationCount = inFlightCreationCount;
                PendingAcquisitionCount = pendingAcquisitionCount;
                ReadWriteTransactionRequests = readWriteTransactionRequests;
                ReadWriteTransactionRequestsPrewarmed = readWriteTransactionRequestsPrewarmed;
                Healthy = healthy;
                Shutdown = shutdown;
            }

            /// <inheritdoc />
            public override string ToString()
            {
                string status = Shutdown ? "Shutdown"
                    : Healthy ? "Healthy"
                    : "Unhealthy";
                return $"Database: {DatabaseName}; Active: {ActiveSessionCount}; Read pool: {ReadPoolCount}; Write pool: {ReadWritePoolCount}; In-flight creation: {InFlightCreationCount}; Pending acquisitions: {PendingAcquisitionCount}; Status: {status}; Read/write prewarming: {ReadWriteTransactionRequestsPrewarmed}/{ReadWriteTransactionRequests}";
            }
        }
    }
}
