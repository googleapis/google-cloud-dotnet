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
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace Google.Bigquery.V2.IntegrationTests
{
    [Collection(nameof(BigqueryFixture))]
    public class UploadTest
    {
        private readonly BigqueryFixture _fixture;

        public UploadTest(BigqueryFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void UploadCsv()
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);

            string[] csvRows =
            {
                "Name,GameStarted,Score",
                "Ben,2014-08-19T12:41:35.220Z,85",
                "Lucy,2014-08-20T12:41:35.220Z,130",
                "Rohit,2014-08-21T12:41:35.220Z,90"
            };

            var bytes = Encoding.UTF8.GetBytes(string.Join("\n", csvRows));
            
            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            var beforeRowCount = table.ListRows().Count();

            var job = table.UploadCsv(new MemoryStream(bytes), new UploadCsvOptions { SkipLeadingRows = 1 });
            var result = job.PollUntilCompleted();
            Assert.Null(result.Status.ErrorResult);

            var afterRows = table.ListRows().ToList();
            Assert.Equal(beforeRowCount + 3, afterRows.Count);

            var ben = afterRows.Single(row => (string)row["player"] == "Ben");
            Assert.Equal(85, (long)ben["score"]);
            Assert.Equal(new DateTime(2014, 8, 19, 12, 41, 35, 220, DateTimeKind.Utc), (DateTime)ben["gameStarted"]);
        }

        [Fact]
        public void UploadJson()
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);

            // We use ' instead of " in the JSON to make it easier to write the string literals, then fix it up.
            var jsonRows = new[]
            {
                "{ 'player': 'UploadJsonTest1', 'score': 90, 'GameStarted': '2015-01-01T00:00:00.000Z' }",
                "{ 'player': 'UploadJsonTest2', 'score': 100, 'GameStarted': '2014-01-01T01:00:00.000Z' }"
            }.Select(x => x.Replace('\'', '"'));

            var bytes = Encoding.UTF8.GetBytes(string.Join("\n", jsonRows));

            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            var beforeRowCount = table.ListRows().Count();

            var job = table.UploadJson(new MemoryStream(bytes));
            var result = job.PollUntilCompleted();
            Assert.Null(result.Status.ErrorResult);

            var afterRows = table.ListRows().ToList();
            Assert.Equal(beforeRowCount + 2, afterRows.Count);

            var sql = $"SELECT player, score FROM {table} WHERE STARTS_WITH(player, 'UploadJsonTest') ORDER BY player";
            var rows = client.ExecuteQuery(sql).GetRows().ToList();
            Assert.Equal(2, rows.Count);
            Assert.Equal("UploadJsonTest1", (string)rows[0]["player"]);
            Assert.Equal("UploadJsonTest2", (string)rows[1]["player"]);
            Assert.Equal(90L, (long)rows[0]["score"]);
            Assert.Equal(100L, (long)rows[1]["score"]);
        }
    }
}
