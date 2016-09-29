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

using Google.Api.Gax.Rest;
using Google.Apis.Bigquery.v2.Data;
using System;
using System.Linq;
using Xunit;

namespace Google.Bigquery.V2.Snippets
{
    [Collection(nameof(BigquerySnippetFixture))]
    public class BigqueryTableSnippets
    {
        private readonly BigquerySnippetFixture _fixture;

        public BigqueryTableSnippets(BigquerySnippetFixture fixture)
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
            BigqueryClient client = BigqueryClient.Create(projectId);
            BigqueryTable table = client.GetTable(datasetId, tableId);
            IPagedEnumerable<TableDataList, BigqueryRow> result = table.ListRows();
            foreach (BigqueryRow row in result)
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
    }
}
