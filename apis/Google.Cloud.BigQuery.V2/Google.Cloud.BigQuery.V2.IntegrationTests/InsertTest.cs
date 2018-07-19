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

using Google.Cloud.ClientTesting;
using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public void InsertRow()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.HighScoreTableId);

            var row = BuildRow("Joe", 100, new DateTime(2016, 4, 26, 11, 43, 1, DateTimeKind.Utc));

            _fixture.InsertAndWait(table, () => table.InsertRow(row), 1);

            var rowsAfter = table.ListRows();
            var fetched = rowsAfter.Single(r => (string)r["player"] == "Joe");
            Assert.Equal(row["score"], fetched["score"]);
            Assert.Equal(row["gameStarted"], fetched["gameStarted"]);
        }

        [Fact]
        public void InsertRows()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.HighScoreTableId);

            var rows = new[]
            {
                BuildRow("Jenny", 125, new DateTime(2012, 5, 22, 1, 20, 30, DateTimeKind.Utc)),
                BuildRow("Lisa", 90, new DateTime(2011, 10, 12, 0, 0, 0, DateTimeKind.Utc))
            };

            _fixture.InsertAndWait(table, () => table.InsertRows(rows), 2);

            var rowsAfter = table.ListRows().ToList();
            Assert.Contains(rowsAfter, r => (string)r["player"] == "Jenny");
            Assert.Contains(rowsAfter, r => (string)r["player"] == "Lisa");
        }

        [Fact]
        public void InsertRow_BadData()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.HighScoreTableId);
            var row = new BigQueryInsertRow { { "noSuchField", 10 } };
            Assert.Throws<GoogleApiException>(() => table.InsertRow(row));
        }

        [Fact]
        public void InsertRow_BadData_IgnoreBadData()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            // Don't insert into a table used by other tests...
            var table = dataset.CreateTable(
                _fixture.CreateTableId(),
                new TableSchemaBuilder { { "name", BigQueryDbType.String } }.Build());

            var row = new BigQueryInsertRow { { "noSuchField", 10 } };

            var options = new InsertOptions { AllowUnknownFields = true };
            _fixture.InsertAndWait(table, () => table.InsertRow(row, options), 1);
        }


        [Fact]
        public void InsertRow_RecordField()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.ComplexTypesTableId);

            var guid = IdGenerator.FromGuid();
            var row = new BigQueryInsertRow
            {
                ["guid"] = guid,
                ["position"] = new BigQueryInsertRow { ["x"] = 10L, ["y"] = 20L }
            };

            _fixture.InsertAndWait(table, () => table.InsertRow(row), 1);
            string sql = $"SELECT guid, position.x, position.y FROM {table} WHERE guid=@guid";
            var parameters = new[] { new BigQueryParameter("guid", BigQueryDbType.String, guid) };
            var resultRows = client.ExecuteQuery(sql, parameters)
                .Select(r => new { Guid = (string)r["guid"], X = (long)r["x"], Y = (long)r["y"] })
                .ToList();
            var expectedResults = new[]
            {
                new { Guid = guid, X = 10L, Y = 20L }
            };
            Assert.Equal(expectedResults, resultRows);
        }

        [Fact]
        public void InsertRow_RepeatedField()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.ComplexTypesTableId);
            var guid = IdGenerator.FromGuid();
            var row = new BigQueryInsertRow
            {
                ["guid"] = guid,
                ["tags"] = new[] { "a", "b"}
            };
            _fixture.InsertAndWait(table, () => table.InsertRow(row), 1);

            string sql = $"SELECT guid, tag FROM {table}, UNNEST(tags) AS tag WHERE guid=@guid ORDER BY tag";
            var parameters = new[] { new BigQueryParameter("guid", BigQueryDbType.String, guid) };
            var resultRows = client.ExecuteQuery(sql, parameters)
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
        public void InsertRow_RepeatedRecordField()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.ComplexTypesTableId);
            var guid = IdGenerator.FromGuid();
            var row = new BigQueryInsertRow
            {
                ["guid"] = guid,
                ["names"] = new[] {
                    new BigQueryInsertRow { ["first"] = "a", ["last"] = "b" },
                    new BigQueryInsertRow { ["first"] = "x", ["last"] = "y" }
                }
            };

            _fixture.InsertAndWait(table, () => table.InsertRow(row), 1);

            // Fetch flattened fields
            string sql = $"SELECT guid, name.first, name.last FROM {table}, UNNEST(names) AS name WHERE guid=@guid ORDER BY name.first";
            var parameters = new[] { new BigQueryParameter("guid", BigQueryDbType.String, guid) };
            var resultRows = client.ExecuteQuery(sql, parameters)
                .Select(r => new { Guid = (string)r["guid"], FirstName = (string)r["first"], LastName = (string)r["last"] })
                .ToList();
            var expectedResults = new[]
            {
                new { Guid = guid, FirstName = "a", LastName = "b" },
                new { Guid = guid, FirstName = "x", LastName = "y" }
            };
            Assert.Equal(expectedResults, resultRows);
            // Fetch unflattened
            sql = $"SELECT names FROM {table} WHERE guid=@guid";
            var resultRow = client.ExecuteQuery(sql, parameters)
                .Single();
            var fetchedNames = (Dictionary<string, object>[]) resultRow["names"];
            Assert.Equal(2, fetchedNames.Length);
            Assert.Contains(fetchedNames, d => (string) d["first"] == "a" && (string) d["last"] == "b");
            Assert.Contains(fetchedNames, d => (string) d["first"] == "x" && (string) d["last"] == "y");
        }

        [Fact]
        public void InsertRow_RecordRepeatedField()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.ComplexTypesTableId);
            var guid = IdGenerator.FromGuid();
            var row = new BigQueryInsertRow
            {
                ["guid"] = guid,
                ["job"] = new BigQueryInsertRow { ["company"] = "Pet Store", ["roles"] = new[] { "cashier", "manager" } },
            };

            _fixture.InsertAndWait(table, () => table.InsertRow(row), 1);

            string sql = $"SELECT job FROM {table} WHERE guid=@guid";
            var parameters = new[] { new BigQueryParameter("guid", BigQueryDbType.String, guid) };
            var fetchedRow = client.ExecuteQuery(sql, parameters)
                    .Single();
            var job = (Dictionary<string, object>) fetchedRow["job"];
            Assert.Equal("Pet Store", (string) job["company"]);
            Assert.Equal(new[] { "cashier", "manager" }, (string[]) job["roles"]);
        }

        private BigQueryInsertRow BuildRow(string player, long score, DateTime gameStarted) =>
            new BigQueryInsertRow
            {
                { "player", player },
                { "score", score },
                { "gameStarted", gameStarted }
            };

        [Fact]
        public void CreateLoadJob_Parquet()
        {
            string sourceUri = "gs://cloud-samples-data/bigquery/us-states/us-states.parquet";

            var client = BigQueryClient.Create(_fixture.ProjectId);
            var tableId = _fixture.CreateTableId();
            var tableRef = client.GetTableReference(_fixture.DatasetId, tableId);

            var options = new CreateLoadJobOptions { SourceFormat = FileFormat.Parquet };
            var job = client.CreateLoadJob(sourceUri, tableRef, schema: null, options: options);
            job.PollUntilCompleted().ThrowOnAnyError();

            var table = client.GetTable(tableRef);
            var rows = table.ListRows().ToList();
            Assert.Equal(50, rows.Count);
        }
    }
}
