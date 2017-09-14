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

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using System.Collections.Generic;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class BigQueryPageTest
    {
        [Fact]
        public void PublicConstructor()
        {
            var rows = new List<BigQueryRow>();
            var schema = new TableSchema();
            var jobReference = new JobReference { ProjectId = "project", JobId = "job" };
            var tableReference = new TableReference { ProjectId = "project", DatasetId = "dataset", TableId = "table" };
            var nextPageToken = "token";
            var page = new BigQueryPage(rows, schema, jobReference, tableReference, nextPageToken);
            Assert.Same(rows, page.Rows);
            Assert.Same(schema, page.Schema);
            Assert.Same(jobReference, page.JobReference);
            Assert.Same(tableReference, page.TableReference);
            Assert.Same(nextPageToken, page.NextPageToken);
        }

        [Fact]
        public void InternalConstructor()
        {
            var nextPageToken = "token";
            var schema = new TableSchema();
            var row = new BigQueryRow(new TableRow(), schema, schema.IndexFieldNames());
            var rawPage = new Page<BigQueryRow>(new List<BigQueryRow> { row }, nextPageToken);
            var jobReference = new JobReference { ProjectId = "project", JobId = "job" };
            var tableReference = new TableReference { ProjectId = "project", DatasetId = "dataset", TableId = "table" };
            var page = new BigQueryPage(rawPage, schema, jobReference, tableReference);
            Assert.Equal(new[] { row }, page.Rows);
            Assert.Same(schema, page.Schema);
            Assert.Same(jobReference, page.JobReference);
            Assert.Same(tableReference, page.TableReference);
            Assert.Same(nextPageToken, page.NextPageToken);
        }
    }
}
