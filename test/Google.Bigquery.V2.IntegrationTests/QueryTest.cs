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
using System.Linq;
using Xunit;

namespace Google.Bigquery.V2.IntegrationTests
{
    public class QueryTest
    {
        private const string PublicDatasetsProject = "bigquery-public-data";
        private const string PublicDatasetsDataset = "samples";
        private const string ShakespeareTable = "shakespeare";

        [Fact]
        public void SynchronousTemporaryQuery()
        {
            // We create the client using our user, but then access a dataset in a public data
            // project. We can't run a query "as" the public data project.
            var projectId = CloudConfiguration.Instance.Project;
            var client = BigqueryClient.Create(projectId);
            var table = client.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);

            var sql = $"SELECT TOP(corpus, 10) as title, COUNT(*) as unique_words FROM {table}";
            var rows = client.ExecuteQuery(sql).Rows.ToList();
            Assert.Equal(10, rows.Count);
            Assert.Equal("hamlet", (string) rows[0]["title"]);
            Assert.Equal(5318, (long) rows[0]["unique_words"]);
        }

        [Fact]
        public void AsynchronousTemporaryQuery()
        {
            // We create the client using our user, but then access a dataset in a public data
            // project. We can't run a query "as" the public data project.
            var projectId = CloudConfiguration.Instance.Project;
            var client = BigqueryClient.Create(projectId);
            var table = client.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);

            var sql = $"SELECT TOP(corpus, 10) as title, COUNT(*) as unique_words FROM {table}";
            var job = client.CreateQueryJob(sql);
            var rows = job.GetQueryResults().Rows.ToList();
            Assert.Equal(10, rows.Count);
            Assert.Equal("hamlet", (string)rows[0]["title"]);
            Assert.Equal(5318, (long)rows[0]["unique_words"]);
        }

        [Fact]
        public void AsynchronousPermanentQuery()
        {
            // We create the client using our user, but then access a dataset in a public data
            // project. We can't run a query "as" the public data project.
            var projectId = CloudConfiguration.Instance.Project;
            var client = BigqueryClient.Create(projectId);
            var table = client.GetTable(PublicDatasetsProject, PublicDatasetsDataset, ShakespeareTable);
            var userDataset = client.GetDataset("demo");

            var sql = $"SELECT TOP(corpus, 10) as title, COUNT(*) as unique_words FROM {table}";
            var destinationTable = userDataset.GetTableReference("test_" + Guid.NewGuid().ToString().Replace("-", "_"));
            var job = client.CreateQueryJob(sql, new CreateQueryJobOptions { DestinationTable = destinationTable });
            var rows = job.GetQueryResults().Rows.ToList();
            Assert.Equal(10, rows.Count);
            Assert.Equal("hamlet", (string)rows[0][0]);
            Assert.Equal(5318, (long)rows[0][1]);

            // Read the table again later - synchronously this time
            table = client.GetTable(destinationTable);
            rows = client.ExecuteQuery($"SELECT * FROM {table}").Rows.ToList();
            Assert.Equal(10, rows.Count);
            Assert.Equal("hamlet", (string)rows[0][0]);
            Assert.Equal(5318, (long)rows[0][1]);
        }
    }
}
