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
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static Google.Apis.Bigquery.v2.Data.DatasetList;
using static Google.Apis.Bigquery.v2.Data.JobList;
using static Google.Apis.Bigquery.v2.Data.ProjectList;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class BigQueryClientImplTest
    {
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
            var dataset = await result.Single();
            Assert.Equal(projectId, dataset.Reference.ProjectId);
        }

        [Fact]
        public async Task CreateDatasetAsync()
        {
            var projectId = "project";
            var datasetId = "dataset";
            var service = new FakeBigqueryService();
            var client = new BigQueryClientImpl(projectId, service);
            var reference = client.GetDatasetReference(projectId, datasetId);
            service.ExpectRequest(
                service.Datasets.Insert(new Dataset { DatasetReference = reference }, projectId),
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
            var dataset = await result.Single();
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
            var job = await result.Single();
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
            var client = new BigQueryClientImpl(projectId, service);
            return client.CreateJob(new JobConfiguration(), options);
        }

        [Fact]
        public void CreateJob_NoOptions()
        {
            var job = CreateJobWithSampleConfiguration(null);
            Assert.Equal("project", job.JobReference.ProjectId);
            Assert.StartsWith(BigQueryClientImpl.DefaultJobIdPrefix, job.JobReference.JobId);
            Assert.NotEqual(BigQueryClientImpl.DefaultJobIdPrefix, job.JobReference.JobId);
        }

        [Fact]
        public void CreateJob_DefaultProjectId()
        {
            var job = CreateJobWithSampleConfiguration(new UploadCsvOptions());
            Assert.Equal("project", job.JobReference.ProjectId);
            Assert.StartsWith(BigQueryClientImpl.DefaultJobIdPrefix, job.JobReference.JobId);
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
    }
}
