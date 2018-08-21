// Copyright 2017 Google Inc. All Rights Reserved.
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
using Google.Cloud.ClientTesting;
using System;
using System.Threading;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(BigQuerySnippetFixture))]
    public class BigQueryDatasetSnippets
    {
        private readonly BigQuerySnippetFixture _fixture;

        public BigQueryDatasetSnippets(BigQuerySnippetFixture fixture) => _fixture = fixture;

        [Fact]
        public void Update()
        {
            // Avoid quota issues: only one dataset modification is allowed per 2 seconds.
            Thread.Sleep(2500);

            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GenerateDatasetId();

            BigQueryClient.Create(projectId).CreateDataset(datasetId);

            // Snippet: Update(Dataset, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryDataset dataset = client.GetDataset(datasetId);

            // This example modifies the in-memory resource in the BigQueryDataset,
            // and then applies that change in the server. Alternatively, pass a Dataset
            // into the Update method.
            dataset.Resource.FriendlyName = "Updated dataset";
            BigQueryDataset updated = dataset.Update();
            
            Console.WriteLine($"Updated dataset friendly name: {updated.Resource.FriendlyName}");
            // End snippet

            Assert.Equal("Updated dataset", updated.Resource.FriendlyName);
        }

        // See-also: Update(Dataset, *)
        // Member: UpdateAsync(Dataset, *, *)
        // See [Update](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void Patch()
        {
            // Avoid quota issues: only one dataset modification is allowed per 2 seconds.
            Thread.Sleep(2500);

            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GenerateDatasetId();

            BigQueryClient.Create(projectId).CreateDataset(datasetId);

            // Snippet: Patch(Dataset, bool, *)
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryDataset dataset = client.GetDataset(datasetId);

            // There's no ETag in this Dataset. The matchETag parameter in the method call
            // determines whether the ETag in the original resource is propagated into the
            // patch.
            Dataset patch = new Dataset
            {
                FriendlyName = "Patched dataset"
            };
            BigQueryDataset updated = dataset.Patch(patch, matchETag: true);

            Console.WriteLine($"Patched dataset friendly name: {updated.Resource.FriendlyName}");
            // End snippet

            Assert.Equal("Patched dataset", updated.Resource.FriendlyName);
        }

        // See-also: Patch(Dataset, bool, *)
        // Member: PatchAsync(Dataset, bool, *, *)
        // See [Patch](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void GetTableReference()
        {
            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;

            // Snippet: GetTableReference
            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryDataset dataset = client.GetDataset(datasetId);
            TableReference reference = dataset.GetTableReference("table");
            Console.WriteLine(reference);
            // End snippet
        }

        // See-also: BigQueryClient.ListTables(string, *)
        // Member: ListTables(*)
        // See [BigQueryClient.ListTables](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.ListTablesAsync(string, *)
        // Member: ListTablesAsync(*)
        // See [BigQueryClient.ListTablesAsync](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.DeleteDataset(string, *)
        // Member: Delete(*)
        // See [BigQueryClient.Delete](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.DeleteDatasetAsync(string, *, *)
        // Member: DeleteAsync(*, *)
        // See [BigQueryClient.DeleteDatasetAsync](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.GetTable(string, string, *)
        // Member: GetTable(string, *)
        // Member: GetTableAsync(string, *, *)
        // See [BigQueryClient.GetTable](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.GetOrCreateTable(string, string, *, *, *)
        // Member: GetOrCreateTable(string, *, *, *)
        // Member: GetOrCreateTableAsync(string, *, *, *, *)
        // See [BigQueryClient.GetOrCreateTable](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.CreateTable(string, string, *, *)
        // Member: CreateTable(string, *, *)
        // See [BigQueryClient.CreateTable](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.CreateTableAsync(string, string, *, *, *)
        // Member: CreateTableAsync(string, *, *, *)
        // See [BigQueryClient.CreateTableAsync](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.UploadCsv(string, string, TableSchema, Stream, *)
        // Member: UploadCsv(string, TableSchema, *, *)
        // See [BigQueryClient.UploadCsv](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.UploadCsvAsync(string, string, TableSchema, Stream, *, *)
        // Member: UploadCsvAsync(string, TableSchema, *, *, *)
        // See [BigQueryClient.UploadCsvAsync](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.UploadAvro(string, string, TableSchema, Stream, *)
        // Member: UploadAvro(string, TableSchema, *, *)
        // Member: UploadAvroAsync(string, TableSchema, *, *, *)
        // See [BigQueryClient.UploadAvro](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.UploadParquet(string, string, Stream, *)
        // Member: UploadParquet(string, *, *)
        // Member: UploadParquetAsync(string, *, *, *)
        // See [BigQueryClient.UploadParquet](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.UploadOrc(string, string, Stream, *)
        // Member: UploadOrc(string, *, *)
        // Member: UploadOrcAsync(string, *, *, *)
        // See [BigQueryClient.UploadOrc](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.UploadJson(string, string, TableSchema, Stream, *)
        // Member: UploadJson(string, TableSchema, Stream, *)
        // See [BigQueryClient.UploadJson](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.UploadJsonAsync(string, string, TableSchema, Stream, *, *)
        // Member: UploadJsonAsync(string, TableSchema, Stream, *, *)
        // See [BigQueryClient.UploadJsonAsync](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.UploadJson(string, string, TableSchema, IEnumerable<string>, *)
        // Member: UploadJson(string, TableSchema, IEnumerable<string>, *)
        // See [BigQueryClient.UploadJson](ref) for an example using BigQueryClient.
        // End see-also

        // See-also: BigQueryClient.UploadJsonAsync(string, string, TableSchema, IEnumerable<string>, *, *)
        // Member: UploadJsonAsync(string, TableSchema, IEnumerable<string>, *, *)
        // See [BigQueryClient.UploadJsonAsync](ref) for an example using BigQueryClient.
        // End see-also
    }
}
