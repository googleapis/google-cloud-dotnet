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

using System;
using System.Collections.Generic;
using System.Linq;
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
            var table = dataset.GetOrCreateTable("scores", new SchemaBuilder
            {
                { "player", SchemaFieldType.String },
                { "gameStarted", SchemaFieldType.Timestamp },
                { "score", SchemaFieldType.Integer }
            }.Build());

            // Insert a single row. There are many other ways of inserting
            // data into a table.
            table.InsertRow(new Dictionary<string, object>
            {
                { "player", "Bob" },
                { "score", 85 },
                { "gameStarted", new DateTime(2000, 1, 14, 10, 30, 0, DateTimeKind.Utc) }
            });
            // </InsertOverview>
        }
    }
}
