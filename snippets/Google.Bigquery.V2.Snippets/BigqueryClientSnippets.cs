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
using Google.Storage.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Xunit;

namespace Google.Bigquery.V2.Snippets
{
    [Collection(nameof(BigquerySnippetFixture))]
    public class BigqueryClientSnippets
    {
        private readonly BigquerySnippetFixture _fixture;

        public BigqueryClientSnippets(BigquerySnippetFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void QueryOverview()
        {
            string projectId = _fixture.ProjectId;

            // <QueryOverview>
            var client = BigqueryClient.Create(projectId);
            var table = client.GetTable("bigquery-public-data", "samples", "shakespeare");

            string sql = $"SELECT TOP(corpus, 10) as title, COUNT(*) as unique_words FROM {table}";
            BigqueryResult query = client.ExecuteQuery(sql);

            foreach (BigqueryResult.Row row in query.Rows)
            {
                Console.WriteLine($"{row["title"]}: {row["unique_words"]}");
            }
            // </QueryOverview>
        }

        [Fact]
        public void InsertionOverview()
        {
            string projectId = _fixture.ProjectId;

            // <InsertOverview>
            var client = BigqueryClient.Create(projectId);

            // Create the dataset if it doesn't exist.
            var dataset = client.GetOrCreateDataset("mydata");

            // Create the table if it doesn't exist.
            var table = dataset.GetOrCreateTable("scores", new TableSchemaBuilder
            {
                { "player", BigqueryDbType.String },
                { "gameStarted", BigqueryDbType.Timestamp },
                { "score", BigqueryDbType.Integer }
            }.Build());

            // Insert a single row. There are many other ways of inserting
            // data into a table.
            table.Insert(new InsertRow
            {
                { "player", "Bob" },
                { "score", 85 },
                { "gameStarted", new DateTime(2000, 1, 14, 10, 30, 0, DateTimeKind.Utc) }
            });
            // </InsertOverview>
        }

        [Fact]
        public void ExecuteQuery()
        {
            var projectId = _fixture.ProjectId;
            var datasetId = _fixture.GameDatasetId;
            var historyTableId = _fixture.HistoryTableId;

            // <ExecuteQuery>
            BigqueryClient client = BigqueryClient.Create(projectId);
            BigqueryTable table = client.GetTable(datasetId, historyTableId);
            BigqueryResult result = client.ExecuteQuery(
                $@"SELECT player, MAX(score) AS score
                   FROM {table}
                   GROUP BY player
                   ORDER BY score DESC");
            foreach (var row in result.Rows)
            {
                Console.WriteLine($"{row["player"]}: {row["score"]}");
            }
            // </ExecuteQuery>

            var players = result.Rows.Select(r => (string)r["player"]).ToList();
            Assert.Contains("Ben", players);
            Assert.Contains("Nadia", players);
            Assert.Contains("Tim", players);
        }

        [Fact]
        public void CreateDataset()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GenerateDatasetId();

            // <CreateDataset_System.String>
            BigqueryClient client = BigqueryClient.Create(projectId);
            BigqueryDataset dataset = client.CreateDataset(datasetId);
            // Now populate tables in the dataset...
            // </CreateDataset_System.String>

            _fixture.RegisterDatasetToDelete(datasetId);
        }

        [Fact]
        public void ListDatasets()
        {
            string projectId = _fixture.ProjectId;

            // <ListDatasets____>
            BigqueryClient client = BigqueryClient.Create(projectId);
            var datasets = client.ListDatasets().ToList();
            foreach (var dataset in datasets)
            {
                Console.WriteLine(dataset.FullyQualifiedId);
            }
            // </ListDatasets____>

            var ids = datasets.Select(ds => ds.Reference.DatasetId).ToList();
            Assert.Contains(_fixture.GameDatasetId, ids);
        }

        [Fact]
        public void ListTables()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;

            // <ListTables_System.String___>
            BigqueryClient client = BigqueryClient.Create(projectId);
            var tables = client.ListTables(datasetId).ToList();
            foreach (var table in tables)
            {
                Console.WriteLine(table.FullyQualifiedId);
            }
            // </ListTables_System.String___>

            var ids = tables.Select(ds => ds.Reference.TableId).ToList();
            Assert.Contains(_fixture.HistoryTableId, ids);
        }

