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

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    public abstract partial class BigQueryClient
    {
        #region ListJobs
        /// <summary>
        /// Lists the jobs within this client's project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListJobs(ProjectReference, ListJobsOptions)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of the jobs within this project.</returns>
        public virtual PagedEnumerable<JobList, BigQueryJob> ListJobs(ListJobsOptions options = null) =>
            ListJobs(GetProjectReference(ProjectId), options);

        /// <summary>
        /// Lists the jobs within the specified project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListJobs(ProjectReference, ListJobsOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project to list the jobs from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of the jobs within the specified project.</returns>
        public virtual PagedEnumerable<JobList, BigQueryJob> ListJobs(string projectId, ListJobsOptions options = null) =>
            ListJobs(GetProjectReference(projectId), options);

        /// <summary>
        /// Lists the jobs within the specified project.
        /// </summary>
        /// <param name="projectReference">A fully-qualified identifier for the project. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of the jobs within the specified project.</returns>
        public virtual PagedEnumerable<JobList, BigQueryJob> ListJobs(ProjectReference projectReference, ListJobsOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously lists the jobs within this client's project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListJobsAsync(ProjectReference, ListJobsOptions)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of the jobs within this project.</returns>
        public virtual PagedAsyncEnumerable<JobList, BigQueryJob> ListJobsAsync(ListJobsOptions options = null) =>
            ListJobsAsync(GetProjectReference(ProjectId), options);

        /// <summary>
        /// Asynchronously lists the jobs within the specified project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListJobsAsync(ProjectReference, ListJobsOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project to list the jobs from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of the jobs within the specified project.</returns>
        public virtual PagedAsyncEnumerable<JobList, BigQueryJob> ListJobsAsync(string projectId, ListJobsOptions options = null) =>
            ListJobsAsync(GetProjectReference(projectId), options);

        /// <summary>
        /// Asynchronously lists the jobs within the specified project.
        /// </summary>
        /// <param name="projectReference">A fully-qualified identifier for the project. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of the jobs within the specified project.</returns>
        public virtual PagedAsyncEnumerable<JobList, BigQueryJob> ListJobsAsync(ProjectReference projectReference, ListJobsOptions options = null)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region PollJobUntilCompleted (autogenerated - do not edit manually)
        /// <summary>
        /// Polls the specified job within this client's project for completion.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="PollJobUntilCompleted(JobReference, GetJobOptions, PollSettings)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete. May be null, in which case defaults will be supplied.</param>
        /// <returns>The completed job.</returns>
        public virtual BigQueryJob PollJobUntilCompleted(string jobId, GetJobOptions options = null, PollSettings pollSettings = null) =>
            PollJobUntilCompleted(GetJobReference(jobId), options, pollSettings);
        
        /// <summary>
        /// Polls the specified job for completion.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="PollJobUntilCompleted(JobReference, GetJobOptions, PollSettings)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete. May be null, in which case defaults will be supplied.</param>
        /// <returns>The completed job.</returns>
        public virtual BigQueryJob PollJobUntilCompleted(string projectId, string jobId, GetJobOptions options = null, PollSettings pollSettings = null) =>
            PollJobUntilCompleted(GetJobReference(projectId, jobId), options, pollSettings);
        
        /// <summary>
        /// Polls the specified job for completion.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete. May be null, in which case defaults will be supplied.</param>
        /// <returns>The completed job.</returns>
        public virtual BigQueryJob PollJobUntilCompleted(JobReference jobReference, GetJobOptions options = null, PollSettings pollSettings = null) =>
            throw new NotImplementedException();
        
        /// <summary>
        /// Asynchronously polls the specified job within this client's project for completion.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="PollJobUntilCompletedAsync(JobReference, GetJobOptions, PollSettings, CancellationToken)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the completed job.</returns>
        public virtual Task<BigQueryJob> PollJobUntilCompletedAsync(string jobId, GetJobOptions options = null, PollSettings pollSettings = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            PollJobUntilCompletedAsync(GetJobReference(jobId), options, pollSettings, cancellationToken);
        
        /// <summary>
        /// Asynchronously polls the specified job for completion.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="PollJobUntilCompletedAsync(JobReference, GetJobOptions, PollSettings, CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the completed job.</returns>
        public virtual Task<BigQueryJob> PollJobUntilCompletedAsync(string projectId, string jobId, GetJobOptions options = null, PollSettings pollSettings = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            PollJobUntilCompletedAsync(GetJobReference(projectId, jobId), options, pollSettings, cancellationToken);
        
        /// <summary>
        /// Asynchronously polls the specified job for completion.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the completed job.</returns>
        public virtual Task<BigQueryJob> PollJobUntilCompletedAsync(JobReference jobReference, GetJobOptions options = null, PollSettings pollSettings = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            throw new NotImplementedException();
        #endregion

        #region GetJob (autogenerated - do not edit manually)
        /// <summary>
        /// Retrieves the specified job within this client's project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetJob(JobReference, GetJobOptions)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The retrieved job.</returns>
        public virtual BigQueryJob GetJob(string jobId, GetJobOptions options = null) =>
            GetJob(GetJobReference(jobId), options);
        
        /// <summary>
        /// Retrieves the specified job.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetJob(JobReference, GetJobOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The retrieved job.</returns>
        public virtual BigQueryJob GetJob(string projectId, string jobId, GetJobOptions options = null) =>
            GetJob(GetJobReference(projectId, jobId), options);
        
        /// <summary>
        /// Retrieves the specified job.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The retrieved job.</returns>
        public virtual BigQueryJob GetJob(JobReference jobReference, GetJobOptions options = null) =>
            throw new NotImplementedException();
        
        /// <summary>
        /// Asynchronously retrieves the specified job within this client's project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetJobAsync(JobReference, GetJobOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the retrieved job.</returns>
        public virtual Task<BigQueryJob> GetJobAsync(string jobId, GetJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            GetJobAsync(GetJobReference(jobId), options, cancellationToken);
        
        /// <summary>
        /// Asynchronously retrieves the specified job.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetJobAsync(JobReference, GetJobOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the retrieved job.</returns>
        public virtual Task<BigQueryJob> GetJobAsync(string projectId, string jobId, GetJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            GetJobAsync(GetJobReference(projectId, jobId), options, cancellationToken);
        
        /// <summary>
        /// Asynchronously retrieves the specified job.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the retrieved job.</returns>
        public virtual Task<BigQueryJob> GetJobAsync(JobReference jobReference, GetJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            throw new NotImplementedException();
        #endregion

        #region CancelJob (autogenerated - do not edit manually)
        /// <summary>
        /// Cancels the specified job within this client's project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="CancelJob(JobReference, CancelJobOptions)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The final state of the job.</returns>
        public virtual BigQueryJob CancelJob(string jobId, CancelJobOptions options = null) =>
            CancelJob(GetJobReference(jobId), options);
        
        /// <summary>
        /// Cancels the specified job.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="CancelJob(JobReference, CancelJobOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The final state of the job.</returns>
        public virtual BigQueryJob CancelJob(string projectId, string jobId, CancelJobOptions options = null) =>
            CancelJob(GetJobReference(projectId, jobId), options);
        
        /// <summary>
        /// Cancels the specified job.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The final state of the job.</returns>
        public virtual BigQueryJob CancelJob(JobReference jobReference, CancelJobOptions options = null) =>
            throw new NotImplementedException();
        
        /// <summary>
        /// Asynchronously cancels the specified job within this client's project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="CancelJobAsync(JobReference, CancelJobOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the final state of the job.</returns>
        public virtual Task<BigQueryJob> CancelJobAsync(string jobId, CancelJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            CancelJobAsync(GetJobReference(jobId), options, cancellationToken);
        
        /// <summary>
        /// Asynchronously cancels the specified job.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="CancelJobAsync(JobReference, CancelJobOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the final state of the job.</returns>
        public virtual Task<BigQueryJob> CancelJobAsync(string projectId, string jobId, CancelJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            CancelJobAsync(GetJobReference(projectId, jobId), options, cancellationToken);
        
        /// <summary>
        /// Asynchronously cancels the specified job.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the final state of the job.</returns>
        public virtual Task<BigQueryJob> CancelJobAsync(JobReference jobReference, CancelJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            throw new NotImplementedException();
        #endregion

        #region CreateExtractJob(single uri)
        /// <summary>
        /// Creates a job to extract data from the specified BigQuery table to Google Cloud Storage.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateExtractJob(TableReference, string, CreateExtractJobOptions)"/>.
        /// See [the BigQuery documentation](https://cloud.google.com/bigquery/docs/exporting-data) for more information on extract jobs.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="destinationUri">The Google Cloud Storage URI (possibly including a wildcard) to extract the data to. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The job created for the extract operation.</returns>
        public virtual BigQueryJob CreateExtractJob(string projectId, string datasetId, string tableId, string destinationUri, CreateExtractJobOptions options = null)
            => CreateExtractJob(GetTableReference(projectId, datasetId, tableId), destinationUri, options);

        /// <summary>
        /// Creates a job to extract data from the specified BigQuery table within this client's project to Google Cloud Storage.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateExtractJob(TableReference, string, CreateExtractJobOptions)"/>.
        /// See [the BigQuery documentation](https://cloud.google.com/bigquery/docs/exporting-data) for more information on extract jobs.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="destinationUri">The Google Cloud Storage URI (possibly including a wildcard) to extract the data to. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The job created for the extract operation.</returns>
        public virtual BigQueryJob CreateExtractJob(string datasetId, string tableId, string destinationUri, CreateExtractJobOptions options = null)
            => CreateExtractJob(GetTableReference(datasetId, tableId), destinationUri, options);

        /// <summary>
        /// Creates a job to extract data from the specified BigQuery table to Google Cloud Storage.
        /// This method just creates a single-element array and delegates to <see cref="CreateExtractJob(TableReference, IEnumerable{String}, CreateExtractJobOptions)"/>.
        /// See [the BigQuery documentation](https://cloud.google.com/bigquery/docs/exporting-data) for more information on extract jobs.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="destinationUri">The Google Cloud Storage URI (possibly including a wildcard) to extract the data to. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The job created for the extract operation.</returns>
        public virtual BigQueryJob CreateExtractJob(TableReference tableReference, string destinationUri, CreateExtractJobOptions options = null) =>
            CreateExtractJob(
                GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference)),
                new[] { GaxPreconditions.CheckNotNull(destinationUri, nameof(destinationUri)) },
                options);

        /// <summary>
        /// Asynchronously creates a job to extract data from the specified BigQuery table to Google Cloud Storage.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateExtractJobAsync(TableReference, string, CreateExtractJobOptions, CancellationToken)"/>.
        /// See [the BigQuery documentation](https://cloud.google.com/bigquery/docs/exporting-data) for more information on extract jobs.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="destinationUri">The Google Cloud Storage URI (possibly including a wildcard) to extract the data to. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is the job created for the extract operation.</returns>
        public virtual Task<BigQueryJob> CreateExtractJobAsync(string projectId, string datasetId, string tableId, string destinationUri, CreateExtractJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
            => CreateExtractJobAsync(GetTableReference(projectId, datasetId, tableId), destinationUri, options, cancellationToken);

        /// <summary>
        /// Asynchronously creates a job to extract data from the specified BigQuery table within this client's project to Google Cloud Storage.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateExtractJobAsync(TableReference, string, CreateExtractJobOptions, CancellationToken)"/>.
        /// See [the BigQuery documentation](https://cloud.google.com/bigquery/docs/exporting-data) for more information on extract jobs.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="destinationUri">The Google Cloud Storage URI (possibly including a wildcard) to extract the data to. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is the job created for the extract operation.</returns>
        public virtual Task<BigQueryJob> CreateExtractJobAsync(string datasetId, string tableId, string destinationUri, CreateExtractJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
            => CreateExtractJobAsync(GetTableReference(datasetId, tableId), destinationUri, options, cancellationToken);

        /// <summary>
        /// Asynchronously creates a job to extract data from the specified BigQuery table to Google Cloud Storage.
        /// This method just creates a single-element array and delegates to <see cref="CreateExtractJobAsync(TableReference, IEnumerable{String}, CreateExtractJobOptions, CancellationToken)"/>.
        /// See [the BigQuery documentation](https://cloud.google.com/bigquery/docs/exporting-data) for more information on extract jobs.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="destinationUri">The Google Cloud Storage URI (possibly including a wildcard) to extract the data to. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is the job created for the extract operation.</returns>
        public virtual Task<BigQueryJob> CreateExtractJobAsync(TableReference tableReference, string destinationUri, CreateExtractJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            CreateExtractJobAsync(
                GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference)),
                new[] { GaxPreconditions.CheckNotNull(destinationUri, nameof(destinationUri)) },
                options, cancellationToken);
        #endregion

        #region CreateExtractJob(multiple uris) (autogenerated - do not edit manually)
        /// <summary>
        /// Creates a job to extract data from the specified BigQuery table to Google Cloud Storage.
        /// See [the BigQuery documentation](https://cloud.google.com/bigquery/docs/exporting-data) for more information on extract jobs.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateExtractJob(TableReference, IEnumerable{string}, CreateExtractJobOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="destinationUris">The Google Cloud Storage URIs (possibly including a wildcard) to extract the data to. Must not be null or empty.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The job created for the extract operation.</returns>
        public virtual BigQueryJob CreateExtractJob(string datasetId, string tableId, IEnumerable<string> destinationUris, CreateExtractJobOptions options = null) =>
            CreateExtractJob(GetTableReference(datasetId, tableId), destinationUris, options);
        
        /// <summary>
        /// Creates a job to extract data from the specified BigQuery table to Google Cloud Storage.
        /// See [the BigQuery documentation](https://cloud.google.com/bigquery/docs/exporting-data) for more information on extract jobs.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateExtractJob(TableReference, IEnumerable{string}, CreateExtractJobOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="destinationUris">The Google Cloud Storage URIs (possibly including a wildcard) to extract the data to. Must not be null or empty.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The job created for the extract operation.</returns>
        public virtual BigQueryJob CreateExtractJob(string projectId, string datasetId, string tableId, IEnumerable<string> destinationUris, CreateExtractJobOptions options = null) =>
            CreateExtractJob(GetTableReference(projectId, datasetId, tableId), destinationUris, options);
        
        /// <summary>
        /// Creates a job to extract data from the specified BigQuery table to Google Cloud Storage.
        /// See [the BigQuery documentation](https://cloud.google.com/bigquery/docs/exporting-data) for more information on extract jobs.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="destinationUris">The Google Cloud Storage URIs (possibly including a wildcard) to extract the data to. Must not be null or empty.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The job created for the extract operation.</returns>
        public virtual BigQueryJob CreateExtractJob(TableReference tableReference, IEnumerable<string> destinationUris, CreateExtractJobOptions options = null) =>
            throw new NotImplementedException();
        
        /// <summary>
        /// Asynchronously creates a job to extract data from the specified BigQuery table to Google Cloud Storage.
        /// See [the BigQuery documentation](https://cloud.google.com/bigquery/docs/exporting-data) for more information on extract jobs.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateExtractJobAsync(TableReference, IEnumerable{string}, CreateExtractJobOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="destinationUris">The Google Cloud Storage URIs (possibly including a wildcard) to extract the data to. Must not be null or empty.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the job created for the extract operation.</returns>
        public virtual Task<BigQueryJob> CreateExtractJobAsync(string datasetId, string tableId, IEnumerable<string> destinationUris, CreateExtractJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            CreateExtractJobAsync(GetTableReference(datasetId, tableId), destinationUris, options, cancellationToken);
        
        /// <summary>
        /// Asynchronously creates a job to extract data from the specified BigQuery table to Google Cloud Storage.
        /// See [the BigQuery documentation](https://cloud.google.com/bigquery/docs/exporting-data) for more information on extract jobs.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateExtractJobAsync(TableReference, IEnumerable{string}, CreateExtractJobOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="destinationUris">The Google Cloud Storage URIs (possibly including a wildcard) to extract the data to. Must not be null or empty.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the job created for the extract operation.</returns>
        public virtual Task<BigQueryJob> CreateExtractJobAsync(string projectId, string datasetId, string tableId, IEnumerable<string> destinationUris, CreateExtractJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            CreateExtractJobAsync(GetTableReference(projectId, datasetId, tableId), destinationUris, options, cancellationToken);
        
        /// <summary>
        /// Asynchronously creates a job to extract data from the specified BigQuery table to Google Cloud Storage.
        /// See [the BigQuery documentation](https://cloud.google.com/bigquery/docs/exporting-data) for more information on extract jobs.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="destinationUris">The Google Cloud Storage URIs (possibly including a wildcard) to extract the data to. Must not be null or empty.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the job created for the extract operation.</returns>
        public virtual Task<BigQueryJob> CreateExtractJobAsync(TableReference tableReference, IEnumerable<string> destinationUris, CreateExtractJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            throw new NotImplementedException();
        #endregion

        #region CreateCopyJob
        /// <summary>
        /// Creates a job to copy one table to another.
        /// This method creates a single-element array and delegates to <see cref="CreateCopyJob(IEnumerable{TableReference}, TableReference, CreateCopyJobOptions)"/>.
        /// </summary>
        /// <remarks>
        /// To avoid confusion between source and destination tables, overloads are not provided that take the
        /// individual components of table references. Instead, use <see cref="GetTableReference(string, string)"/> or
        /// <see cref="GetTableReference(string, string, string)"/> to create table references.
        /// </remarks>
        /// <param name="source">The source table to copy. Must not be null.</param>
        /// <param name="destination">The destination to copy to. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The job created for the copy operation.</returns>
        public virtual BigQueryJob CreateCopyJob(TableReference source, TableReference destination, CreateCopyJobOptions options = null)
            => CreateCopyJob(new[] { GaxPreconditions.CheckNotNull(source, nameof(source)) }, destination, options);

        /// <summary>
        /// Creates a job to copy data from at least one table to another.
        /// </summary>
        /// <remarks>
        /// To avoid confusion between source and destination tables, overloads are not provided that take the
        /// individual components of table references. Instead, use <see cref="GetTableReference(string, string)"/> or
        /// <see cref="GetTableReference(string, string, string)"/> to create table references.
        /// </remarks>
        /// <param name="sources">The source tables to copy. Must not be null or empty.</param>
        /// <param name="destination">The destination to copy to. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The job created for the copy operation.</returns>
        public virtual BigQueryJob CreateCopyJob(IEnumerable<TableReference> sources, TableReference destination, CreateCopyJobOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously creates a job to copy one table to another.
        /// This method creates a single-element array and delegates to <see cref="CreateCopyJobAsync(IEnumerable{TableReference}, TableReference, CreateCopyJobOptions, CancellationToken)"/>.
        /// </summary>
        /// <remarks>
        /// To avoid confusion between source and destination tables, overloads are not provided that take the
        /// individual components of table references. Instead, use <see cref="GetTableReference(string, string)"/> or
        /// <see cref="GetTableReference(string, string, string)"/> to create table references.
        /// </remarks>
        /// <param name="source">The source table to copy. Must not be null.</param>
        /// <param name="destination">The destination to copy to. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is the job created for the copy operation.</returns>
        public virtual Task<BigQueryJob> CreateCopyJobAsync(TableReference source, TableReference destination, CreateCopyJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
            => CreateCopyJobAsync(new[] { GaxPreconditions.CheckNotNull(source, nameof(source)) }, destination, options, cancellationToken);

        /// <summary>
        /// Asynchronously creates a job to copy data from at least one table to another.
        /// </summary>
        /// <remarks>
        /// To avoid confusion between source and destination tables, overloads are not provided that take the
        /// individual components of table references. Instead, use <see cref="GetTableReference(string, string)"/> or
        /// <see cref="GetTableReference(string, string, string)"/> to create table references.
        /// </remarks>
        /// <param name="sources">The source tables to copy. Must not be null or empty.</param>
        /// <param name="destination">The destination to copy to. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is the job created for the copy operation.</returns>
        public virtual Task<BigQueryJob> CreateCopyJobAsync(IEnumerable<TableReference> sources, TableReference destination, CreateCopyJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
        #endregion

        #region CreateLoadJob
        /// <summary>
        /// Creates a job to load data from a Google Cloud Storage file to a BigQuery table.
        /// This method creates a single-element array and delegates to <see cref="CreateLoadJob(IEnumerable{String}, TableReference, TableSchema, CreateLoadJobOptions)"/>.
        /// </summary>
        /// <remarks>
        /// To avoid confusion between source and destination tables, overloads are not provided that take the
        /// individual components of table references. Instead, use <see cref="GetTableReference(string, string)"/> or
        /// <see cref="GetTableReference(string, string, string)"/> to create table references.
        /// </remarks>
        /// <param name="sourceUri">The Google Cloud Storage URI of the file to load. Must not be null.</param>
        /// <param name="destination">The destination table to write data to. Must not be null.</param>
        /// <param name="schema">The schema for the table. May be null if the load operation does not require a schema,
        /// such as if the table already exists, the data is being loaded from a Google Cloud Datastore backup, or if
        /// the options are set to autodetect the schema.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The job created for the load operation.</returns>
        public virtual BigQueryJob CreateLoadJob(string sourceUri, TableReference destination, TableSchema schema, CreateLoadJobOptions options = null)
            => CreateLoadJob(new[] { GaxPreconditions.CheckNotNull(sourceUri, nameof(sourceUri)) }, destination, schema, options);

        /// <summary>
        /// Creates a job to load data from at least one Google Cloud Storage file to a BigQuery table.
        /// </summary>
        /// <remarks>
        /// To avoid confusion between source and destination tables, overloads are not provided that take the
        /// individual components of table references. Instead, use <see cref="GetTableReference(string, string)"/> or
        /// <see cref="GetTableReference(string, string, string)"/> to create table references.
        /// </remarks>
        /// <param name="sourceUris">The Google Cloud Storage URIs of the files to load. Must not be null or empty.</param>
        /// <param name="destination">The destination table to write data to. Must not be null.</param>
        /// <param name="schema">The schema for the table. May be null if the load operation does not require a schema,
        /// such as if the table already exists, the data is being loaded from a Google Cloud Datastore backup, or if
        /// the options are set to autodetect the schema.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The job created for the load operation.</returns>
        public virtual BigQueryJob CreateLoadJob(IEnumerable<string> sourceUris, TableReference destination, TableSchema schema, CreateLoadJobOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously creates a job to load data from a Google Cloud Storage file to a BigQuery table.
        /// This method creates a single-element array and delegates to <see cref="CreateLoadJobAsync(IEnumerable{String}, TableReference, TableSchema, CreateLoadJobOptions, CancellationToken)"/>.
        /// </summary>
        /// <remarks>
        /// To avoid confusion between source and destination tables, overloads are not provided that take the
        /// individual components of table references. Instead, use <see cref="GetTableReference(string, string)"/> or
        /// <see cref="GetTableReference(string, string, string)"/> to create table references.
        /// </remarks>
        /// <param name="sourceUri">The Google Cloud Storage URI of the file to load. Must not be null.</param>
        /// <param name="destination">The destination table to write data to. Must not be null.</param>
        /// <param name="schema">The schema for the table. May be null if the load operation does not require a schema,
        /// such as if the table already exists, the data is being loaded from a Google Cloud Datastore backup, or if
        /// the options are set to autodetect the schema.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is the job created for the load operation.</returns>
        public virtual Task<BigQueryJob> CreateLoadJobAsync(string sourceUri, TableReference destination, TableSchema schema, CreateLoadJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
            => CreateLoadJobAsync(new[] { GaxPreconditions.CheckNotNull(sourceUri, nameof(sourceUri)) }, destination, schema, options, cancellationToken);

        /// <summary>
        /// Asynchronously creates a job to load data from at least one Google Cloud Storage file to a BigQuery table.
        /// </summary>
        /// <remarks>
        /// To avoid confusion between source and destination tables, overloads are not provided that take the
        /// individual components of table references. Instead, use <see cref="GetTableReference(string, string)"/> or
        /// <see cref="GetTableReference(string, string, string)"/> to create table references.
        /// </remarks>
        /// <param name="sourceUris">The Google Cloud Storage URIs of the files to load. Must not be null or empty.</param>
        /// <param name="destination">The destination table to write data to. Must not be null.</param>
        /// <param name="schema">The schema for the table. May be null if the load operation does not require a schema,
        /// such as if the table already exists, the data is being loaded from a Google Cloud Datastore backup, or if
        /// the options are set to autodetect the schema.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is the job created for the load operation.</returns>
        public virtual Task<BigQueryJob> CreateLoadJobAsync(IEnumerable<string> sourceUris, TableReference destination, TableSchema schema, CreateLoadJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
