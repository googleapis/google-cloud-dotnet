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
using Google.Apis.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using static Google.Apis.Bigquery.v2.Data.DatasetList;
using static Google.Apis.Bigquery.v2.Data.JobList;
using static Google.Apis.Bigquery.v2.Data.ProjectList;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class BigQueryClientImplTest
    {
        // Default location for tests that need one.
        private const string DefaultLocation = "default-location";

        [Fact]
        public void Constructor_DefaultLocations()
        {
            var projectId = "project";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            Assert.Null(client.DefaultLocation);
            client = new BigQueryClientImpl(new ProjectReference { ProjectId = projectId }, service);
            Assert.Null(client.DefaultLocation);

            client = new BigQueryClientImpl(projectId, service, "us");
            Assert.Equal("us", client.DefaultLocation);

            client = new BigQueryClientImpl(new ProjectReference { ProjectId = projectId }, service, "us");
            Assert.Equal("us", client.DefaultLocation);
        }

        [Fact]
        public void WithDefaultLocation()
        {
            var projectId = "project";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service).WithDefaultLocation("us");
            Assert.Same(projectId, client.ProjectId);
            Assert.Same(service, client.Service);
            Assert.Equal("us", client.DefaultLocation);
        }

        [Fact]
        public void ListProjects()
        {
            var projectId = "project";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetProjectReference(projectId);
            service.ExpectRequest(
                service.Projects.List(),
                new ProjectList { Projects = new[] { new ProjectsData { ProjectReference = reference } } });
            var result = client.ListProjects();
            var dataset = result.Single();
            Assert.Equal(projectId, dataset.Reference.ProjectId);
        }

        [Fact]
        public void CreateDataset()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetDatasetReference(projectId, datasetId);
            service.ExpectRequest(
                service.Datasets.Insert(new Dataset { DatasetReference = reference }, projectId),
                new Dataset { DatasetReference = reference });
            var result = client.CreateDataset(reference);
            Assert.Equal(projectId, result.Reference.ProjectId);
            Assert.Equal(datasetId, result.Reference.DatasetId);
        }

        [Fact]
        public void GetDataset()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetDatasetReference(projectId, datasetId);
            service.ExpectRequest(
                service.Datasets.Get(projectId, datasetId),
                new Dataset { DatasetReference = reference });
            var result = client.GetDataset(reference);
            Assert.Equal(projectId, result.Reference.ProjectId);
            Assert.Equal(datasetId, result.Reference.DatasetId);
        }

        [Fact]
        public void GetDataset_FailThenRetry()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetDatasetReference(projectId, datasetId);
            service.ExpectRequest(
                service.Datasets.Get(projectId, datasetId),
                HttpStatusCode.InternalServerError,
                new RequestError { Errors = new[] { new SingleError { Reason = "backendError" } } });
            service.ExpectRequest(
                service.Datasets.Get(projectId, datasetId),
                new Dataset { DatasetReference = reference });
            var result = client.GetDataset(reference);
            service.Verify();
            Assert.Equal(projectId, result.Reference.ProjectId);
            Assert.Equal(datasetId, result.Reference.DatasetId);
        }

        // Effectively testing BigQueryClient.RetryIfETagPresent, but it's hard to test that without
        // making a concrete request via BigQueryClientImpl.
        [Fact]
        public void UpdateDataset_RetryIfETagPresent()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetDatasetReference(projectId, datasetId);
            var dataset = new Dataset { FriendlyName = "Foo", ETag = "\"etag\"" };

            service.ExpectRequest(
                service.Datasets.Update(dataset, projectId, datasetId),
                HttpStatusCode.InternalServerError,
                new RequestError { Errors = new[] { new SingleError { Reason = "backendError" } } });
            service.ExpectRequest(
                service.Datasets.Update(dataset, projectId, datasetId),
                new Dataset { DatasetReference = reference });
            var result = client.UpdateDataset(reference, dataset);
            service.Verify();
            Assert.Equal(projectId, result.Reference.ProjectId);
            Assert.Equal(datasetId, result.Reference.DatasetId);
        }

        [Fact]
        public void UpdateDataset_NoRetryIfETagAbsent()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetDatasetReference(projectId, datasetId);
            var dataset = new Dataset { FriendlyName = "Foo" };

            service.ExpectRequest(
                service.Datasets.Update(dataset, projectId, datasetId),
                HttpStatusCode.InternalServerError,
                new RequestError { Errors = new[] { new SingleError { Reason = "backendError" } } });
            // No second chance...
            var exception = Assert.Throws<GoogleApiException>(() => client.UpdateDataset(reference, dataset));
            Assert.Equal("backendError", exception.Error.Errors[0].Reason);
            service.Verify();
        }

        [Fact]
        public void GetDataset_NonRetriableFailure()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetDatasetReference(projectId, datasetId);
            service.ExpectRequest(
                service.Datasets.Get(projectId, datasetId),
                HttpStatusCode.BadRequest,
                new RequestError { Errors = new[] { new SingleError { Reason = "youCan'tRetryThis" } } });
            Assert.Throws<GoogleApiException>(() => client.GetDataset(reference));
            service.Verify();
        }

        [Fact]
        public void ListDatasets()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var projectReference = client.GetProjectReference(projectId);
            var datasetReference = client.GetDatasetReference(projectId, datasetId);
            service.ExpectRequest(
                service.Datasets.List(projectId),
                new DatasetList { Datasets = new[] { new DatasetsData { DatasetReference = datasetReference } } });
            var result = client.ListDatasets(projectReference);
            var dataset = result.Single();
            Assert.Equal(projectId, dataset.Reference.ProjectId);
            Assert.Equal(datasetId, dataset.Reference.DatasetId);
        }

        [Fact]
        public void DeleteDataset()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetDatasetReference(projectId, datasetId);
            service.ExpectRequest(
                service.Datasets.Delete(projectId, datasetId),
                "OK");
            client.DeleteDataset(reference);
        }

        [Fact]
        public void CreateTable()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var tableId = "table";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetTableReference(projectId, datasetId, tableId);
            var schema = new TableSchemaBuilder { { "column", BigQueryDbType.Int64 } }.Build();
            service.ExpectRequest(
                service.Tables.Insert(new Table { TableReference = reference, Schema = schema }, projectId, datasetId),
                new Table { TableReference = reference, Schema = schema });
            var result = client.CreateTable(reference, schema);
            Assert.Equal(projectId, result.Reference.ProjectId);
            Assert.Equal(datasetId, result.Reference.DatasetId);
            Assert.Equal(tableId, result.Reference.TableId);
            Assert.Equal("column", result.Schema.Fields[0].Name);
        }

        [Fact]
        public void GetTable()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var tableId = "table";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetTableReference(projectId, datasetId, tableId);
            service.ExpectRequest(
                service.Tables.Get(projectId, datasetId, tableId),
                new Table { TableReference = reference });
            var result = client.GetTable(reference);
            Assert.Equal(projectId, result.Reference.ProjectId);
            Assert.Equal(datasetId, result.Reference.DatasetId);
            Assert.Equal(tableId, result.Reference.TableId);
        }

        [Fact]
        public void DeleteTable()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var tableId = "table";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetTableReference(projectId, datasetId, tableId);
            service.ExpectRequest(
                service.Tables.Delete(projectId, datasetId, tableId),
                "OK");
            client.DeleteTable(reference);
        }

        [Fact]
        public void GetJob()
        {
            var projectId = "project";
            var jobId = "job";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetJobReference(projectId, jobId);
            service.ExpectRequest(
                service.Jobs.Get(projectId, jobId),
                new Job { JobReference = reference });
            var result = client.GetJob(reference);
            Assert.Equal(projectId, result.Reference.ProjectId);
            Assert.Equal(jobId, result.Reference.JobId);
        }

        [Fact]
        public void ListJobs()
        {
            var projectId = "project";
            var jobId = "job";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var projectReference = client.GetProjectReference(projectId);
            var jobReference = client.GetJobReference(projectId, jobId);
            service.ExpectRequest(
                service.Jobs.List(projectId),
                new JobList { Jobs = new[] { new JobsData { JobReference = jobReference } } });
            var result = client.ListJobs(projectReference);
            var job = result.Single();
            Assert.Equal(projectId, job.Reference.ProjectId);
            Assert.Equal(jobId, job.Reference.JobId);
        }

        [Fact]
        public void CancelJob()
        {
            var projectId = "project";
            var jobId = "job";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetJobReference(projectId, jobId);
            service.ExpectRequest(
                service.Jobs.Cancel(projectId, jobId),
                new JobCancelResponse { Job = new Job { JobReference = reference } });
            var result = client.CancelJob(reference);
            Assert.Equal(projectId, result.Reference.ProjectId);
            Assert.Equal(jobId, result.Reference.JobId);
        }

        [Fact]
        public async Task ListProjectsAsyncAsync()
        {
            var projectId = "project";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetProjectReference(projectId);
            service.ExpectRequest(
                service.Projects.List(),
                new ProjectList { Projects = new[] { new ProjectsData { ProjectReference = reference } } });
            var result = client.ListProjectsAsync();
            var dataset = await result.SingleAsync();
            Assert.Equal(projectId, dataset.Reference.ProjectId);
        }

        [Fact]
        public async Task CreateDatasetAsync()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service, DefaultLocation);
            var reference = client.GetDatasetReference(projectId, datasetId);
            service.ExpectRequest(
                service.Datasets.Insert(new Dataset { DatasetReference = reference, Location = DefaultLocation }, projectId),
                new Dataset { DatasetReference = reference });
            var result = await client.CreateDatasetAsync(reference);
            Assert.Equal(projectId, result.Reference.ProjectId);
            Assert.Equal(datasetId, result.Reference.DatasetId);
        }

        [Fact]
        public async Task GetDatasetAsync()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetDatasetReference(projectId, datasetId);
            service.ExpectRequest(
                service.Datasets.Get(projectId, datasetId),
                new Dataset { DatasetReference = reference });
            var result = await client.GetDatasetAsync(reference);
            Assert.Equal(projectId, result.Reference.ProjectId);
            Assert.Equal(datasetId, result.Reference.DatasetId);
        }

        [Fact]
        public async Task ListDatasetsAsync()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var projectReference = client.GetProjectReference(projectId);
            var datasetReference = client.GetDatasetReference(projectId, datasetId);
            service.ExpectRequest(
                service.Datasets.List(projectId),
                new DatasetList { Datasets = new[] { new DatasetsData { DatasetReference = datasetReference } } });
            var result = client.ListDatasetsAsync(projectReference);
            var dataset = await result.SingleAsync();
            Assert.Equal(projectId, dataset.Reference.ProjectId);
            Assert.Equal(datasetId, dataset.Reference.DatasetId);
        }

        [Fact]
        public async Task DeleteDatasetAsync()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetDatasetReference(projectId, datasetId);
            service.ExpectRequest(
                service.Datasets.Delete(projectId, datasetId),
                "OK");
            await client.DeleteDatasetAsync(reference);
        }

        [Fact]
        public async Task CreateTableAsync()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var tableId = "table";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetTableReference(projectId, datasetId, tableId);
            var schema = new TableSchemaBuilder { { "column", BigQueryDbType.Int64 } }.Build();
            service.ExpectRequest(
                service.Tables.Insert(new Table { TableReference = reference, Schema = schema }, projectId, datasetId),
                new Table { TableReference = reference, Schema = schema });
            var result = await client.CreateTableAsync(reference, schema);
            Assert.Equal(projectId, result.Reference.ProjectId);
            Assert.Equal(datasetId, result.Reference.DatasetId);
            Assert.Equal(tableId, result.Reference.TableId);
            Assert.Equal("column", result.Schema.Fields[0].Name);
        }

        [Fact]
        public async Task GetTableAsync()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var tableId = "table";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetTableReference(projectId, datasetId, tableId);
            service.ExpectRequest(
                service.Tables.Get(projectId, datasetId, tableId),
                new Table { TableReference = reference });
            var result = await client.GetTableAsync(reference);
            Assert.Equal(projectId, result.Reference.ProjectId);
            Assert.Equal(datasetId, result.Reference.DatasetId);
            Assert.Equal(tableId, result.Reference.TableId);
        }

        [Fact]
        public async Task DeleteTableAsync()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var tableId = "table";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetTableReference(projectId, datasetId, tableId);
            service.ExpectRequest(
                service.Tables.Delete(projectId, datasetId, tableId),
                "OK");
            await client.DeleteTableAsync(reference);
        }

        [Fact]
        public async Task GetJobAsync()
        {
            var projectId = "project";
            var jobId = "job";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetJobReference(projectId, jobId);
            service.ExpectRequest(
                service.Jobs.Get(projectId, jobId),
                new Job { JobReference = reference });
            var result = await client.GetJobAsync(reference);
            Assert.Equal(projectId, result.Reference.ProjectId);
            Assert.Equal(jobId, result.Reference.JobId);
        }

        [Fact]
        public async Task ListJobsAsync()
        {
            var projectId = "project";
            var jobId = "job";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var projectReference = client.GetProjectReference(projectId);
            var jobReference = client.GetJobReference(projectId, jobId);
            service.ExpectRequest(
                service.Jobs.List(projectId),
                new JobList { Jobs = new[] { new JobsData { JobReference = jobReference } } });
            var result = client.ListJobsAsync(projectReference);
            var job = await result.SingleAsync();
            Assert.Equal(projectId, job.Reference.ProjectId);
            Assert.Equal(jobId, job.Reference.JobId);
        }

        [Fact]
        public async Task CancelJobAsync()
        {
            var projectId = "project";
            var jobId = "job";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetJobReference(projectId, jobId);
            service.ExpectRequest(
                service.Jobs.Cancel(projectId, jobId),
                new JobCancelResponse { Job = new Job { JobReference = reference } });
            var result = await client.CancelJobAsync(reference);
            Assert.Equal(projectId, result.Reference.ProjectId);
            Assert.Equal(jobId, result.Reference.JobId);
        }

        private Job CreateJobWithSampleConfiguration(JobCreationOptions options)
        {
            var projectId = "project";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service, DefaultLocation);
            return client.CreateJob(new JobConfiguration(), options);
        }

        [Fact]
        public void CreateJob_NoOptions()
        {
            var job = CreateJobWithSampleConfiguration(null);
            Assert.Equal("project", job.JobReference.ProjectId);
            Assert.StartsWith(BigQueryClientImpl.DefaultJobIdPrefix, job.JobReference.JobId);
            Assert.NotEqual(BigQueryClientImpl.DefaultJobIdPrefix, job.JobReference.JobId);
            Assert.Equal(DefaultLocation, job.JobReference.Location);
            // Don't really care if Configuration is null or not, Labels needs to be null.
            Assert.Null(job.Configuration?.Labels);
        }

        [Fact]
        public void CreateJob_DefaultConfiguration()
        {
            var job = CreateJobWithSampleConfiguration(new UploadCsvOptions());
            Assert.Equal("project", job.JobReference.ProjectId);
            Assert.StartsWith(BigQueryClientImpl.DefaultJobIdPrefix, job.JobReference.JobId);
            Assert.Equal(DefaultLocation, job.JobReference.Location);
            // Don't really care if Configuration is null or not, Labels needs to be null.
            Assert.Null(job.Configuration?.Labels);
        }

        [Fact]
        public void CreateJob_CustomProjectId()
        {
            var job = CreateJobWithSampleConfiguration(new UploadCsvOptions { ProjectId = "custom_project" });
            Assert.Equal("custom_project", job.JobReference.ProjectId);
            Assert.StartsWith(BigQueryClientImpl.DefaultJobIdPrefix, job.JobReference.JobId);
        }

        [Fact]
        public void CreateJob_CustomJobIdPrefix()
        {
            var job = CreateJobWithSampleConfiguration(new UploadCsvOptions { JobIdPrefix = "custom_prefix" });
            Assert.Equal("project", job.JobReference.ProjectId);
            Assert.StartsWith("custom_prefix", job.JobReference.JobId);
            // Check that it's only a prefix...
            Assert.NotEqual("custom_prefix", job.JobReference.JobId);
        }

        [Fact]
        public void CreateJob_CustomJobId()
        {
            var job = CreateJobWithSampleConfiguration(new UploadCsvOptions { JobId = "custom_job_id" });
            Assert.Equal("project", job.JobReference.ProjectId);
            Assert.Equal("custom_job_id", job.JobReference.JobId);
        }

        [Fact]
        public void CreateJob_BothJobIdAndPrefix()
        {
            var options = new UploadCsvOptions { JobIdPrefix = "prefix", JobId = "id" };
            Assert.Throws<ArgumentException>(() => CreateJobWithSampleConfiguration(options));
        }

        [Fact]
        public void CreateJob_CustomLocation()
        {
            var job = CreateJobWithSampleConfiguration(new UploadCsvOptions { JobLocation = "custom-location" });
            Assert.Equal("custom-location", job.JobReference.Location);
        }

        [Fact]
        public void CreateJob_Labels()
        {
            var options = new UploadCsvOptions
            {
                Labels = new Dictionary<string, string>()
                {
                    { "one_label", "one-label-value" },
                    { "another-label_2", "label_value_2" }
                }
            };
            var job = CreateJobWithSampleConfiguration(options);

            Assert.Equal(2, job.Configuration.Labels.Count);
            Assert.Equal("one-label-value", job.Configuration.Labels["one_label"]);
            Assert.Equal("label_value_2", job.Configuration.Labels["another-label_2"]);
        }

        [Fact]
        public void ListTablesConversion()
        {
            var listResource = new TableList.TablesData
            {
                FriendlyName = "friendly name",
                Id = "id",
                Kind = "Table",
                Labels = new Dictionary<string, string> { { "x", "y" } },
                TableReference = new TableReference { DatasetId = "dataset", TableId = "id", ProjectId = "project" },
                TimePartitioning = new TimePartitioning { ExpirationMs = 10000, Type = "DAY" },
                Type = "VIEW",
                View = new TableList.TablesData.ViewData { UseLegacySql = true },
                Clustering = new Clustering { Fields = new[] { "ClusterCol1", "ClusterCol2" } },
                CreationTime = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds,
                ExpirationTime = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds
            };
            var tableResource = BigQueryClientImpl.TablePageManager.ConvertResource(listResource);
            Assert.Equal("friendly name", tableResource.FriendlyName);
            Assert.Equal("id", tableResource.Id);
            Assert.Equal("Table", tableResource.Kind);
            Assert.Equal("y", tableResource.Labels["x"]);
            Assert.Same(listResource.TableReference, tableResource.TableReference);
            Assert.Equal("VIEW", tableResource.Type);
            Assert.True(tableResource.View.UseLegacySql);
            Assert.Equal(listResource.Clustering.Fields, tableResource.Clustering.Fields);
            Assert.Equal(listResource.CreationTime, tableResource.CreationTime);
            Assert.Equal(listResource.ExpirationTime, tableResource.ExpirationTime);
        }

        [Fact]
        public void InsertRows_NoRows_NoOp()
        {
            // We don't set up any expected requests, so if the client issues any, the test will fail.
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl("project", service);
            client.InsertRows("dataset", "table", new BigQueryInsertRow[0]);
        }

        [Fact]
        public async Task InsertRowsAsync_NoRows_NoOp()
        {
            // We don't set up any expected requests, so if the client issues any, the test will fail.
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl("project", service);
            await client.InsertRowsAsync("dataset", "table", new BigQueryInsertRow[0]);
        }
    }
}
