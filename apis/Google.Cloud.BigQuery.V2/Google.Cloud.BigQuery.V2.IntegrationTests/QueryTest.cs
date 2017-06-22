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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    [Collection(nameof(BigQueryFixture))]
    public class QueryTest
    {
        private const string PublicDatasetsProject = "bigquery-public-data";
        private const string PublicDatasetsDataset = "samples";
        private const string ShakespeareTable = "shakespeare";
        private readonly BigQueryFixture _fixture;

        public QueryTest(BigQueryFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void SynchronousTemporaryQuery()
        {
            // We create the client using our user, but then access a dataset in a public data
            // project. We can't run a query "as" the public data project.
            var projectId = _fixture.ProjectId;
            var client = BigQueryClient.Create(projectId);
            var table = client.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);

            var sql = $"SELECT corpus as title, COUNT(word) as unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";
            var rows = client.ExecuteQuery(sql).GetRows().ToList();
            Assert.Equal(10, rows.Count);
            Assert.Equal("hamlet", (string) rows[0]["title"]);
            Assert.Equal(5318, (long) rows[0]["unique_words"]);
        }

        [Fact]
        public void AsynchronousTemporaryQuery()
        {
            // We create the client using our user, but then access a dataset in a public data
            // project. We can't run a query "as" the public data project.
            var projectId = _fixture.ProjectId;
            var client = BigQueryClient.Create(projectId);
            var table = client.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);

            var sql = $"SELECT corpus as title, COUNT(word) as unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";
            var job = client.CreateQueryJob(sql);
            var rows = job.PollQueryUntilCompleted().GetRows().ToList();
            Assert.Equal(10, rows.Count);
            Assert.Equal("hamlet", (string)rows[0]["title"]);
            Assert.Equal(5318, (long)rows[0]["unique_words"]);
        }

        [Fact]
        public void AsynchronousPermanentQuery()
        {
            // We create the client using our user, but then access a dataset in a public data
            // project. We can't run a query "as" the public data project.
            var projectId = _fixture.ProjectId;
            var client = BigQueryClient.Create(projectId);
            var table = client.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);
            var userDataset = client.GetDataset(_fixture.DatasetId);

            var sql = $"SELECT corpus as title, COUNT(word) as unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";
            var destinationTable = userDataset.GetTableReference(_fixture.CreateTableId());
            var job = client.CreateQueryJob(sql, new CreateQueryJobOptions { DestinationTable = destinationTable });
            var rows = job.PollQueryUntilCompleted().GetRows().ToList();
            Assert.Equal(10, rows.Count);
            Assert.Equal("hamlet", (string)rows[0][0]);
            Assert.Equal(5318, (long)rows[0][1]);

            // Read the table again later - synchronously this time
            table = client.GetTable(destinationTable);
            rows = client.ExecuteQuery($"SELECT * FROM {table} ORDER BY unique_words DESC").GetRows().ToList();
            Assert.Equal(10, rows.Count);
            Assert.Equal("hamlet", (string)rows[0][0]);
            Assert.Equal(5318, (long)rows[0][1]);
        }

        [Fact]
        public void RepeatedFields_Aggregate()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.PeopleTableId);
            var resultRows = client.ExecuteQuery($"SELECT fullName, ARRAY_LENGTH(children) AS childCount FROM {table} ORDER BY fullName")                
                .GetRows()
                .Select(row => new { Name = (string)row["fullName"], Count = (long)row["childCount"] })
                .ToList();
            var expectedResults = new[]
            {
                new { Name = "Anna Karenina", Count = 0L },
                new { Name = "John Doe", Count = 2L },
                new { Name = "Mike Jones", Count = 3L },
            };
            Assert.Equal(expectedResults, resultRows);
        }

        [Fact]
        public void RepeatedFields_Flattening()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.PeopleTableId);
            var resultRows = client.ExecuteQuery($"SELECT fullName, child.name AS childName FROM {table} LEFT JOIN UNNEST(children) AS child ORDER BY fullName, childName")                
                .GetRows()
                .Select(row => new { Name = (string)row["fullName"], Child = (string)row["childName"] })
                .ToList();
            var expectedResults = new[]
            {
                new { Name = "Anna Karenina", Child = (string) null },
                new { Name = "John Doe", Child = "Jane" },
                new { Name = "John Doe", Child = "John" },
                new { Name = "Mike Jones", Child = "Earl" },
                new { Name = "Mike Jones", Child = "Kit" },
                new { Name = "Mike Jones", Child = "Sam" }
            };
            Assert.Equal(expectedResults, resultRows);
        }

        [Fact]
        public void RecordField()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.PeopleTableId);
            var resultRows = client.ExecuteQuery($"SELECT fullName, phoneNumber.areaCode, phoneNumber.number FROM {table} ORDER BY fullName")                
                .GetRows()
                .Select(row => new { Name = (string)row["fullName"], AreaCode = (long)row["areaCode"], Number = (long)row["number"] })
                .ToList();
            var expectedResults = new[]
            {
                new { Name = "Anna Karenina", AreaCode = 425L, Number = 1984783L },
                new { Name = "John Doe", AreaCode = 206L, Number = 1234567L },
                new { Name = "Mike Jones", AreaCode = 622L, Number = 1567845L }
            };
            Assert.Equal(expectedResults, resultRows);
        }

        [Fact]
        public void MultiRequestQueryStreaming()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            var resultRows = client.ExecuteQuery($"SELECT * FROM {table}", new ExecuteQueryOptions { PageSize = 1 })                
                .GetRows()
                .ToList();
            Assert.True(resultRows.Count >= 2);
        }

        [Fact]
        public void EmptyQueryResults_ExecuteQuery()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            var resultRows = client.ExecuteQuery($"SELECT * FROM {table} WHERE score < 0")                
                .GetRows()
                .ToList();
            Assert.Empty(resultRows);
        }

        [Fact]
        public void EmptyQueryResults_CreateQueryJob()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            var resultRows = client.CreateQueryJob($"SELECT * FROM {table} WHERE score < 0")
                .PollQueryUntilCompleted()
                .GetRows()
                .ToList();
            Assert.Empty(resultRows);
        }

        [Fact]
        public void EmptyQueryResults_ReadPage()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            // Deliberately overfetch
            var queryJob = client.CreateQueryJob($"SELECT * FROM {table} WHERE score < 0")
                .PollQueryUntilCompleted(new GetQueryResultsOptions { PageSize = 100 });
            var resultSet = queryJob.ReadPage(10);
            Assert.Empty(resultSet.Rows);
        }

        [Fact]
        public void SimpleTypes()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var row = client.CreateQueryJob($@"SELECT
                'Hello' AS String,
                b'Hello' AS Bytes,
                TRUE AS Boolean,
                1234567890 AS Int64,
                1.234567 AS Float64,
                DATE '2016-11-29' AS Date,
                TIME '12:34:56.123456' AS Time,
                DATETIME '2016-11-29 12:34:56.123456' AS DateTime,
                TIMESTAMP '2016-11-29 12:34:56.123456' AS Timestamp")
                .PollQueryUntilCompleted()
                .GetRows()
                .Single();

            Assert.Equal("Hello", row["String"]);
            Assert.Equal(Encoding.UTF8.GetBytes("Hello"), row["Bytes"]);
            Assert.Equal(true, row["Boolean"]);
            Assert.Equal(1234567890L, row["Int64"]);
            Assert.Equal(1.234567, row["Float64"]);
            Assert.Equal(new DateTime(2016, 11, 29, 0, 0, 0, DateTimeKind.Unspecified), row["Date"]);
            // There are 10 ticks per microsecond.
            Assert.Equal(new TimeSpan(0, 12, 34, 56, 123) + TimeSpan.FromTicks(4560), row["Time"]);
            Assert.Equal(new DateTime(2016, 11, 29, 12, 34, 56, 123, DateTimeKind.Unspecified) + TimeSpan.FromTicks(4560), row["DateTime"]);
            Assert.Equal(new DateTime(2016, 11, 29, 12, 34, 56, 123, DateTimeKind.Utc) + TimeSpan.FromTicks(4560), row["Timestamp"]);

            // Double-check the kinds here...
            Assert.Equal(DateTimeKind.Unspecified, ((DateTime) row["DateTime"]).Kind);
            Assert.Equal(DateTimeKind.Utc, ((DateTime) row["Timestamp"]).Kind);
        }

        [Fact]
        public void ArrayTypes()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var row = client.CreateQueryJob($@"SELECT
                ['Hello'] AS String,
                [b'Hello'] AS Bytes,
                [TRUE] AS Boolean,
                [1234567890] AS Int64,
                [1.234567] AS Float64,
                [DATE '2016-11-29'] AS Date,
                [TIME '12:34:56.123456'] AS Time,
                [DATETIME '2016-11-29 12:34:56.123456'] AS DateTime,
                [TIMESTAMP '2016-11-29 12:34:56.123456'] AS Timestamp")
                .PollQueryUntilCompleted()
                .GetRows()
                .Single();

            Assert.Equal(new[] { "Hello" }, row["String"]);
            Assert.Equal(new[] { Encoding.UTF8.GetBytes("Hello") }, row["Bytes"]);
            Assert.Equal(new[] { true }, row["Boolean"]);
            Assert.Equal(new[] { 1234567890L }, row["Int64"]);
            Assert.Equal(new[] { 1.234567 }, row["Float64"]);
            Assert.Equal(new[] { new DateTime(2016, 11, 29, 0, 0, 0, DateTimeKind.Unspecified) }, row["Date"]);
            // There are 10 ticks per microsecond.
            Assert.Equal(new[] { new TimeSpan(0, 12, 34, 56, 123) + TimeSpan.FromTicks(4560) }, row["Time"]);
            Assert.Equal(new[] { new DateTime(2016, 11, 29, 12, 34, 56, 123, DateTimeKind.Unspecified) + TimeSpan.FromTicks(4560) }, row["DateTime"]);
            Assert.Equal(new[] { new DateTime(2016, 11, 29, 12, 34, 56, 123, DateTimeKind.Utc) + TimeSpan.FromTicks(4560) }, row["Timestamp"]);

            // Double-check the kinds here...
            Assert.Equal(DateTimeKind.Unspecified, ((DateTime[]) row["DateTime"])[0].Kind);
            Assert.Equal(DateTimeKind.Utc, ((DateTime[]) row["Timestamp"])[0].Kind);
        }

        [Fact]
        public void StructTypes()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var row = client.CreateQueryJob($@"
                SELECT ('Hello', b'Hello', TRUE, 1234567890, 1.234567, DATE '2016-11-29',
                        TIME '12:34:56.123456', DATETIME '2016-11-29 12:34:56.123456',
                        TIMESTAMP '2016-11-29 12:34:56.123456') AS value")
                .PollQueryUntilCompleted()
                .GetRows()
                .Single();

            // Structs come back as dictionaries, as if they're records.
            var values = (Dictionary<string, object>) row["value"];
            Assert.Equal("Hello", values["_field_1"]);
            Assert.Equal(Encoding.UTF8.GetBytes("Hello"), values["_field_2"]);
            Assert.Equal(true, values["_field_3"]);
            Assert.Equal(1234567890L, values["_field_4"]);
            Assert.Equal(1.234567, values["_field_5"]);
            Assert.Equal(new DateTime(2016, 11, 29, 0, 0, 0, DateTimeKind.Unspecified), values["_field_6"]);
            // There are 10 ticks per microsecond.
            Assert.Equal(new TimeSpan(0, 12, 34, 56, 123) + TimeSpan.FromTicks(4560), values["_field_7"]);
            Assert.Equal(new DateTime(2016, 11, 29, 12, 34, 56, 123) + TimeSpan.FromTicks(4560), values["_field_8"]);
            Assert.Equal(new DateTime(2016, 11, 29, 12, 34, 56, 123, DateTimeKind.Utc) + TimeSpan.FromTicks(4560), values["_field_9"]);

            // Double-check the kinds here...
            Assert.Equal(DateTimeKind.Unspecified, ((DateTime) values["_field_8"]).Kind);
            Assert.Equal(DateTimeKind.Utc, ((DateTime) values["_field_9"]).Kind);
        }

        [Fact]
        public void NullStructValue()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var row = client.ExecuteQuery("SELECT STRUCT<x string>(NULL) AS s").GetRows().Single();
            var s = (Dictionary <string, object>) row["s"];
            Assert.Null(s["x"]);
        }

        [Fact]
        public void StringValueThatLooksLikeADate()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var row = client.CreateQueryJob("SELECT '2017-05-04T15:01:00Z' AS value")
                .PollQueryUntilCompleted()
                .GetRows()
                .Single();

            // Check that the schema really claims it's a string...
            var field = row.Schema.Fields.Single();
            Assert.Equal("value", field.Name);
            Assert.Equal("STRING", field.Type);

            // And we should be able to get the value as a string too...
            Assert.Equal("2017-05-04T15:01:00Z", (string) row["value"]);
        }

        // TODO: Struct containing array or array containing struct.

        [Fact]
        public void QueryOnView()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            var viewDefinition = new ViewDefinition { Query = $"SELECT player, MAX(score) AS score FROM {table} WHERE player IS NOT NULL GROUP BY player ORDER BY 2 DESC", UseLegacySql = false };
            var view = client.CreateTable(_fixture.DatasetId, "highscore_view", schema: null, options: new CreateTableOptions { View = viewDefinition });

            // This is how a client can check that a BigQueryTable is a view.
            Assert.NotNull(view.Resource.View);

            var queryResults = client.CreateQueryJob($"SELECT * FROM {view} WHERE player = 'Bob'").GetQueryResults().GetRows().ToList();
            Assert.Equal(1, queryResults.Count);
            // The earlier game is not present in the view
            Assert.Equal(85L, (long) queryResults[0]["score"]);
        }
    }
}
