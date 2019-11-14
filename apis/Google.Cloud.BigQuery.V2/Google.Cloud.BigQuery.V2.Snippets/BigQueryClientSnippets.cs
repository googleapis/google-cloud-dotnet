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
using Google.Cloud.BigQuery.V2.IntegrationTests;
using Google.Cloud.Storage.V1;
using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using System.Reflection;

namespace Google.Cloud.BigQuery.V2.Snippets
{
    [SnippetOutputCollector]
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
            BigQueryParameter[] parameters = null;
            BigQueryResults results = client.ExecuteQuery(sql, parameters);

            foreach (BigQueryRow row in results)
            {
                Console.WriteLine($"{row["title"]}: {row["unique_words"]}");
            }
            // End sample
        }

        [Fact]
        public void WildcardQuery()
        {
            string projectId = _fixture.ProjectId;

            // Sample: WildcardQuery
            BigQueryClient client = BigQueryClient.Create(projectId);

            string sql = $"SELECT year, mo, da, temp, min, max FROM `bigquery-public-data.noaa_gsod.gsod*` where `max` > 120 and `max` < 121 LIMIT 10";
            BigQueryParameter[] parameters = null;
            BigQueryResults results = client.ExecuteQuery(sql, parameters);

            foreach (BigQueryRow row in results)
            {
                Console.WriteLine($"On {row["year"]}-{row["mo"]}-{row["da"]} the mean temperature was {row["temp"]} with min temperature at {row["min"]} and max temperature at {row["max"]}.");
            }
            // End sample
        }

        [Fact]
        public void DmlSample()
        {
            string projectId = _fixture.ProjectId;

            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Sample: DmlSample
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, tableId);
            BigQueryResults result = client.ExecuteQuery(
                $"UPDATE {table} SET score = score * 2 WHERE DATE(game_started) = @date",
                new[] { new BigQueryParameter("date", BigQueryDbType.Date, new DateTime(2013, 6, 1)) })
                .ThrowOnAnyError();
            Console.WriteLine($"Modified {result.NumDmlAffectedRows} row(s)");
            // End sample

            Assert.Equal(1, result.NumDmlAffectedRows);
        }

        [Fact]
        public void LegacySqlOverview()
        {
            string projectId = _fixture.ProjectId;

            // Sample: LegacySql
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable("bigquery-public-data", "samples", "shakespeare");

            string sql = $"SELECT TOP(corpus, 10) AS title, COUNT(*) AS unique_words FROM {table:legacy}";
            BigQueryParameter[] parameters = null;
            BigQueryResults results = client.ExecuteQuery(sql, parameters, new QueryOptions { UseLegacySql = true });

            foreach (BigQueryRow row in results)
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
            string bucket = _fixture.StorageBucketName;
            string objectName = _fixture.GenerateStorageObjectName();
            StorageClient storageClient = StorageClient.Create();
            byte[] csvData = Encoding.UTF8.GetBytes("Jon,10\nChris,20");
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
            BigQueryParameter[] parameters = null;
            List<BigQueryRow> rows = client.ExecuteQuery($"SELECT name, score FROM {table} ORDER BY score", parameters).ToList();
            foreach (BigQueryRow row in rows)
            {
                Console.WriteLine($"{row["name"]} - {row["score"]}");
            }
            // End sample
            Assert.Equal(2, rows.Count);
            Assert.Equal(new[] { "Jon", "Chris" }, rows.Select(r => (string) r["name"]));
            Assert.Equal(new[] { 10L, 20L }, rows.Select(r => (long) r["score"]));
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

            // Snippet: ExecuteQuery(string,IEnumerable<BigQueryParameter>,*,*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, historyTableId);
            BigQueryResults result = client.ExecuteQuery(
                $@"SELECT player, MAX(score) AS score
                   FROM {table}
                   GROUP BY player
                   ORDER BY score DESC",
                parameters: null);
            foreach (BigQueryRow row in result)
            {
                Console.WriteLine($"{row["player"]}: {row["score"]}");
            }
            // End snippet

            List<string> players = result.Select(r => (string) r["player"]).ToList();
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

        // See-also: CreateDataset(string,CreateDatasetOptions)
        // Member: CreateDataset(DatasetReference, *)
        // Member: CreateDataset(string, string, *)
        // See [CreateDataset](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void GetOrCreateDataset()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GenerateDatasetId();

            // Snippet: GetOrCreateDataset(string, GetDatasetOptions, CreateDatasetOptions)
            BigQueryClient client = BigQueryClient.Create(projectId);
            // If the dataset isn't found, it will be created.
            BigQueryDataset dataset = client.GetOrCreateDataset(datasetId);
            // Now populate tables in the dataset...
            // End snippet

            _fixture.RegisterDatasetToDelete(datasetId);
        }

        // See-also: GetOrCreateDataset(string, GetDatasetOptions, CreateDatasetOptions)
        // Member: GetOrCreateDataset(DatasetReference, *, *)
        // Member: GetOrCreateDataset(string, string, *, *)
        // See [GetOrCreateDataset](ref) for an example using an alternative overload.
        // End see-also

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

            // We only show 20 above, but let's validate that the complete list includes the dataset we want.
            List<string> ids = client.ListDatasets().Select(ds => ds.Reference.DatasetId).ToList();
            Assert.Contains(_fixture.GameDatasetId, ids);
        }

        // See-also: ListDatasets(*)
        // Member: ListDatasets(ProjectReference, *)
        // Member: ListDatasets(string, *)
        // See [ListDatasets](ref) for an example using an alternative overload.
        // End see-also

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

        // See-also: ListTables(string, *)
        // Member: ListTables(DatasetReference, *)
        // Member: ListTables(string, string, *)
        // See [ListTables](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void CreateTable()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.GenerateTableId();

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

        // See-also: CreateTable(string, string, *, *)
        // Member: CreateTable(TableReference, *, *)
        // Member: CreateTable(string, string, string, *, *)
        // See [CreateTable](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void GetOrCreateTable()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.GenerateTableId();

            // Snippet: GetOrCreateTable(string,string,*,*,*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            TableSchema schema = new TableSchemaBuilder
            {
                { "from_player", BigQueryDbType.String },
                { "to_player", BigQueryDbType.String },
                { "message", BigQueryDbType.String }
            }.Build();
            // If the table isn't found, it will be created.
            BigQueryTable table = client.GetOrCreateTable(datasetId, tableId, schema);
            // Now populate the table with data...
            // End snippet

            PagedEnumerable<TableList, BigQueryTable> tables = client.ListTables(datasetId);
            List<string> ids = tables.Select(ds => ds.Reference.TableId).ToList();
            Assert.Contains(tableId, ids);
        }

        // See-also: GetOrCreateTable(string, string, *, *, *)
        // Member: GetOrCreateTable(TableReference, *, *, *)
        // Member: GetOrCreateTable(string, string, string, *, *, *)
        // See [GetOrCreateTable](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void ListRows()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Snippet: ListRows(string, string, *, *)
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

        // See-also: ListRows(string, string, *, *)
        // Member: ListRows(string, string, string, *, *)
        // Member: ListRows(TableReference, *, *)
        // See [ListRows](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void InsertRow()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableWithInsertsId;

            BigQueryTable table = BigQueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: InsertRow(string, string, *, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            // The insert ID is optional; it is autogenerated if not specified.
            BigQueryInsertRow row = new BigQueryInsertRow("row-single")
            {
                { "player", "Jane" },
                { "level", 3 },
                { "score", 3600 },
                { "game_started", DateTime.UtcNow }
            };
            client.InsertRow(datasetId, tableId, row);
            // End snippet

            int actualCount = table.PollUntilRowCountIsAtLeast(rowsBefore + 1);
            Assert.Equal(rowsBefore + 1, actualCount);
        }

        // See-also: InsertRow(string, string, *, *)
        // Member: InsertRow(string, string, string, *, *)
        // Member: InsertRow(TableReference, *, *)
        // See [InsertRow](ref) for an example using an alternative overload.
        // End see-also

        // See-also: InsertRow(string, string, *, *)
        // Member: InsertRowAsync(string, string, string, *, *, *)
        // Member: InsertRowAsync(TableReference, *, *, *)
        // Member: InsertRowAsync(string, string, *, *, *)
        // See [InsertRow](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void InsertRows()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableWithInsertsId;

            BigQueryTable table = BigQueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: InsertRows(string, string, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            // The insert ID is optional; it is autogenerated if not specified.
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

            int actualCount = table.PollUntilRowCountIsAtLeast(rowsBefore + 2);
            Assert.Equal(rowsBefore + 2, actualCount);
        }

        // See-also: InsertRows(string, string, *)
        // Member: InsertRows(string, string, string, *)
        // Member: InsertRows(TableReference, *)
        // Member: InsertRows(string, string, IEnumerable<BigQueryInsertRow>, *)
        // Member: InsertRows(string, string, string, IEnumerable<BigQueryInsertRow>, *)
        // Member: InsertRows(TableReference, IEnumerable<BigQueryInsertRow>, *)
        // See [InsertRows](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void UploadCsv()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableWithInsertsId;

            BigQueryTable table = BigQueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: UploadCsv(string, string, TableSchema, Stream, *)
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
            // columns are in a different order), create a schema to pass into the call, or set
            // options.Autodetect to true.
            TableSchema schema = null;
            BigQueryJob job = client.UploadCsv(datasetId, tableId, schema, stream,
                // Our sample data has a header row, so we need to skip it.
                new UploadCsvOptions { SkipLeadingRows = 1 });
            // Use the job to find out when the data has finished being inserted into the table,
            // report errors etc.
            // End snippet

            AssertJobCompletesSuccessfully(job);
            int rowsAfter = table.ListRows().Count();
            Assert.Equal(rowsBefore + 3, rowsAfter);
        }

        // See-also: UploadCsv(string, string, TableSchema, Stream, *)
        // Member: UploadCsv(string, string, string, TableSchema, Stream, *)
        // Member: UploadCsv(TableReference, TableSchema, Stream, *)
        // See [UploadCsv](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void UploadAvro()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.GenerateTableId();

            var typeInfo = GetType().GetTypeInfo();
            string resourceName = typeInfo.Namespace + ".one_complex.avro";
            var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName);
            // Snippet: UploadAvro(string, string, TableSchema, Stream, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            // This example creates a new table. Any schema provided is ignored, as Avro
            // is self-describing. (The parameter only exists for legacy reasons.)
            BigQueryJob job = client.UploadAvro(datasetId, tableId, null, stream);
            // Use the job to find out when the data has finished being inserted into the table,
            // report errors etc.
            // End snippet

            AssertJobCompletesSuccessfully(job);
        }

        // See-also: UploadAvro(string, string, TableSchema, Stream, *)
        // Member: UploadAvro(TableReference, *, *, *)
        // Member: UploadAvro(string, string, string, *, *, *)
        // See [UploadAvro](ref) for an example using an alternative overload.
        // End see-also

        // See-also: UploadAvro(string, string, *, *, *)
        // Member: UploadAvroAsync(TableReference, *, *, *, *)
        // Member: UploadAvroAsync(string, string, string, *, *, *, *)
        // Member: UploadAvroAsync(string, string, *, *, *, *)
        // See [UploadAvro](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void UploadParquet()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.GenerateTableId();

            var typeInfo = GetType().GetTypeInfo();
            string resourceName = typeInfo.Namespace + ".us-states.parquet";
            var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName);
            // Snippet: UploadParquet(string, string, Stream, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            // This example creates a new table.
            BigQueryJob job = client.UploadParquet(datasetId, tableId, stream);
            // Use the job to find out when the data has finished being inserted into the table,
            // report errors etc.
            // End snippet

            AssertJobCompletesSuccessfully(job);
        }

        // See-also: UploadParquet(string, string, Stream, *)
        // Member: UploadParquet(TableReference, *, *)
        // Member: UploadParquet(string, string, string, *, *)
        // See [UploadParquet](ref) for an example using an alternative overload.
        // End see-also

        // See-also: UploadParquet(string, string, *, *)
        // Member: UploadParquetAsync(TableReference, *, *, *)
        // Member: UploadParquetAsync(string, string, string, *, *, *)
        // Member: UploadParquetAsync(string, string, *, *, *)
        // See [UploadParquet](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void UploadOrc()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.GenerateTableId();

            var typeInfo = GetType().GetTypeInfo();
            string resourceName = typeInfo.Namespace + ".us-states.orc";
            var stream = typeInfo.Assembly.GetManifestResourceStream(resourceName);
            // Snippet: UploadOrc(string, string, Stream, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            // This example creates a new table.
            BigQueryJob job = client.UploadOrc(datasetId, tableId, stream);
            // Use the job to find out when the data has finished being inserted into the table,
            // report errors etc.
            // End snippet

            AssertJobCompletesSuccessfully(job);
        }

        // See-also: UploadOrc(string, string, Stream, *)
        // Member: UploadOrc(TableReference, *, *)
        // Member: UploadOrc(string, string, string, *, *)
        // See [UploadOrc](ref) for an example using an alternative overload.
        // End see-also

        // See-also: UploadOrc(string, string, *, *)
        // Member: UploadOrcAsync(TableReference, *, *, *)
        // Member: UploadOrcAsync(string, string, string, *, *, *)
        // Member: UploadOrcAsync(string, string, *, *, *)
        // See [UploadOrc](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void UploadJson_Stream()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableWithInsertsId;

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
            // create a schema to pass into the call, or set options.Autodetect to true.
            TableSchema schema = null;
            BigQueryJob job = client.UploadJson(datasetId, tableId, schema, stream);
            // Use the job to find out when the data has finished being inserted into the table,
            // report errors etc.
            // End snippet

            AssertJobCompletesSuccessfully(job);
            int rowsAfter = table.ListRows().Count();
            Assert.Equal(rowsBefore + 2, rowsAfter);
        }

        // See-also: UploadJson(string, string, *, Stream, *)
        // Member: UploadJson(TableReference, *, Stream, *)
        // Member: UploadJson(string, string, string, *, Stream, *)
        // See [UploadJson](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void UploadJson_Strings()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableWithInsertsId;

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

            AssertJobCompletesSuccessfully(job);
            int rowsAfter = table.ListRows().Count();
            Assert.Equal(rowsBefore + 2, rowsAfter);
        }

        // See-also: UploadJson(string, string, *, IEnumerable<string>, *)
        // Member: UploadJson(TableReference, *, IEnumerable<string>, *)
        // Member: UploadJson(string, string, string, *, IEnumerable<string>, *)
        // See [UploadJson](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void CreateQueryJob()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string historyTableId = _fixture.HistoryTableId;
            string queryTableId = _fixture.GenerateTableId();

            // Snippet: CreateQueryJob(string,IEnumerable<BigQueryParameter>,*)
            // Additional: GetQueryResults(JobReference, *)
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
                null, // No parameters
                new QueryOptions { DestinationTable = destination });

            // Wait for the job to complete.
            job.PollUntilCompleted();

            // Then we can fetch the results, either via the job or by accessing
            // the destination table.
            BigQueryResults result = client.GetQueryResults(job.Reference);
            foreach (BigQueryRow row in result)
            {
                Console.WriteLine($"{row["player"]}: {row["score"]}");
            }
            // End snippet

            List<string> players = result.Select(r => (string) r["player"]).ToList();
            Assert.Contains("Ben", players);
            Assert.Contains("Nadia", players);
            Assert.Contains("Tim", players);
        }

        // See-also: GetQueryResults(JobReference, *)
        // Member: GetQueryResults(string, *)
        // Member: GetQueryResults(string, string, *)
        // See [GetQueryResults](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void PollJobUntilCompleted()
        {
            string bucket = _fixture.StorageBucketName;
            string objectName = _fixture.GenerateStorageObjectName();

            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Snippet: PollJobUntilCompleted(string, *, *)
            // Just an example of a job: extracting data to Google Cloud Storage.
            BigQueryClient client = BigQueryClient.Create(projectId);
            string destinationUri = $"gs://{bucket}/{objectName}";

            // Start the job running...
            BigQueryJob job = client.CreateExtractJob(projectId, datasetId, tableId, destinationUri);
            string jobId = job.Reference.JobId;
            // Imagine code here to store the ID somewhere, e.g. a database.
            // We later come back and want to wait for the job to complete.

            BigQueryJob completedJob = client.PollJobUntilCompleted(jobId);
            // End snippet

            completedJob.ThrowOnAnyError();
        }

        // See-also: PollJobUntilCompleted(string, *, *)
        // Member: PollJobUntilCompleted(JobReference, *, *)
        // Member: PollJobUntilCompleted(string, string, *, *)
        // See [PollJobUntilCompleted](ref) for an example using an alternative overload.
        // End see-also

        // See-also: PollJobUntilCompleted(string, *, *)
        // Member: PollJobUntilCompletedAsync(JobReference, *, *, *)
        // Member: PollJobUntilCompletedAsync(string, string, *, *, *)
        // Member: PollJobUntilCompletedAsync(string, *, *, *)
        // See [PollJobUntilCompleted](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void CancelJob()
        {
            string bucket = _fixture.StorageBucketName;
            string objectName = _fixture.GenerateStorageObjectName();

            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Snippet: CancelJob(string, *)
            // Just an example of a job: extracting data to Google Cloud Storage.
            BigQueryClient client = BigQueryClient.Create(projectId);
            string destinationUri = $"gs://{bucket}/{objectName}";

            // Start the job running...
            BigQueryJob job = client.CreateExtractJob(projectId, datasetId, tableId, destinationUri);

            // Now cancel it by ID. (Equivalent to calling job.Cancel().)
            string jobId = job.Reference.JobId;
            BigQueryJob canceledJob = client.CancelJob(jobId);
            Console.WriteLine(canceledJob.State);
            // End snippet
        }

        // See-also: CancelJob(string, *)
        // Member: CancelJob(JobReference, *)
        // Member: CancelJob(string, string, *)
        // See [CancelJob](ref) for an example using an alternative overload.
        // End see-also

        // See-also: CancelJob(string, *)
        // Member: CancelJobAsync(JobReference, *, *)
        // Member: CancelJobAsync(string, string, *, *)
        // Member: CancelJobAsync(string, *, *)
        // See [CancelJob](ref) for a synchronous example.
        // End see-also

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

        // See-also: ListJobs(*)
        // Member: ListJobs(string, *)
        // Member: ListJobs(ProjectReference, *)
        // See [ListJobs](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void CreateExtractJob()
        {
            string bucket = _fixture.StorageBucketName;
            string objectName = _fixture.GenerateStorageObjectName();

            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Snippet: CreateExtractJob(string, string, string, string, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            string destinationUri = $"gs://{bucket}/{objectName}";

            BigQueryJob job = client.CreateExtractJob(projectId, datasetId, tableId, destinationUri)
                .PollUntilCompleted();
            // If there are any errors, display them.
            if (job.Status.ErrorResult != null)
            {
                foreach (ErrorProto error in job.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            else
            {
                StorageClient storageClient = StorageClient.Create();
                var obj = storageClient.GetObject(bucket, objectName);
                Console.WriteLine($"Extracted file size: {obj.Size}");
            }
            // End snippet

            job.ThrowOnAnyError();
        }

        // See-also: CreateExtractJob(string, string, string, string, *)
        // Member: CreateExtractJob(string, string, string, *)
        // Member: CreateExtractJob(TableReference, string, *)
        // Member: CreateExtractJob(string, string, string, IEnumerable<string>, *)
        // Member: CreateExtractJob(string, string, IEnumerable<string>, *)
        // Member: CreateExtractJob(TableReference, IEnumerable<string>, *)
        // See [CreateExtractJob](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void CreateCopyJob()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string sourceTableId = _fixture.HistoryTableId;
            string destinationTableId = _fixture.GenerateTableId();

            // Snippet: CreateCopyJob(TableReference, TableReference, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            TableReference sourceTableReference = client.GetTableReference(datasetId, sourceTableId);
            TableReference destinationTableReference = client.GetTableReference(datasetId, destinationTableId);

            BigQueryJob job = client.CreateCopyJob(sourceTableReference, destinationTableReference)
                .PollUntilCompleted();
            // If there are any errors, display them.
            if (job.Status.ErrorResult != null)
            {
                foreach (ErrorProto error in job.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            // End snippet

            job.ThrowOnAnyError();
            var sourceTable = client.GetTable(sourceTableReference);
            var destinationTable = client.GetTable(destinationTableReference);

            var sourceRows = sourceTable.ListRows().Count();
            var destinationRows = destinationTable.ListRows().Count();
            Assert.Equal(sourceRows, destinationRows);
        }

        // See-also: CreateCopyJob(TableReference, TableReference, *)
        // Member: CreateCopyJob(IEnumerable<TableReference>, TableReference, *)
        // See [CreateCopyJob](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void CreateLoadJob()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string originalTableId = _fixture.HistoryTableId;
            string newTableId = _fixture.GenerateTableId();
            string bucket = _fixture.StorageBucketName;
            string objectName = _fixture.GenerateStorageObjectName();
            string objectUri = $"gs://{bucket}/{objectName}";

            // Snippet: CreateLoadJob(string, TableReference, TableSchema, *)
            BigQueryClient client = BigQueryClient.Create(projectId);

            // First extract the data to Google Cloud Storage...
            // (This is just a convenient way of getting data into Google Cloud Storage
            // to demonstrate a load job. If you only wanted to copy a table,
            // you'd create a copy job instead.)
            BigQueryTable table = client.GetTable(datasetId, originalTableId);
            table.CreateExtractJob(objectUri).PollUntilCompleted().ThrowOnAnyError();

            TableReference newTableReference = client.GetTableReference(datasetId, newTableId);

            // Then load it back again, with the same schema.
            // The extracted file will contain a header row: we need to skip it when loading.
            CreateLoadJobOptions options = new CreateLoadJobOptions
            {
                SkipLeadingRows = 1
            };
            BigQueryJob job = client.CreateLoadJob(objectUri, newTableReference, table.Schema, options).PollUntilCompleted();

            // If there are any errors, display them.
            if (job.Status.ErrorResult != null)
            {
                foreach (ErrorProto error in job.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            // End snippet

            job.ThrowOnAnyError();
            var newTable = client.GetTable(newTableReference);

            var sourceRows = table.ListRows().Count();
            var newTableRows = newTable.ListRows().Count();
            Assert.Equal(sourceRows, newTableRows);
        }

        // See-also: CreateLoadJob(string, TableReference, TableSchema, *)
        // Member: CreateLoadJob(IEnumerable<string>, TableReference, TableSchema, *)
        // See [CreateLoadJob](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public void DeleteTable()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.GenerateTableId();
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

        // See-also: DeleteTable(string, string, *)
        // Member: DeleteTable(string, string, string, *)
        // Member: DeleteTable(TableReference, *)
        // See [DeleteTable](ref) for an example using an alternative overload.
        // End see-also

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

        // See-also: DeleteDataset(string, DeleteDatasetOptions)
        // Member: DeleteDataset(DatasetReference, *)
        // Member: DeleteDataset(string, string, *)
        // See [DeleteDataset](ref) for an example using an alternative overload.
        // End see-also

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
            // Additional: ExecuteQuery(string,IEnumerable<BigQueryParameter>,*,*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, tableId);
            string sql = $"SELECT player, score, level FROM {table} WHERE score >= @score AND level >= @level";
            BigQueryParameter[] parameters = new[]
            {
                new BigQueryParameter("level", BigQueryDbType.Int64, 2),
                new BigQueryParameter("score", BigQueryDbType.Int64, 1500)
            };
            BigQueryResults results = client.ExecuteQuery(sql, parameters);
            foreach (BigQueryRow row in results)
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            }
            // End sample

            var resultsList = client.ExecuteQuery(sql, parameters)
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
            string sql = $"SELECT player, score, level FROM {table} WHERE score >= ? AND level >= ?";
            BigQueryParameter[] parameters = new[]
            {
                new BigQueryParameter(BigQueryDbType.Int64, 1500), // For score
                new BigQueryParameter(BigQueryDbType.Int64, 2), // For level
            };
            QueryOptions queryOptions = new QueryOptions { ParameterMode = BigQueryParameterMode.Positional };
            BigQueryResults results = client.ExecuteQuery(sql, parameters, queryOptions);
            foreach (BigQueryRow row in results)
            {
                Console.WriteLine($"Name: {row["player"]}; Score: {row["score"]}; Level: {row["level"]}");
            }
            /// End sample

            // Execute the same command again for validation.
            var resultsList = client.ExecuteQuery(sql, parameters, queryOptions)
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
            BigQueryResults query = await client.ExecuteQueryAsync(sql, parameters: null);

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
            BigQueryParameter[] parameters = null;
            BigQueryResults query = await client.ExecuteQueryAsync(sql, parameters, new QueryOptions { UseLegacySql = true });

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

            // Snippet: ExecuteQueryAsync(string,IEnumerable<BigQueryParameter>,*,*,*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            BigQueryTable table = await client.GetTableAsync(datasetId, historyTableId);
            BigQueryResults result = await client.ExecuteQueryAsync(
                $@"SELECT player, MAX(score) AS score
                   FROM {table}
                   GROUP BY player
                   ORDER BY score DESC",
                parameters: null);
            await result.GetRowsAsync().ForEachAsync(row =>
            {
                Console.WriteLine($"{row["player"]}: {row["score"]}");
            });
            // End snippet

            List<string> players = result.Select(r => (string) r["player"]).ToList();
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

        // See-also: CreateDatasetAsync(string, CreateDatasetOptions, *)
        // Member: CreateDatasetAsync(DatasetReference, *, *)
        // Member: CreateDatasetAsync(string, string, *, *)
        // See [CreateDataset](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task GetOrCreateDatasetAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GenerateDatasetId();

            // Snippet: GetOrCreateDatasetAsync(string, GetDatasetOptions, CreateDatasetOptions, *)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            // If the dataset isn't found, it will be created.
            BigQueryDataset dataset = await client.GetOrCreateDatasetAsync(datasetId);
            // Now populate tables in the dataset...
            // End snippet

            _fixture.RegisterDatasetToDelete(datasetId);
        }

        // See-also: GetOrCreateDatasetAsync(string, GetDatasetOptions, CreateDatasetOptions, *)
        // Member: GetOrCreateDatasetAsync(DatasetReference, *, *, *)
        // Member: GetOrCreateDatasetAsync(string, string, *, *, *)
        // See [GetOrCreateDataset](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task ListDatasetsAsync()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: ListDatasetsAsync(*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            List<BigQueryDataset> datasets = await client.ListDatasetsAsync().Take(20).ToListAsync();
            foreach (BigQueryDataset dataset in datasets)
            {
                Console.WriteLine(dataset.FullyQualifiedId);
            }
            // End snippet

            // We only show 20 above, but let's validate that the complete list includes the dataset we want.
            List<string> ids = await client.ListDatasetsAsync().Select(ds => ds.Reference.DatasetId).ToListAsync();
            Assert.Contains(_fixture.GameDatasetId, ids);
        }

        // See-also: ListDatasetsAsync(*)
        // Member: ListDatasetsAsync(ProjectReference, *)
        // Member: ListDatasetsAsync(string, *)
        // See [ListDatasetsAsync](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task ListTablesAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;

            // Snippet: ListTablesAsync(string,ListTablesOptions)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            List<BigQueryTable> tables = await client.ListTablesAsync(datasetId).Take(20).ToListAsync();
            foreach (BigQueryTable table in tables)
            {
                Console.WriteLine(table.FullyQualifiedId);
            }
            // End snippet

            List<string> ids = tables.Select(ds => ds.Reference.TableId).ToList();
            Assert.Contains(_fixture.HistoryTableId, ids);
        }

        // See-also: ListTablesAsync(string, *)
        // Member: ListTablesAsync(DatasetReference, *)
        // Member: ListTablesAsync(string, string, *)
        // See [ListTablesAsync](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task CreateTableAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.GenerateTableId();

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

        // See-also: CreateTableAsync(string, string, *, *, *)
        // Member: CreateTableAsync(TableReference, *, *, *)
        // Member: CreateTableAsync(string, string, string, *, *, *)
        // See [CreateTableAsync](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task GetOrCreateTableAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.GenerateTableId();

            // Snippet: GetOrCreateTableAsync(string,string,*,*,*,*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            TableSchema schema = new TableSchemaBuilder
            {
                { "from_player", BigQueryDbType.String },
                { "to_player", BigQueryDbType.String },
                { "message", BigQueryDbType.String }
            }.Build();
            // If the table isn't found, it will be created.
            BigQueryTable table = await client.GetOrCreateTableAsync(datasetId, tableId, schema);
            // Now populate the table with data...
            // End snippet

            PagedEnumerable<TableList, BigQueryTable> tables = client.ListTables(datasetId);
            List<string> ids = tables.Select(ds => ds.Reference.TableId).ToList();
            Assert.Contains(tableId, ids);
        }

        // See-also: GetOrCreateTableAsync(string, string, *, *, *, *)
        // Member: GetOrCreateTableAsync(TableReference, *, *, *, *)
        // Member: GetOrCreateTableAsync(string, string, string, *, *, *, *)
        // See [GetOrCreateTableAsync](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task ListRowsAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Snippet: ListRowsAsync(string, string, *, *)
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
            Assert.True(await result.CountAsync() >= 7);
        }

        // See-also: ListRowsAsync(string, string, *, *)
        // Member: ListRowsAsync(string, string, string, *, *)
        // Member: ListRowsAsync(TableReference, *, *)
        // See [ListRowsAsync](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task InsertRowsAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableWithInsertsId;

            BigQueryTable table = BigQueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: InsertRowsAsync(string,string,*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            // The insert ID is optional; it is autogenerated if not specified.
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
            int actualCount = table.PollUntilRowCountIsAtLeast(rowsBefore + 2);
            Assert.Equal(rowsBefore + 2, actualCount);
        }

        // See-also: InsertRowsAsync(string, string, *) 
        // Member: InsertRowsAsync(string, string, string, *)
        // Member: InsertRowsAsync(TableReference, *)
        // Member: InsertRowsAsync(string, string, IEnumerable<BigQueryInsertRow>, *, CancellationToken)
        // Member: InsertRowsAsync(string, string, string, IEnumerable<BigQueryInsertRow>, *, CancellationToken)
        // Member: InsertRowsAsync(TableReference, IEnumerable<BigQueryInsertRow>, *, CancellationToken)
        // See [InsertRowsAsync](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task UploadCsvAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableWithInsertsId;

            BigQueryTable table = BigQueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: UploadCsvAsync(string, string, TableSchema, Stream, *, *)
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
            AssertJobCompletesSuccessfully(job);
            int rowsAfter = table.ListRows().Count();
            Assert.Equal(rowsBefore + 3, rowsAfter);
        }

        // See-also: UploadCsvAsync(string, string, TableSchema, Stream, *, *)
        // Member: UploadCsvAsync(string, string, string, TableSchema, Stream, *, *)
        // Member: UploadCsvAsync(TableReference, TableSchema, Stream, *, *)
        // See [UploadCsvAsync](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task UploadJsonAsync_Stream()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableWithInsertsId;

            BigQueryTable table = BigQueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: UploadJsonAsync(string, string, TableSchema, Stream, *, *)
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

            AssertJobCompletesSuccessfully(job);
            int rowsAfter = table.ListRows().Count();
            Assert.Equal(rowsBefore + 2, rowsAfter);
        }


        // See-also: UploadJsonAsync(string, string, TableSchema, Stream, *, *)
        // Member: UploadJsonAsync(TableReference, *, Stream, *, *)
        // Member: UploadJsonAsync(string, string, string, *, Stream, *, *)
        // See [UploadJson](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task UploadJsonAsync_Strings()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableWithInsertsId;

            BigQueryTable table = BigQueryClient.Create(projectId).GetTable(datasetId, tableId);
            int rowsBefore = table.ListRows().Count();

            // Snippet: UploadJsonAsync(string, string, TableSchema,IEnumerable<string>, *, *)
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

            AssertJobCompletesSuccessfully(job);
            int rowsAfter = table.ListRows().Count();
            Assert.Equal(rowsBefore + 2, rowsAfter);
        }

        // See-also: UploadJsonAsync(string, string, TableSchema,IEnumerable<string>, *, *)
        // Member: UploadJsonAsync(TableReference, *, IEnumerable<string>, *, *)
        // Member: UploadJsonAsync(string, string, string, *, IEnumerable<string>, *, *)
        // See [UploadJson](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task CreateQueryJobAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string historyTableId = _fixture.HistoryTableId;
            string queryTableId = _fixture.GenerateTableId();

            // Snippet: CreateQueryJobAsync(string,IEnumerable<BigQueryParameter>,*,*)
            // Additional: GetQueryResultsAsync(JobReference, *, *)
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
                null, // No parameters
                new QueryOptions { DestinationTable = destination });

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

            List<string> players = result.Select(r => (string) r["player"]).ToList();
            Assert.Contains("Ben", players);
            Assert.Contains("Nadia", players);
            Assert.Contains("Tim", players);
        }

        // See-also: GetQueryResultsAsync(JobReference, *, *)
        // Member: GetQueryResultsAsync(string, *, *)
        // Member: GetQueryResultsAsync(string, string, *, *)
        // See [GetQueryResults](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task ListJobsAsync()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: ListJobsAsync(ListJobsOptions)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            List<BigQueryJob> jobs = await client.ListJobsAsync().Take(20).ToListAsync();
            foreach (BigQueryJob job in jobs)
            {
                Console.WriteLine(job.Reference.JobId);
            }
            // End snippet

            Assert.NotEmpty(jobs);
        }

        // See-also: ListJobsAsync(*)
        // Member: ListJobsAsync(string, *)
        // Member: ListJobsAsync(ProjectReference, *)
        // See [ListJobs](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task CreateExtractJobAsync()
        {
            string bucket = _fixture.StorageBucketName;
            string objectName = _fixture.GenerateStorageObjectName();

            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Snippet: CreateExtractJobAsync(string, string, string, string, *, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            string destinationUri = $"gs://{bucket}/{objectName}";

            BigQueryJob job = await client.CreateExtractJobAsync(projectId, datasetId, tableId, destinationUri);
            job = await job.PollUntilCompletedAsync();
            // If there are any errors, display them.
            if (job.Status.ErrorResult != null)
            {
                foreach (ErrorProto error in job.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            else
            {
                StorageClient storageClient = StorageClient.Create();
                var obj = storageClient.GetObject(bucket, objectName);
                Console.WriteLine($"Extracted file size: {obj.Size}");
            }
            // End snippet

            job.ThrowOnAnyError();
        }

        // See-also: CreateExtractJobAsync(string, string, string, string, *, *)
        // Member: CreateExtractJobAsync(string, string, string, *, *)
        // Member: CreateExtractJobAsync(TableReference, string, *, *)
        // Member: CreateExtractJobAsync(string, string, string, IEnumerable<string>, *, *)
        // Member: CreateExtractJobAsync(string, string, IEnumerable<string>, *, *)
        // Member: CreateExtractJobAsync(TableReference, IEnumerable<string>, *, *)
        // See [CreateExtractJobAsync](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task CreateCopyJobAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string sourceTableId = _fixture.HistoryTableId;
            string destinationTableId = _fixture.GenerateTableId();

            // Snippet: CreateCopyJobAsync(TableReference, TableReference, *, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            TableReference sourceTableReference = client.GetTableReference(datasetId, sourceTableId);
            TableReference destinationTableReference = client.GetTableReference(datasetId, destinationTableId);

            BigQueryJob job = await client.CreateCopyJobAsync(sourceTableReference, destinationTableReference);
            job = await job.PollUntilCompletedAsync();

            // If there are any errors, display them.
            if (job.Status.ErrorResult != null)
            {
                foreach (ErrorProto error in job.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            // End snippet

            job.ThrowOnAnyError();
            var sourceTable = client.GetTable(sourceTableReference);
            var destinationTable = client.GetTable(destinationTableReference);

            var sourceRows = sourceTable.ListRows().Count();
            var destinationRows = destinationTable.ListRows().Count();
            Assert.Equal(sourceRows, destinationRows);
        }

        // See-also: CreateCopyJobAsync(TableReference, TableReference, *, *)
        // Member: CreateCopyJobAsync(IEnumerable<TableReference>, TableReference, *, *)
        // See [CreateCopyJob](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task CreateLoadJobAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string originalTableId = _fixture.HistoryTableId;
            string newTableId = _fixture.GenerateTableId();
            string bucket = _fixture.StorageBucketName;
            string objectName = _fixture.GenerateStorageObjectName();
            string objectUri = $"gs://{bucket}/{objectName}";

            // Snippet: CreateLoadJobAsync(string, TableReference, TableSchema, *, *)
            BigQueryClient client = BigQueryClient.Create(projectId);

            // First extract the data to Google Cloud Storage...
            // (This is just a convenient way of getting data into Google Cloud Storage
            // to demonstrate a load job. If you only wanted to copy a table,
            // you'd create a copy job instead.)
            BigQueryTable table = await client.GetTableAsync(datasetId, originalTableId);
            var extractJob = await table.CreateExtractJobAsync(objectUri);
            extractJob = (await extractJob.PollUntilCompletedAsync()).ThrowOnAnyError();

            TableReference newTableReference = client.GetTableReference(datasetId, newTableId);

            // Then load it back again, with the same schema.
            // The extracted file will contain a header row: we need to skip it when loading.
            CreateLoadJobOptions options = new CreateLoadJobOptions
            {
                SkipLeadingRows = 1
            };
            BigQueryJob job = await client.CreateLoadJobAsync(objectUri, newTableReference, table.Schema, options);
            await job.PollUntilCompletedAsync();

            // If there are any errors, display them.
            if (job.Status.ErrorResult != null)
            {
                foreach (ErrorProto error in job.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            // End snippet

            job.ThrowOnAnyError();
            var newTable = await client.GetTableAsync(newTableReference);

            var sourceRows = await table.ListRowsAsync().CountAsync();
            var newTableRows = await newTable.ListRowsAsync().CountAsync();
            Assert.Equal(sourceRows, newTableRows);
        }

        // See-also: CreateLoadJobAsync(string, TableReference, TableSchema, *, *)
        // Member: CreateLoadJobAsync(IEnumerable<string>, TableReference, TableSchema, *, *)
        // See [CreateLoadJob](ref) for an example using an alternative overload.
        // End see-also

        [Fact]
        public async Task DeleteTableAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.GenerateTableId();
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

        // See-also: DeleteTableAsync(string, string, *, *)
        // Member: DeleteTableAsync(string, string, string, *, *)
        // Member: DeleteTableAsync(TableReference, *, *)
        // See [DeleteTableAsync](ref) for an example using an alternative overload.
        // End see-also

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

        // See-also: DeleteDatasetAsync(string, DeleteDatasetOptions, *)
        // Member: DeleteDatasetAsync(DatasetReference, *, *)
        // Member: DeleteDatasetAsync(string, string, *, *)
        // See [DeleteDatasetAsync](ref) for an example using an alternative overload.
        // End see-also

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
            Assert.Contains(_fixture.ProjectId, await projects.Select(p => p.ProjectId).ToListAsync());
        }

        [Fact]
        public async Task ParameterizedQueryAsync_NamedParameters()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Sample: ParameterizedQueryNamedParametersAsync
            // Additional: ExecuteQueryAsync(string,IEnumerable<BigQueryParameter>,*,*,*)
            BigQueryClient client = await BigQueryClient.CreateAsync(projectId);
            BigQueryTable table = await client.GetTableAsync(datasetId, tableId);
            string sql = $"SELECT player, score, level FROM {table} WHERE score >= @score AND level >= @level";
            BigQueryParameter[] parameters = new[]
            {
                new BigQueryParameter("level", BigQueryDbType.Int64, 2),
                new BigQueryParameter("score", BigQueryDbType.Int64, 1500)
            };
            BigQueryResults queryJob = await client.ExecuteQueryAsync(sql, parameters);
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
            string sql = $"SELECT player, score, level FROM {table} WHERE score >= ? AND level >= ?";
            BigQueryParameter[] parameters = new[]
            {
                new BigQueryParameter(BigQueryDbType.Int64, 1500), // For score
                new BigQueryParameter(BigQueryDbType.Int64, 2), // For level
            };
            BigQueryResults queryJob = await client.ExecuteQueryAsync(sql, parameters,
                new QueryOptions { ParameterMode = BigQueryParameterMode.Positional });
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
            string tableId = _fixture.GenerateTableId();

            // Sample: CreatePartitionedTable
            BigQueryClient client = BigQueryClient.Create(projectId);
            TableSchema schema = new TableSchemaBuilder
            {
                { "message", BigQueryDbType.String }
            }.Build();
            CreateTableOptions options = new CreateTableOptions { TimePartitioning = TimePartition.CreateDailyPartitioning(expiration: null) };
            BigQueryTable table = client.CreateTable(datasetId, tableId, schema, options);
            // Upload a single row to the table, using JSON rather than the streaming buffer, as
            // the _PARTITIONTIME column will be null while it's being served from the streaming buffer.
            // This code assumes the upload succeeds; normally, you should check the job results.
            table.UploadJson(new[] { "{ \"message\": \"Sample message\" }" }).PollUntilCompleted();
            
            BigQueryResults results = client.ExecuteQuery(
                $"SELECT message, _PARTITIONTIME AS pt FROM {table}",
                parameters: null);
            List<BigQueryRow> rows = results.ToList();
            foreach (BigQueryRow row in rows)
            {
                string message = (string) row["message"];
                DateTime partition = (DateTime) row["pt"];
                Console.WriteLine($"Message: {message}; partition: {partition:yyyy-MM-dd}");
            }
            // End sample

            Assert.Equal(1, rows.Count);
        }

        // TODO: Repeated fields and record types.

        // TODO:
        // Job update/patch

        [Fact]
        public void DryRunValidQuery()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Sample: DryRunValidQuery
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(projectId, datasetId, tableId);
            QueryOptions options = new QueryOptions { DryRun = true };
            BigQueryParameter[] parameters = null;
            BigQueryJob job = client.CreateQueryJob($"SELECT player, game_started FROM {table}", parameters, options);
            // There are no rows in the result, but we do have the schema as if we'd run the query.
            TableSchema schema = job.Resource.Statistics.Query.Schema;
            foreach (var field in schema.Fields)
            {
                Console.WriteLine($"{field.Name}: {field.Type}");
            }
            // End sample

            // Although the JobReference itself isn't null, the job ID is, showing that this hasn't
            // created a job.
            Assert.Null(job.Reference.JobId);
        }

        [Fact]
        public void DryRunInvalidQuery()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Sample: DryRunInvalidQuery
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(projectId, datasetId, tableId);
            BigQueryParameter[] parameters = null;
            QueryOptions options = new QueryOptions { DryRun = true };
            // Note deliberate typo in field name
            try
            {
                // Output includes "Unrecognized name: playr; Did you mean player? at [1:8] [400]"
                client.CreateQueryJob($"SELECT playr, game_started FROM {table}", parameters, options);
            }
            catch (GoogleApiException e)
            {
                Console.WriteLine(e.Error);
            }
            // End sample
        }

        [Fact]
        public void UpdateDataset()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GenerateDatasetId();

            BigQueryClient.Create(projectId).CreateDataset(datasetId);

            // Snippet: UpdateDataset(string, Dataset, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryDataset dataset = client.GetDataset(datasetId);
            Dataset resource = dataset.Resource;
            resource.FriendlyName = "Updated dataset";

            // Alternatively, just call dataset.Update(). In either case,
            // the etag in the resource will automatically be used for optimistic concurrency.
            client.UpdateDataset(datasetId, resource);

            // Fetch just to make sure it's really changed...
            BigQueryDataset fetched = client.GetDataset(datasetId);
            Console.WriteLine($"Fetched dataset friendly name: {fetched.Resource.FriendlyName}");
            // End snippet

            Assert.Equal("Updated dataset", fetched.Resource.FriendlyName);
        }

        // See-also: UpdateDataset(string, Dataset, *)
        // Member: UpdateDataset(DatasetReference, Dataset, *)
        // Member: UpdateDataset(string, string, Dataset, *)
        // See [UpdateDataset](ref) for an example using an alternative overload.
        // End see-also

        // See-also: UpdateDataset(string, Dataset, *)
        // Member: UpdateDatasetAsync(DatasetReference, Dataset, *, *)
        // Member: UpdateDatasetAsync(string, Dataset, *, *)
        // Member: UpdateDatasetAsync(string, string, Dataset, *, *)
        // See [UpdateDataset](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void PatchDataset()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GenerateDatasetId();

            BigQueryClient.Create(projectId).CreateDataset(datasetId);

            // Snippet: PatchDataset(string, Dataset, *)
            BigQueryClient client = BigQueryClient.Create(projectId);

            // There's no ETag in this Dataset, so the patch will be applied unconditionally.
            // If we specified an ETag, the patch would only be applied if it matched.
            client.PatchDataset(datasetId, new Dataset { FriendlyName = "Patched dataset" } );

            // Fetch just to make sure it's really changed...
            BigQueryDataset fetched = client.GetDataset(datasetId);
            Console.WriteLine($"Fetched dataset friendly name: {fetched.Resource.FriendlyName}");
            // End snippet

            Assert.Equal("Patched dataset", fetched.Resource.FriendlyName);
        }

        // See-also: PatchDataset(string, Dataset, *)
        // Member: PatchDataset(DatasetReference, Dataset, *)
        // Member: PatchDataset(string, string, Dataset, *)
        // See [PatchDataset](ref) for an example using an alternative overload.
        // End see-also

        // See-also: PatchDataset(string, Dataset, *)
        // Member: PatchDatasetAsync(DatasetReference, Dataset, *, *)
        // Member: PatchDatasetAsync(string, Dataset, *, *)
        // Member: PatchDatasetAsync(string, string, Dataset, *, *)
        // See [PatchDataset](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void UpdateTable()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.GenerateTableId();
            BigQueryClient.Create(projectId).CreateTable(datasetId, tableId, new TableSchema());

            // Snippet: UpdateTable(string,string,*,*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, tableId);
            Table resource = table.Resource;
            resource.FriendlyName = "Updated table";

            // Alternatively, just call table.Update(). In either case,
            // the etag in the resource will automatically be used for optimistic concurrency.
            client.UpdateTable(datasetId, tableId, resource);

            // Fetch just to make sure it's really changed...
            BigQueryTable fetched = client.GetTable(datasetId, tableId);
            Console.WriteLine($"Fetched table friendly name: {fetched.Resource.FriendlyName}");
            // End snippet

            Assert.Equal("Updated table", fetched.Resource.FriendlyName);
        }

        // See-also: UpdateTable(string, string, Table, *)
        // Member: UpdateTable(TableReference, Table, *)
        // Member: UpdateTable(string, string, string, Table, *)
        // See [UpdateTable](ref) for an example using an alternative overload.
        // End see-also

        // See-also: UpdateTable(string, string, Table, *)
        // Member: UpdateTableAsync(TableReference, Table, *, *)
        // Member: UpdateTableAsync(string, string, Table, *, *)
        // Member: UpdateTableAsync(string, string, string, Table, *, *)
        // See [UpdateTable](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void PatchTable()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.GenerateTableId();
            BigQueryClient.Create(projectId).CreateTable(datasetId, tableId, new TableSchema());

            // Snippet: PatchTable(string, string, Table, *)
            BigQueryClient client = BigQueryClient.Create(projectId);

            // There's no ETag in this Table, so the patch will be applied unconditionally.
            // If we specified an ETag, the patch would only be applied if it matched.
            client.PatchTable(datasetId, tableId, new Table { FriendlyName = "Patched table" });

            // Fetch just to make sure it's really changed...
            BigQueryTable fetched = client.GetTable(datasetId, tableId);
            Console.WriteLine($"Fetched table friendly name: {fetched.Resource.FriendlyName}");
            // End snippet

            Assert.Equal("Patched table", fetched.Resource.FriendlyName);
        }

        // See-also: PatchTable(string, string, Table, *)
        // Member: PatchTable(TableReference, Table, *)
        // Member: PatchTable(string, string, string, Table, *)
        // See [PatchTable](ref) for an example using an alternative overload.
        // End see-also

        // See-also: PatchTable(string, string, Table, *)
        // Member: PatchTableAsync(TableReference, Table, *, *)
        // Member: PatchTableAsync(string, string, Table, *, *)
        // Member: PatchTableAsync(string, string, string, Table, *, *)
        // See [PatchTable](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void ClearDatasetLabels()
        {
            // Avoid quota issues: only one dataset modification is allowed per 2 seconds.
            Thread.Sleep(2500);
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;

            // Snippet: ClearDatasetLabels(string, *)
            BigQueryClient client = BigQueryClient.Create(projectId);

            IDictionary<string, string> previousLabels = client.ClearDatasetLabels(datasetId);
            Console.WriteLine("Previous labels:");
            foreach (KeyValuePair<string, string> label in previousLabels)
            {
                Console.WriteLine($"Name: {label.Key}; Value: {label.Value}");
            }
            // End snippet
        }

        // See-also: ClearDatasetLabels(string, *)
        // Member: ClearDatasetLabels(string, string, *)
        // Member: ClearDatasetLabels(DatasetReference, *)
        // See [ClearDatasetLabels](ref) for an example using an alternative overload.
        // End see-also

        // See-also: ClearDatasetLabels(string, *)
        // Member: ClearDatasetLabelsAsync(string, *, *)
        // Member: ClearDatasetLabelsAsync(string, string, *, *)
        // Member: ClearDatasetLabelsAsync(DatasetReference, *, *)
        // See [ClearDatasetLabels](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void SetDatasetLabel()
        {
            // Avoid quota issues: only one dataset modification is allowed per 2 seconds.
            Thread.Sleep(2500);
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;

            // Snippet: SetDatasetLabel(string, string, string, *)
            BigQueryClient client = BigQueryClient.Create(projectId);

            string previousValue = client.SetDatasetLabel(datasetId, "label_name", "new_label_value");
            Console.WriteLine($"Previous label value: {previousValue}");
            // End snippet
        }

        // See-also: SetDatasetLabel(string, string, string, *)
        // Member: SetDatasetLabel(string, string, string, string, *)
        // Member: SetDatasetLabel(DatasetReference, string, string, *)
        // See [SetDatasetLabel](ref) for an example using an alternative overload.
        // End see-also

        // See-also: SetDatasetLabel(string, string, string, *)
        // Member: SetDatasetLabelAsync(string, string, string, *, *)
        // Member: SetDatasetLabelAsync(string, string, string, string, *, *)
        // Member: SetDatasetLabelAsync(DatasetReference, string, string, *, *)
        // See [SetDatasetLabel](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void RemoveDatasetLabel()
        {
            // Avoid quota issues: only one dataset modification is allowed per 2 seconds.
            Thread.Sleep(2500);
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;

            // Snippet: RemoveDatasetLabel(string, string, *)
            BigQueryClient client = BigQueryClient.Create(projectId);

            string previousValue = client.RemoveDatasetLabel(datasetId, "labelName");
            Console.WriteLine($"Previous label value: {previousValue}");
            // End snippet
        }

        // See-also: RemoveDatasetLabel(string, string, *)
        // Member: RemoveDatasetLabel(string, string, string, *)
        // Member: RemoveDatasetLabel(DatasetReference, string, *)
        // See [RemoveDatasetLabel](ref) for an example using an alternative overload.
        // End see-also

        // See-also: RemoveDatasetLabel(string, string, *)
        // Member: RemoveDatasetLabelAsync(string, string, *, *)
        // Member: RemoveDatasetLabelAsync(string, string, string, *, *)
        // Member: RemoveDatasetLabelAsync(DatasetReference, string, *, *)
        // See [RemoveDatasetLabel](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void ModifyDatasetLabels()
        {
            // Avoid quota issues: only one dataset modification is allowed per 2 seconds.
            Thread.Sleep(2500);
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;

            // Snippet: ModifyDatasetLabels(string, IDictionary<string, string>, *)
            BigQueryClient client = BigQueryClient.Create(projectId);

            IDictionary<string, string> modifications = new Dictionary<string, string>
            {
                { "set_me", "x" },    // Label "set_me" will be set to value "x"
                { "remove_me", null } // Label "remove_me" will be removed
            };

            IDictionary<string, string> previousLabels = client.ModifyDatasetLabels(datasetId, modifications);
            Console.WriteLine("Previous values for specified labels:");
            foreach (KeyValuePair<string, string> label in previousLabels)
            {
                Console.WriteLine($"Name: {label.Key}; Value: {label.Value}");
            }
            // End snippet
        }

        // See-also: ModifyDatasetLabels(string, IDictionary<string, string>, *)
        // Member: ModifyDatasetLabels(string, string, IDictionary<string, string>, *)
        // Member: ModifyDatasetLabels(DatasetReference, IDictionary<string, string>, *)
        // See [ModifyDatasetLabels](ref) for an example using an alternative overload.
        // End see-also

        // See-also: ModifyDatasetLabels(string, IDictionary<string, string>, *)
        // Member: ModifyDatasetLabelsAsync(string, IDictionary<string, string>, *, *)
        // Member: ModifyDatasetLabelsAsync(string, string, IDictionary<string, string>, *, *)
        // Member: ModifyDatasetLabelsAsync(DatasetReference, IDictionary<string, string>, *, *)
        // See [ModifyDatasetLabels](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void GetTableReference_NoProject()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: GetTableReference(string, string)
            BigQueryClient client = BigQueryClient.Create(projectId);
            TableReference reference = client.GetTableReference("dataset", "table");
            // ProjectId is defaulted from the client in this overload
            Console.WriteLine(reference.ProjectId);
            // End snippet

            Assert.Equal(projectId, reference.ProjectId);
            Assert.Equal("dataset", reference.DatasetId);
            Assert.Equal("table", reference.TableId);
        }

        [Fact]
        public void GetTableReference_WithProject()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: GetTableReference(string, string, string)
            BigQueryClient client = BigQueryClient.Create(projectId);
            TableReference reference = client.GetTableReference("other-project", "dataset", "table");
            // ProjectId is as specified in the call, not the client's project
            Console.WriteLine(reference.ProjectId);
            // End snippet

            Assert.Equal("other-project", reference.ProjectId);
            Assert.Equal("dataset", reference.DatasetId);
            Assert.Equal("table", reference.TableId);
        }

        [Fact]
        public void GetDatasetReference_NoProject()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: GetDatasetReference(string)
            BigQueryClient client = BigQueryClient.Create(projectId);
            DatasetReference reference = client.GetDatasetReference("dataset");
            // ProjectId is defaulted from the client in this overload
            Console.WriteLine(reference.ProjectId);
            // End snippet

            Assert.Equal(projectId, reference.ProjectId);
            Assert.Equal("dataset", reference.DatasetId);
        }

        [Fact]
        public void GetDatasetReference_WithProject()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: GetDatasetReference(string, string)
            BigQueryClient client = BigQueryClient.Create(projectId);
            DatasetReference reference = client.GetDatasetReference("other-project", "dataset");
            // ProjectId is as specified in the call, not the client's project
            Console.WriteLine(reference.ProjectId);
            // End snippet

            Assert.Equal("other-project", reference.ProjectId);
            Assert.Equal("dataset", reference.DatasetId);
        }

        [Fact]
        public void GetJobReference_NoProject()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: GetJobReference(string)
            BigQueryClient client = BigQueryClient.Create(projectId);
            JobReference reference = client.GetJobReference("job");
            // ProjectId is defaulted from the client in this overload
            Console.WriteLine(reference.ProjectId);
            // End snippet

            Assert.Equal(projectId, reference.ProjectId);
            Assert.Equal("job", reference.JobId);
        }

        [Fact]
        public void GetJobReference_WithProject()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: GetJobReference(string, string)
            BigQueryClient client = BigQueryClient.Create(projectId);
            JobReference reference = client.GetJobReference("other-project", "job");
            // ProjectId is as specified in the call, not the client's project
            Console.WriteLine(reference.ProjectId);
            // End snippet

            Assert.Equal("other-project", reference.ProjectId);
            Assert.Equal("job", reference.JobId);
        }

        [Fact]
        public void GetProjectReference()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: GetProjectReference(string)
            BigQueryClient client = BigQueryClient.Create(projectId);
            ProjectReference reference = client.GetProjectReference("other-project");
            Console.WriteLine(reference.ProjectId);
            // End snippet

            Assert.Equal("other-project", reference.ProjectId);
        }

        [Fact]
        public void GetDataset()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;

            // Snippet: GetDataset(string, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryDataset dataset = client.GetDataset(datasetId);
            Console.WriteLine(dataset.FullyQualifiedId);
            // End snippet
        }

        // See-also: GetDataset(string, *)
        // Member: GetDataset(string, string, *)
        // Member: GetDataset(DatasetReference, *)
        // See [GetDataset](ref) for an example using an alternative overload.
        // End see-also

        // See-also: GetDataset(string, *)
        // Member: GetDatasetAsync(string, *, *)
        // Member: GetDatasetAsync(string, string, *, *)
        // Member: GetDatasetAsync(DatasetReference, *, *)
        // See [GetDataset](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void GetTable()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Snippet: GetTable(string, string, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, tableId);
            Console.WriteLine(table.FullyQualifiedId);
            // End snippet
        }

        // See-also: GetTable(string, string, *)
        // Member: GetTable(string, string, string, *)
        // Member: GetTable(TableReference, *)
        // See [GetTable](ref) for an example using an alternative overload.
        // End see-also

        // See-also: GetTable(string, string, *)
        // Member: GetTableAsync(string, string, *, *)
        // Member: GetTableAsync(string, string, string, *, *)
        // Member: GetTableAsync(TableReference, *, *)
        // See [GetTable](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void GetJob()
        {
            string projectId = _fixture.ProjectId;
            // Just fetch any job ID...
            string jobId = BigQueryClient.Create(projectId).ListJobs().First().Reference.JobId;

            // Snippet: GetJob(string, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryJob job = client.GetJob(jobId);
            Console.WriteLine(job.State);
            // End snippet
        }

        // See-also: GetJob(string, *)
        // Member: GetJob(string, string, *)
        // Member: GetJob(JobReference, *)
        // See [GetJob](ref) for an example using an alternative overload.
        // End see-also

        // See-also: GetJob(string, *)
        // Member: GetJobAsync(string, *, *)
        // Member: GetJobAsync(string, string, *, *)
        // Member: GetJobAsync(JobReference, *, *)
        // See [GetJob](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void GetBigQueryServiceAccountEmail()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: GetBigQueryServiceAccountEmail(*)
            BigQueryClient client = BigQueryClient.Create(projectId);
            string email = client.GetBigQueryServiceAccountEmail();
            Console.WriteLine(email);
            // End snippet
        }

        [Fact]
        public void WithDefaultLocation()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GenerateDatasetId();

            // Snippet: WithDefaultLocation(*)
            BigQueryClient client = BigQueryClient.Create(projectId).WithDefaultLocation(Locations.Tokyo);

            // This dataset will be implicitly created in the Tokyo region. All jobs will also
            // be implicitly created in the Tokyo region.
            BigQueryDataset dataset = client.CreateDataset(datasetId);
            // End snippet
            _fixture.RegisterDatasetToDelete(datasetId);
        }

        // See-also: GetBigQueryServiceAccountEmail(*)
        // Member: GetBigQueryServiceAccountEmail(string, *)
        // Member: GetBigQueryServiceAccountEmail(ProjectReference, *)
        // See [GetBigQueryServiceAccountEmail](ref) for an example using an alternative overload.
        // End see-also

        // See-also: GetBigQueryServiceAccountEmail(*)
        // Member: GetBigQueryServiceAccountEmailAsync(*, *)
        // Member: GetBigQueryServiceAccountEmailAsync(string, *, *)
        // Member: GetBigQueryServiceAccountEmailAsync(ProjectReference, *, *)
        // See [GetBigQueryServiceAccountEmail](ref) for a synchronous example.
        // End see-also

        private void AssertJobCompletesSuccessfully(BigQueryJob job)
        {
            BigQueryJob result = job.PollUntilCompleted();
            // If there are any errors, display them *then* fail.
            if (result.Status.Errors?.Count > 0)
            {
                foreach (ErrorProto error in result.Status.Errors)
                {
                    Console.WriteLine(error.Message);
                }
            }
            result.ThrowOnAnyError();
        }
    }
}
