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

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    /// <summary>
    /// Tests for listing and fetching datasets and tables. These use the public datasets.
    /// </summary>
    public class MetadataExplorationTest
    {
        private const string PublicDatasetsProject = "bigquery-public-data";
        private const string PublicDatasetsDataset = "samples";

        [Fact]
        public void ListDatasets()
        {
            var client = BigQueryClient.Create(PublicDatasetsProject);
            var datasets = client.ListDatasets();
            var datasetIds = datasets.Select(ds => ds.Reference.DatasetId).ToList();

            // Documented set of sample datasets in April 2016. More tables may be added
            // later.
            string[] expectedIds = { "hacker_news", "noaa_gsod", "samples", "usa_names" };
            foreach (var id in expectedIds)
            {
                Assert.Contains(id, datasetIds);
            }
        }

        [Fact]
        public void ListTables()
        {
            var client = BigQueryClient.Create(PublicDatasetsProject);
            var dataset = client.GetDataset(PublicDatasetsDataset);
            var tables = dataset.ListTables();

            var tableIds = tables.Select(table => table.Reference.TableId).ToList();

            // Documented set of sample tables in April 2016. More tables may be added
            // later.
            string[] expectedIds = { "gsod", "github_nested", "github_timeline", "natality", "shakespeare", "trigrams", "wikipedia" };
            foreach (var id in expectedIds)
            {
                Assert.Contains(id, tableIds);
            }
        }

        [Fact]
        public void GetTable_ViaDataset()
        {
            var client = BigQueryClient.Create(PublicDatasetsProject);
            var dataset = client.GetDataset(PublicDatasetsDataset);

            var table = dataset.GetTable("wikipedia");
            Assert.Equal("bigquery-public-data.samples.wikipedia", table.FullyQualifiedId);
        }

        [Fact]
        public void GetTable_FromIds()
        {
            var client = BigQueryClient.Create(PublicDatasetsProject);
            var table = client.GetTable(PublicDatasetsDataset, "wikipedia");

            Assert.Equal("bigquery-public-data.samples.wikipedia", table.FullyQualifiedId);
        }
    }
}
