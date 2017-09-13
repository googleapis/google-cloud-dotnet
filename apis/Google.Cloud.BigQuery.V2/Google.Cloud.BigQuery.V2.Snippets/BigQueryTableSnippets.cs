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
            Assert.True(await result.Count() >= 7);
        }
    }
}
