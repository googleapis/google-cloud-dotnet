// Copyright 2018 Google Inc. All Rights Reserved.
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

using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Google.Apis.Bigquery.v2.JobsResource.ListRequest;

namespace Google.Cloud.BigQuery.V2.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(BigQuerySnippetFixture))]
    public class JobCreationOptionsSnippets
    {
        private readonly BigQuerySnippetFixture _fixture;

        public JobCreationOptionsSnippets(BigQuerySnippetFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void ListJobs_FilterByLabels()
        {
            string bucketName = _fixture.StorageBucketName;
            string objectName = _fixture.GenerateStorageObjectName();

            string projectId = _fixture.ProjectId;
            string datasetId = _fixture.GameDatasetId;
            string tableId = _fixture.HistoryTableId;

            // Snippet: Labels
            IDictionary<string, string> labels = new Dictionary<string, string>()
            {
                {"label-key", "label-value" }
            };

            BigQueryClient client = BigQueryClient.Create(projectId);
            BigQueryTable table = client.GetTable(projectId, datasetId, tableId);
            string destinationUri = $"gs://{bucketName}/{objectName}";

            // Just a couple examples of jobs marked with labels:
            // (These jobs will most certainly be created somewhere else.)
            // Running a query on a given table.
            BigQueryJob oneLabeledJob = client.CreateQueryJob(
                $"SELECT * FROM {table}", null,
                new QueryOptions { Labels = labels });
            // Extracting data from a table to GCS.
            BigQueryJob anotherLabeledJob = client.CreateExtractJob(
                projectId, datasetId, tableId, destinationUri,
                new CreateExtractJobOptions { Labels = labels });

            // Find jobs marked with a certain label.
            KeyValuePair<string, string> labelToBeFound = labels.First();
            List<BigQueryJob> jobs = client
                .ListJobs(new ListJobsOptions
                {
                    // Specify full projection to make sure that
                    // label information, if it exists, is returned for listed jobs.
                    Projection = ProjectionEnum.Full
                })
                .Where(job => job.Resource.Configuration.Labels?.Contains(labelToBeFound) ?? false)
                .ToList();
            foreach (BigQueryJob job in jobs)
            {
                Console.WriteLine(job.Reference.JobId);
            }
            // End snippet

            // This test added two jobs with such labels, other tests might have
            // added more.
            Assert.True(jobs.Count >= 2);
        }
    }
}
