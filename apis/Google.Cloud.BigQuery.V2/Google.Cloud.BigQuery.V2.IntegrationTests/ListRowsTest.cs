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
            var guid = Guid.NewGuid().ToString();
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
    }
}