        [Fact]
        public void CreateTable()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = Guid.NewGuid().ToString().Replace("-", "_");

            // <CreateTable>
            BigqueryClient client = BigqueryClient.Create(projectId);
            TableSchema schema = new TableSchemaBuilder
            {
                { "from_player", BigqueryDbType.String },
                { "to_player", BigqueryDbType.String },
                { "message", BigqueryDbType.String }
            }.Build();
            BigqueryTable table = client.CreateTable(datasetId, tableId, schema);
            // Now populate the table with data...
            // </CreateTable>

            var tables = client.ListTables(datasetId);
            var ids = tables.Select(ds => ds.Reference.TableId).ToList();
            Assert.Contains(tableId, ids);
        }

        [Fact]
        public void ListRows()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // <ListRows_System.String__System.String___>
            BigqueryClient client = BigqueryClient.Create(projectId);
            BigqueryResult result = client.ListRows(datasetId, tableId);
            foreach (BigqueryResult.Row row in result.Rows)
            {
                DateTime timestamp = (DateTime) row["game_started"];
                long level = (long) row["level"];
                long score = (long) row["score"];
                string player = (string) row["player"];
                Console.WriteLine($"{player}: {level}/{score} ({timestamp:yyyy-MM-dd HH:mm:ss})");
            }
            // </ListRows_System.String__System.String___>

