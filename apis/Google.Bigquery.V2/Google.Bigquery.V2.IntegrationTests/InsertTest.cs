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
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Xunit;

namespace Google.Bigquery.V2.IntegrationTests
{
    [Collection(nameof(BigqueryFixture))]
    public class InsertTest
    {
        private readonly BigqueryFixture _fixture;

        public InsertTest(BigqueryFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void InsertSingleRow()
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.HighScoreTableId);

            var countBefore = table.ListRows().Count();

            var row = BuildRow("Joe", 100, new DateTime(2016, 4, 26, 11, 43, 1, DateTimeKind.Utc));
            table.Insert(row);

            var rowsAfter = table.ListRows();
            var fetched = rowsAfter.Single(r => (string)r["player"] == "Joe");
            Assert.Equal(row["score"], fetched["score"]);
            Assert.Equal(row["gameStarted"], fetched["gameStarted"]);

            Assert.Equal(countBefore + 1, rowsAfter.Count());
        }

        [Fact]
        public void InsertMultipleRows()
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.HighScoreTableId);

            var countBefore = table.ListRows().Count();

            var rows = new[]
            {
                BuildRow("Jenny", 125, new DateTime(2012, 5, 22, 1, 20, 30, DateTimeKind.Utc)),
                BuildRow("Lisa", 90, new DateTime(2011, 10, 12, 0, 0, 0, DateTimeKind.Utc))
            };
            table.Insert(rows);

            var rowsAfter = table.ListRows();
            Assert.True(rowsAfter.Any(r => (string)r["player"] == "Jenny"));
            Assert.True(rowsAfter.Any(r => (string)r["player"] == "Lisa"));

            Assert.Equal(countBefore + 2, rowsAfter.Count());
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

        [Fact]
        public void Insert_RecordField()
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.ComplexTypesTableId);
            var guid = Guid.NewGuid().ToString();
            var row = new InsertRow
            {
                ["guid"] = guid,
                ["position"] = new InsertRow { ["x"] = 10L, ["y"] = 20L }
            };
            table.Insert(row);
            var command = new BigqueryCommand($"SELECT guid, position.x, position.y FROM {table} WHERE guid=@guid")
            {
                Parameters = { { "guid", BigqueryParameterType.String, guid } }
            };
            var queryResults = WaitForRows(client, command)
                .Select(r => new { Guid = (string)r["guid"], X = (long)r["x"], Y = (long)r["y"] })
                .ToList();
            var expectedResults = new[]
            {
                new { Guid = guid, X = 10L, Y = 20L }
            };
            Assert.Equal(expectedResults, queryResults);
        }

        [Fact]
        public void Insert_RepeatedField()
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.ComplexTypesTableId);
            var guid = Guid.NewGuid().ToString();
            var row = new InsertRow
            {
                ["guid"] = guid,
                // The null element will be ignored here (at the server side)
                ["tags"] = new[] { "a", null, "b"}
            };
            table.Insert(row);
            var command = new BigqueryCommand($"SELECT guid, tag FROM {table}, UNNEST(tags) AS tag WHERE guid=@guid ORDER BY tag")
            {
                Parameters = { { "guid", BigqueryParameterType.String, guid } }
            };
            var queryResults = WaitForRows(client, command)
                .Select(r => new { Guid = (string)r["guid"], Tag = (string)r["tag"] })
                .ToList();
            var expectedResults = new[]
            {
                new { Guid = guid, Tag = "a" },
                new { Guid = guid, Tag = "b" }
            };
            Assert.Equal(expectedResults, queryResults);
        }

        [Fact]
        public void Insert_RepeatedRecordField()
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.ComplexTypesTableId);
            var guid = Guid.NewGuid().ToString();
            var row = new InsertRow
            {
                ["guid"] = guid,
                ["names"] = new[] {
                    new InsertRow { ["first"] = "a", ["last"] = "b" },
                    new InsertRow { ["first"] = "x", ["last"] = "y" }
                }
            };
            table.Insert(row);
            var command = new BigqueryCommand($"SELECT guid, name.first, name.last FROM {table}, UNNEST(names) AS name WHERE guid=@guid ORDER BY name.first")
            {
                Parameters = { { "guid", BigqueryParameterType.String, guid } }
            };
            var queryResults = WaitForRows(client, command)
                .Select(r => new { Guid = (string)r["guid"], FirstName = (string)r["first"], LastName = (string)r["last"] })
                .ToList();
            var expectedResults = new[]
            {
                new { Guid = guid, FirstName = "a", LastName = "b" },
                new { Guid = guid, FirstName = "x", LastName = "y" }
            };
            Assert.Equal(expectedResults, queryResults);
        }

        /// <summary>
        /// Waits for a query to return a non-empty result set. Some inserts may take a few seconds before the results are visible
        /// via queries - and much longer to show up in ListRows. (It looks like these are inserts with repeated fields and/or record fields.)
        /// </summary>
        private IEnumerable<BigqueryRow> WaitForRows(BigqueryClient client, BigqueryCommand command)
        {
            for (int i = 0; i < 5; i++)
            {
                var rows = client.ExecuteQuery(command)
                    .PollUntilCompleted()
                    .GetRows()
                    .ToList();
                if (rows.Count > 0)
                {
                    return rows;
                }
                Thread.Sleep(1000);
            }
            throw new TimeoutException("Expected rows were not available after 5 seconds");
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
