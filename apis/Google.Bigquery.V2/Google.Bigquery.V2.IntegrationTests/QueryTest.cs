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

using System.Linq;
using Xunit;

namespace Google.Bigquery.V2.IntegrationTests
{
    [Collection(nameof(BigqueryFixture))]
    public class QueryTest
    {
        private const string PublicDatasetsProject = "bigquery-public-data";
        private const string PublicDatasetsDataset = "samples";
        private const string ShakespeareTable = "shakespeare";
        private readonly BigqueryFixture _fixture;

        public QueryTest(BigqueryFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void SynchronousTemporaryQuery()
        {
            // We create the client using our user, but then access a dataset in a public data
            // project. We can't run a query "as" the public data project.
            var projectId = _fixture.ProjectId;
            var client = BigqueryClient.Create(projectId);
            var table = client.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);

            var sql = $"SELECT corpus as title, COUNT(word) as unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";
            var rows = client.ExecuteQuery(sql).PollUntilCompleted().GetRows().ToList();
            Assert.Equal(10, rows.Count);
            Assert.Equal("hamlet", (string) rows[0]["title"]);
            Assert.Equal(5318, (long) rows[0]["unique_words"]);
        }

        [Fact]
        public void AsynchronousTemporaryQuery()
        {
            // We create the client using our user, but then access a dataset in a public data
            // project. We can't run a query "as" the public data project.
            var projectId = _fixture.ProjectId;
            var client = BigqueryClient.Create(projectId);
            var table = client.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);

            var sql = $"SELECT corpus as title, COUNT(word) as unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";
            var job = client.CreateQueryJob(sql);
            var rows = job.PollQueryUntilCompleted().GetRows().ToList();
            Assert.Equal(10, rows.Count);
            Assert.Equal("hamlet", (string)rows[0]["title"]);
            Assert.Equal(5318, (long)rows[0]["unique_words"]);
        }

        [Fact]
        public void AsynchronousPermanentQuery()
        {
            // We create the client using our user, but then access a dataset in a public data
            // project. We can't run a query "as" the public data project.
            var projectId = _fixture.ProjectId;
            var client = BigqueryClient.Create(projectId);
            var table = client.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);
            var userDataset = client.GetDataset(_fixture.DatasetId);

            var sql = $"SELECT corpus as title, COUNT(word) as unique_words FROM {table} GROUP BY title ORDER BY unique_words DESC LIMIT 10";
            var destinationTable = userDataset.GetTableReference(_fixture.CreateTableId());
            var job = client.CreateQueryJob(sql, new CreateQueryJobOptions { DestinationTable = destinationTable });
            var rows = job.PollQueryUntilCompleted().GetRows().ToList();
            Assert.Equal(10, rows.Count);
            Assert.Equal("hamlet", (string)rows[0][0]);
            Assert.Equal(5318, (long)rows[0][1]);

            // Read the table again later - synchronously this time
            table = client.GetTable(destinationTable);
            rows = client.ExecuteQuery($"SELECT * FROM {table} ORDER BY unique_words DESC").PollUntilCompleted().GetRows().ToList();
            Assert.Equal(10, rows.Count);
            Assert.Equal("hamlet", (string)rows[0][0]);
            Assert.Equal(5318, (long)rows[0][1]);
        }

        [Fact]
        public void RepeatedFields_Aggregate()
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.PeopleTableId);
            var queryResults = client.ExecuteQuery($"SELECT fullName, ARRAY_LENGTH(children) AS childCount FROM {table} ORDER BY fullName")
                .PollUntilCompleted()
                .GetRows()
                .Select(row => new { Name = (string)row["fullName"], Count = (long)row["childCount"] })
                .ToList();
            var expectedResults = new[]
            {
                new { Name = "Anna Karenina", Count = 0L },
                new { Name = "John Doe", Count = 2L },
                new { Name = "Mike Jones", Count = 3L },
            };
            Assert.Equal(expectedResults, queryResults);
        }

        [Fact]
        public void RepeatedFields_Flattening()
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.PeopleTableId);
            var queryResults = client.ExecuteQuery($"SELECT fullName, child.name AS childName FROM {table} LEFT JOIN UNNEST(children) AS child ORDER BY fullName, childName")
                .PollUntilCompleted()
                .GetRows()
                .Select(row => new { Name = (string)row["fullName"], Child = (string)row["childName"] })
                .ToList();
            var expectedResults = new[]
            {
                new { Name = "Anna Karenina", Child = (string) null },
                new { Name = "John Doe", Child = "Jane" },
                new { Name = "John Doe", Child = "John" },
                new { Name = "Mike Jones", Child = "Earl" },
                new { Name = "Mike Jones", Child = "Kit" },
                new { Name = "Mike Jones", Child = "Sam" }
            };
            Assert.Equal(expectedResults, queryResults);
        }

        [Fact]
        public void RecordField()
        {
            var client = BigqueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.DatasetId, _fixture.PeopleTableId);
            var queryResults = client.ExecuteQuery($"SELECT fullName, phoneNumber.areaCode, phoneNumber.number FROM {table} ORDER BY fullName")
                .PollUntilCompleted()
                .GetRows()
                .Select(row => new { Name = (string)row["fullName"], AreaCode = (long)row["areaCode"], Number = (long)row["number"] })
                .ToList();
            var expectedResults = new[]
            {
                new { Name = "Anna Karenina", AreaCode = 425L, Number = 1984783L },
                new { Name = "John Doe", AreaCode = 206L, Number = 1234567L },
                new { Name = "Mike Jones", AreaCode = 622L, Number = 1567845L }
            };
            Assert.Equal(expectedResults, queryResults);
        }
    }
}
