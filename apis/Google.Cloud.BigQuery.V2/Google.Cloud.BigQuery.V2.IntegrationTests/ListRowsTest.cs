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
using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    /// <summary>
    /// Tests specifically for ListRows functionality, separate to queries.
    /// </summary>
    [Collection(nameof(BigQueryFixture))]
    public class ListRowsTest
    {
        private readonly BigQueryFixture _fixture;

        public ListRowsTest(BigQueryFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void ComplexTypes()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var dataset = client.GetDataset(_fixture.DatasetId);
            var table = dataset.GetTable(_fixture.ComplexTypesTableId);
            var guid = IdGenerator.FromGuid();
            var insertRow = new BigQueryInsertRow
            {
                ["guid"] = guid,
                ["tags"] = new[] { "a", "b" },
                ["position"] = new BigQueryInsertRow { ["x"] = 10L, ["y"] = 20L },
                ["names"] = new[] {
                    new BigQueryInsertRow { ["first"] = "a", ["last"] = "b" },
                    new BigQueryInsertRow { ["first"] = "x", ["last"] = "y" }
                }
            };

            _fixture.InsertAndWait(table, () => table.InsertRow(insertRow), 1);

            var result = table.ListRows();
            var row = result.Single(r => (string)r["guid"] == guid);
            var tags = (string[])row["tags"];
            Assert.Equal(new[] { "a", "b" }, tags);

            var position = (Dictionary<string, object>)row["position"];
            Assert.Equal(new Dictionary<string, object> { ["x"] = 10L, ["y"] = 20L }, position);

            var names = (Dictionary<string, object>[])row["names"];
            Assert.Equal(new[] {
                new Dictionary<string, object> { ["first"] = "a", ["last"] = "b" },
                new Dictionary<string, object> { ["first"] = "x", ["last"] = "y" }
            }, names);
        }

        [Fact]
        public void EmptyTable()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var schema = new TableSchemaBuilder { { "name", BigQueryDbType.String } }.Build();
            var table = client.CreateTable(_fixture.DatasetId, _fixture.CreateTableId(), schema);
            var rows = table.ListRows().ToList();
            Assert.Empty(rows);
        }

        [Fact]
        public void ImplicitPagingWithStartIndex()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            
            // Get them all in one go, skipping the first row
            var rows1 = table.ListRows(new ListRowsOptions { PageSize = 100, StartIndex = 1 }).ToList();

            // Now get them one row at a time, again skipping the first row
            var rows2 = table.ListRows(new ListRowsOptions { PageSize = 1, StartIndex = 1 }).ToList();

            Func<BigQueryRow, string> projection = r => $"{r["gameStarted"]:o} {r["player"]} {r["score"]}";
            Assert.Equal(rows1.Select(projection), rows2.Select(projection));
        }

        [Fact]
        public async Task ListRows_PartialSchema()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            string tableId = _fixture.PeopleTableId;
            var options = new GetTableOptions
            {
                SelectedFields = "age,gender,children.gender,children.age"
            };

            // Obtain the table's partial schema.
            var table = client.GetTable(datasetId, tableId, options);
            // Use the partial schema to obtain partial rows.
            // We are testing both the sync and async versions.
            var rowsAsync = client.ListRowsAsync(datasetId, tableId, table.Schema);
            var rows = client.ListRows(datasetId, tableId, table.Schema);
            // Make sure we grab a row of a person with children for testing fields that should be present.
            var rowAsyncTask = rowsAsync.FirstAsync(row => ((Dictionary<string, object>[])row["children"])?.Length > 0);
            var rowSync = rows.First(row => ((Dictionary<string, object>[])row["children"])?.Length > 0);
            var rowAsync = await rowAsyncTask.ConfigureAwait(false);

            AssertPartialRow(rowSync);
            AssertPartialRow(rowAsync);

            void AssertPartialRow(BigQueryRow row)
            {
                // These should be present
                Assert.NotNull(row["age"]);
                Assert.NotNull(row["gender"]);
                var children = row["children"] as Dictionary<string, object>[];
                Assert.NotNull(children);
                Assert.NotNull(children[0]["gender"]);
                Assert.NotNull(children[0]["age"]);
                // These shouldn't
                Assert.Throws<KeyNotFoundException>(() => row["fullName"]);
                Assert.Throws<KeyNotFoundException>(() => children[0]["name"]);
            }
        }

        [Fact]
        public async Task ListRows_EmptySchema()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            string tableId = _fixture.PeopleTableId;

            // Use an empty schema to obtain the rows.
            // We should get full rows.
            var rowsAsyncTask = client.ListRowsAsync(datasetId, tableId, new TableSchema()).ToListAsync();
            var rowsSync = client.ListRows(datasetId, tableId, new TableSchema()).ToList();
            var rowsAsync = await rowsAsyncTask.ConfigureAwait(false);

            AssertFullRows(rowsSync);
            AssertFullRows(rowsAsync);

            void AssertFullRows(IList<BigQueryRow> rows)
            {
                // The People table has 7 top level fields. We should have all fields.
                object dummy;
                Assert.All(rows, row => dummy = row[6]);
            }
        }
    }
}
