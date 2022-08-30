// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Cloud.Spanner.Common.V1;
using static Google.Cloud.Spanner.V1.SessionPool;
using System.Data;

namespace Google.Cloud.Spanner.V1;
public partial class SessionPool
{
    /// <summary>
    /// A snapshot of statistics for a <see cref="SessionPoolSegmentKey"/> within a <see cref="SessionPool"/>.
    /// </summary>
    public sealed class SessionPoolSegmentStatistics
    {
        /// <summary>
        /// The database associated with the pool this set of statistics corresponds. 
        /// </summary>
        public DatabaseName DatabaseName => Key.DatabaseName;

        /// <summary>
        /// The database role of the sessions in the pool this set of statistics corresponds to.May be null,
        /// in which case sessions are will either have the default role, if fine-grained access control is
        /// configured, or no role at all.
        /// </summary>
        public string DatabaseRole => Key.DatabaseRole;

        /// <summary>
        /// Represents the aspects defining the session pool this set of statistics correspond to.
        /// </summary>
        private SessionPoolSegmentKey Key { get; }

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
        internal SessionPoolSegmentStatistics(
            SessionPoolSegmentKey key,
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
            Key = key;
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
            return $"{Key}; Active: {ActiveSessionCount}; Read pool: {ReadPoolCount}; Write pool: {ReadWritePoolCount}; In-flight creation: {InFlightCreationCount}; Pending acquisitions: {PendingAcquisitionCount}; Status: {status}; Read/write prewarming: {ReadWriteTransactionRequestsPrewarmed}/{ReadWriteTransactionRequests}";
        }
    }
}
