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

using Google.Apis.Bigquery.v2.Data;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    [Collection(nameof(BigQueryFixture))]
    public class UploadTest
    {
        private readonly BigQueryFixture _fixture;

        public UploadTest(BigQueryFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void UploadCsv()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);

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
        public void UploadCsv_Autodetect()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);

            string tableId = _fixture.CreateTableId();

            string[] csvRows =
            {
                "Name,GameStarted,Score",
                "Ben,2014-08-19T12:41:35.220Z,85",
                "Lucy,2014-08-20T12:41:35.220Z,130",
                "Rohit,2014-08-21T12:41:35.220Z,90"
            };

            var bytes = Encoding.UTF8.GetBytes(string.Join("\n", csvRows));

            TableSchema schema = null;
            var job = client.UploadCsv(_fixture.DatasetId, tableId, schema, new MemoryStream(bytes), new UploadCsvOptions { Autodetect = true });
            var result = job.PollUntilCompleted();
            Assert.Null(result.Status.ErrorResult);

            var table = client.GetTable(_fixture.DatasetId, tableId);
            Assert.Equal(3, table.ListRows().Count());
            var fields = table.Schema.Fields.Select(f => new { f.Name, f.Type, f.Mode }).OrderBy(f => f.Name).ToList();
            Assert.Equal(new { Name = "GameStarted", Type = "TIMESTAMP", Mode = "NULLABLE" }, fields[0]);
            Assert.Equal(new { Name = "Name", Type = "STRING", Mode = "NULLABLE" }, fields[1]);
            Assert.Equal(new { Name = "Score", Type = "INTEGER", Mode = "NULLABLE" }, fields[2]);
        }

        [Fact]
        public void UploadCsv_UpdatesSchema()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);

            var tableReference = client.GetTableReference(_fixture.DatasetId, _fixture.CreateTableId());

            string[] csvRows =
            {
                "Name,GameStarted",
                "Ben,2014-08-19T12:41:35.220Z",
                "Lucy,2014-08-20T12:41:35.220Z",
                "Rohit,2014-08-21T12:41:35.220Z"
            };

            var bytes = Encoding.UTF8.GetBytes(string.Join("\n", csvRows));

            TableSchema schema = null;
            var job = client.UploadCsv(tableReference, schema, new MemoryStream(bytes), new UploadCsvOptions { Autodetect = true });
            var result = job.PollUntilCompleted();
            Assert.Null(result.Status.ErrorResult);

            var table = client.GetTable(tableReference);
            Assert.Equal(2, table.Schema.Fields.Count());

            // Upload a new CSV adding a field.
            csvRows = new string[]
            {
                "Name,GameStarted,Score",
                "Ben,2014-08-19T12:41:35.220Z,85",
                "Lucy,2014-08-20T12:41:35.220Z,130",
                "Rohit,2014-08-21T12:41:35.220Z,90"
            };

            bytes = Encoding.UTF8.GetBytes(string.Join("\n", csvRows));

            job = client.UploadCsv(tableReference, schema, new MemoryStream(bytes),
                new UploadCsvOptions
                {
                    Autodetect = true,
                    WriteDisposition = WriteDisposition.WriteAppend,
                    DestinationSchemaUpdateOptions = SchemaUpdateOption.AllowFieldAddition
                });
            result = job.PollUntilCompleted();
            Assert.Null(result.Status.ErrorResult);

            table = client.GetTable(tableReference);
            var rows = table.ListRows().ToList();
            Assert.Equal(6, rows.Count);
            var fields = table.Schema.Fields.Select(f => new { f.Name, f.Type, f.Mode }).OrderBy(f => f.Name).ToList();
            Assert.Equal(3, fields.Count);
            Assert.Equal(new { Name = "GameStarted", Type = "TIMESTAMP", Mode = "NULLABLE" }, fields[0]);
            Assert.Equal(new { Name = "Name", Type = "STRING", Mode = "NULLABLE" }, fields[1]);
            Assert.Equal(new { Name = "Score", Type = "INTEGER", Mode = "NULLABLE" }, fields[2]);
        }

        [Fact]
        public void UploadCsv_PartitionedByField()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string tableId = _fixture.CreateTableId();
            var tableReference = client.GetTableReference(_fixture.DatasetId, _fixture.CreateTableId());

            string[] csvRows =
            {
                "Name,GameStarted,Score",
                "Ben,2014-08-19T12:41:35.220Z,85",
                "Lucy,2014-08-20T12:41:35.220Z,130",
                "Rohit,2014-08-21T12:41:35.220Z,90"
            };

            var bytes = Encoding.UTF8.GetBytes(string.Join("\n", csvRows));

            TableSchema schema = new TableSchemaBuilder
            {
                { "Name", BigQueryDbType.String },
                { "GameStarted", BigQueryDbType.Timestamp },
                { "Score", BigQueryDbType.Int64 },
            }.Build();
            var options = new UploadCsvOptions
            {
                SkipLeadingRows = 1,
                TimePartitioning = TimePartition.CreateDailyPartitioning(expiration: null, "GameStarted")
            };
            var job = client.UploadCsv(_fixture.DatasetId, tableId, schema, new MemoryStream(bytes), options);
            var result = job.PollUntilCompleted();
            Assert.Null(result.Status.ErrorResult);

            var table = client.GetTable(_fixture.DatasetId, tableId);
            Assert.Equal("GameStarted", table.Resource.TimePartitioning.Field);            
        }

        [Fact]
        public void UploadCsv_JobLabels()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);

            var tableReference = client.GetTableReference(_fixture.DatasetId, _fixture.CreateTableId());

            string[] csvRows =
            {
                "Name,GameStarted",
                "Ben,2014-08-19T12:41:35.220Z",
                "Lucy,2014-08-20T12:41:35.220Z",
                "Rohit,2014-08-21T12:41:35.220Z"
            };

            var bytes = Encoding.UTF8.GetBytes(string.Join("\n", csvRows));
            TableSchema schema = null;

            var job = client.UploadCsv(tableReference, schema, new MemoryStream(bytes),
                new UploadCsvOptions { Autodetect = true, Labels = JobsTest.JobLabels });
            JobsTest.VerifyJobLabels(job?.Resource?.Configuration?.Labels);

            job = job.PollUntilCompleted().ThrowOnAnyError();
            JobsTest.VerifyJobLabels(job?.Resource?.Configuration?.Labels);
        }

        [Fact]
        public void UploadAvro()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var tableId = _fixture.CreateTableId();
            var tableReference = client.GetTableReference(_fixture.DatasetId, tableId);
            var typeInfo = typeof(UploadTest).GetTypeInfo();
            string resourceName = typeInfo.Namespace + ".one_complex.avro";
            using (var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName))
            {
                var job = client.UploadAvro(tableReference, null, stream);
                job = job.PollUntilCompleted();
                job.ThrowOnAnyError();
            }
            var rows = client.GetTable(tableReference).ListRows().ToList();
            Assert.Equal(1, rows.Count);
            Assert.Equal(100, (long)rows[0]["re"]);
            Assert.Equal(200, (long)rows[0]["im"]);
        }

        [Fact]
        public void UploadAvro_IgnoresSchema()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var tableId = _fixture.CreateTableId();
            var tableReference = client.GetTableReference(_fixture.DatasetId, tableId);
            var typeInfo = typeof(UploadTest).GetTypeInfo();
            string resourceName = typeInfo.Namespace + ".one_complex.avro";
            // This schema is incorrect for the data, but is completely ignored.
            var schema = new TableSchemaBuilder
            {
                { "bogus", BigQueryDbType.String },
                { "wrong", BigQueryDbType.Bytes }
            }.Build();
            using (var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName))
            {
                var job = client.UploadAvro(tableReference, schema, stream);
                job = job.PollUntilCompleted();
                job.ThrowOnAnyError();
            }
            var rows = client.GetTable(tableReference).ListRows().ToList();
            Assert.Equal(1, rows.Count);
            Assert.Equal(100, (long)rows[0]["re"]);
            Assert.Equal(200, (long)rows[0]["im"]);
        }

        [Fact]
        public async Task UploadAvroAsync()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var tableId = _fixture.CreateTableId();
            var tableReference = client.GetTableReference(_fixture.DatasetId, tableId);
            var typeInfo = typeof(UploadTest).GetTypeInfo();
            string resourceName = typeInfo.Namespace + ".one_complex.avro";
            using (var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName))
            {
                var job = await client.UploadAvroAsync(tableReference, null, stream);
                job = await job.PollUntilCompletedAsync();
                job.ThrowOnAnyError();
            }
            var table = await client.GetTableAsync(tableReference);
            var rows = await table.ListRowsAsync().ToListAsync();
            Assert.Equal(1, rows.Count);
            Assert.Equal(100, (long)rows[0]["re"]);
            Assert.Equal(200, (long)rows[0]["im"]);
        }

        [Fact]
        public async Task UploadAvroAsync_IgnoresSchema()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var tableId = _fixture.CreateTableId();
            var tableReference = client.GetTableReference(_fixture.DatasetId, tableId);
            var typeInfo = typeof(UploadTest).GetTypeInfo();
            string resourceName = typeInfo.Namespace + ".one_complex.avro";
            // This schema is incorrect for the data, but is completely ignored.
            var schema = new TableSchemaBuilder
            {
                { "bogus", BigQueryDbType.String },
                { "wrong", BigQueryDbType.Bytes }
            }.Build();

            using (var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName))
            {
                var job = await client.UploadAvroAsync(tableReference, schema, stream);
                job = await job.PollUntilCompletedAsync();
                job.ThrowOnAnyError();
            }
            var table = await client.GetTableAsync(tableReference);
            var rows = await table.ListRowsAsync().ToListAsync();
            Assert.Equal(1, rows.Count);
            Assert.Equal(100, (long)rows[0]["re"]);
            Assert.Equal(200, (long)rows[0]["im"]);
        }

        [Fact]
        public void UploadAvro_UpdatesSchema()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);

            var tableReference = client.GetTableReference(_fixture.DatasetId, _fixture.CreateTableId());

            var typeInfo = typeof(UploadTest).GetTypeInfo();
            string resourceName = typeInfo.Namespace + ".before_schema_update.avro";
            using (var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName))
            {
                var job = client.UploadAvro(tableReference, null, stream);
                job = job.PollUntilCompleted();
                job.ThrowOnAnyError();
            }

            var table = client.GetTable(tableReference);
            Assert.Equal(2, table.Schema.Fields.Count());

            // Upload an avro file adding a field.
            resourceName = typeInfo.Namespace + ".after_schema_update.avro";
            using (var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName))
            {
                var job = client.UploadAvro(tableReference, null, stream,
                    new UploadAvroOptions
                    {
                        WriteDisposition = WriteDisposition.WriteAppend,
                        DestinationSchemaUpdateOptions = SchemaUpdateOption.AllowFieldAddition,
                    });
                job = job.PollUntilCompleted();
                job.ThrowOnAnyError();
            }

            table = client.GetTable(tableReference);
            var rows = table.ListRows().ToList();
            Assert.Equal(4, rows.Count);
            var fields = table.Schema.Fields.Select(f => new { f.Name, f.Type, f.Mode }).OrderBy(f => f.Name).ToList();
            Assert.Equal(3, fields.Count);
            Assert.Equal(new { Name = "name", Type = "STRING", Mode = "NULLABLE" }, fields[0]);
            Assert.Equal(new { Name = "score1", Type = "INTEGER", Mode = "NULLABLE" }, fields[1]);
            Assert.Equal(new { Name = "score2", Type = "INTEGER", Mode = "NULLABLE" }, fields[2]);
        }

        [Fact]
        public void UploadJson_Stream()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);

            // We use ' instead of " in the JSON to make it easier to write the string literals, then fix it up.
            var jsonRows = new[]
            {
                "{ 'player': 'UploadJsonStreamTest1', 'score': 90, 'GameStarted': '2015-01-01T00:00:00.000Z' }",
                "{ 'player': 'UploadJsonStreamTest2', 'score': 100, 'GameStarted': '2014-01-01T01:00:00.000Z' }"
            }.Select(x => x.Replace('\'', '"'));

            var bytes = Encoding.UTF8.GetBytes(string.Join("\n", jsonRows));

            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            var beforeRowCount = table.ListRows().Count();

            var job = table.UploadJson(new MemoryStream(bytes));
            var result = job.PollUntilCompleted();
            Assert.Null(result.Status.ErrorResult);

            var afterRows = table.ListRows().ToList();
            Assert.Equal(beforeRowCount + 2, afterRows.Count);

            var sql = $"SELECT player, score FROM {table} WHERE STARTS_WITH(player, 'UploadJsonStreamTest') ORDER BY player";
            var rows = client.ExecuteQuery(sql, parameters: null).ToList();
            Assert.Equal(2, rows.Count);
            Assert.Equal("UploadJsonStreamTest1", (string)rows[0]["player"]);
            Assert.Equal("UploadJsonStreamTest2", (string)rows[1]["player"]);
            Assert.Equal(90L, (long)rows[0]["score"]);
            Assert.Equal(100L, (long)rows[1]["score"]);
        }

        [Fact]
        public void UploadJson_Autodetect()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string tableId = _fixture.CreateTableId();
            // We use ' instead of " in the JSON to make it easier to write the string literals, then fix it up.
            var jsonRows = new[]
            {
                "{ 'player': 'UploadJsonStringsTest1', \r\n 'score': 90, 'GameStarted': '2015-01-01T00:00:00.000Z' }",
                "{ 'player': 'UploadJsonStringsTest2', \n 'score': 100, 'GameStarted': '2014-01-01T01:00:00.000Z' }"
            }.Select(x => x.Replace('\'', '"'));

            TableSchema schema = null;
            var job = client.UploadJson(_fixture.DatasetId, tableId, schema, jsonRows, new UploadJsonOptions { Autodetect = true });
            var result = job.PollUntilCompleted();
            Assert.Null(result.Status.ErrorResult);

            var table = client.GetTable(_fixture.DatasetId, tableId);
            Assert.Equal(2, table.ListRows().Count());
            var fields = table.Schema.Fields.Select(f => new { f.Name, f.Type, f.Mode }).OrderBy(f => f.Name).ToList();
            Assert.Equal(new { Name = "GameStarted", Type = "TIMESTAMP", Mode = "NULLABLE" }, fields[0]);
            Assert.Equal(new { Name = "player", Type = "STRING", Mode = "NULLABLE" }, fields[1]);
            Assert.Equal(new { Name = "score", Type = "INTEGER", Mode = "NULLABLE" }, fields[2]);
        }

        [Fact]
        public void UploadJson_Strings()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);

            // We use ' instead of " in the JSON to make it easier to write the string literals, then fix it up.
            var jsonRows = new[]
            {
                "{ 'player': 'UploadJsonStringsTest1', \r\n 'score': 90, 'GameStarted': '2015-01-01T00:00:00.000Z' }",
                "{ 'player': 'UploadJsonStringsTest2', \n 'score': 100, 'GameStarted': '2014-01-01T01:00:00.000Z' }"
            }.Select(x => x.Replace('\'', '"'));


            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            var beforeRowCount = table.ListRows().Count();

            var job = table.UploadJson(jsonRows);
            var result = job.PollUntilCompleted();
            Assert.Null(result.Status.ErrorResult);

            var afterRows = table.ListRows().ToList();
            Assert.Equal(beforeRowCount + 2, afterRows.Count);

            var sql = $"SELECT player, score FROM {table} WHERE STARTS_WITH(player, 'UploadJsonStringsTest') ORDER BY player";
            var rows = client.ExecuteQuery(sql, parameters: null).ToList();
            Assert.Equal(2, rows.Count);
            Assert.Equal("UploadJsonStringsTest1", (string)rows[0]["player"]);
            Assert.Equal("UploadJsonStringsTest2", (string)rows[1]["player"]);
            Assert.Equal(90L, (long)rows[0]["score"]);
            Assert.Equal(100L, (long)rows[1]["score"]);
        }

        [Fact]
        public void UploadJson_UpdatesSchema()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var tableReference = client.GetTableReference(_fixture.DatasetId, _fixture.CreateTableId());

            // We use ' instead of " in the JSON to make it easier to write the string literals, then fix it up.
            var jsonRows = new[]
            {
                "{ 'player': 'UploadJsonStreamTest1', 'GameStarted': '2015-01-01T00:00:00.000Z' }",
                "{ 'player': 'UploadJsonStreamTest2', 'GameStarted': '2014-01-01T01:00:00.000Z' }"
            }.Select(x => x.Replace('\'', '"'));

            var bytes = Encoding.UTF8.GetBytes(string.Join("\n", jsonRows));

            var job = client.UploadJson(tableReference, null, new MemoryStream(bytes), new UploadJsonOptions { Autodetect = true });
            var result = job.PollUntilCompleted();
            Assert.Null(result.Status.ErrorResult);

            var table = client.GetTable(tableReference);
            Assert.Equal(2, table.Schema.Fields.Count);

            // We use ' instead of " in the JSON to make it easier to write the string literals, then fix it up.
            jsonRows = new[]
            {
                "{ 'player': 'UploadJsonStreamTest1', 'score': 90, 'GameStarted': '2015-01-01T00:00:00.000Z' }",
                "{ 'player': 'UploadJsonStreamTest2', 'score': 100, 'GameStarted': '2014-01-01T01:00:00.000Z' }"
            }.Select(x => x.Replace('\'', '"'));

            bytes = Encoding.UTF8.GetBytes(string.Join("\n", jsonRows));

            job = client.UploadJson(tableReference, null, new MemoryStream(bytes),
                new UploadJsonOptions
                {
                    Autodetect = true,
                    WriteDisposition = WriteDisposition.WriteAppend,
                    DestinationSchemaUpdateOptions = SchemaUpdateOption.AllowFieldAddition
                });
            result = job.PollUntilCompleted();
            Assert.Null(result.Status.ErrorResult);

            table = client.GetTable(tableReference);
            var rows = table.ListRows().ToList();
            Assert.Equal(4, rows.Count);
            var fields = table.Schema.Fields.Select(f => new { f.Name, f.Type, f.Mode }).OrderBy(f => f.Name).ToList();
            Assert.Equal(3, fields.Count);
            Assert.Equal(new { Name = "GameStarted", Type = "TIMESTAMP", Mode = "NULLABLE" }, fields[0]);
            Assert.Equal(new { Name = "player", Type = "STRING", Mode = "NULLABLE" }, fields[1]);
            Assert.Equal(new { Name = "score", Type = "INTEGER", Mode = "NULLABLE" }, fields[2]);
        }

        [Fact]
        public void UploadParquet()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var tableReference = client.GetTableReference(_fixture.DatasetId, _fixture.CreateTableId());
            var typeInfo = typeof(UploadTest).GetTypeInfo();
            string resourceName = typeInfo.Namespace + ".us-states.parquet";
            using (var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName))
            {
                var job = client.UploadParquet(tableReference, stream);
                job = job.PollUntilCompleted();
                job.ThrowOnAnyError();
            }
            var table = client.GetTable(tableReference);
            var rows = table.ListRows().ToList();
            Assert.Equal(50, rows.Count);
            var fields = table.Schema.Fields.Select(f => new { f.Name, f.Type, f.Mode }).OrderBy(f => f.Name).ToList();
            Assert.Equal(new { Name = "name", Type = "STRING", Mode = "NULLABLE" }, fields[0]);
            Assert.Equal(new { Name = "post_abbr", Type = "STRING", Mode = "NULLABLE" }, fields[1]);
        }

        [Fact]
        public async Task UploadParquetAsync()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var tableReference = client.GetTableReference(_fixture.DatasetId, _fixture.CreateTableId());
            var typeInfo = typeof(UploadTest).GetTypeInfo();
            string resourceName = typeInfo.Namespace + ".us-states.parquet";
            using (var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName))
            {
                var job = await client.UploadParquetAsync(tableReference, stream);
                job = job.PollUntilCompleted();
                job.ThrowOnAnyError();
            }
            var table = client.GetTable(tableReference);
            var rows = table.ListRows().ToList();
            Assert.Equal(50, rows.Count);
            var fields = table.Schema.Fields.Select(f => new { f.Name, f.Type, f.Mode }).OrderBy(f => f.Name).ToList();
            Assert.Equal(new { Name = "name", Type = "STRING", Mode = "NULLABLE" }, fields[0]);
            Assert.Equal(new { Name = "post_abbr", Type = "STRING", Mode = "NULLABLE" }, fields[1]);
        }

        [Fact]
        public void UploadParquet_UpdatesSchema()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var tableReference = client.GetTableReference(_fixture.DatasetId, _fixture.CreateTableId());

            string[] csvRows =
            {
                "oneState",
                "anotherState"
            };

            var schema = new TableSchemaBuilder
            {
                {"name", BigQueryDbType.String, BigQueryFieldMode.Nullable }
            }.Build();

            var bytes = Encoding.UTF8.GetBytes(string.Join("\n", csvRows));

            var job = client.UploadCsv(tableReference, schema, new MemoryStream(bytes));
            var result = job.PollUntilCompleted();
            Assert.Null(result.Status.ErrorResult);

            var table = client.GetTable(tableReference);
            Assert.Equal(1, table.Schema.Fields.Count());

            var typeInfo = typeof(UploadTest).GetTypeInfo();
            string resourceName = typeInfo.Namespace + ".us-states.parquet";
            using (var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName))
            {
                job = client.UploadParquet(tableReference, stream,
                    new UploadParquetOptions
                    {
                        WriteDisposition = WriteDisposition.WriteAppend,
                        DestinationSchemaUpdateOptions = SchemaUpdateOption.AllowFieldAddition
                    });
                job = job.PollUntilCompleted();
                job.ThrowOnAnyError();
            }
            table = client.GetTable(tableReference);
            var rows = table.ListRows().ToList();
            Assert.Equal(52, rows.Count);
            var fields = table.Schema.Fields.Select(f => new { f.Name, f.Type, f.Mode }).OrderBy(f => f.Name).ToList();
            Assert.Equal(2, fields.Count);
            Assert.Equal(new { Name = "name", Type = "STRING", Mode = "NULLABLE" }, fields[0]);
            Assert.Equal(new { Name = "post_abbr", Type = "STRING", Mode = "NULLABLE" }, fields[1]);
        }

        [Fact]
        public void UploadOrc()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var tableReference = client.GetTableReference(_fixture.DatasetId, _fixture.CreateTableId());
            var typeInfo = typeof(UploadTest).GetTypeInfo();
            string resourceName = typeInfo.Namespace + ".us-states.orc";
            using (var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName))
            {
                var job = client.UploadOrc(tableReference, stream);
                job = job.PollUntilCompleted();
                job.ThrowOnAnyError();
            }
            var table = client.GetTable(tableReference);
            var rows = table.ListRows().ToList();
            Assert.Equal(50, rows.Count);
            var fields = table.Schema.Fields.Select(f => new { f.Name, f.Type, f.Mode }).OrderBy(f => f.Name).ToList();
            Assert.Equal(new { Name = "name", Type = "STRING", Mode = "NULLABLE" }, fields[0]);
            Assert.Equal(new { Name = "post_abbr", Type = "STRING", Mode = "NULLABLE" }, fields[1]);
        }

        [Fact]
        public async Task UploadOrcAsync()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var tableReference = client.GetTableReference(_fixture.DatasetId, _fixture.CreateTableId());
            var typeInfo = typeof(UploadTest).GetTypeInfo();
            string resourceName = typeInfo.Namespace + ".us-states.orc";
            using (var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName))
            {
                var job = await client.UploadOrcAsync(tableReference, stream);
                job = job.PollUntilCompleted();
                job.ThrowOnAnyError();
            }
            var table = client.GetTable(tableReference);
            var rows = table.ListRows().ToList();
            Assert.Equal(50, rows.Count);
            var fields = table.Schema.Fields.Select(f => new { f.Name, f.Type, f.Mode }).OrderBy(f => f.Name).ToList();
            Assert.Equal(new { Name = "name", Type = "STRING", Mode = "NULLABLE" }, fields[0]);
            Assert.Equal(new { Name = "post_abbr", Type = "STRING", Mode = "NULLABLE" }, fields[1]);
        }

        [Fact]
        public void UploadOrc_UpdatesSchema()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var tableReference = client.GetTableReference(_fixture.DatasetId, _fixture.CreateTableId());

            string[] csvRows =
            {
                "oneState",
                "anotherState"
            };

            var schema = new TableSchemaBuilder
            {
                {"name", BigQueryDbType.String, BigQueryFieldMode.Nullable }
            }.Build();

            var bytes = Encoding.UTF8.GetBytes(string.Join("\n", csvRows));

            var job = client.UploadCsv(tableReference, schema, new MemoryStream(bytes));
            var result = job.PollUntilCompleted();
            Assert.Null(result.Status.ErrorResult);

            var table = client.GetTable(tableReference);
            Assert.Equal(1, table.Schema.Fields.Count());

            var typeInfo = typeof(UploadTest).GetTypeInfo();
            string resourceName = typeInfo.Namespace + ".us-states.orc";
            using (var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName))
            {
                job = client.UploadOrc(tableReference, stream,
                    new UploadOrcOptions
                    {
                        WriteDisposition = WriteDisposition.WriteAppend,
                        DestinationSchemaUpdateOptions = SchemaUpdateOption.AllowFieldAddition
                    });
                job = job.PollUntilCompleted();
                job.ThrowOnAnyError();
            }
            table = client.GetTable(tableReference);
            var rows = table.ListRows().ToList();
            Assert.Equal(52, rows.Count);
            var fields = table.Schema.Fields.Select(f => new { f.Name, f.Type, f.Mode }).OrderBy(f => f.Name).ToList();
            Assert.Equal(2, fields.Count);
            Assert.Equal(new { Name = "name", Type = "STRING", Mode = "NULLABLE" }, fields[0]);
            Assert.Equal(new { Name = "post_abbr", Type = "STRING", Mode = "NULLABLE" }, fields[1]);
        }
    }
}
