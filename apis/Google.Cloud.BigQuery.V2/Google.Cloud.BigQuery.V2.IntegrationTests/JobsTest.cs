// Copyright 2016 Google Inc. All Rights Reserved.
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
using System.Linq;
using Xunit;

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    [Collection(nameof(BigQueryFixture))]
    public class JobsTest
    {
        private readonly BigQueryFixture _fixture;

        public JobsTest(BigQueryFixture fixture)
        {
            _fixture = fixture;
        }

        // TODO: Put this somewhere in the API code for convenience.
        // We'd need an assertion that it's a UTC DateTime.
        private long ToMillisecondsSinceEpoch(DateTime dateTime) =>
            (long) (dateTime - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;

        [Fact]
        public void ListJobs()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);

            var table = client.GetTable(_fixture.ProjectId, _fixture.DatasetId, _fixture.HighScoreTableId);
            var jobToFind = client.CreateQueryJob("SELECT * FROM {table}");

            var oneMinuteAgo = ToMillisecondsSinceEpoch(DateTime.UtcNow.AddMinutes(-1));

            // Find all jobs started in the last minute.
            var recentJobs = client.ListJobs().TakeWhile(job => job.Statistics.CreationTime >= jobToFind.Statistics.CreationTime).ToList();

            // Note: can't find the job reference itself, as that would check equality by reference :(
            var jobIds = recentJobs.Select(job => job.Reference.JobId).ToList();
            Assert.Contains(jobToFind.Reference.JobId, jobIds);
        }
    }
}
