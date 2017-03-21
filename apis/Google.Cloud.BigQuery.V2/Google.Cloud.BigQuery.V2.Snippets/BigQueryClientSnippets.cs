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

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Snippets
{
    [Collection(nameof(BigQuerySnippetFixture))]
    public class BigQueryClientSnippets
    {
        private readonly BigQuerySnippetFixture _fixture;

        public BigQueryClientSnippets(BigQuerySnippetFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void QueryOverview()
        {
            string projectId = _fixture.ProjectId;

            // Sample: QueryOverview
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable("bigquery-public-data", "samples", "shakespeare");

            string sql = $"SELECT corpus AS title, COUNT(word) AS unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";
            BigQueryResults results = client.ExecuteQuery(sql);

            foreach (BigQueryRow row in results.GetRows())
            {
                Console.WriteLine($"{row["title"]}: {row["unique_words"]}");
            }
            // End sample
        }

        [Fact]
        public void LegacySqlOverview()
        {
            string projectId = _fixture.ProjectId;

            // Sample: LegacySql
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable("bigquery-public-data", "samples", "shakespeare");

            string sql = $"SELECT TOP(corpus, 10) AS title, COUNT(*) AS unique_words FROM {table:legacy}";
            BigQueryResults results = client.ExecuteQuery(sql, new ExecuteQueryOptions { UseLegacySql = true });

            foreach (BigQueryRow row in results.GetRows())
            {
                Console.WriteLine($"{row["title"]}: {row["unique_words"]}");
            }
            // End sample
        }

        [Fact]
        public void ExternalCsv()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GenerateDatasetId();
            string tableId = "people";
            string bucket = "bigquerysnippets-" + Guid.NewGuid().ToString().ToLowerInvariant();
            string objectName = "table.csv";
            StorageClient storageClient = StorageClient.Create();
            byte[] csvData = Encoding.UTF8.GetBytes("Jon,10\nChris,20");
            storageClient.CreateBucket(projectId, bucket);
            storageClient.UploadObject(bucket, objectName, "text/csv", new MemoryStream(csvData));
            BigQueryClient.Create(projectId).CreateDataset(datasetId);
            _fixture.RegisterDatasetToDelete(datasetId);

            // Sample: ExternalCsv
            BigQueryClient client = BigQueryClient.Create(projectId);
            TableSchema schema = new TableSchemaBuilder
            {
                { "name", BigQueryDbType.String },
                { "score", BigQueryDbType.Int64 }
            }.Build();
            CreateTableOptions options = new CreateTableOptions
            {
                ExternalDataConfiguration = new ExternalDataConfiguration
                {
                    SourceFormat = "CSV",
                    SourceUris = new[] { $"gs://{bucket}/{objectName}" }
                }
            };
            BigQueryTable table = client.CreateTable(datasetId, tableId, schema, options);
            List<BigQueryRow> rows = client.ExecuteQuery($"SELECT name, score FROM {table} ORDER BY score").GetRows().ToList();
            foreach (BigQueryRow row in rows)
            {
                Console.WriteLine($"{row["name"]} - {row["score"]}");
            }
            // End sample
            Assert.Equal(2, rows.Count);
            Assert.Equal(new[] { "Jon", "Chris" }, rows.Select(r => (string) r["name"]));
            Assert.Equal(new[] { 10L, 20L }, rows.Select(r => (long) r["score"]));
            storageClient.DeleteObject(bucket, objectName);
            storageClient.DeleteBucket(bucket);
        }

        [Fact]
        public void InsertionOverview()
        {
            string projectId = _fixture.ProjectId;

            // Sample: InsertOverview
            BigQueryClient client = BigQueryClient.Create(projectId);

            // Create the dataset if it doesn't exist.
            BigQueryDataset dataset = client.GetOrCreateDataset("mydata");

            // Create the table if it doesn't exist.
            BigQueryTable table = dataset.GetOrCreateTable("scores", new TableSchemaBuilder
            {
                { "player", BigQueryDbType.String },
                { "gameStarted", BigQueryDbType.Timestamp },
                { "score", BigQueryDbType.Int64 }
            }.Build());

            // Insert a single row. There are many other ways of inserting
            // data into a table.
            table.InsertRow(new BigQueryInsertRow
            {
                { "player", "Bob" },
                { "score", 85 },
                { "gameStarted", new DateTime(2000, 1, 14, 10, 30, 0, DateTimeKind.Utc) }
            });
            // End sample
        }

        [Fact]
        public void ExecuteQuery()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string historyTableId = _fixture.HistoryTableId;

            // Snippet: ExecuteQuery(string,*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, historyTableId);
            BigQueryResults result = client.ExecuteQuery(
                $@"SELECT player, MAX(score) AS score
                   FROM {table}
                   GROUP BY player
                   ORDER BY score DESC");
            foreach (BigQueryRow row in result.GetRows())
            {
                Console.WriteLine($"{row["player"]}: {row["score"]}");
            }
            // End snippet

            List<string> players = result.GetRows().Select(r => (string) r["player"]).ToList();
            Assert.Contains("Ben", players);
            Assert.Contains("Nadia", players);
            Assert.Contains("Tim", players);
        }

        [Fact]
        public void CreateDataset()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GenerateDatasetId();

            // Snippet: CreateDataset(string,CreateDatasetOptions)
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryDataset dataset = client.CreateDataset(datasetId);
            // Now populate tables in the dataset...
            // End snippet

            _fixture.RegisterDatasetToDelete(datasetId);
        }

        [Fact]
        public void ListDatasets()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: ListDatasets(*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            List<BigQueryDataset> datasets = client.ListDatasets().Take(20).ToList();
            foreach (BigQueryDataset dataset in datasets)
            {
                Console.WriteLine(dataset.FullyQualifiedId);
            }
            // End snippet

            // Note: if this fails, run the clean-up tool to make sure there
            // are fewer than 20 datasets in the project, then rerun.
            List<string> ids = datasets.Select(ds => ds.Reference.DatasetId).ToList();
            Assert.Contains(_fixture.GameDatasetId, ids);
        }

        [Fact]
        public void ListTables()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;

            // Snippet: ListTables(string,ListTablesOptions)
            BigQueryClient client = BigQueryClient.Create(projectId);
            List<BigQueryTable> tables = client.ListTables(datasetId).Take(20).ToList();
            foreach (BigQueryTable table in tables)
            {
                Console.WriteLine(table.FullyQualifiedId);
            }
            // End snippet

            List<string> ids = tables.Select(ds => ds.Reference.TableId).ToList();
            Assert.Contains(_fixture.HistoryTableId, ids);
        }

        [Fact]
        public void CreateTable()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = Guid.NewGuid().ToString().Replace("-", "_");

            // Snippet: CreateTable(string,string,*,*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            TableSchema schema = new TableSchemaBuilder
            {
                { "from_player", BigQueryDbType.String },
                { "to_player", BigQueryDbType.String },
                { "message", BigQueryDbType.String }
            }.Build();
            BigQueryTable table = client.CreateTable(datasetId, tableId, schema);
            // Now populate the table with data...
            // End snippet

            PagedEnumerable<TableList, BigQueryTable> tables = client.ListTables(datasetId);
            List<string> ids = tables.Select(ds => ds.Reference.TableId).ToList();
            Assert.Contains(tableId, ids);
        }

        [Fact]
        public void ListRows()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Snippet: ListRows(*,*,*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            PagedEnumerable<TableDataList, BigQueryRow> result = client.ListRows(datasetId, tableId);
            foreach (BigQueryRow row in result)
            {
                DateTime timestamp = (DateTime) row["game_started"];
                long level = (long) row["level"];
                long score = (long) row["score"];
                string player = (string) row["player"];
                Console.WriteLine($"{player}: {level}/{score} ({timestamp:yyyy-MM-dd HH:mm:ss})");
            }
            // End snippet

            // We set up 7 results in the fixture. Other tests may add more.
            Assert.True(result.Count() >= 7);
        }

        [Fact]
        public void InsertRows()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            BigQueryTable table = BigQueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: InsertRows(string,string,*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            // The insert ID is optional, but can avoid duplicate data
            // when retrying inserts.
            BigQueryInsertRow row1 = new BigQueryInsertRow("row1")
            {
                { "player", "Jane" },
                { "level", 3 },
                { "score", 3600 },
                { "game_started", DateTime.UtcNow }
            };
            BigQueryInsertRow row2 = new BigQueryInsertRow("row2")
            {
                { "player", "Jeff" },
                { "level", 2 },
                { "score", 2000 },
                { "game_started", DateTime.UtcNow }
            };
            client.InsertRows(datasetId, tableId, row1, row2);
            // End snippet

            int rowsAfter = table.ListRows().Count();
            Assert.Equal(rowsBefore + 2, rowsAfter);
        }

        [Fact]
        public void UploadCsv()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            BigQueryTable table = BigQueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: UploadCsv(*,*,*,*,*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            string[] csvRows =
            {
                "player,score,level,game_started",
                "Tim,5000,3,2014-08-19T12:41:35.220Z",
                "Holly,6000,4,2014-08-03T08:45:35.123Z",
                "Jane,2402,1,2015-01-20T10:13:35.059Z"
            };

            // Normally we'd be uploading from a file or similar. Any readable stream can be used.
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(string.Join("\n", csvRows)));

            // This example uploads data to an existing table. If the upload will create a new table
            // or if the schema in the CSV isn't identical to the schema in the table (for example if the
            // columns are in a different order), create a schema to pass into the call.
            TableSchema schema = null;
            BigQueryJob job = client.UploadCsv(datasetId, tableId, schema, stream,
                // Our sample data has a header row, so we need to skip it.
                new UploadCsvOptions { SkipLeadingRows = 1 });
            // Use the job to find out when the data has finished being inserted into the table,
            // report errors etc.
            // End snippet

            BigQueryJob result = job.PollUntilCompleted();
            // If there are any errors, display them *then* fail.
            if (result.Status.ErrorResult != null)
            {
                foreach (ErrorProto error in result.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Assert.Null(result.Status.ErrorResult);

            int rowsAfter = table.ListRows().Count();
            Assert.Equal(rowsBefore + 3, rowsAfter);
        }

        [Fact]
        public void UploadJson_Stream()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            BigQueryTable table = BigQueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: UploadJson(*,*,*,Stream,*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            // Note that there's a single line per JSON object. This is not a JSON array.
            IEnumerable<string> jsonRows = new string[]
            {
                "{ 'player': 'John', 'score': 50, 'level': 1, 'game_started': '2014-08-19 12:41:35.220' }",
                "{ 'player': 'Zoe', 'score': 605, 'level': 1, 'game_started': '2016-01-01 08:30:35.000' }",
            }.Select(row => row.Replace('\'', '"')); // Simple way of representing C# in JSON to avoid escaping " everywhere.

            // Normally we'd be uploading from a file or similar. Any readable stream can be used.
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(string.Join("\n", jsonRows)));

            // This example uploads data to an existing table. If the upload will create a new table
            // or if the schema in the JSON isn't identical to the schema in the table,
            // create a schema to pass into the call.
            TableSchema schema = null;
            BigQueryJob job = client.UploadJson(datasetId, tableId, schema, stream);
            // Use the job to find out when the data has finished being inserted into the table,
            // report errors etc.
            // End snippet

            BigQueryJob result = job.PollUntilCompleted();
            // If there are any errors, display them *then* fail.
            if (result.Status.ErrorResult != null)
            {
                foreach (ErrorProto error in result.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Assert.Null(result.Status.ErrorResult);

            int rowsAfter = table.ListRows().Count();
            Assert.Equal(rowsBefore + 2, rowsAfter);
        }

        [Fact]
        public void UploadJson_Strings()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            BigQueryTable table = BigQueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: UploadJson(*,*,*,IEnumerable<string>,*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            // Note that there's a single line per JSON object. This is not a JSON array.
            IEnumerable<string> jsonRows = new string[]
            {
                "{ 'player': 'Jean', 'score': 500, 'level': 1, 'game_started': '2012-08-19 12:41:35.220' }",
                "{ 'player': 'Joe', 'score': 705, 'level': 1, 'game_started': '2014-01-01 08:30:35.000' }",
            }.Select(row => row.Replace('\'', '"')); // Simple way of representing C# in JSON to avoid escaping " everywhere.

            // This example uploads data to an existing table. If the upload will create a new table
            // or if the schema in the JSON isn't identical to the schema in the table,
            // create a schema to pass into the call.
            TableSchema schema = null;
            BigQueryJob job = client.UploadJson(datasetId, tableId, schema, jsonRows);
            // Use the job to find out when the data has finished being inserted into the table,
            // report errors etc.
            // End snippet

            BigQueryJob result = job.PollUntilCompleted();
            // If there are any errors, display them *then* fail.
            if (result.Status.ErrorResult != null)
            {
                foreach (ErrorProto error in result.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Assert.Null(result.Status.ErrorResult);

            int rowsAfter = table.ListRows().Count();
            Assert.Equal(rowsBefore + 2, rowsAfter);
        }

        [Fact]
        public void CreateQueryJob()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string historyTableId = _fixture.HistoryTableId;
            string queryTableId = Guid.NewGuid().ToString().Replace('-', '_');

            // Snippet: CreateQueryJob(string,*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, historyTableId);
            TableReference destination = client.GetTableReference(datasetId, queryTableId);
            // If the destination table is not specified, the results will be stored in
            // a temporary table.
            BigQueryJob job = client.CreateQueryJob(
                $@"SELECT player, MAX(score) AS score
                   FROM {table}
                   GROUP BY player
                   ORDER BY score DESC",
                new CreateQueryJobOptions { DestinationTable = destination });

            // Wait for the job to complete.
            job.PollUntilCompleted();

            // Then we can fetch the results, either via the job or by accessing
            // the destination table.
            BigQueryResults result = client.GetQueryResults(job.Reference);
            foreach (BigQueryRow row in result.GetRows())
            {
                Console.WriteLine($"{row["player"]}: {row["score"]}");
            }
            // End snippet

            List<string> players = result.GetRows().Select(r => (string) r["player"]).ToList();
            Assert.Contains("Ben", players);
            Assert.Contains("Nadia", players);
            Assert.Contains("Tim", players);
        }

        [Fact]
        public void ListJobs()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: ListJobs(*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            List<BigQueryJob> jobs = client.ListJobs().Take(20).ToList();
            foreach (BigQueryJob job in jobs)
            {
                Console.WriteLine(job.Reference.JobId);
            }
            // End snippet

            Assert.NotEmpty(jobs);
        }

        [Fact(Skip = "The streaming buffer never empties quickly enough")]
        public void ExportCsv()
        {
            // TODO: Make this simpler in the wrapper
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string historyTableId = _fixture.HistoryTableId;
            string bucket = "bigquerysnippets-" + Guid.NewGuid().ToString().ToLowerInvariant();
            string objectName = "table.csv";

            if (!WaitForStreamingBufferToEmpty(historyTableId))
            {
                Console.WriteLine("Streaming buffer not empty after 30 seconds; not performing export");
                return;
            }

            // Sample: ExportCsv
            BigQueryClient client = BigQueryClient.Create(projectId);

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
            BigQueryJob result = client.PollJobUntilCompleted(job.JobReference);
            // If there are any errors, display them *then* fail.
            if (result.Status.ErrorResult != null)
            {
                foreach (ErrorProto error in result.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Assert.Null(result.Status.ErrorResult);

            MemoryStream stream = new MemoryStream();
            storageClient.DownloadObject(bucket, objectName, stream);
            Console.WriteLine(Encoding.UTF8.GetString(stream.ToArray()));
            // End sample

            storageClient.DeleteObject(bucket, objectName);
            storageClient.DeleteBucket(bucket);
        }

        // TODO: ExportJson
        // TODO: ImportCsv
        // TODO: ImportJson

        [Fact(Skip = "The streaming buffer never empties quickly enough")]
        public void CopyTable()
        {
            // TODO: Make this simpler in the wrapper
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string historyTableId = _fixture.HistoryTableId;
            string destinationTableId = Guid.NewGuid().ToString().Replace('-', '_');

            if (!WaitForStreamingBufferToEmpty(historyTableId))
            {
                Console.WriteLine("Streaming buffer not empty after 30 seconds; not performing export");
                return;
            }

            // Sample: CopyTable
            BigQueryClient client = BigQueryClient.Create(projectId);

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
            client.PollJobUntilCompleted(job.JobReference);

            // Now list its rows
            PagedEnumerable<TableDataList, BigQueryRow> result = client.ListRows(datasetId, destinationTableId);
            foreach (BigQueryRow row in result)
            {
                DateTime timestamp = (DateTime) row["game_started"];
                long level = (long) row["level"];
                long score = (long) row["score"];
                string player = (string) row["player"];
                Console.WriteLine($"{player}: {level}/{score} ({timestamp:yyyy-MM-dd HH:mm:ss})");
            }
            // End sample

            int originalRows = client.ListRows(datasetId, historyTableId).Count();
            int copiedRows = result.Count();

            Assert.Equal(originalRows, copiedRows);
        }

        [Fact]
        public void DeleteTable()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = Guid.NewGuid().ToString().Replace("-", "_");
            TableSchema schema = new TableSchemaBuilder
            {
                { "from_player", BigQueryDbType.String },
                { "to_player", BigQueryDbType.String },
                { "message", BigQueryDbType.String }
            }.Build();
            BigQueryClient.Create(projectId).CreateTable(datasetId, tableId, schema);

            // Snippet: DeleteTable(string,string,*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            client.DeleteTable(datasetId, tableId);
            // End snippet

            PagedEnumerable<TableList, BigQueryTable> tables = client.ListTables(datasetId);
            List<string> ids = tables.Select(ds => ds.Reference.TableId).ToList();
            Assert.DoesNotContain(tableId, ids);
        }

        [Fact]
        public void DeleteDataset()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GenerateDatasetId();
            BigQueryClient.Create(projectId).CreateDataset(datasetId);
            // Snippet: DeleteDataset(string,DeleteDatasetOptions)
            BigQueryClient client = BigQueryClient.Create(projectId);
            client.DeleteDataset(datasetId);
            // End snippet

            PagedEnumerable<DatasetList, BigQueryDataset> datasets = client.ListDatasets();
            List<string> ids = datasets.Select(ds => ds.Reference.DatasetId).ToList();
            Assert.DoesNotContain(datasetId, ids);
        }

        [Fact]
        public void ListProjects()
        {
            // Snippet: ListProjects(*)
            BigQueryClient client = BigQueryClient.Create("irrelevant");
            PagedEnumerable<ProjectList, CloudProject> projects = client.ListProjects();
            foreach (CloudProject project in projects)
            {
                Console.WriteLine($"{project.ProjectId}: {project.FriendlyName}");
            }
            // End snippet
            Assert.Contains(_fixture.ProjectId, projects.Select(p => p.ProjectId));
        }

        [Fact]
        public void ParameterizedQuery_NamedParameters()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Sample: ParameterizedQueryNamedParameters
            // Additional: ExecuteQuery(BigQueryCommand,*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, tableId);
            BigQueryCommand command = new BigQueryCommand($"SELECT player, score, level FROM {table} WHERE score >= @score AND level >= @level");
            // Note: could also use a collection initializer to populate the parameters.
            command.Parameters.Add("level", BigQueryDbType.Int64).Value = 2;
            command.Parameters.Add("score", BigQueryDbType.Int64).Value = 1500;
            IEnumerable<BigQueryRow> resultRows = client.ExecuteQuery(command).GetRows();
            foreach (BigQueryRow row in resultRows)
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            }
            // End sample

            var resultsList = client.ExecuteQuery(command)
                 .GetRows()
                 .Select(row => new { Name = (string) row["player"], Score = (long) row["score"], Level = (long) row["level"] })
                 .ToList();

            Assert.Contains(new { Name = "Tim", Score = 5310L, Level = 3L }, resultsList);
            Assert.Contains(new { Name = "Tim", Score = 2000L, Level = 2L }, resultsList);
            Assert.Contains(new { Name = "Nadia", Score = 8310L, Level = 5L }, resultsList);
            Assert.DoesNotContain(new { Name = "Tim", Score = 503L, Level = 1L }, resultsList);
            Assert.DoesNotContain(new { Name = "Nadia", Score = 1320L, Level = 2L }, resultsList);
        }

        [Fact]
        public void ParameterizedQuery_PositionalParameters()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            /// Sample: ParameterizedQueryPositionalParameters
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, tableId);
            BigQueryCommand command = new BigQueryCommand($"SELECT player, score, level FROM {table} WHERE score >= ? AND level >= ?");
            command.ParameterMode = BigQueryParameterMode.Positional;
            command.Parameters.Add(BigQueryDbType.Int64, 1500); // For score
            command.Parameters.Add(BigQueryDbType.Int64, 2); // For level
            IEnumerable<BigQueryRow> resultRows = client.ExecuteQuery(command).GetRows();
            foreach (BigQueryRow row in resultRows)
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            }
            /// End sample

            // Execute the same command again for validation.
            var resultsList = client.ExecuteQuery(command)
                .GetRows()
                .Select(row => new { Name = (string) row["player"], Score = (long) row["score"], Level = (long) row["level"] })
                .ToList();

            Assert.Contains(new { Name = "Tim", Score = 5310L, Level = 3L }, resultsList);
            Assert.Contains(new { Name = "Tim", Score = 2000L, Level = 2L }, resultsList);
            Assert.Contains(new { Name = "Nadia", Score = 8310L, Level = 5L }, resultsList);
            Assert.DoesNotContain(new { Name = "Tim", Score = 503L, Level = 1L }, resultsList);
            Assert.DoesNotContain(new { Name = "Nadia", Score = 1320L, Level = 2L }, resultsList);
        }

        [Fact]
        public async Task QueryOverviewAsync()
        {
            string projectId = _fixture.ProjectId;

            // Sample: QueryOverviewAsync
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            BigQueryTable table = await client.GetTableAsync("bigquery-public-data", "samples", "shakespeare");

            string sql = $"SELECT corpus AS title, COUNT(word) AS unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";
            BigQueryResults query = await client.ExecuteQueryAsync(sql);

            await query.GetRowsAsync().ForEachAsync(row =>
            {
                Console.WriteLine($"{row["title"]}: {row["unique_words"]}");
            });
            // End sample
        }

        [Fact]
        public async Task LegacySqlOverviewAsync()
        {
            string projectId = _fixture.ProjectId;

            // Sample: LegacySqlAsync
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            BigQueryTable table = await client.GetTableAsync("bigquery-public-data", "samples", "shakespeare");

            string sql = $"SELECT TOP(corpus, 10) AS title, COUNT(*) AS unique_words FROM {table:legacy}";
            BigQueryResults query = await client.ExecuteQueryAsync(sql, new ExecuteQueryOptions { UseLegacySql = true });

            await query.GetRowsAsync().ForEachAsync(row =>
            {
                Console.WriteLine($"{row["title"]}: {row["unique_words"]}");
            });
            // End sample
        }

        [Fact]
        public async Task InsertionOverviewAsync()
        {
            string projectId = _fixture.ProjectId;

            // Sample: InsertOverviewAsync
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);

            // Create the dataset if it doesn't exist.
            BigQueryDataset dataset = await client.GetOrCreateDatasetAsync("mydata");

            // Create the table if it doesn't exist.
            BigQueryTable table = await dataset.GetOrCreateTableAsync("scores", new TableSchemaBuilder
            {
                { "player", BigQueryDbType.String },
                { "gameStarted", BigQueryDbType.Timestamp },
                { "score", BigQueryDbType.Int64 }
            }.Build());

            // Insert a single row. There are many other ways of inserting
            // data into a table.
            await table.InsertRowAsync(new BigQueryInsertRow
            {
                { "player", "Bob" },
                { "score", 85 },
                { "gameStarted", new DateTime(2000, 1, 14, 10, 30, 0, DateTimeKind.Utc) }
            });
            // End sample
        }

        [Fact]
        public async Task ExecuteQueryAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string historyTableId = _fixture.HistoryTableId;

            // Snippet: ExecuteQueryAsync(string,*,*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            BigQueryTable table = await client.GetTableAsync(datasetId, historyTableId);
            BigQueryResults result = await client.ExecuteQueryAsync(
                $@"SELECT player, MAX(score) AS score
                   FROM {table}
                   GROUP BY player
                   ORDER BY score DESC");
            await result.GetRowsAsync().ForEachAsync(row =>
            {
                Console.WriteLine($"{row["player"]}: {row["score"]}");
            });
            // End snippet

            List<string> players = result.GetRows().Select(r => (string) r["player"]).ToList();
            Assert.Contains("Ben", players);
            Assert.Contains("Nadia", players);
            Assert.Contains("Tim", players);
        }

        [Fact]
        public async Task CreateDatasetAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GenerateDatasetId();

            // Snippet: CreateDatasetAsync(string,CreateDatasetOptions,CancellationToken)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            BigQueryDataset dataset = await client.CreateDatasetAsync(datasetId);
            // Now populate tables in the dataset...
            // End snippet

            _fixture.RegisterDatasetToDelete(datasetId);
        }

        [Fact]
        public async Task ListDatasetsAsync()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: ListDatasetsAsync(*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            List<BigQueryDataset> datasets = await client.ListDatasetsAsync().Take(20).ToList();
            foreach (BigQueryDataset dataset in datasets)
            {
                Console.WriteLine(dataset.FullyQualifiedId);
            }
            // End snippet

            // Note: if this fails, run the clean-up tool to make sure there
            // are fewer than 20 datasets in the project, then rerun.
            List<string> ids = datasets.Select(ds => ds.Reference.DatasetId).ToList();
            Assert.Contains(_fixture.GameDatasetId, ids);
        }

        [Fact]
        public async Task ListTablesAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;

            // Snippet: ListTablesAsync(string,ListTablesOptions)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            List<BigQueryTable> tables = await client.ListTablesAsync(datasetId).Take(20).ToList();
            foreach (BigQueryTable table in tables)
            {
                Console.WriteLine(table.FullyQualifiedId);
            }
            // End snippet

            List<string> ids = tables.Select(ds => ds.Reference.TableId).ToList();
            Assert.Contains(_fixture.HistoryTableId, ids);
        }

        [Fact]
        public async Task CreateTableAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = Guid.NewGuid().ToString().Replace("-", "_");

            // Snippet: CreateTableAsync(string,string,*,*,*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            TableSchema schema = new TableSchemaBuilder
            {
                { "from_player", BigQueryDbType.String },
                { "to_player", BigQueryDbType.String },
                { "message", BigQueryDbType.String }
            }.Build();
            BigQueryTable table = await client.CreateTableAsync(datasetId, tableId, schema);
            // Now populate the table with data...
            // End snippet

            PagedEnumerable<TableList, BigQueryTable> tables = client.ListTables(datasetId);
            List<string> ids = tables.Select(ds => ds.Reference.TableId).ToList();
            Assert.Contains(tableId, ids);
        }

        [Fact]
        public async Task ListRowsAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Snippet: ListRowsAsync(*,*,*,*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            PagedAsyncEnumerable<TableDataList, BigQueryRow> result = client.ListRowsAsync(datasetId, tableId);
            await result.ForEachAsync(row =>
            {
                DateTime timestamp = (DateTime) row["game_started"];
                long level = (long) row["level"];
                long score = (long) row["score"];
                string player = (string) row["player"];
                Console.WriteLine($"{player}: {level}/{score} ({timestamp:yyyy-MM-dd HH:mm:ss})");
            });
            // End snippet

            // We set up 7 results in the fixture. Other tests may add more.
            Assert.True(await result.Count() >= 7);
        }

        [Fact]
        public async Task InsertRowsAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            BigQueryTable table = BigQueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: InsertRowsAsync(string,string,*,*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            // The insert ID is optional, but can avoid duplicate data
            // when retrying inserts.
            BigQueryInsertRow row1 = new BigQueryInsertRow("row1-async")
            {
                { "player", "Jane" },
                { "level", 3 },
                { "score", 3600 },
                { "game_started", DateTime.UtcNow }
            };
            BigQueryInsertRow row2 = new BigQueryInsertRow("row2-async")
            {
                { "player", "Jeff" },
                { "level", 2 },
                { "score", 2000 },
                { "game_started", DateTime.UtcNow }
            };
            await client.InsertRowsAsync(datasetId, tableId, row1, row2);
            // End snippet

            int rowsAfter = table.ListRows().Count();
            Assert.Equal(rowsBefore + 2, rowsAfter);
        }

        [Fact]
        public async Task UploadCsvAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            BigQueryTable table = BigQueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: UploadCsvAsync(*,*,*,*,*,*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            string[] csvRows =
            {
                "player,score,level,game_started",
                "Tim,5000,3,2014-08-19T12:41:35.220Z",
                "Holly,6000,4,2014-08-03T08:45:35.123Z",
                "Jane,2402,1,2015-01-20T10:13:35.059Z"
            };

            // Normally we'd be uploading from a file or similar. Any readable stream can be used.
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(string.Join("\n", csvRows)));

            // This example uploads data to an existing table. If the upload will create a new table
            // or if the schema in the CSV isn't identical to the schema in the table (for example if the
            // columns are in a different order), create a schema to pass into the call.
            TableSchema schema = null;
            BigQueryJob job = await client.UploadCsvAsync(datasetId, tableId, schema, stream,
                // Our sample data has a header row, so we need to skip it.
                new UploadCsvOptions { SkipLeadingRows = 1 });
            // Use the job to find out when the data has finished being inserted into the table,
            // report errors etc.
            // End snippet

            BigQueryJob result = job.PollUntilCompleted();
            // If there are any errors, display them *then* fail.
            if (result.Status.ErrorResult != null)
            {
                foreach (ErrorProto error in result.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Assert.Null(result.Status.ErrorResult);

            int rowsAfter = table.ListRows().Count();
            Assert.Equal(rowsBefore + 3, rowsAfter);
        }

        [Fact]
        public async Task UploadJsonAsync_Stream()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            BigQueryTable table = BigQueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: UploadJsonAsync(*,*,*,*,Stream,*,*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            // Note that there's a single line per JSON object. This is not a JSON array.
            IEnumerable<string> jsonRows = new string[]
            {
                "{ 'player': 'John', 'score': 50, 'level': 1, 'game_started': '2014-08-19 12:41:35.220' }",
                "{ 'player': 'Zoe', 'score': 605, 'level': 1, 'game_started': '2016-01-01 08:30:35.000' }",
            }.Select(row => row.Replace('\'', '"')); // Simple way of representing C# in JSON to avoid escaping " everywhere.

            // Normally we'd be uploading from a file or similar. Any readable stream can be used.
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(string.Join("\n", jsonRows)));

            // This example uploads data to an existing table. If the upload will create a new table
            // or if the schema in the JSON isn't identical to the schema in the table,
            // create a schema to pass into the call.
            TableSchema schema = null;
            BigQueryJob job = await client.UploadJsonAsync(datasetId, tableId, schema, stream);
            // Use the job to find out when the data has finished being inserted into the table,
            // report errors etc.
            // End snippet

            BigQueryJob result = job.PollUntilCompleted();
            // If there are any errors, display them *then* fail.
            if (result.Status.ErrorResult != null)
            {
                foreach (ErrorProto error in result.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Assert.Null(result.Status.ErrorResult);

            int rowsAfter = table.ListRows().Count();
            Assert.Equal(rowsBefore + 2, rowsAfter);
        }

        [Fact]
        public async Task UploadJsonAsync_Strings()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            BigQueryTable table = BigQueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: UploadJsonAsync(*,*,*,*,IEnumerable<string>,*,*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            // Note that there's a single line per JSON object. This is not a JSON array.
            IEnumerable<string> jsonRows = new string[]
            {
                "{ 'player': 'Jean', 'score': 500, 'level': 1, 'game_started': '2012-08-19 12:41:35.220' }",
                "{ 'player': 'Joe', 'score': 705, 'level': 1, 'game_started': '2014-01-01 08:30:35.000' }",
            }.Select(row => row.Replace('\'', '"')); // Simple way of representing C# in JSON to avoid escaping " everywhere.

            // This example uploads data to an existing table. If the upload will create a new table
            // or if the schema in the JSON isn't identical to the schema in the table,
            // create a schema to pass into the call.
            TableSchema schema = null;
            BigQueryJob job = await client.UploadJsonAsync(datasetId, tableId, schema, jsonRows);
            // Use the job to find out when the data has finished being inserted into the table,
            // report errors etc.
            // End snippet

            BigQueryJob result = job.PollUntilCompleted();
            // If there are any errors, display them *then* fail.
            if (result.Status.ErrorResult != null)
            {
                foreach (ErrorProto error in result.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Assert.Null(result.Status.ErrorResult);

            int rowsAfter = table.ListRows().Count();
            Assert.Equal(rowsBefore + 2, rowsAfter);
        }

        [Fact]
        public async Task CreateQueryJobAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string historyTableId = _fixture.HistoryTableId;
            string queryTableId = Guid.NewGuid().ToString().Replace('-', '_');

            // Snippet: CreateQueryJobAsync(string,*,*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            BigQueryTable table = await client.GetTableAsync(datasetId, historyTableId);
            TableReference destination = client.GetTableReference(datasetId, queryTableId);
            // If the destination table is not specified, the results will be stored in
            // a temporary table.
            BigQueryJob job = await client.CreateQueryJobAsync(
                $@"SELECT player, MAX(score) AS score
                   FROM {table}
                   GROUP BY player
                   ORDER BY score DESC",
                new CreateQueryJobOptions { DestinationTable = destination });

            // Wait for the job to complete.
            await job.PollUntilCompletedAsync();

            // Then we can fetch the results, either via the job or by accessing
            // the destination table.
            BigQueryResults result = await client.GetQueryResultsAsync(job.Reference);
            await result.GetRowsAsync().ForEachAsync(row =>
            {
                Console.WriteLine($"{row["player"]}: {row["score"]}");
            });
            // End snippet

            List<string> players = result.GetRows().Select(r => (string) r["player"]).ToList();
            Assert.Contains("Ben", players);
            Assert.Contains("Nadia", players);
            Assert.Contains("Tim", players);
        }

        [Fact]
        public async Task ListJobsAsync()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: ListJobsAsync(ListJobsOptions)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            List<BigQueryJob> jobs = await client.ListJobsAsync().Take(20).ToList();
            foreach (BigQueryJob job in jobs)
            {
                Console.WriteLine(job.Reference.JobId);
            }
            // End snippet

            Assert.NotEmpty(jobs);
        }

        [Fact(Skip = "The streaming buffer never empties quickly enough")]
        public async Task ExportCsvAsync()
        {
            // TODO: Make this simpler in the wrapper
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string historyTableId = _fixture.HistoryTableId;
            string bucket = "bigquerysnippets-" + Guid.NewGuid().ToString().ToLowerInvariant();
            string objectName = "table.csv";

            if (!WaitForStreamingBufferToEmpty(historyTableId))
            {
                Console.WriteLine("Streaming buffer not empty after 30 seconds; not performing export");
                return;
            }

            // Sample: ExportCsvAsync
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);

            // Create a storage bucket; in normal use it's likely that one would exist already.
            StorageClient storageClient = await StorageClient.CreateAsync();
            await storageClient.CreateBucketAsync(projectId, bucket);
            string destinationUri = $"gs://{bucket}/{objectName}";

            Job job = await client.Service.Jobs.Insert(new Job
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
            }, projectId).ExecuteAsync();

            // Wait until the export has finished.
            BigQueryJob result = await client.PollJobUntilCompletedAsync(job.JobReference);
            // If there are any errors, display them *then* fail.
            if (result.Status.ErrorResult != null)
            {
                foreach (ErrorProto error in result.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Assert.Null(result.Status.ErrorResult);

            MemoryStream stream = new MemoryStream();
            await storageClient.DownloadObjectAsync(bucket, objectName, stream);
            Console.WriteLine(Encoding.UTF8.GetString(stream.ToArray()));
            // End sample

            storageClient.DeleteObject(bucket, objectName);
            storageClient.DeleteBucket(bucket);
        }

        // TODO: ExportJson
        // TODO: ImportCsv
        // TODO: ImportJson

        [Fact(Skip = "The streaming buffer never empties quickly enough")]
        public async Task CopyTableAsync()
        {
            // TODO: Make this simpler in the wrapper
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string historyTableId = _fixture.HistoryTableId;
            string destinationTableId = Guid.NewGuid().ToString().Replace('-', '_');

            if (!WaitForStreamingBufferToEmpty(historyTableId))
            {
                Console.WriteLine("Streaming buffer not empty after 30 seconds; not performing export");
                return;
            }

            // Sample: CopyTableAsync
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);

            Job job = await client.Service.Jobs.Insert(new Job
            {
                Configuration = new JobConfiguration
                {
                    Copy = new JobConfigurationTableCopy
                    {
                        DestinationTable = client.GetTableReference(datasetId, destinationTableId),
                        SourceTable = client.GetTableReference(datasetId, historyTableId)
                    }
                }
            }, projectId).ExecuteAsync();

            // Wait until the copy has finished.
            await client.PollJobUntilCompletedAsync(job.JobReference);

            // Now list its rows
            PagedAsyncEnumerable<TableDataList, BigQueryRow> result = client.ListRowsAsync(datasetId, destinationTableId);
            await result.ForEachAsync(row =>
            {
                DateTime timestamp = (DateTime) row["game_started"];
                long level = (long) row["level"];
                long score = (long) row["score"];
                string player = (string) row["player"];
                Console.WriteLine($"{player}: {level}/{score} ({timestamp:yyyy-MM-dd HH:mm:ss})");
            });
            // End sample

            int originalRows = await client.ListRowsAsync(datasetId, historyTableId).Count();
            int copiedRows = await result.Count();

            Assert.Equal(originalRows, copiedRows);
        }

        [Fact]
        public async Task DeleteTableAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = Guid.NewGuid().ToString().Replace("-", "_");
            TableSchema schema = new TableSchemaBuilder
            {
                { "from_player", BigQueryDbType.String },
                { "to_player", BigQueryDbType.String },
                { "message", BigQueryDbType.String }
            }.Build();
            BigQueryClient.Create(projectId).CreateTable(datasetId, tableId, schema);

            // Snippet: DeleteTableAsync(string,string,*,*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            await client.DeleteTableAsync(datasetId, tableId);
            // End snippet

            PagedEnumerable<TableList, BigQueryTable> tables = client.ListTables(datasetId);
            List<string> ids = tables.Select(ds => ds.Reference.TableId).ToList();
            Assert.DoesNotContain(tableId, ids);
        }

        [Fact]
        public async Task DeleteDatasetAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GenerateDatasetId();
            BigQueryClient.Create(projectId).CreateDataset(datasetId);
            // Snippet: DeleteDatasetAsync(string,DeleteDatasetOptions,*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            await client.DeleteDatasetAsync(datasetId);
            // End snippet

            PagedEnumerable<DatasetList, BigQueryDataset> datasets = client.ListDatasets();
            List<string> ids = datasets.Select(ds => ds.Reference.DatasetId).ToList();
            Assert.DoesNotContain(datasetId, ids);
        }

        [Fact]
        public async Task ListProjectsAsync()
        {
            // Snippet: ListProjectsAsync(*)
            BigQueryClient client = BigQueryClient.Create("irrelevant");
            PagedAsyncEnumerable<ProjectList, CloudProject> projects = client.ListProjectsAsync();
            await projects.ForEachAsync(project =>
            {
                Console.WriteLine($"{project.ProjectId}: {project.FriendlyName}");
            });
            // End snippet
            Assert.Contains(_fixture.ProjectId, await projects.Select(p => p.ProjectId).ToList());
        }

        [Fact]
        public async Task ParameterizedQueryAsync_NamedParameters()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Sample: ParameterizedQueryNamedParametersAsync
            // Additional: ExecuteQueryAsync(BigQueryCommand,*,*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            BigQueryTable table = await client.GetTableAsync(datasetId, tableId);
            BigQueryCommand command = new BigQueryCommand($"SELECT player, score, level FROM {table} WHERE score >= @score AND level >= @level");
            // Note: could also use a collection initializer to populate the parameters.
            command.Parameters.Add("level", BigQueryDbType.Int64).Value = 2;
            command.Parameters.Add("score", BigQueryDbType.Int64).Value = 1500;
            BigQueryResults queryJob = await client.ExecuteQueryAsync(command);
            IAsyncEnumerable<BigQueryRow> resultRows = queryJob.GetRowsAsync();
            await resultRows.ForEachAsync(row =>
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            });
            // End sample
        }

        [Fact]
        public async Task ParameterizedQueryAsync_PositionalParameters()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            /// Sample: ParameterizedQueryPositionalParametersAsync
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            BigQueryTable table = await client.GetTableAsync(datasetId, tableId);
            BigQueryCommand command = new BigQueryCommand($"SELECT player, score, level FROM {table} WHERE score >= ? AND level >= ?");
            command.ParameterMode = BigQueryParameterMode.Positional;
            command.Parameters.Add(BigQueryDbType.Int64, 1500); // For score
            command.Parameters.Add(BigQueryDbType.Int64, 2); // For level
            BigQueryResults queryJob = await client.ExecuteQueryAsync(command);
            IAsyncEnumerable<BigQueryRow> resultRows = queryJob.GetRowsAsync();
            await resultRows.ForEachAsync(row =>
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            });
            /// End sample
        }

        [Fact]
        public void CreatePartitionedTable()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = Guid.NewGuid().ToString().Replace("-", "_");

            // Sample: CreatePartitionedTable
            BigQueryClient client = BigQueryClient.Create(projectId);
            TableSchema schema = new TableSchemaBuilder
            {
                { "message", BigQueryDbType.String }
            }.Build();
            CreateTableOptions options = new CreateTableOptions { TimePartitionType = TimePartitionType.Day };
            BigQueryTable table = client.CreateTable(datasetId, tableId, schema, options);
            // Upload a single row to the table, using JSON rather than the streaming buffer, as
            // the _PARTITIONTIME column will be null while it's being served from the streaming buffer.
            // This code assumes the upload succeeds; normally, you should check the job results.
            table.UploadJson(new[] { "{ \"message\": \"Sample message\" }" }).PollUntilCompleted();
            
            BigQueryResults results = client.ExecuteQuery($"SELECT message, _PARTITIONTIME AS pt FROM {table}");
            List<BigQueryRow> rows = results.GetRows().ToList();
            foreach (BigQueryRow row in rows)
            {
                string message = (string) row["message"];
                DateTime partition = (DateTime) row["pt"];
                Console.WriteLine($"Message: {message}; partition: {partition:yyyy-MM-dd}");
            }
            // End sample

            Assert.Equal(1, rows.Count);
        }

        private bool WaitForStreamingBufferToEmpty(string tableId)
        {
            BigQueryClient client = BigQueryClient.Create(_fixture.ProjectId);
            BigQueryTable table = client.GetTable(_fixture.GameDatasetId, tableId);
            for (int i = 0; i < 3 && table.Resource.StreamingBuffer != null; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(10));
                table = client.GetTable(table.Reference);
            }
            return table.Resource.StreamingBuffer == null;
        }

        // TODO: Repeated fields and record types.

        // TODO:
        // Dataset update/patch
        // Table update/patch
    }
}
