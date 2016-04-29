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
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace Google.Bigquery.V2.IntegrationTests
{
    [Collection(nameof(SampleDatasetFixture))]
    public class UploadTest
    {
        private readonly SampleDatasetFixture _fixture;

        public UploadTest(SampleDatasetFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void UploadCsv()
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);

            string[] csvRows =
            {
                "Name,GameStarted,Score",
                "Ben,2014-08-19T12:41:35.220Z,85",
                "Lucy,2014-08-20T12:41:35.220Z,130",
                "Rohit,2014-08-21T12:41:35.220Z,90"
            };

            var bytes = Encoding.UTF8.GetBytes(string.Join("\n", csvRows));
            
            var table = client.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            var beforeRowCount = table.ListRows().Rows.Count();

            var job = table.UploadCsv(new MemoryStream(bytes));
            var result = job.Poll();
            Assert.Null(result.Status.ErrorResult);

            var afterRows = table.ListRows().Rows.ToList();
            Assert.Equal(beforeRowCount + 3, afterRows.Count);

            var ben = afterRows.Single(row => (string)row["player"] == "Ben");
            Assert.Equal(85, (long)ben["score"]);
            Assert.Equal(new DateTime(2014, 8, 19, 12, 41, 35, 220, DateTimeKind.Utc), (DateTime)ben["gameStarted"]);
        }

        [Fact]
        public void UploadJson()
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);

            // This takes advantage of support for nested objects.
            // We use ' instead of " in the JSON to make it easier to write the string literals, then fix it up.
            var jsonRows = new[]
            {
                "{ 'name': { 'first': 'James', 'last': 'Brock' }, 'address': { 'number': 35, 'street': 'Some road', 'city': 'London' }, 'lastModified': '2015-04-02 13:45:23' }"
            }.Select(x => x.Replace('\'', '"'));

            var bytes = Encoding.UTF8.GetBytes(string.Join("\n", jsonRows));

            var table = client.GetTable(_fixture.DatasetId, _fixture.AddressbookTableId);
            var beforeRowCount = table.ListRows().Rows.Count();

            var job = table.UploadJson(new MemoryStream(bytes));
            var result = job.Poll();
            Assert.Null(result.Status.ErrorResult);

            var afterRows = table.ListRows().Rows.ToList();
            Assert.Equal(beforeRowCount + 1, afterRows.Count);

            // Can't get at nested data using BigqueryResult yet, so use a SQL projection

            var sql = $"SELECT name.first, address.number, address.city, lastModified FROM {table} WHERE name.last='Brock'";
            var flatRows = client.ExecuteQuery(sql).Rows.ToList();
            Assert.Equal(1, flatRows.Count);
            var row = flatRows[0];
            // The result comes back with dots replaced by underscores. It's probably not worth trying to disguise that.
            Assert.Equal("James", (string)row["name_first"]);
            Assert.Equal(35, (long)row["address_number"]);
            Assert.Equal("London", (string)row["address_city"]);
            Assert.Equal(new DateTime(2015, 4, 2, 13, 45, 23, DateTimeKind.Utc), (DateTime)row["lastModified"]);
        }
    }
}
