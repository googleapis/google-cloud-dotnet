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
using System.Linq;
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
                var db1Stats = new SessionPoolSegmentStatistics(
                    SessionPoolSegmentKey.Create(new DatabaseName("project", "instance", "db1")),
                    activeSessionCount: 4,
                    poolCount: 15,
                    inFlightCreationCount: 3,
                    pendingAcquisitionCount: 0,
                    healthy: true,
                    shutdown: false);
                var db2Stats = new SessionPoolSegmentStatistics(
                    SessionPoolSegmentKey.Create(new DatabaseName("project", "instance", "db2")),
                    activeSessionCount: 8,
                    poolCount: 10,
                    inFlightCreationCount: 2,
                    pendingAcquisitionCount: 0,
                    healthy: true,
                    shutdown: false);
                var db3Stats = new SessionPoolSegmentStatistics(
                    SessionPoolSegmentKey.Create(new DatabaseName("project", "instance", "db3")),
                    activeSessionCount: 3,
                    poolCount: 0,
                    inFlightCreationCount: 16,
                    pendingAcquisitionCount: 3,
                    healthy: true,
                    shutdown: false);
                var db4Stats = new SessionPoolSegmentStatistics(
                    SessionPoolSegmentKey.Create(new DatabaseName("project", "instance", "db1")).WithDatabaseRole("dbrole"),
                    activeSessionCount: 5,
                    poolCount: 0,
                    inFlightCreationCount: 4,
                    pendingAcquisitionCount: 0,
                    healthy: true,
                    shutdown: false);
                var allStats = new[] { db1Stats, db2Stats, db3Stats, db4Stats };
                var statistics = new Statistics(allStats);

                Assert.Equal(allStats, statistics.PerSegmentStatistics);
                Assert.Equal(20, statistics.TotalActiveSessionCount);
                Assert.Equal(25, statistics.TotalPoolCount);
                Assert.Equal(25, statistics.TotalInFlightCreationCount);
                Assert.Equal(3, statistics.TotalPendingAcquisitionCount);
            }
        }
    }
}
