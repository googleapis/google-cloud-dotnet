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
using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var rows = client.ExecuteQuery(sql, parameters: null).ToList();
            Assert.Equal(10, rows.Count);
            Assert.Equal("hamlet", (string)rows[0]["title"]);
            Assert.Equal(5318, (long)rows[0]["unique_words"]);
        }

        [Fact]
        public void SynchronousTemporaryQuery_JobLabels()
        {
            var projectId = _fixture.ProjectId;
            var client = BigQueryClient.Create(projectId);
            var table = client.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);

            var sql = $"SELECT corpus as title, COUNT(word) as unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";
            var options = new QueryOptions { Labels = JobsTest.JobLabels };

            var queryJob = client.CreateQueryJob(sql, null, options);
            JobsTest.VerifyJobLabels(queryJob?.Resource?.Configuration?.Labels);

            queryJob.PollUntilCompleted().ThrowOnAnyError();
            JobsTest.VerifyJobLabels(queryJob?.Resource?.Configuration?.Labels);
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
            var job = client.CreateQueryJob(sql, parameters: null);
            var rows = job.GetQueryResults().ToList();
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
            var job = client.CreateQueryJob(sql, null, new QueryOptions { DestinationTable = destinationTable });
            var rows = job.GetQueryResults().ToList();
            Assert.Equal(10, rows.Count);
            Assert.Equal("hamlet", (string)rows[0][0]);
            Assert.Equal(5318, (long)rows[0][1]);

            // Read the table again later - synchronously this time
            table = client.GetTable(destinationTable);
            rows = client.ExecuteQuery($"SELECT * FROM {table} ORDER BY unique_words DESC", parameters: null).ToList();
            Assert.Equal(10, rows.Count);
            Assert.Equal("hamlet", (string)rows[0][0]);
            Assert.Equal(5318, (long)rows[0][1]);
        }

        [Fact]
        public void AsynchronousPermanentQuery_UpdatesSchema()
        {
            // We create the client using our user, but then access a dataset in a public data
            // project. We can't run a query "as" the public data project.
            var projectId = _fixture.ProjectId;
            var client = BigQueryClient.Create(projectId);
            var table = client.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);
            var userDataset = client.GetDataset(_fixture.DatasetId);
            var destinationTableReference = userDataset.GetTableReference(_fixture.CreateTableId());
            var sql = $"SELECT corpus as title FROM {table} ORDER BY title DESC LIMIT 10";

            var job = client.CreateQueryJob(sql, null, new QueryOptions { DestinationTable = destinationTableReference });
            var result = job.PollUntilCompleted();
            Assert.Null(result.Status.ErrorResult);

            var destinationTable = client.GetTable(destinationTableReference);
            var rows = destinationTable.ListRows().ToList();
            Assert.Equal(1, destinationTable.Schema.Fields.Count);
            Assert.Equal(10, rows.Count);

            // Execute a new query adding a field
            sql = $"SELECT corpus as title, COUNT(word) as unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";

            job = client.CreateQueryJob(sql, null,
                new QueryOptions
                {
                    DestinationTable = destinationTableReference,
                    WriteDisposition = WriteDisposition.WriteAppend,
                    DestinationSchemaUpdateOptions = SchemaUpdateOption.AllowFieldAddition
                });
            result = job.PollUntilCompleted();
            Assert.Null(result.Status.ErrorResult);

            destinationTable = client.GetTable(destinationTableReference);
            rows = destinationTable.ListRows().ToList();
            var fields = destinationTable.Schema.Fields.Select(f => new { f.Name, f.Type, f.Mode }).OrderBy(f => f.Name).ToList();
            Assert.Equal(20, rows.Count);
            Assert.Equal(2, fields.Count);
            Assert.Equal(new { Name = "title", Type = "STRING", Mode = "NULLABLE" }, fields[0]);
            Assert.Equal(new { Name = "unique_words", Type = "INTEGER", Mode = "NULLABLE" }, fields[1]);
        }

        [Fact]
        public void QueryWithTimePartitioning()
        {
            var projectId = _fixture.ProjectId;
            var client = BigQueryClient.Create(projectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            var queryOptions = new QueryOptions
            {
                DestinationTable = client.GetTableReference(_fixture.DatasetId, _fixture.CreateTableId()),
                TimePartitioning = TimePartition.CreateDailyPartitioning(null, "GameStarted")
            };
            var results = client.ExecuteQuery($"SELECT * FROM {table}", null, queryOptions);
            var outputTable = client.GetTable(results.TableReference);
            Assert.Equal("GameStarted", outputTable.Resource.TimePartitioning.Field);
        }

        [Fact]
        public void RepeatedFields_Aggregate()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.PeopleTableId);
            var resultRows = client.ExecuteQuery($"SELECT fullName, ARRAY_LENGTH(children) AS childCount FROM {table} ORDER BY fullName", parameters: null)
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
            var resultRows = client.ExecuteQuery($"SELECT fullName, child.name AS childName FROM {table} LEFT JOIN UNNEST(children) AS child ORDER BY fullName, childName", parameters: null)
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
            var resultRows = client.ExecuteQuery($"SELECT fullName, phoneNumber.areaCode, phoneNumber.number FROM {table} ORDER BY fullName", parameters: null)
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
            var resultRows = client.ExecuteQuery($"SELECT * FROM {table}", parameters: null, resultsOptions: new GetQueryResultsOptions { PageSize = 1 })
                .ToList();
            Assert.True(resultRows.Count >= 2);
        }

        [Fact]
        public void EmptyQueryResults_ExecuteQuery()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            var resultRows = client.ExecuteQuery($"SELECT * FROM {table} WHERE score < 0", parameters: null)
                .ToList();
            Assert.Empty(resultRows);
        }

        [Fact]
        public void EmptyQueryResults_CreateQueryJob()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            var resultRows = client.CreateQueryJob($"SELECT * FROM {table} WHERE score < 0", parameters: null)
                .GetQueryResults()
                .ToList();
            Assert.Empty(resultRows);
        }

        [Fact]
        public void EmptyQueryResults_ReadPage()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            // Deliberately overfetch
            var queryJob = client.CreateQueryJob($"SELECT * FROM {table} WHERE score < 0", parameters: null)
                .GetQueryResults(new GetQueryResultsOptions { PageSize = 100 });
            var resultSet = queryJob.ReadPage(10);
            Assert.Empty(resultSet.Rows);
        }

        [Fact]
        public void SimpleTypes()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var row = client.ExecuteQuery($@"SELECT
                'Hello' AS String,
                b'Hello' AS Bytes,
                TRUE AS Boolean,
                1234567890 AS Int64,
                1.234567 AS Float64,
                DATE '2016-11-29' AS Date,
                TIME '12:34:56.123456' AS Time,
                DATETIME '2016-11-29 12:34:56.123456' AS DateTime,
                TIMESTAMP '2016-11-29 12:34:56.123456' AS Timestamp",
                parameters: null)
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
            Assert.Equal(DateTimeKind.Unspecified, ((DateTime)row["DateTime"]).Kind);
            Assert.Equal(DateTimeKind.Utc, ((DateTime)row["Timestamp"]).Kind);
        }

        [Fact]
        public void ArrayTypes()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var row = client.ExecuteQuery($@"SELECT
                ['Hello'] AS String,
                [b'Hello'] AS Bytes,
                [TRUE] AS Boolean,
                [1234567890] AS Int64,
                [1.234567] AS Float64,
                [DATE '2016-11-29'] AS Date,
                [TIME '12:34:56.123456'] AS Time,
                [DATETIME '2016-11-29 12:34:56.123456'] AS DateTime,
                [TIMESTAMP '2016-11-29 12:34:56.123456'] AS Timestamp",
                parameters: null)
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
            Assert.Equal(DateTimeKind.Unspecified, ((DateTime[])row["DateTime"])[0].Kind);
            Assert.Equal(DateTimeKind.Utc, ((DateTime[])row["Timestamp"])[0].Kind);
        }

        [Fact]
        public void StructTypes()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var row = client.ExecuteQuery($@"
                SELECT ('Hello', b'Hello', TRUE, 1234567890, 1.234567, DATE '2016-11-29',
                        TIME '12:34:56.123456', DATETIME '2016-11-29 12:34:56.123456',
                        TIMESTAMP '2016-11-29 12:34:56.123456') AS value",
                parameters: null)
                .Single();

            // Structs come back as dictionaries, as if they're records.
            var values = (Dictionary<string, object>)row["value"];
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
            Assert.Equal(DateTimeKind.Unspecified, ((DateTime)values["_field_8"]).Kind);
            Assert.Equal(DateTimeKind.Utc, ((DateTime)values["_field_9"]).Kind);
        }

        [Fact]
        public void NullStructValue()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var row = client.ExecuteQuery("SELECT STRUCT<x string>(NULL) AS s", parameters: null).Single();
            var s = (Dictionary<string, object>)row["s"];
            Assert.Null(s["x"]);
        }

        [Fact]
        public void StringValueThatLooksLikeADate()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var row = client.ExecuteQuery("SELECT '2017-05-04T15:01:00Z' AS value", parameters: null)
                .Single();

            // Check that the schema really claims it's a string...
            var field = row.Schema.Fields.Single();
            Assert.Equal("value", field.Name);
            Assert.Equal("STRING", field.Type);

            // And we should be able to get the value as a string too...
            Assert.Equal("2017-05-04T15:01:00Z", (string)row["value"]);
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

            var queryResults = client.ExecuteQuery($"SELECT * FROM {view} WHERE player = 'Bob'", parameters: null).ToList();
            Assert.Equal(1, queryResults.Count);
            // The earlier game is not present in the view
            Assert.Equal(85L, (long)queryResults[0]["score"]);
        }

        [Fact]
        public void BrokenQuery()
        {
            BigQueryClient client = BigQueryClient.Create(_fixture.ProjectId);

            string sql = $"This is a broken query";
            var job = client.CreateQueryJob(sql, parameters: null);
            Assert.Throws<GoogleApiException>(() => job.GetQueryResults());
        }

        [Fact]
        public void NonQueryJob()
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

            Assert.Throws<InvalidOperationException>(() => job.GetQueryResults());
            Assert.Throws<InvalidOperationException>(() => client.GetQueryResults(job.Reference));
        }

        [Fact(Skip = "Processes 2TB - costs money!")]
        public void ExecuteQuery_Timeout()
        {
            // SQL that I happen to know takes over 10 seconds to query.
            string sql = "SELECT id FROM [bigquery-public-data:github_repos.contents] where content contains 'NodaTime' AND content contains '2.0.2' LIMIT 1000";
            BigQueryClient client = BigQueryClient.Create(_fixture.ProjectId);
            var queryOptions = new QueryOptions { UseLegacySql = true, UseQueryCache = false };
            var resultsOptions = new GetQueryResultsOptions { Timeout = TimeSpan.FromSeconds(2) };
            Assert.Throws<TimeoutException>(() => client.ExecuteQuery(sql, null, queryOptions, resultsOptions));
        }

        [Fact(Skip = "Processes 2TB - costs money!")]
        public void GetQueryResults_Timeout()
        {
            // SQL that I happen to know takes over 10 seconds to query.
            string sql = "SELECT id FROM [bigquery-public-data:github_repos.contents] where content contains 'NodaTime' AND content contains '2.0.2' LIMIT 1000";
            BigQueryClient client = BigQueryClient.Create(_fixture.ProjectId);
            var queryOptions = new QueryOptions { UseLegacySql = true, UseQueryCache = false };
            var job = client.CreateQueryJob(sql, null, queryOptions);
            var resultsOptions = new GetQueryResultsOptions { Timeout = TimeSpan.FromSeconds(2) };
            Assert.Throws<TimeoutException>(() => job.GetQueryResults(resultsOptions));
        }

        [Fact]
        public void MultiplePagesWithStartIndex()
        {
            // We create the client using our user, but then access a dataset in a public data
            // project. We can't run a query "as" the public data project.
            var projectId = _fixture.ProjectId;
            var client = BigQueryClient.Create(projectId);
            var table = client.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);

            var sql = $"SELECT corpus as title, COUNT(word) as unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 20";
            var results = client.ExecuteQuery(sql, parameters: null, resultsOptions: new GetQueryResultsOptions { PageSize = 5, StartIndex = 7 });
            // Iterate over multiple pages automatically to get all results. The query has 20 results, but
            // we're asking to start at index 7, so we actually see 13.
            var rows = results.ToList();
            Assert.Equal(13, rows.Count);

            // Now try getting one page at a time, in the same way we would if we were in a web application.
            var page1 = results.ReadPage(5);
            var page2 = client.GetQueryResults(results.JobReference, new GetQueryResultsOptions { PageToken = page1.NextPageToken }).ReadPage(5);
            var page3 = client.GetQueryResults(results.JobReference, new GetQueryResultsOptions { PageToken = page2.NextPageToken }).ReadPage(5);

            var titleComparer = new TitleComparer();
            Assert.Equal(rows.Take(5), page1.Rows, titleComparer);
            Assert.Equal(rows.Skip(5).Take(5), page2.Rows, titleComparer);
            Assert.Equal(rows.Skip(10).Take(5), page3.Rows, titleComparer);
            Assert.Null(page3.NextPageToken);
        }

        [Fact]
        public async Task MultiplePagesAsyncWithStartIndex()
        {
            // We create the client using our user, but then access a dataset in a public data
            // project. We can't run a query "as" the public data project.
            var projectId = _fixture.ProjectId;
            var client = BigQueryClient.Create(projectId);
            var table = client.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);

            var sql = $"SELECT corpus as title, COUNT(word) as unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 20";
            var results = await client.ExecuteQueryAsync(sql, parameters: null, resultsOptions: new GetQueryResultsOptions { PageSize = 5, StartIndex = 7 });
            // Iterate over multiple pages automatically to get all results. The query has 20 results, but
            // we're asking to start at index 7, so we actually see 13.
            var rows = await results.GetRowsAsync().ToListAsync();
            Assert.Equal(13, rows.Count);

            // Now try getting one page at a time, in the same way we would if we were in a web application.
            var page1 = await results.ReadPageAsync(5);
            var page2 = await client.GetQueryResults(results.JobReference, new GetQueryResultsOptions { PageToken = page1.NextPageToken }).ReadPageAsync(5);
            var page3 = await client.GetQueryResults(results.JobReference, new GetQueryResultsOptions { PageToken = page2.NextPageToken }).ReadPageAsync(5);

            var titleComparer = new TitleComparer();
            Assert.Equal(rows.Take(5), page1.Rows, titleComparer);
            Assert.Equal(rows.Skip(5).Take(5), page2.Rows, titleComparer);
            Assert.Equal(rows.Skip(10).Take(5), page3.Rows, titleComparer);
            Assert.Null(page3.NextPageToken);
        }

        /// <summary>
        /// Creates a table associated with a CSV file on Google Cloud Storage, which has some invalid data.
        /// A query on that table can provide the valid data but still have errors.
        /// </summary>
        [Fact]
        public void PartiallyBrokenQuery()
        {
            string[] csvRows =
            {
                "First,Last,Age,Gender",
                "Victor,Mota,23,M",
                "v,m,break,M", // Not a valid age
                "\"\",Blank,23,F",
                "foo,bar,32,M"
            };

            // Create the object in GCS
            byte[] bytes = Encoding.UTF8.GetBytes(string.Join("\n", csvRows));
            StorageClient storage = StorageClient.Create();
            string bucketName = _fixture.StorageBucketName;
            string objectName = _fixture.GenerateStorageObjectName();
            storage.UploadObject(bucketName, objectName, "text/csv", new MemoryStream(bytes));

            // Create the table associated with it
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var schema = new TableSchemaBuilder
            {
                { "First", BigQueryDbType.String },
                { "Last", BigQueryDbType.String },
                { "Age", BigQueryDbType.Int64 },
                { "Gender", BigQueryDbType.String },
            }.Build();
            var configuration = new ExternalDataConfiguration
            {
                SourceFormat = "CSV",
                CsvOptions = new CsvOptions { SkipLeadingRows = 1 },
                MaxBadRecords = 1,
                SourceUris = new[] { $"gs://{bucketName}/{objectName}" },
            };
            var table = client.CreateTable(_fixture.DatasetId, _fixture.CreateTableId(),
                schema, new CreateTableOptions { ExternalDataConfiguration = configuration });

            // Run a query
            var results = client.ExecuteQuery($"SELECT * FROM {table:legacy}", null, new QueryOptions { UseLegacySql = true });
            Assert.Equal(3, results.Count());
            Assert.Throws<GoogleApiException>(() => results.ThrowOnAnyError());
        }

        [Fact]
        public void DryRun_GetResults()
        {
            var projectId = _fixture.ProjectId;
            var client = BigQueryClient.Create(projectId);
            var table = client.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);

            var sql = $"SELECT corpus as title, COUNT(word) as unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";
            var job = client.CreateQueryJob(sql, null, new QueryOptions { DryRun = true });
            Assert.Throws<InvalidOperationException>(() => job.GetQueryResults());
        }

        [Fact]
        public void UnnamedParameterCannotBeConvertedWith_ExplicitlyNamedMode()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            string sql = $"SELECT score FROM {table} WHERE player=@player";
            var parameter = new BigQueryParameter(BigQueryDbType.String, "Angela");
            var options = new QueryOptions { ParameterMode = BigQueryParameterMode.Named };
            Assert.Throws<ArgumentException>(() => client.ExecuteQuery(sql, new[] { parameter }, options));
        }

        [Fact]
        public void UnnamedParameterCannotBeConvertedWith_DefaultNamedMode()
        {

            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            string sql = $"SELECT score FROM {table} WHERE player=@player";
            var parameter = new BigQueryParameter(BigQueryDbType.String, "Angela");
            Assert.Throws<ArgumentException>(() => client.ExecuteQuery(sql, new[] { parameter }));
        }

        [Fact]
        public void JobCreation_CustomDefaultLocation()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId).WithDefaultLocation(Locations.Tokyo);
            var job = client.CreateQueryJob("SELECT 'value' AS value", parameters: null);
            Assert.Equal(Locations.Tokyo, job.Reference.Location);
        }

        [Fact]
        public void JobCreation_WithCustomLocation()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var job = client.CreateQueryJob("SELECT 'value' AS value", parameters: null,
                new QueryOptions { JobLocation = Locations.Tokyo });
            Assert.Equal(Locations.Tokyo, job.Reference.Location);
        }

        [Fact]
        public void JobCreation_WithCustomLocationOverridingDefaultLocation()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId).WithDefaultLocation(Locations.Tokyo);
            var job = client.CreateQueryJob("SELECT 'value' AS value", parameters: null,
                new QueryOptions { JobLocation = Locations.EuropeanUnion });
            Assert.Equal(Locations.EuropeanUnion, job.Reference.Location);
        }

        [Fact]
        public void DdlQuery()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var tableId = _fixture.CreateTableId();
            var job = client.CreateQueryJob($"CREATE TABLE `{_fixture.ProjectId}.{_fixture.DatasetId}.{tableId}` (x INT64, y STRING)", null);
            job = job.PollUntilCompleted().ThrowOnAnyError();
            Assert.Equal("CREATE", job.Statistics.Query.DdlOperationPerformed);
            var tableRef = job.Statistics.Query.DdlTargetTable;
            Assert.Equal(_fixture.ProjectId, tableRef.ProjectId);
            Assert.Equal(_fixture.DatasetId, tableRef.DatasetId);
            Assert.Equal(tableId, tableRef.TableId);

            var table = client.GetTable(tableRef);
            var fields = table.Schema.Fields;
            Assert.Equal(2, fields.Count);
            Assert.Equal("x", fields[0].Name);
            Assert.Equal("y", fields[1].Name);

            // Viewing the job as a query, there aren't any results.
            Assert.Empty(job.GetQueryResults());
        }

        [Fact]
        public void DmlQuery()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.HighScoreTableId);

            var parameters = new[]
            {
                new BigQueryParameter("player", BigQueryDbType.String, "karen"),
                new BigQueryParameter("gameStarted", BigQueryDbType.Timestamp, new DateTime(2005, 1, 1, 0, 0, 0, DateTimeKind.Utc)),
                new BigQueryParameter("score", BigQueryDbType.Int64, 300)
            };
            var results = client.ExecuteQuery(
                $"INSERT INTO {table} (player, gameStarted, score) VALUES (@player, @gameStarted, @score)",
                parameters)
                .ThrowOnAnyError();
            Assert.Null(results.SafeTotalRows);
            Assert.Equal(1, results.NumDmlAffectedRows);

            // This used to query the whole table; now it returns empty results (as we're using GetQueryResults rather than ListRows).
            Assert.Empty(results);
        }

        [Fact]
        public void ScriptQuery()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);

            string sql = "DECLARE accumulator INT64 DEFAULT 5; SELECT accumulator;";
            var results = client.ExecuteQuery(sql, null).ThrowOnAnyError();

            Assert.True(results.SafeTotalRows.HasValue);
            Assert.Equal<ulong>(1, results.SafeTotalRows.Value);

            var row = results.Single();
            Assert.Equal((long)5, row[0]);
        }

        [Fact]
        public void GisQuery()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);

            string sql = @"SELECT ST_GeogPoint(longitude, latitude) AS WKT, num_bikes_available
                           FROM `bigquery-public-data.new_york.citibike_stations`
                           WHERE num_bikes_available > 30
                           LIMIT 10";
            var results = client.ExecuteQuery(sql, parameters: null);
            foreach (var row in results)
            {
                var geography = (BigQueryGeography) row["WKT"];
                Assert.StartsWith("POINT", geography.Text);
            }
        }

        [Fact]
        public void EarlyDate()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var results = client.ExecuteQuery("SELECT DATE '0001-01-01' AS x", null);
            var rows = results.ToList();
            var row = Assert.Single(rows);
            Assert.Equal(DateTime.MinValue, (DateTime) row["x"]);
        }

        private class TitleComparer : IEqualityComparer<BigQueryRow>
        {
            public bool Equals(BigQueryRow x, BigQueryRow y) => (string)x["title"] == (string)y["title"];

            public int GetHashCode(BigQueryRow obj) => obj["title"]?.GetHashCode() ?? 0;
        }
    }
}
