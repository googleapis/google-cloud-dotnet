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
        public void UploadAvro()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var tableId = _fixture.CreateTableId();
            var tableReference = client.GetTableReference(_fixture.DatasetId, tableId);
            var schema = new TableSchemaBuilder
            {
                { "re", BigQueryDbType.Int64 },
                { "im", BigQueryDbType.Int64 }
            }.Build();
            var typeInfo = typeof(UploadTest).GetTypeInfo();
            string resourceName = typeInfo.Namespace + ".one_complex.avro";
            using (var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName))
            {
                var job = client.UploadAvro(tableReference, schema, stream);
                job.PollUntilCompleted();
            }
            var rows = client.GetTable(tableReference).ListRows().ToList();
            Assert.Equal(1, rows.Count);
            Assert.Equal(100, (long) rows[0]["re"]);
            Assert.Equal(200, (long) rows[0]["im"]);
        }

        [Fact]
        public async Task UploadAvroAsync()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var tableId = _fixture.CreateTableId();
            var tableReference = client.GetTableReference(_fixture.DatasetId, tableId);
            var schema = new TableSchemaBuilder
            {
                { "re", BigQueryDbType.Int64 },
                { "im", BigQueryDbType.Int64 }
            }.Build();
            var typeInfo = typeof(UploadTest).GetTypeInfo();
            string resourceName = typeInfo.Namespace + ".one_complex.avro";
            using (var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName))
            {
                var job = await client.UploadAvroAsync(tableReference, schema, stream);
                await job.PollUntilCompletedAsync();
            }
            var table = await client.GetTableAsync(tableReference);
            var rows = await table.ListRowsAsync().ToList();
            Assert.Equal(1, rows.Count);
            Assert.Equal(100, (long) rows[0]["re"]);
            Assert.Equal(200, (long) rows[0]["im"]);
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
            var rows = client.ExecuteQuery(sql).GetRows().ToList();
            Assert.Equal(2, rows.Count);
            Assert.Equal("UploadJsonStreamTest1", (string)rows[0]["player"]);
            Assert.Equal("UploadJsonStreamTest2", (string)rows[1]["player"]);
            Assert.Equal(90L, (long)rows[0]["score"]);
            Assert.Equal(100L, (long)rows[1]["score"]);
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
            var rows = client.ExecuteQuery(sql).GetRows().ToList();
            Assert.Equal(2, rows.Count);
            Assert.Equal("UploadJsonStringsTest1", (string) rows[0]["player"]);
            Assert.Equal("UploadJsonStringsTest2", (string) rows[1]["player"]);
            Assert.Equal(90L, (long) rows[0]["score"]);
            Assert.Equal(100L, (long) rows[1]["score"]);
        }
    }
}
