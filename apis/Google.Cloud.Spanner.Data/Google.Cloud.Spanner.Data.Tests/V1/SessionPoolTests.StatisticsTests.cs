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
using Xunit;
using static Google.Cloud.Spanner.V1.SessionPool;

namespace Google.Cloud.Spanner.V1.Tests
{
    public partial class SessionPoolTests
    {
        public sealed class StatisticsTests
        {
            [Fact]
            public void AllProperties()
            {
                var db1Stats = new DatabaseStatistics(
                    databaseName: new DatabaseName("project", "instance", "db1"),
                    activeSessionCount: 4,
                    readPoolCount: 5,
                    readWritePoolCount: 10,
                    inFlightCreationCount: 3,
                    pendingAcquisitionCount: 0,
                    readWriteTransactionRequests: 100L,
                    readWriteTransactionRequestsPrewarmed: 95L,
                    healthy: true,
                    shutdown: false);
                var db2Stats = new DatabaseStatistics(
                    databaseName: new DatabaseName("project", "instance", "db2"),
                    activeSessionCount: 8,
                    readPoolCount: 7,
                    readWritePoolCount: 3,
                    inFlightCreationCount: 2,
                    pendingAcquisitionCount: 0,
                    readWriteTransactionRequests: 200L,
                    readWriteTransactionRequestsPrewarmed: 195L,
                    healthy: true,
                    shutdown: false);
                var db3Stats = new DatabaseStatistics(
                    databaseName: new DatabaseName("project", "instance", "db3"),
                    activeSessionCount: 3,
                    readPoolCount: 0,
                    readWritePoolCount: 0,
                    inFlightCreationCount: 16,
                    pendingAcquisitionCount: 3,
                    readWriteTransactionRequests: 500L,
                    readWriteTransactionRequestsPrewarmed: 500L,
                    healthy: true,
                    shutdown: false);
                var allStats = new[] { db1Stats, db2Stats, db3Stats };
                var statistics = new Statistics(allStats);

                Assert.Equal(allStats, statistics.PerDatabaseStatistics);
                Assert.Equal(15, statistics.TotalActiveSessionCount);
                Assert.Equal(12, statistics.TotalReadPoolCount);
                Assert.Equal(13, statistics.TotalReadWritePoolCount);
                Assert.Equal(21, statistics.TotalInFlightCreationCount);
                Assert.Equal(3, statistics.TotalPendingAcquisitionCount);
            }
        }
    }
}
