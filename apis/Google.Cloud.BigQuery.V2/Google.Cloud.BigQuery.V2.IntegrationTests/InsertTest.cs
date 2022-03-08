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
using System;
using System.Collections.Generic;
using System.Linq;
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

        private void AssertAllRowsInserted(BigQueryInsertResults insertResult)
        {
            Assert.Equal(BigQueryInsertStatus.AllRowsInserted, insertResult.Status);
            Assert.Empty(insertResult.Errors);
        }

        [Fact]
        public void InsertRow()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.HighScoreTableId);

            var row = BuildRow("Joe", 100, new DateTime(2016, 4, 26, 11, 43, 1, DateTimeKind.Utc));

            var insertResult = _fixture.InsertAndWait(table, () => table.InsertRow(row), 1);

            AssertAllRowsInserted(insertResult);

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

            var insertResult = _fixture.InsertAndWait(table, () => table.InsertRows(rows), 2);

            AssertAllRowsInserted(insertResult);

            var rowsAfter = table.ListRows().ToList();
            Assert.Contains(rowsAfter, r => (string)r["player"] == "Jenny");
            Assert.Contains(rowsAfter, r => (string)r["player"] == "Lisa");
        }

        [Fact]
        public void InsertRows_AllowEmptyInsertIds()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.HighScoreTableId);
            var options = new InsertOptions { AllowEmptyInsertIds = true };

            var rows = new[]
            {
                BuildRow("Helen", 125, new DateTime(2012, 5, 22, 1, 20, 30, DateTimeKind.Utc)),
                BuildRow("Henry", 90, new DateTime(2011, 10, 12, 0, 0, 0, DateTimeKind.Utc))
            };

            var insertResult = _fixture.InsertAndWait(table, () => table.InsertRows(rows, options), 2);

            Assert.Null(rows[0].InsertId);
            Assert.Null(rows[1].InsertId);

            AssertAllRowsInserted(insertResult);

            var rowsAfter = table.ListRows().ToList();
            Assert.Contains(rowsAfter, r => (string)r["player"] == "Helen");
            Assert.Contains(rowsAfter, r => (string)r["player"] == "Henry");
        }

        public static IEnumerable<object[]> BadDataThrowsOptions
        {
            get
            {
                int[] bothRowsIndexes = new int[] { 0, 1 };
                int[] oneRowIndex = new int[] { 1 };

                yield return new object[] { null, bothRowsIndexes };
                yield return new object[] { new InsertOptions(), bothRowsIndexes };
                yield return new object[] { new InsertOptions { SkipInvalidRows = false }, bothRowsIndexes };
                yield return new object[] { new InsertOptions { SkipInvalidRows = true }, bothRowsIndexes };
                yield return new object[] { new InsertOptions { AllowUnknownFields = false }, bothRowsIndexes };
                yield return new object[] { new InsertOptions { AllowUnknownFields = true }, bothRowsIndexes };
                yield return new object[] { new InsertOptions { SkipInvalidRows = false, AllowUnknownFields = false }, bothRowsIndexes };
                yield return new object[] { new InsertOptions { SkipInvalidRows = false, AllowUnknownFields = true }, bothRowsIndexes };
                yield return new object[] { new InsertOptions { SkipInvalidRows = true, AllowUnknownFields = false }, bothRowsIndexes };
                yield return new object[] { new InsertOptions { SkipInvalidRows = true, AllowUnknownFields = true }, oneRowIndex };
            }
        }

        [Theory]
        [MemberData(nameof(BadDataThrowsOptions))]
        public void InsertRow_BadData_Throws(InsertOptions options, int[] errorRowsIndexes)
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            // Don't insert into a table used by other tests...
            var table = dataset.CreateTable(
                _fixture.CreateTableId(),
                new TableSchemaBuilder { { "year", BigQueryDbType.Int64 } }.Build());
            var rows = new BigQueryInsertRow[]
            {
                new BigQueryInsertRow { { "noSuchField", 10 } },
                new BigQueryInsertRow { {"year", "Unknown"} }
            };
            var exception = Assert.Throws<GoogleApiException>(() => table.InsertRows(rows, options));

            Assert.Equal(errorRowsIndexes.Length, exception.Error.Errors.Count);
            foreach (var index in errorRowsIndexes)
            {
                Assert.Contains(exception.Error.Errors, e => e.Message.ToLower().Contains($"in row {index}"));
            }
        }

        [Fact]
        public void InsertRow_Single_Throws()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            // Don't insert into a table used by other tests...
            var table = dataset.CreateTable(
                _fixture.CreateTableId(),
                new TableSchemaBuilder { { "year", BigQueryDbType.Int64 } }.Build());
            var row = new BigQueryInsertRow { { "noSuchField", 10 } };

            var exception = Assert.Throws<GoogleApiException>(() => table.InsertRow(row));

            Assert.Equal(
                "The service bigquery has thrown an exception. " +
                "No HttpStatusCode was specified. " +
                "Error inserting data: 1 error(s). " +
                "Status: NoRowsInserted. " +
                "First error message: Error in row 0. no such field: noSuchField.",
                exception.Message);
            Assert.Equal(1, exception.Error.Errors.Count);
            Assert.Contains(exception.Error.Errors, e => e.Message.ToLower().Contains($"in row 0"));
        }

        public static IEnumerable<object[]> BadDataSilentOptions
        {
            get
            {
                int[] bothRowsIndexes = new int[] { 0, 1 };
                int[] oneRowIndex = new int[] { 1 };

                yield return new object[] { new InsertOptions { SuppressInsertErrors = true }, bothRowsIndexes };
                yield return new object[] { new InsertOptions { SkipInvalidRows = false, SuppressInsertErrors = true }, bothRowsIndexes };
                yield return new object[] { new InsertOptions { SkipInvalidRows = true, SuppressInsertErrors = true }, bothRowsIndexes };
                yield return new object[] { new InsertOptions { AllowUnknownFields = false, SuppressInsertErrors = true }, bothRowsIndexes };
                yield return new object[] { new InsertOptions { AllowUnknownFields = true, SuppressInsertErrors = true }, bothRowsIndexes };
                yield return new object[] { new InsertOptions { SkipInvalidRows = false, AllowUnknownFields = false, SuppressInsertErrors = true }, bothRowsIndexes };
                yield return new object[] { new InsertOptions { SkipInvalidRows = false, AllowUnknownFields = true, SuppressInsertErrors = true }, bothRowsIndexes };
                yield return new object[] { new InsertOptions { SkipInvalidRows = true, AllowUnknownFields = false, SuppressInsertErrors = true }, bothRowsIndexes };
                yield return new object[] { new InsertOptions { SkipInvalidRows = true, AllowUnknownFields = true, SuppressInsertErrors = true }, oneRowIndex };
            }
        }

        [Theory]
        [MemberData(nameof(BadDataSilentOptions))]
        public void InsertRow_BadData_Silent(InsertOptions options, int[] errorRowsIndexes)
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            // Don't insert into a table used by other tests...
            var table = dataset.CreateTable(
                _fixture.CreateTableId(),
                new TableSchemaBuilder { { "year", BigQueryDbType.Int64 } }.Build());
            var rows = new BigQueryInsertRow[]
            {
                new BigQueryInsertRow { { "noSuchField", 10 } },
                new BigQueryInsertRow { {"year", "Unknown"} }
            };
            var insertResult = table.InsertRows(rows, options);

            Assert.Equal(errorRowsIndexes.Length, insertResult.OriginalRowsWithErrors);
            Assert.Equal(errorRowsIndexes,
                insertResult.Errors.
                Select(e => (int?) e.OriginalRowIndex ?? -1).
                OrderBy(index => index).
                ToArray());
        }

        [Fact]
        public void InsertRow_BadTable()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var options = new InsertOptions { AllowUnknownFields = true, SkipInvalidRows = true, SuppressInsertErrors = true };
            var row = new BigQueryInsertRow { { "noSuchField", 10 } };
            // This should still throw because the error is not on inserting a specific row.
            var exception = Assert.Throws<GoogleApiException>(() => client.InsertRow(_fixture.DatasetId, "noSuchTable", row));
        }

        [Fact]
        public void InsertRow_BadData_IgnoreExtraColumn()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            // Don't insert into a table used by other tests...
            var table = dataset.CreateTable(
                _fixture.CreateTableId(),
                new TableSchemaBuilder { { "name", BigQueryDbType.String } }.Build());

            var row = new BigQueryInsertRow { { "noSuchField", 10 } };

            // Even though SuppressInsertErrors is false, this won't throw
            // because server side, unknown fields are ignored silently.
            var options = new InsertOptions { AllowUnknownFields = true };
            var insertResult = _fixture.InsertAndWait(table, () => table.InsertRow(row, options), 1);

            AssertAllRowsInserted(insertResult);
        }

        [Fact]
        public void InsertRow_BadData_IgnoreBadRows_Silent()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            // Don't insert into a table used by other tests...
            var table = dataset.CreateTable(
                _fixture.CreateTableId(),
                new TableSchemaBuilder { { "year", BigQueryDbType.Int64 } }.Build());

            var rows = new BigQueryInsertRow[]
            {
                new BigQueryInsertRow { { "year", 2019 } },
                new BigQueryInsertRow { { "noSuchField", 10 } },
                new BigQueryInsertRow { { "year", "Unknown" } },
            };

            var options = new InsertOptions { SkipInvalidRows = true, SuppressInsertErrors = true};
            // Only one row inserted, we are not ignoring unknown fields so the last two rows are bad.
            var insertResult = _fixture.InsertAndWait(table, () => table.InsertRows(rows, options), 1);

            Assert.Equal(2, insertResult.OriginalRowsWithErrors);
            Assert.Equal(3, insertResult.InsertAttemptRowCount);
            Assert.Equal(BigQueryInsertStatus.SomeRowsInserted, insertResult.Status);
            Assert.Contains(insertResult.Errors, e => e.OriginalRowIndex == 1);
            Assert.Contains(insertResult.Errors, e => e.OriginalRowIndex == 2);
        }

        [Fact]
        public void InsertRow_BadData_IgnoreBadRows_Throws()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            // Don't insert into a table used by other tests...
            var table = dataset.CreateTable(
                _fixture.CreateTableId(),
                new TableSchemaBuilder { { "year", BigQueryDbType.Int64 } }.Build());

            var rows = new BigQueryInsertRow[]
            {
                new BigQueryInsertRow { { "year", 2019 } },
                new BigQueryInsertRow { { "noSuchField", 10 } },
                new BigQueryInsertRow { { "year", "Unknown" } }
            };

            var options = new InsertOptions { SkipInvalidRows = true, SuppressInsertErrors = false };
            var exception = Assert.Throws<GoogleApiException>(() => table.InsertRows(rows, options));
            Assert.Equal(2, exception.Error.Errors.Count);
            Assert.Contains(exception.Error.Errors, e => e.Message.ToLower().Contains("in row 1"));
            Assert.Contains(exception.Error.Errors, e => e.Message.ToLower().Contains("in row 2"));
        }

        [Fact]
        public void InsertRow_BadData_IgnoreUnknownAndBadRows_Silent()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            // Don't insert into a table used by other tests...
            var table = dataset.CreateTable(
                _fixture.CreateTableId(),
                new TableSchemaBuilder { { "year", BigQueryDbType.Int64 } }.Build());

            var rows = new BigQueryInsertRow[]
            {
                new BigQueryInsertRow { { "year", 2019 } },
                new BigQueryInsertRow { { "noSuchField", 10 } },
                new BigQueryInsertRow { { "year", "Unknown" } },
            };

            var options = new InsertOptions { AllowUnknownFields = true, SkipInvalidRows = true, SuppressInsertErrors = true };
            // Now two rows are inserted, we are ignoring unknown fields so only the last row is bad.
            var insertResult = _fixture.InsertAndWait(table, () => table.InsertRows(rows, options), 2);

            Assert.Equal(1, insertResult.OriginalRowsWithErrors);
            Assert.Equal(3, insertResult.InsertAttemptRowCount);
            Assert.Equal(BigQueryInsertStatus.SomeRowsInserted, insertResult.Status);
            Assert.Contains(insertResult.Errors, e => e.OriginalRowIndex == 2);
        }

        [Fact]
        public void InsertRow_BadData_IgnoreUnknownAndBadRows_Throws()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            // Don't insert into a table used by other tests...
            var table = dataset.CreateTable(
                _fixture.CreateTableId(),
                new TableSchemaBuilder { { "year", BigQueryDbType.Int64 } }.Build());

            var rows = new BigQueryInsertRow[]
            {
                new BigQueryInsertRow { { "year", 2019 } },
                new BigQueryInsertRow { { "noSuchField", 10 } },
                new BigQueryInsertRow { { "year", "Unknown" } }
            };

            var options = new InsertOptions { AllowUnknownFields = true, SkipInvalidRows = true, SuppressInsertErrors = false };
            var exception = Assert.Throws<GoogleApiException>(() => table.InsertRows(rows, options));
            Assert.Equal(1, exception.Error.Errors.Count);
            Assert.Contains("in row 2", exception.Error.Errors[0].Message, StringComparison.InvariantCultureIgnoreCase);
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

        [SkippableFact]
        public void CreateLoadJob_Parquet()
        {
            TestEnvironment.SkipIfVpcSc();
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