            // We set up 7 results in the fixture. Other tests may add more.
            Assert.True(result.Rows.Count() >= 7);
        }

        [Fact]
        public void Insert()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            BigqueryTable table = BigqueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Rows.Count();

            // TODO: Make this a proper snippet. We can't find the overload properly right now.
            // (The signature contains [] which aren't valid characters in snippet IDs for docfx.)
            BigqueryClient client = BigqueryClient.Create(projectId);
            // The insert ID is optional, but can avoid duplicate data
            // when retrying inserts.
            InsertRow row1 = new InsertRow("row1")
            {
                { "player", "Jane" },
                { "level", 3 },
                { "score", 3600 },
                { "game_started", DateTime.UtcNow }
            };
            InsertRow row2 = new InsertRow("row2")
            {
                { "player", "Jeff" },
                { "level", 2 },
                { "score", 2000 },
                { "game_started", DateTime.UtcNow }
            };
            client.Insert(datasetId, tableId, row1, row2);
            // TODO: End the snippet here.

            int rowsAfter = table.ListRows().Rows.Count();
            Assert.Equal(rowsBefore + 2, rowsAfter);
        }

        [Fact]
        public void UploadCsv()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            BigqueryTable table = BigqueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Rows.Count();

            // <UploadCsv>
            BigqueryClient client = BigqueryClient.Create(projectId);
            string[] csvRows =
            {
                "player,score,level,game_started",
                "Tim,5000,3,2014-08-19T12:41:35.220Z",
                "Holly,6000,4,2014-08-03T08:45:35.123Z",
                "Jane,2402,1,2015-01-20T10:13:35.059Z"
            };

            // Normally we'd be uploading from a file or similar. Any readable stream can be used.
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(string.Join("\n", csvRows)));

            // This example uploads data to an existing table. If the upload will create a new table
            // or if the schema in the CSV isn't identical to the schema in the table (for example if the
            // columns are in a different order), create a schema to pass into the call.
            TableSchema schema = null;
            BigqueryJob job = client.UploadCsv(datasetId, tableId, schema, stream,
                // Our sample data has a header row, so we need to skip it.
                new UploadCsvOptions { SkipLeadingRows = 1 });
            // Use the job to find out when the data has finished being inserted into the table,
            // report errors etc.
            // </UploadCsv>

            var result = job.Poll();
            // If there are any errors, display them *then* fail.
            if (result.Status.ErrorResult != null)
            {
                foreach (var error in result.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Assert.Null(result.Status.ErrorResult);

            int rowsAfter = table.ListRows().Rows.Count();
            Assert.Equal(rowsBefore + 3, rowsAfter);
        }

        [Fact]
        public void UploadJson()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            BigqueryTable table = BigqueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Rows.Count();

            // <UploadJson>
            BigqueryClient client = BigqueryClient.Create(projectId);
            // Note that there's a single line per JSON object. This is not a JSON array.
            IEnumerable<string> jsonRows = new string[]
            {
                "{ 'player': 'John', 'score': 50, 'level': 1, 'game_started': '2014-08-19 12:41:35.220' }",
                "{ 'player': 'Zoe', 'score': 605, 'level': 1, 'game_started': '2016-01-01 08:30:35.000' }",
            }.Select(row => row.Replace('\'', '"')); // Simple way of representing C# in JSON to avoid escaping " everywhere.

            // Normally we'd be uploading from a file or similar. Any readable stream can be used.
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(string.Join("\n", jsonRows)));

            // This example uploads data to an existing table. If the upload will create a new table
            // or if the schema in the JSON isn't identical to the schema in the table,
            // create a schema to pass into the call.
            TableSchema schema = null;
            BigqueryJob job = client.UploadJson(datasetId, tableId, schema, stream);
            // Use the job to find out when the data has finished being inserted into the table,
            // report errors etc.
            // </UploadJson>

            var result = job.Poll();
            // If there are any errors, display them *then* fail.
            if (result.Status.ErrorResult != null)
            {
                foreach (var error in result.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Assert.Null(result.Status.ErrorResult);

            int rowsAfter = table.ListRows().Rows.Count();
            Assert.Equal(rowsBefore + 2, rowsAfter);
        }

        [Fact]
        public void CreateQueryJob()
        {
            var projectId = _fixture.ProjectId;
            var datasetId = _fixture.GameDatasetId;
            var historyTableId = _fixture.HistoryTableId;
            var queryTableId = Guid.NewGuid().ToString().Replace('-', '_');

            // <CreateQueryJob>
            BigqueryClient client = BigqueryClient.Create(projectId);
            BigqueryTable table = client.GetTable(datasetId, historyTableId);
            TableReference destination = client.GetTableReference(datasetId, queryTableId);
            // If the destination table is not specified, the results will be stored in
            // a temporary table.
            BigqueryJob job = client.CreateQueryJob(
                $@"SELECT player, MAX(score) AS score
                   FROM {table}
                   GROUP BY player
                   ORDER BY score DESC",
                new CreateQueryJobOptions { DestinationTable = destination });

            // Wait for the job to complete.
            job.Poll();

            // Then we can fetch the results, either via the job or by accessing
            // the destination table.
            BigqueryResult result = client.GetQueryResults(job.Reference);
            foreach (var row in result.Rows)
            {
                Console.WriteLine($"{row["player"]}: {row["score"]}");
            }
            // </CreateQueryJob>

            var players = result.Rows.Select(r => (string)r["player"]).ToList();
            Assert.Contains("Ben", players);
            Assert.Contains("Nadia", players);
            Assert.Contains("Tim", players);
        }

        [Fact]
        public void ListJobs()
        {
            var projectId = _fixture.ProjectId;

            // <ListJobs>
            BigqueryClient client = BigqueryClient.Create(projectId);
            var jobs = client.ListJobs().ToList();
            foreach (var job in jobs)
            {
                Console.WriteLine(job.Reference.JobId);
            }
            // </ListJobs>

            Assert.NotEmpty(jobs);
        }

        [Fact]
        public void ExportCsv()
        {
            // TODO: Make this simpler in the wrapper
            var projectId = _fixture.ProjectId;
            var datasetId = _fixture.GameDatasetId;
            var historyTableId = _fixture.HistoryTableId;
            string bucket = "bigquerysnippets-" + Guid.NewGuid().ToString().ToLowerInvariant();
            string objectName = "table.csv";

            if (!WaitForStreamingBufferToEmpty(historyTableId))
            {
                Console.WriteLine("Streaming buffer not empty after 30 seconds; not performing export");
                return;
            }

            // <ExportCsv>
            BigqueryClient client = BigqueryClient.Create(projectId);

            // Create a storage bucket; in normal use it's likely that one would exist already.
            StorageClient storageClient = StorageClient.Create();
            storageClient.CreateBucket(projectId, bucket);
            string destinationUri = $"gs://{bucket}/{objectName}";

            Job job = client.Service.Jobs.Insert(new Job
            {
                Configuration = new JobConfiguration
                {
                    Extract = new JobConfigurationExtract
                    {
                        DestinationFormat = "CSV",
                        DestinationUris = new[] { destinationUri },
                        SourceTable = client.GetTableReference(datasetId, historyTableId)                        
                    }
                }
            }, projectId).Execute();

            // Wait until the export has finished.
            var result = client.PollJob(job.JobReference);
            // If there are any errors, display them *then* fail.
            if (result.Status.ErrorResult != null)
            {
                foreach (var error in result.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Assert.Null(result.Status.ErrorResult);

            MemoryStream stream = new MemoryStream();
            storageClient.DownloadObject(bucket, objectName, stream);
            Console.WriteLine(Encoding.UTF8.GetString(stream.ToArray()));
            // </ExportCsv>

            storageClient.DeleteObject(bucket, objectName);
            storageClient.DeleteBucket(bucket);
        }

        // TODO: ExportJson
        // TODO: ImportCsv
        // TODO: ImportJson

        [Fact]
        public void CopyTable()
        {
            // TODO: Make this simpler in the wrapper
            var projectId = _fixture.ProjectId;
            var datasetId = _fixture.GameDatasetId;
            var historyTableId = _fixture.HistoryTableId;
            var destinationTableId = Guid.NewGuid().ToString().Replace('-', '_');

            if (!WaitForStreamingBufferToEmpty(historyTableId))
            {
                Console.WriteLine("Streaming buffer not empty after 30 seconds; not performing export");
                return;
            }

            // <CopyTable>
            BigqueryClient client = BigqueryClient.Create(projectId);

            Job job = client.Service.Jobs.Insert(new Job
            {
                Configuration = new JobConfiguration
                {
                    Copy = new JobConfigurationTableCopy
                    {
                        DestinationTable = client.GetTableReference(datasetId, destinationTableId),
                        SourceTable = client.GetTableReference(datasetId, historyTableId)                        
                    }
                }
            }, projectId).Execute();

            // Wait until the copy has finished.
            client.PollJob(job.JobReference);

            // Now list its rows
            BigqueryResult result = client.ListRows(datasetId, destinationTableId);
            foreach (BigqueryResult.Row row in result.Rows)
            {
                DateTime timestamp = (DateTime)row["game_started"];
                long level = (long)row["level"];
                long score = (long)row["score"];
                string player = (string)row["player"];
                Console.WriteLine($"{player}: {level}/{score} ({timestamp:yyyy-MM-dd HH:mm:ss})");
            }
            // </CopyTable>

            var originalRows = client.ListRows(datasetId, historyTableId).Rows.Count();
            var copiedRows = result.Rows.Count();

            Assert.Equal(originalRows, copiedRows);
        }

        private bool WaitForStreamingBufferToEmpty(string tableId)
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.GameDatasetId, tableId);
            for (int i = 0; i < 3 && table.Resource.StreamingBuffer != null; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(10));
                table = client.GetTable(table.Reference);
            }
            return table.Resource.StreamingBuffer == null;
        }

        // TODO: Snippets for DeleteTable and DeleteDataset; they fail with "still in use" at the moment (when just created).

        // TODO: Repeated fields and record types.

        // TODO:
        // Dataset update/patch
        // Table update/patch
    }
}
