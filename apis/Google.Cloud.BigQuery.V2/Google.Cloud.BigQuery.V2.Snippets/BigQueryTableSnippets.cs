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
using Google.Cloud.ClientTesting;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(BigQuerySnippetFixture))]
    public class BigQueryTableSnippets
    {
        private readonly BigQuerySnippetFixture _fixture;

        public BigQueryTableSnippets(BigQuerySnippetFixture fixture)
        {
            _fixture = fixture;
        }

        // TODO: Snippets for all the other methods :)

        [Fact]
        public void ListRows()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Snippet: ListRows
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, tableId);
            PagedEnumerable<TableDataList, BigQueryRow> result = table.ListRows();
            foreach (BigQueryRow row in result)
            {
                DateTime timestamp = (DateTime)row["game_started"];
                long level = (long)row["level"];
                long score = (long)row["score"];
                string player = (string)row["player"];
                Console.WriteLine($"{player}: {level}/{score} ({timestamp:yyyy-MM-dd HH:mm:ss})");
            }
            // End snippet

            // We set up 7 results in the fixture. Other tests may add more.
            Assert.True(result.Count() >= 7);
        }

        [Fact]
        public async Task ListRowsAsync()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Snippet: ListRowsAsync
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, tableId);
            PagedAsyncEnumerable<TableDataList, BigQueryRow> result = table.ListRowsAsync();
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
            Assert.True(await result.CountAsync() >= 7);
        }

        [Fact]
        public void Update()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.GenerateTableId();
            BigQueryClient.Create(projectId).CreateTable(datasetId, tableId, new TableSchema());

            // Snippet: Update(Table, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(datasetId, tableId);

            // This example modifies the in-memory resource in the BigQueryDataset,
            // and then applies that change in the server. Alternatively, pass a Dataset
            // into the Update method.
            table.Resource.FriendlyName = "Updated table";
            BigQueryTable updated = table.Update();

            Console.WriteLine($"Updated table friendly name: {updated.Resource.FriendlyName}");
            // End snippet

            Assert.Equal("Updated table", updated.Resource.FriendlyName);
        }

        // See-also: Update(Table, *)
        // Member: UpdateAsync(Table, *, *)
        // See [Update](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void Patch()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.GenerateTableId();
            BigQueryClient.Create(projectId).CreateTable(datasetId, tableId, new TableSchema());

            // Snippet: Patch(Table, bool, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable dataset = client.GetTable(datasetId, tableId);

            // There's no ETag in this Table. The matchETag parameter in the method call
            // determines whether the ETag in the original resource is propagated into the
            // patch.
            Table patch = new Table
            {
                FriendlyName = "Patched table"
            };
            BigQueryTable updated = dataset.Patch(patch, matchETag: true);

            Console.WriteLine($"Patched table friendly name: {updated.Resource.FriendlyName}");
            // End snippet

            Assert.Equal("Patched table", updated.Resource.FriendlyName);
        }

        // See-also: Patch(Table, bool, *)
        // Member: PatchAsync(Table, bool, *, *)
        // See [Patch](ref) for a synchronous example.
        // End see-also

        // See-also: BigQueryClient.UploadCsv(string, string, TableSchema, Stream, *)
        // Member: UploadCsv(*, *)
        // See [BigQueryClient.UploadCsv](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.UploadCsvAsync(string, string, TableSchema, Stream, *, *)
        // Member: UploadCsvAsync(*, *, *)
        // See [BigQueryClient.UploadCsvAsync](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.UploadAvro(string, string, TableSchema, Stream, *)
        // Member: UploadAvro(*, *)
        // Member: UploadAvroAsync(*, *, *)
        // See [BigQueryClient.UploadAvro](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.UploadParquet(string, string, Stream, *)
        // Member: UploadParquet(*, *)
        // Member: UploadParquetAsync(*, *, *)
        // See [BigQueryClient.UploadParquet](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.UploadOrc(string, string, Stream, *)
        // Member: UploadOrc(*, *)
        // Member: UploadOrcAsync(*, *, *)
        // See [BigQueryClient.UploadOrc](ref) for an example using BigQueryClient.
        // End see-also
        
        // See-also: BigQueryClient.UploadJson(string, string, TableSchema, Stream, *)
        // Member: UploadJson(Stream, *)
        // See [BigQueryClient.UploadJson](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.UploadJsonAsync(string, string, TableSchema, Stream, *, *)
        // Member: UploadJsonAsync(Stream, *, *)
        // See [BigQueryClient.UploadJsonAsync](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.UploadJson(string, string, TableSchema, IEnumerable<string>, *)
        // Member: UploadJson(IEnumerable<string>, *)
        // See [BigQueryClient.UploadJson](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.UploadJsonAsync(string, string, TableSchema, IEnumerable<string>, *, *)
        // Member: UploadJsonAsync(IEnumerable<string>, *, *)
        // See [BigQueryClient.UploadJsonAsync](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.InsertRow(string, string, *, *)
        // Member: InsertRow(*, *)
        // Member: InsertRowAsync(*, *, *)
        // See [BigQueryClient.InsertRow](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.InsertRows(string, string, *)
        // Member: InsertRows(*, *)
        // Member: InsertRows(*)
        // See [BigQueryClient.InsertRows](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.InsertRowsAsync(string, string, *)
        // Member: InsertRowsAsync(*, *, *)
        // Member: InsertRowsAsync(*)
        // See [BigQueryClient.InsertRowAsync](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.DeleteTable(string, string, *)
        // Member: Delete(*)
        // See [BigQueryClient.DeleteTable](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.DeleteTableAsync(string, string, *, *)
        // Member: DeleteAsync(*, *)
        // See [BigQueryClient.DeleteTableAsync](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.CreateExtractJob(string, string, string, string, *)
        // Member: CreateExtractJob(string, *)
        // Member: CreateExtractJob(IEnumerable<string>, *)
        // See [BigQueryClient.CreateExtractJob](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.CreateExtractJobAsync(string, string, string, string, *, *)
        // Member: CreateExtractJobAsync(string, *, *)
        // Member: CreateExtractJobAsync(IEnumerable<string>, *, *)
        // See [BigQueryClient.CreateExtractJobAsync](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.CreateCopyJob(TableReference, TableReference, *)
        // Member: CreateCopyJob(TableReference, *)
        // See [BigQueryClient.CreateCopyJob](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.CreateCopyJobAsync(TableReference, TableReference, *, *)
        // Member: CreateCopyJobAsync(TableReference, *, *)
        // See [BigQueryClient.CreateCopyJobAsync](ref) for an example using BigQueryClient.
        // End see-also
    }
}
