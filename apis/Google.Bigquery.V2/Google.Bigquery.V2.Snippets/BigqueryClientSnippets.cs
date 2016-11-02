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
using Google.Storage.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

            // Sample: QueryOverview
            var client = BigqueryClient.Create(projectId);
            var table = client.GetTable("bigquery-public-data", "samples", "shakespeare");

            string sql = $"SELECT corpus AS title, COUNT(word) AS unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";
            BigqueryQueryJob query = client.ExecuteQuery(sql).PollUntilCompleted();

            foreach (BigqueryRow row in query.GetRows())
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
            var client = BigqueryClient.Create(projectId);
            var table = client.GetTable("bigquery-public-data", "samples", "shakespeare");

            string sql = $"SELECT TOP(corpus, 10) AS title, COUNT(*) AS unique_words FROM {table:legacy}";
            BigqueryQueryJob query = client.ExecuteQuery(sql, new ExecuteQueryOptions { UseLegacySql = true }).PollUntilCompleted();

            foreach (BigqueryRow row in query.GetRows())
            {
                Console.WriteLine($"{row["title"]}: {row["unique_words"]}");
            }
            // End sample
        }

        [Fact]
        public void InsertionOverview()
        {
            string projectId = _fixture.ProjectId;

            // Sample: InsertOverview
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
            // End sample
        }

        [Fact]
        public void ExecuteQuery()
        {
            var projectId = _fixture.ProjectId;
            var datasetId = _fixture.GameDatasetId;
            var historyTableId = _fixture.HistoryTableId;

            // Snippet: ExecuteQuery
            BigqueryClient client = BigqueryClient.Create(projectId);
            BigqueryTable table = client.GetTable(datasetId, historyTableId);
            BigqueryQueryJob result = client.ExecuteQuery(
                $@"SELECT player, MAX(score) AS score
                   FROM {table}
                   GROUP BY player
                   ORDER BY score DESC").PollUntilCompleted();
            foreach (var row in result.GetRows())
            {
                Console.WriteLine($"{row["player"]}: {row["score"]}");
            }
            // End snippet

            var players = result.GetRows().Select(r => (string)r["player"]).ToList();
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
            BigqueryClient client = BigqueryClient.Create(projectId);
            BigqueryDataset dataset = client.CreateDataset(datasetId);
            // Now populate tables in the dataset...
            // End snippet

            _fixture.RegisterDatasetToDelete(datasetId);
        }

        [Fact]
        public void ListDatasets()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: ListDatasets(*)
            BigqueryClient client = BigqueryClient.Create(projectId);
            var datasets = client.ListDatasets().Take(20).ToList();
            foreach (var dataset in datasets)
            {
                Console.WriteLine(dataset.FullyQualifiedId);
            }
            // End snippet

            // Note: if this fails, run the clean-up tool to make sure there
            // are fewer than 20 datasets in the project, then rerun.
            var ids = datasets.Select(ds => ds.Reference.DatasetId).ToList();
            Assert.Contains(_fixture.GameDatasetId, ids);
        }

        [Fact]
        public void ListTables()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;

            // Snippet: ListTables(string,ListTablesOptions)
            BigqueryClient client = BigqueryClient.Create(projectId);
            var tables = client.ListTables(datasetId).Take(20).ToList();
            foreach (var table in tables)
            {
                Console.WriteLine(table.FullyQualifiedId);
            }
            // End snippet

            var ids = tables.Select(ds => ds.Reference.TableId).ToList();
            Assert.Contains(_fixture.HistoryTableId, ids);
        }

        [Fact]
        public void CreateTable()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = Guid.NewGuid().ToString().Replace("-", "_");

            // Snippet: CreateTable(string,string,*,*)
            BigqueryClient client = BigqueryClient.Create(projectId);
            TableSchema schema = new TableSchemaBuilder
            {
                { "from_player", BigqueryDbType.String },
                { "to_player", BigqueryDbType.String },
                { "message", BigqueryDbType.String }
            }.Build();
            BigqueryTable table = client.CreateTable(datasetId, tableId, schema);
            // Now populate the table with data...
            // End snippet

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

            // Snippet: ListRows(*,*,*)
            BigqueryClient client = BigqueryClient.Create(projectId);
            IPagedEnumerable<TableDataList, BigqueryRow> result = client.ListRows(datasetId, tableId);
            foreach (BigqueryRow row in result)
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
        public void Insert()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            BigqueryTable table = BigqueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: Insert(string,string,*)
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

            BigqueryTable table = BigqueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: UploadCsv(*,*,*,*,*)
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
            // End snippet

            var result = job.PollUntilCompleted();
            // If there are any errors, display them *then* fail.
            if (result.Status.ErrorResult != null)
            {
                foreach (var error in result.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Assert.Null(result.Status.ErrorResult);

            int rowsAfter = table.ListRows().Count();
            Assert.Equal(rowsBefore + 3, rowsAfter);
        }

        [Fact]
        public void UploadJson()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            BigqueryTable table = BigqueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: UploadJson(*,*,*,*,*)
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
            // End snippet

            var result = job.PollUntilCompleted();
            // If there are any errors, display them *then* fail.
            if (result.Status.ErrorResult != null)
            {
                foreach (var error in result.Status.Errors)
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
            var projectId = _fixture.ProjectId;
            var datasetId = _fixture.GameDatasetId;
            var historyTableId = _fixture.HistoryTableId;
            var queryTableId = Guid.NewGuid().ToString().Replace('-', '_');

            // Snippet: CreateQueryJob(*,*)
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
            job.PollUntilCompleted();

            // Then we can fetch the results, either via the job or by accessing
            // the destination table.
            BigqueryQueryJob result = client.GetQueryJob(job.Reference);
            foreach (var row in result.GetRows())
            {
                Console.WriteLine($"{row["player"]}: {row["score"]}");
            }
            // End snippet

            var players = result.GetRows().Select(r => (string)r["player"]).ToList();
            Assert.Contains("Ben", players);
            Assert.Contains("Nadia", players);
            Assert.Contains("Tim", players);
        }

        [Fact]
        public void ListJobs()
        {
            var projectId = _fixture.ProjectId;

            // Snippet: ListJobs(*)
            BigqueryClient client = BigqueryClient.Create(projectId);
            var jobs = client.ListJobs().Take(20).ToList();
            foreach (var job in jobs)
            {
                Console.WriteLine(job.Reference.JobId);
            }
            // End snippet

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

            // Sample: ExportCsv
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
            var result = client.PollJobUntilCompleted(job.JobReference);
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
            // End sample

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

            // Sample: CopyTable
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
            client.PollJobUntilCompleted(job.JobReference);

            // Now list its rows
            IPagedEnumerable<TableDataList, BigqueryRow> result = client.ListRows(datasetId, destinationTableId);
            foreach (BigqueryRow row in result)
            {
                DateTime timestamp = (DateTime)row["game_started"];
                long level = (long)row["level"];
                long score = (long)row["score"];
                string player = (string)row["player"];
                Console.WriteLine($"{player}: {level}/{score} ({timestamp:yyyy-MM-dd HH:mm:ss})");
            }
            // End sample

            var originalRows = client.ListRows(datasetId, historyTableId).Count();
            var copiedRows = result.Count();

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
                { "from_player", BigqueryDbType.String },
                { "to_player", BigqueryDbType.String },
                { "message", BigqueryDbType.String }
            }.Build();
            BigqueryClient.Create(projectId).CreateTable(datasetId, tableId, schema);

            // Snippet: DeleteTable(string,string,*)
            BigqueryClient client = BigqueryClient.Create(projectId);
            client.DeleteTable(datasetId, tableId);
            // End snippet

            var tables = client.ListTables(datasetId);
            var ids = tables.Select(ds => ds.Reference.TableId).ToList();
            Assert.DoesNotContain(tableId, ids);
        }

        [Fact]
        public void DeleteDataset()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GenerateDatasetId();
            BigqueryClient.Create(projectId).CreateDataset(datasetId);
            // Snippet: DeleteDataset(string,DeleteDatasetOptions)
            BigqueryClient client = BigqueryClient.Create(projectId);
            client.DeleteDataset(datasetId);
            // End snippet

            var datasets = client.ListDatasets();
            var ids = datasets.Select(ds => ds.Reference.DatasetId).ToList();
            Assert.DoesNotContain(datasetId, ids);
        }

        [Fact]
        public void ListProjects()
        {
            // Snippet: ListProjects(*)
            BigqueryClient client = BigqueryClient.Create("irrelevant");
            IPagedEnumerable<ProjectList, CloudProject> projects = client.ListProjects();
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
            // Sample: ParameterizedQueryNamedParameters
            // Additional: ExecuteQuery(BigqueryCommand,*)
            var client = BigqueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.GameDatasetId, _fixture.HistoryTableId);
            var command = new BigqueryCommand($"SELECT player, score, level FROM {table} WHERE score >= @score AND level >= @level");
            // Note: could also use a collection initializer to populate the parameters.
            command.Parameters.Add("level", BigqueryParameterType.Int64).Value = 2;
            command.Parameters.Add("score", BigqueryParameterType.Int64).Value = 1500;
            IEnumerable<BigqueryRow> queryResults = client.ExecuteQuery(command).PollUntilCompleted().GetRows();
            foreach (BigqueryRow row in queryResults)
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            }
            // End sample

            var resultsList = client.ExecuteQuery(command)
                 .PollUntilCompleted()
                 .GetRows()
                 .Select(row => new { Name = (string)row["player"], Score = (long)row["score"], Level = (long)row["level"] })
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
            /// Sample: ParameterizedQueryPositionalParameters
            var client = BigqueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.GameDatasetId, _fixture.HistoryTableId);
            var command = new BigqueryCommand($"SELECT player, score, level FROM {table} WHERE score >= ? AND level >= ?");
            command.ParameterMode = BigqueryParameterMode.Positional;
            command.Parameters.Add(BigqueryParameterType.Int64, 1500); // For score
            command.Parameters.Add(BigqueryParameterType.Int64, 2); // For level
            IEnumerable<BigqueryRow> queryResults = client.ExecuteQuery(command).PollUntilCompleted().GetRows();
            foreach (BigqueryRow row in queryResults)
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            }
            /// End snippet

            // Execute the same command again for validation.
            var resultsList = client.ExecuteQuery(command)
                .PollUntilCompleted()
                .GetRows()
                .Select(row => new { Name = (string)row["player"], Score = (long)row["score"], Level = (long)row["level"] })
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

            // Sample: QueryOverview
            var client = await BigqueryClient.CreateAsync(projectId);
            var table = await client.GetTableAsync("bigquery-public-data", "samples", "shakespeare");

            string sql = $"SELECT corpus AS title, COUNT(word) AS unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";
            BigqueryQueryJob query = await client.ExecuteQueryAsync(sql);
            query = await query.PollUntilCompletedAsync();

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

            // Sample: LegacySql
            var client = await BigqueryClient.CreateAsync(projectId);
            var table = await client.GetTableAsync("bigquery-public-data", "samples", "shakespeare");

            string sql = $"SELECT TOP(corpus, 10) AS title, COUNT(*) AS unique_words FROM {table:legacy}";
            BigqueryQueryJob query = await client.ExecuteQueryAsync(sql, new ExecuteQueryOptions { UseLegacySql = true });
            query = await query.PollUntilCompletedAsync();

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

            // Sample: InsertOverview
            var client = await BigqueryClient.CreateAsync(projectId);

            // Create the dataset if it doesn't exist.
            var dataset = await client.GetOrCreateDatasetAsync("mydata");

            // Create the table if it doesn't exist.
            var table = await dataset.GetOrCreateTableAsync("scores", new TableSchemaBuilder
            {
                { "player", BigqueryDbType.String },
                { "gameStarted", BigqueryDbType.Timestamp },
                { "score", BigqueryDbType.Integer }
            }.Build());

            // Insert a single row. There are many other ways of inserting
            // data into a table.
            await table.InsertAsync(new InsertRow
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
            var projectId = _fixture.ProjectId;
            var datasetId = _fixture.GameDatasetId;
            var historyTableId = _fixture.HistoryTableId;

            // Snippet: ExecuteQueryAsync
            BigqueryClient client = await BigqueryClient.CreateAsync(projectId);
            BigqueryTable table = await client.GetTableAsync(datasetId, historyTableId);
            BigqueryQueryJob result = await client.ExecuteQueryAsync(
                $@"SELECT player, MAX(score) AS score
                   FROM {table}
                   GROUP BY player
                   ORDER BY score DESC");
            result = await result.PollUntilCompletedAsync();
            await result.GetRowsAsync().ForEachAsync(row =>
            {
                Console.WriteLine($"{row["player"]}: {row["score"]}");
            });
            // End snippet

            var players = result.GetRows().Select(r => (string)r["player"]).ToList();
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
            BigqueryClient client = await BigqueryClient.CreateAsync(projectId);
            BigqueryDataset dataset = await client.CreateDatasetAsync(datasetId);
            // Now populate tables in the dataset...
            // End snippet

            _fixture.RegisterDatasetToDelete(datasetId);
        }

        [Fact]
        public async Task ListDatasetsAsync()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: ListDatasetsAsync(*)
            BigqueryClient client = await BigqueryClient.CreateAsync(projectId);
            var datasets = await client.ListDatasetsAsync().Take(20).ToList();
            foreach (var dataset in datasets)
            {
                Console.WriteLine(dataset.FullyQualifiedId);
            }
            // End snippet

            // Note: if this fails, run the clean-up tool to make sure there
            // are fewer than 20 datasets in the project, then rerun.
            var ids = datasets.Select(ds => ds.Reference.DatasetId).ToList();
            Assert.Contains(_fixture.GameDatasetId, ids);
        }

        [Fact]
        public async Task ListTablesAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;

            // Snippet: ListTablesAsync(string,ListTablesOptions,CancellationToken)
            BigqueryClient client = await BigqueryClient.CreateAsync(projectId);
            var tables = await client.ListTablesAsync(datasetId).Take(20).ToList();
            foreach (var table in tables)
            {
                Console.WriteLine(table.FullyQualifiedId);
            }
            // End snippet

            var ids = tables.Select(ds => ds.Reference.TableId).ToList();
            Assert.Contains(_fixture.HistoryTableId, ids);
        }

        [Fact]
        public async Task CreateTableAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = Guid.NewGuid().ToString().Replace("-", "_");

            // Snippet: CreateTable(string,string,*,*)
            BigqueryClient client = await BigqueryClient.CreateAsync(projectId);
            TableSchema schema = new TableSchemaBuilder
            {
                { "from_player", BigqueryDbType.String },
                { "to_player", BigqueryDbType.String },
                { "message", BigqueryDbType.String }
            }.Build();
            BigqueryTable table = await client.CreateTableAsync(datasetId, tableId, schema);
            // Now populate the table with data...
            // End snippet

            var tables = client.ListTables(datasetId);
            var ids = tables.Select(ds => ds.Reference.TableId).ToList();
            Assert.Contains(tableId, ids);
        }

        [Fact]
        public async Task ListRowsAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Snippet: ListRowsAsync(*,*,*,*)
            BigqueryClient client = await BigqueryClient.CreateAsync(projectId);
            IPagedAsyncEnumerable<TableDataList, BigqueryRow> result = client.ListRowsAsync(datasetId, tableId);
            await result.ForEachAsync(row =>
            {
                DateTime timestamp = (DateTime)row["game_started"];
                long level = (long)row["level"];
                long score = (long)row["score"];
                string player = (string)row["player"];
                Console.WriteLine($"{player}: {level}/{score} ({timestamp:yyyy-MM-dd HH:mm:ss})");
            });
            // End snippet

            // We set up 7 results in the fixture. Other tests may add more.
            Assert.True(await result.Count() >= 7);
        }

        [Fact]
        public async Task InsertAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            BigqueryTable table = BigqueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: InsertAsync(string,string,*,*)
            BigqueryClient client = await BigqueryClient.CreateAsync(projectId);
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
            await client.InsertAsync(datasetId, tableId, row1, row2);
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

            BigqueryTable table = BigqueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: UploadCsvAsync(*,*,*,*,*,*)
            BigqueryClient client = await BigqueryClient.CreateAsync(projectId);
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
            BigqueryJob job = await client.UploadCsvAsync(datasetId, tableId, schema, stream,
                // Our sample data has a header row, so we need to skip it.
                new UploadCsvOptions { SkipLeadingRows = 1 });
            // Use the job to find out when the data has finished being inserted into the table,
            // report errors etc.
            // End snippet

            var result = job.PollUntilCompleted();
            // If there are any errors, display them *then* fail.
            if (result.Status.ErrorResult != null)
            {
                foreach (var error in result.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Assert.Null(result.Status.ErrorResult);

            int rowsAfter = table.ListRows().Count();
            Assert.Equal(rowsBefore + 3, rowsAfter);
        }

        [Fact]
        public async Task UploadJsonAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            BigqueryTable table = BigqueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: UploadJsonAsync(*,*,*,*,*,*)
            BigqueryClient client = await BigqueryClient.CreateAsync(projectId);
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
            BigqueryJob job = await client.UploadJsonAsync(datasetId, tableId, schema, stream);
            // Use the job to find out when the data has finished being inserted into the table,
            // report errors etc.
            // End snippet

            var result = job.PollUntilCompleted();
            // If there are any errors, display them *then* fail.
            if (result.Status.ErrorResult != null)
            {
                foreach (var error in result.Status.Errors)
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
            var projectId = _fixture.ProjectId;
            var datasetId = _fixture.GameDatasetId;
            var historyTableId = _fixture.HistoryTableId;
            var queryTableId = Guid.NewGuid().ToString().Replace('-', '_');

            // Snippet: CreateQueryJobAsync(*,*)
            BigqueryClient client = await BigqueryClient.CreateAsync(projectId);
            BigqueryTable table = await client.GetTableAsync(datasetId, historyTableId);
            TableReference destination = client.GetTableReference(datasetId, queryTableId);
            // If the destination table is not specified, the results will be stored in
            // a temporary table.
            BigqueryJob job = await client.CreateQueryJobAsync(
                $@"SELECT player, MAX(score) AS score
                   FROM {table}
                   GROUP BY player
                   ORDER BY score DESC",
                new CreateQueryJobOptions { DestinationTable = destination });

            // Wait for the job to complete.
            await job.PollUntilCompletedAsync();

            // Then we can fetch the results, either via the job or by accessing
            // the destination table.
            BigqueryQueryJob result = await client.GetQueryJobAsync(job.Reference);
            await result.GetRowsAsync().ForEachAsync(row =>
            {
                Console.WriteLine($"{row["player"]}: {row["score"]}");
            });
            // End snippet

            var players = result.GetRows().Select(r => (string)r["player"]).ToList();
            Assert.Contains("Ben", players);
            Assert.Contains("Nadia", players);
            Assert.Contains("Tim", players);
        }

        [Fact]
        public async Task ListJobsAsync()
        {
            var projectId = _fixture.ProjectId;

            // Snippet: ListJobsAsync(*,*)
            BigqueryClient client = await BigqueryClient.CreateAsync(projectId);
            var jobs = await client.ListJobsAsync().Take(20).ToList();
            foreach (var job in jobs)
            {
                Console.WriteLine(job.Reference.JobId);
            }
            // End snippet

            Assert.NotEmpty(jobs);
        }

        [Fact]
        public async Task ExportCsvAsync()
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

            // Sample: ExportCsvAsync
            BigqueryClient client = await BigqueryClient.CreateAsync(projectId);

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
            var result = await client.PollJobUntilCompletedAsync(job.JobReference);
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
            await storageClient.DownloadObjectAsync(bucket, objectName, stream);
            Console.WriteLine(Encoding.UTF8.GetString(stream.ToArray()));
            // End sample

            storageClient.DeleteObject(bucket, objectName);
            storageClient.DeleteBucket(bucket);
        }

        // TODO: ExportJson
        // TODO: ImportCsv
        // TODO: ImportJson

        [Fact]
        public async Task CopyTableAsync()
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

            // Sample: CopyTableAsync
            BigqueryClient client = await BigqueryClient.CreateAsync(projectId);

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
            IPagedAsyncEnumerable<TableDataList, BigqueryRow> result = client.ListRowsAsync(datasetId, destinationTableId);
            await result.ForEachAsync(row =>
            {
                DateTime timestamp = (DateTime)row["game_started"];
                long level = (long)row["level"];
                long score = (long)row["score"];
                string player = (string)row["player"];
                Console.WriteLine($"{player}: {level}/{score} ({timestamp:yyyy-MM-dd HH:mm:ss})");
            });
            // End sample

            var originalRows = await client.ListRowsAsync(datasetId, historyTableId).Count();
            var copiedRows = await result.Count();

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
                { "from_player", BigqueryDbType.String },
                { "to_player", BigqueryDbType.String },
                { "message", BigqueryDbType.String }
            }.Build();
            BigqueryClient.Create(projectId).CreateTable(datasetId, tableId, schema);

            // Snippet: DeleteTableAsync(string,string,*,*)
            BigqueryClient client = await BigqueryClient.CreateAsync(projectId);
            await client.DeleteTableAsync(datasetId, tableId);
            // End snippet

            var tables = client.ListTables(datasetId);
            var ids = tables.Select(ds => ds.Reference.TableId).ToList();
            Assert.DoesNotContain(tableId, ids);
        }

        [Fact]
        public async Task DeleteDatasetAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GenerateDatasetId();
            BigqueryClient.Create(projectId).CreateDataset(datasetId);
            // Snippet: DeleteDatasetAsync(string,DeleteDatasetOptions,*)
            BigqueryClient client = await BigqueryClient.CreateAsync(projectId);
            await client.DeleteDatasetAsync(datasetId);
            // End snippet

            var datasets = client.ListDatasets();
            var ids = datasets.Select(ds => ds.Reference.DatasetId).ToList();
            Assert.DoesNotContain(datasetId, ids);
        }

        [Fact]
        public async Task ListProjectsAsync()
        {
            // Snippet: ListProjectsAsync(*,*)
            BigqueryClient client = BigqueryClient.Create("irrelevant");
            IPagedAsyncEnumerable<ProjectList, CloudProject> projects = client.ListProjectsAsync();
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
            // Sample: ParameterizedQueryNamedParametersAsync
            // Additional: ExecuteQueryAsync(BigqueryCommand,*,*)
            var client = await BigqueryClient.CreateAsync(_fixture.ProjectId);
            var table = await client.GetTableAsync(_fixture.GameDatasetId, _fixture.HistoryTableId);
            var command = new BigqueryCommand($"SELECT player, score, level FROM {table} WHERE score >= @score AND level >= @level");
            // Note: could also use a collection initializer to populate the parameters.
            command.Parameters.Add("level", BigqueryParameterType.Int64).Value = 2;
            command.Parameters.Add("score", BigqueryParameterType.Int64).Value = 1500;
            BigqueryQueryJob queryJob = await client.ExecuteQueryAsync(command);
            queryJob = await queryJob.PollUntilCompletedAsync();
            IAsyncEnumerable<BigqueryRow> queryResults = queryJob.GetRowsAsync();
            await queryResults.ForEachAsync(row =>
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            });
            // End sample
        }

        [Fact]
        public async Task ParameterizedQueryAsync_PositionalParameters()
        {
            /// Sample: ParameterizedQueryPositionalParameters
            var client = BigqueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.GameDatasetId, _fixture.HistoryTableId);
            var command = new BigqueryCommand($"SELECT player, score, level FROM {table} WHERE score >= ? AND level >= ?");
            command.ParameterMode = BigqueryParameterMode.Positional;
            command.Parameters.Add(BigqueryParameterType.Int64, 1500); // For score
            command.Parameters.Add(BigqueryParameterType.Int64, 2); // For level
            BigqueryQueryJob queryJob = await client.ExecuteQueryAsync(command);
            queryJob = await queryJob.PollUntilCompletedAsync();
            IAsyncEnumerable<BigqueryRow> queryResults = queryJob.GetRowsAsync();
            await queryResults.ForEachAsync(row =>
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            });
            /// End snippet
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
        
        // TODO: Repeated fields and record types.

        // TODO:
        // Dataset update/patch
        // Table update/patch
    }
}
