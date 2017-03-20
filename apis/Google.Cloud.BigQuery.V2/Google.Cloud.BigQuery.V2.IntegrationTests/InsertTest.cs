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

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    [Collection(nameof(BigQueryFixture))]
    public class InsertTest
    {
        private readonly BigQueryFixture _fixture;

        public InsertTest(BigQueryFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void InsertSingleRow()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
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
            var client = BigQueryClient.Create(_fixture.ProjectId);
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
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.HighScoreTableId);
            var row = new BigQueryInsertRow { { "noSuchField", 10 } };
            Assert.Throws<GoogleApiException>(() => table.Insert(row));
        }

        [Fact]
        public void Insert_BadData_IgnoreBadData()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            // Don't insert into a table used by other tests...
            var table = dataset.CreateTable(
                _fixture.CreateTableId(),
                new TableSchemaBuilder { { "name", BigQueryDbType.String } }.Build());

            Assert.Equal(0, table.ListRows().Count());
            var row = new BigQueryInsertRow { { "noSuchField", 10 } };
            table.Insert(row, new InsertOptions { AllowUnknownFields = true });
            Assert.Equal(1, table.ListRows().Count());
        }

        [Fact]
        public void Insert_RecordField()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.ComplexTypesTableId);
            var guid = Guid.NewGuid().ToString();
            var row = new BigQueryInsertRow
            {
                ["guid"] = guid,
                ["position"] = new BigQueryInsertRow { ["x"] = 10L, ["y"] = 20L }
            };
            table.Insert(row);
            var command = new BigQueryCommand($"SELECT guid, position.x, position.y FROM {table} WHERE guid=@guid")
            {
                Parameters = { { "guid", BigQueryDbType.String, guid } }
            };
            var resultRows = WaitForRows(client, command)
                .Select(r => new { Guid = (string)r["guid"], X = (long)r["x"], Y = (long)r["y"] })
                .ToList();
            var expectedResults = new[]
            {
                new { Guid = guid, X = 10L, Y = 20L }
            };
            Assert.Equal(expectedResults, resultRows);
        }

        [Fact(Skip = "https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/897")]
        public void Insert_RepeatedField()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.ComplexTypesTableId);
            var guid = Guid.NewGuid().ToString();
            var row = new BigQueryInsertRow
            {
                ["guid"] = guid,
                // The null element will be ignored here (at the server side)
                ["tags"] = new[] { "a", null, "b"}
            };
            table.Insert(row);
            var command = new BigQueryCommand($"SELECT guid, tag FROM {table}, UNNEST(tags) AS tag WHERE guid=@guid ORDER BY tag")
            {
                Parameters = { { "guid", BigQueryDbType.String, guid } }
            };
            var resultRows = WaitForRows(client, command)
                .Select(r => new { Guid = (string)r["guid"], Tag = (string)r["tag"] })
                .ToList();
            var expectedResults = new[]
            {
                new { Guid = guid, Tag = "a" },
                new { Guid = guid, Tag = "b" }
            };
            Assert.Equal(expectedResults, resultRows);
        }

        [Fact]
        public void Insert_RepeatedRecordField()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.ComplexTypesTableId);
            var guid = Guid.NewGuid().ToString();
            var row = new BigQueryInsertRow
            {
                ["guid"] = guid,
                ["names"] = new[] {
                    new BigQueryInsertRow { ["first"] = "a", ["last"] = "b" },
                    new BigQueryInsertRow { ["first"] = "x", ["last"] = "y" }
                }
            };
            table.Insert(row);
            // Fetch flattened fields
            var command = new BigQueryCommand($"SELECT guid, name.first, name.last FROM {table}, UNNEST(names) AS name WHERE guid=@guid ORDER BY name.first")
            {
                Parameters = { { "guid", BigQueryDbType.String, guid } }
            };
            var resultRows = WaitForRows(client, command)
                .Select(r => new { Guid = (string)r["guid"], FirstName = (string)r["first"], LastName = (string)r["last"] })
                .ToList();
            var expectedResults = new[]
            {
                new { Guid = guid, FirstName = "a", LastName = "b" },
                new { Guid = guid, FirstName = "x", LastName = "y" }
            };
            Assert.Equal(expectedResults, resultRows);
            // Fetch unflattened
            command = new BigQueryCommand($"SELECT names FROM {table} WHERE guid=@guid")
            {
                Parameters = { { "guid", BigQueryDbType.String, guid } }
            };
            var resultRow = WaitForRows(client, command).Single();
            var fetchedNames = (Dictionary<string, object>[]) resultRow["names"];
            Assert.Equal(2, fetchedNames.Length);
            Assert.True(fetchedNames.Any(d => (string) d["first"] == "a" && (string) d["last"] == "b"));
            Assert.True(fetchedNames.Any(d => (string) d["first"] == "x" && (string) d["last"] == "y"));
        }

        [Fact]
        public void Insert_RecordRepeatedField()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.ComplexTypesTableId);
            var guid = Guid.NewGuid().ToString();
            var row = new BigQueryInsertRow
            {
                ["guid"] = guid,
                ["job"] = new BigQueryInsertRow { ["company"] = "Pet Store", ["roles"] = new[] { "cashier", "manager" } },
            };
            table.Insert(row);
            var command = new BigQueryCommand($"SELECT job FROM {table} WHERE guid=@guid")
            {
                Parameters = { { "guid", BigQueryDbType.String, guid } }
            };
            var fetchedRow = WaitForRows(client, command).Single();
            var job = (Dictionary<string, object>) fetchedRow["job"];
            Assert.Equal("Pet Store", (string) job["company"]);
            Assert.Equal(new[] { "cashier", "manager" }, (string[]) job["roles"]);
        }

        /// <summary>
        /// Waits for a query to return a non-empty result set. Some inserts may take a few seconds before the results are visible
        /// via queries - and much longer to show up in ListRows. (It looks like these are inserts with repeated fields and/or record fields.)
        /// </summary>
        private IEnumerable<BigQueryRow> WaitForRows(BigQueryClient client, BigQueryCommand command)
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

        private BigQueryInsertRow BuildRow(string player, long score, DateTime gameStarted) =>
            new BigQueryInsertRow
            {
                { "player", player },
                { "score", score },
                { "gameStarted", gameStarted }
            };
    }
}
