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

namespace Google.Bigquery.V2.IntegrationTests
{
    [Collection(nameof(SampleDatasetFixture))]
    public class InsertTest
    {
        private readonly SampleDatasetFixture _fixture;

        public InsertTest(SampleDatasetFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void InsertSingleRow()
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.HighScoreTableId);

            var countBefore = table.ListRows().Rows.Count();

            var row = BuildRow("Joe", 100, new DateTime(2016, 4, 26, 11, 43, 1, DateTimeKind.Utc));
            table.Insert(row);

            var rowsAfter = table.ListRows();
            var fetched = rowsAfter.Rows.Single(r => (string)r["player"] == "Joe");
            Assert.Equal(row["score"], fetched["score"]);
            Assert.Equal(row["gameStarted"], fetched["gameStarted"]);

            Assert.Equal(countBefore + 1, rowsAfter.Rows.Count());
        }

        [Fact]
        public void InsertMultipleRows()
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.HighScoreTableId);

            var countBefore = table.ListRows().Rows.Count();

            var rows = new[]
            {
                BuildRow("Jenny", 125, new DateTime(2012, 5, 22, 1, 20, 30, DateTimeKind.Utc)),
                BuildRow("Lisa", 90, new DateTime(2011, 10, 12, 0, 0, 0, DateTimeKind.Utc))
            };
            table.Insert(rows);

            var rowsAfter = table.ListRows();
            Assert.True(rowsAfter.Rows.Any(r => (string)r["player"] == "Jenny"));
            Assert.True(rowsAfter.Rows.Any(r => (string)r["player"] == "Lisa"));

            Assert.Equal(countBefore + 2, rowsAfter.Rows.Count());
        }

        [Fact]
        public void Insert_BadData()
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.HighScoreTableId);
            var row = new InsertRow { { "noSuchField", 10 } };
            Assert.Throws<GoogleApiException>(() => table.Insert(row));
        }

        [Fact]
        public void Insert_BadData_IgnoreBadData()
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.HighScoreTableId);
            var row = new InsertRow { { "noSuchField", 10 } };
            table.Insert(row, new InsertOptions { AllowUnknownFields = true });
        }
        
        private InsertRow BuildRow(string player, long score, DateTime gameStarted) =>
            new InsertRow
            {
                { "player", player },
                { "score", score },
                { "gameStarted", gameStarted }
            };
    }
}
