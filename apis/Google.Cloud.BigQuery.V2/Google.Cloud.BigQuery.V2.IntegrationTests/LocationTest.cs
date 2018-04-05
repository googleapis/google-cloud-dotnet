// Copyright 2018 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
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
    /// Multi-step integration tests for location handling. These are tested with both a default location
    /// and by specifying the location explicitly.
    /// </summary>
    [Collection(nameof(BigQueryFixture))]
    public class LocationTest
    {
        private readonly BigQueryFixture _fixture;

        public LocationTest(BigQueryFixture fixture) => _fixture = fixture;

        [Fact]
        public void WithDefaultLocation()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId).WithDefaultLocation(Locations.Tokyo);

            // Create a dataset; it should be in Tokyo.
            var datasetId = _fixture.CreateDatasetId();
            var dataset = client.CreateDataset(datasetId);
            Assert.Equal(Locations.Tokyo, dataset.Resource.Location);

            // Create a table in the dataset
            var schema = new TableSchemaBuilder
                {
                    { "name", BigQueryDbType.String },
                    { "score", BigQueryDbType.Int64 }
                }.Build();
            var table = dataset.CreateTable("table1", schema);

            // Create a load job; it should be in Tokyo.
            var loadJob = table.UploadJson(new[] { "{\"name\": \"x\", \"score\": 10}" });
            Assert.Equal(Locations.Tokyo, loadJob.Reference.Location);

            // Try to fetch the job in multiple ways
            string jobId = loadJob.Reference.JobId;
            // No location specified; defaults to Tokyo as that's the client default location
            client.GetJob(jobId);
            // Explictly use the US location: this should fail.
            Assert.Throws<GoogleApiException>(() => client.GetJob(client.GetJobReference(_fixture.ProjectId, jobId, Locations.UnitedStates)));
            // Explicitly use Tokyo: this should be fine.
            client.GetJob(client.GetJobReference(_fixture.ProjectId, jobId, Locations.Tokyo));

            // Wait for the job to complete...
            loadJob.PollUntilCompleted();

            // ... then try to cancel it in multiple ways. Cancelling a finished job should not cause an error.
            loadJob.Cancel();
            client.CancelJob(jobId);
            client.CancelJob(client.GetJobReference(_fixture.ProjectId, jobId, Locations.Tokyo));
            // This should fail as the job doesn't exist in the US.
            Assert.Throws<GoogleApiException>(() => client.CancelJob(client.GetJobReference(_fixture.ProjectId, jobId, Locations.UnitedStates)));

            // Perform a query, check it's executing in Tokyo, and wait for it to finish.
            var queryResults = client.ExecuteQuery($"SELECT * FROM {table}", parameters: null);
            Assert.Equal(Locations.Tokyo, queryResults.JobReference.Location);
            var rows = queryResults.ToList();
            Assert.Equal(1, rows.Count);

            // Create a copy job, just to check that the job is created in Tokyo.
            var copyJob = client.CreateCopyJob(table.Reference, dataset.GetTableReference("table2"));
            Assert.Equal(Locations.Tokyo, copyJob.Reference.Location);

            // Create an extract job, just to check that the job is created in Tokyo.
            string bucket = _fixture.StorageBucketName;
            string objectName = _fixture.GenerateStorageObjectName();

            string uri = $"gs://{bucket}/{objectName}";
            var extractJob = client.CreateExtractJob(table.Reference, uri);
            Assert.Equal(Locations.Tokyo, extractJob.Reference.Location);

            // We deliberately don't wait for the jobs to finish. That's not important.
        }

        [Fact]
        public void WithoutDefaultLocation()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);

            // Create a dataset; it should be in Tokyo.
            var datasetId = _fixture.CreateDatasetId();
            var dataset = client.CreateDataset(datasetId, new CreateDatasetOptions { Location = Locations.Tokyo });
            Assert.Equal(Locations.Tokyo, dataset.Resource.Location);

            // Create a table in the dataset
            var schema = new TableSchemaBuilder
                {
                    { "name", BigQueryDbType.String },
                    { "score", BigQueryDbType.Int64 }
                }.Build();
            var table = dataset.CreateTable("table1", schema);

            // Create a load job in Tokyo.
            var loadJob = table.UploadJson(new[] { "{\"name\": \"x\", \"score\": 10}" }, new UploadJsonOptions { JobLocation = Locations.Tokyo });
            Assert.Equal(Locations.Tokyo, loadJob.Reference.Location);

            // Try to fetch the job in multiple ways
            string jobId = loadJob.Reference.JobId;
            // No location specified and no default: this should fail
            Assert.Throws<GoogleApiException>(() => client.GetJob(jobId));
            // Explictly use the US location: this should fail.
            Assert.Throws<GoogleApiException>(() => client.GetJob(client.GetJobReference(_fixture.ProjectId, jobId, Locations.UnitedStates)));
            // Explicitly use Tokyo: this should be fine.
            client.GetJob(client.GetJobReference(_fixture.ProjectId, jobId, Locations.Tokyo));

            // Wait for the job to complete...
            loadJob.PollUntilCompleted();

            // ... then try to cancel it in multiple ways. Cancelling a finished job should not cause an error.
            loadJob.Cancel();
            // This should fail as we're not specifying a location and we don't have a default.
            Assert.Throws<GoogleApiException>(() => client.CancelJob(jobId));
            client.CancelJob(client.GetJobReference(_fixture.ProjectId, jobId, Locations.Tokyo));
            // This should fail as the job doesn't exist in the US.
            Assert.Throws<GoogleApiException>(() => client.CancelJob(client.GetJobReference(_fixture.ProjectId, jobId, Locations.UnitedStates)));

            // Perform a query in Tokyo, check it's executing in Tokyo, and wait for it to finish.
            var queryResults = client.ExecuteQuery($"SELECT * FROM {table}", parameters: null, new QueryOptions { JobLocation = Locations.Tokyo });
            Assert.Equal(Locations.Tokyo, queryResults.JobReference.Location);
            var rows = queryResults.ToList();
            Assert.Equal(1, rows.Count);

            // Create a copy job, just to check that the job is created in Tokyo.
            var copyJob = client.CreateCopyJob(table.Reference, dataset.GetTableReference("table2"), new CreateCopyJobOptions { JobLocation = Locations.Tokyo });
            Assert.Equal(Locations.Tokyo, copyJob.Reference.Location);

            // Create an extract job, just to check that the job is created in Tokyo.
            string bucket = _fixture.StorageBucketName;
            string objectName = _fixture.GenerateStorageObjectName();

            string uri = $"gs://{bucket}/{objectName}";
            var extractJob = client.CreateExtractJob(table.Reference, uri, new CreateExtractJobOptions { JobLocation = Locations.Tokyo });
            Assert.Equal(Locations.Tokyo, extractJob.Reference.Location);

            // We deliberately don't wait for the jobs to finish. That's not important.
        }

    }
}
