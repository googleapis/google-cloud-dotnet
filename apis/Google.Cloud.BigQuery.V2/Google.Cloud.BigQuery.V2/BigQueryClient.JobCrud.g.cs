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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2;

public abstract partial class BigQueryClient
{
    #region PollJobUntilCompleted
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
    public virtual Task<BigQueryJob> PollJobUntilCompletedAsync(string jobId, GetJobOptions options = null, PollSettings pollSettings = null, CancellationToken cancellationToken = default) =>
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
    public virtual Task<BigQueryJob> PollJobUntilCompletedAsync(string projectId, string jobId, GetJobOptions options = null, PollSettings pollSettings = null, CancellationToken cancellationToken = default) =>
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
    public virtual Task<BigQueryJob> PollJobUntilCompletedAsync(JobReference jobReference, GetJobOptions options = null, PollSettings pollSettings = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region GetJob
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
    public virtual Task<BigQueryJob> GetJobAsync(string jobId, GetJobOptions options = null, CancellationToken cancellationToken = default) =>
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
    public virtual Task<BigQueryJob> GetJobAsync(string projectId, string jobId, GetJobOptions options = null, CancellationToken cancellationToken = default) =>
        GetJobAsync(GetJobReference(projectId, jobId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously retrieves the specified job.
    /// </summary>
    /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the retrieved job.</returns>
    public virtual Task<BigQueryJob> GetJobAsync(JobReference jobReference, GetJobOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region CancelJob
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
    public virtual Task<BigQueryJob> CancelJobAsync(string jobId, CancelJobOptions options = null, CancellationToken cancellationToken = default) =>
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
    public virtual Task<BigQueryJob> CancelJobAsync(string projectId, string jobId, CancelJobOptions options = null, CancellationToken cancellationToken = default) =>
        CancelJobAsync(GetJobReference(projectId, jobId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously cancels the specified job.
    /// </summary>
    /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the final state of the job.</returns>
    public virtual Task<BigQueryJob> CancelJobAsync(JobReference jobReference, CancelJobOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region CreateExtractJob(multiple uris)
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
    public virtual Task<BigQueryJob> CreateExtractJobAsync(string datasetId, string tableId, IEnumerable<string> destinationUris, CreateExtractJobOptions options = null, CancellationToken cancellationToken = default) =>
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
    public virtual Task<BigQueryJob> CreateExtractJobAsync(string projectId, string datasetId, string tableId, IEnumerable<string> destinationUris, CreateExtractJobOptions options = null, CancellationToken cancellationToken = default) =>
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
    public virtual Task<BigQueryJob> CreateExtractJobAsync(TableReference tableReference, IEnumerable<string> destinationUris, CreateExtractJobOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region CreateModelExtractJob(multiple uris)
    /// <summary>
    /// Creates a job to extract the specified BigQuery model to Google Cloud Storage.
    /// See [the BigQuery documentation](https://cloud.google.com/bigquery-ml/docs/exporting-models) for more information on model extract jobs.
    /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="CreateModelExtractJob(ModelReference, IEnumerable{string}, CreateModelExtractJobOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="modelId">The model ID. Must not be null.</param>
    /// <param name="destinationUris">The Google Cloud Storage URIs (possibly including a wildcard) to extract the model to. Must not be null or empty.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The job created for the extract operation.</returns>
    public virtual BigQueryJob CreateModelExtractJob(string datasetId, string modelId, IEnumerable<string> destinationUris, CreateModelExtractJobOptions options = null) =>
        CreateModelExtractJob(GetModelReference(datasetId, modelId), destinationUris, options);
    
    /// <summary>
    /// Creates a job to extract the specified BigQuery model to Google Cloud Storage.
    /// See [the BigQuery documentation](https://cloud.google.com/bigquery-ml/docs/exporting-models) for more information on model extract jobs.
    /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="CreateModelExtractJob(ModelReference, IEnumerable{string}, CreateModelExtractJobOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="modelId">The model ID. Must not be null.</param>
    /// <param name="destinationUris">The Google Cloud Storage URIs (possibly including a wildcard) to extract the model to. Must not be null or empty.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The job created for the extract operation.</returns>
    public virtual BigQueryJob CreateModelExtractJob(string projectId, string datasetId, string modelId, IEnumerable<string> destinationUris, CreateModelExtractJobOptions options = null) =>
        CreateModelExtractJob(GetModelReference(projectId, datasetId, modelId), destinationUris, options);
    
    /// <summary>
    /// Creates a job to extract the specified BigQuery model to Google Cloud Storage.
    /// See [the BigQuery documentation](https://cloud.google.com/bigquery-ml/docs/exporting-models) for more information on model extract jobs.
    /// </summary>
    /// <param name="modelReference">A fully-qualified identifier for the model. Must not be null.</param>
    /// <param name="destinationUris">The Google Cloud Storage URIs (possibly including a wildcard) to extract the model to. Must not be null or empty.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The job created for the extract operation.</returns>
    public virtual BigQueryJob CreateModelExtractJob(ModelReference modelReference, IEnumerable<string> destinationUris, CreateModelExtractJobOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously creates a job to extract the specified BigQuery model to Google Cloud Storage.
    /// See [the BigQuery documentation](https://cloud.google.com/bigquery-ml/docs/exporting-models) for more information on model extract jobs.
    /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="CreateModelExtractJobAsync(ModelReference, IEnumerable{string}, CreateModelExtractJobOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="modelId">The model ID. Must not be null.</param>
    /// <param name="destinationUris">The Google Cloud Storage URIs (possibly including a wildcard) to extract the model to. Must not be null or empty.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the job created for the extract operation.</returns>
    public virtual Task<BigQueryJob> CreateModelExtractJobAsync(string datasetId, string modelId, IEnumerable<string> destinationUris, CreateModelExtractJobOptions options = null, CancellationToken cancellationToken = default) =>
        CreateModelExtractJobAsync(GetModelReference(datasetId, modelId), destinationUris, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously creates a job to extract the specified BigQuery model to Google Cloud Storage.
    /// See [the BigQuery documentation](https://cloud.google.com/bigquery-ml/docs/exporting-models) for more information on model extract jobs.
    /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="CreateModelExtractJobAsync(ModelReference, IEnumerable{string}, CreateModelExtractJobOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="modelId">The model ID. Must not be null.</param>
    /// <param name="destinationUris">The Google Cloud Storage URIs (possibly including a wildcard) to extract the model to. Must not be null or empty.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the job created for the extract operation.</returns>
    public virtual Task<BigQueryJob> CreateModelExtractJobAsync(string projectId, string datasetId, string modelId, IEnumerable<string> destinationUris, CreateModelExtractJobOptions options = null, CancellationToken cancellationToken = default) =>
        CreateModelExtractJobAsync(GetModelReference(projectId, datasetId, modelId), destinationUris, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously creates a job to extract the specified BigQuery model to Google Cloud Storage.
    /// See [the BigQuery documentation](https://cloud.google.com/bigquery-ml/docs/exporting-models) for more information on model extract jobs.
    /// </summary>
    /// <param name="modelReference">A fully-qualified identifier for the model. Must not be null.</param>
    /// <param name="destinationUris">The Google Cloud Storage URIs (possibly including a wildcard) to extract the model to. Must not be null or empty.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the job created for the extract operation.</returns>
    public virtual Task<BigQueryJob> CreateModelExtractJobAsync(ModelReference modelReference, IEnumerable<string> destinationUris, CreateModelExtractJobOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region DeleteJob
    /// <summary>
    /// Deletes the specified job within this client's project.
    /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="DeleteJob(JobReference, DeleteJobOptions)"/>.
    /// </summary>
    /// <param name="jobId">The job ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    public virtual void DeleteJob(string jobId, DeleteJobOptions options = null) =>
        DeleteJob(GetJobReference(jobId), options);
    
    /// <summary>
    /// Deletes the specified job.
    /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="DeleteJob(JobReference, DeleteJobOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="jobId">The job ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    public virtual void DeleteJob(string projectId, string jobId, DeleteJobOptions options = null) =>
        DeleteJob(GetJobReference(projectId, jobId), options);
    
    /// <summary>
    /// Deletes the specified job.
    /// </summary>
    /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    public virtual void DeleteJob(JobReference jobReference, DeleteJobOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously deletes the specified job within this client's project.
    /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="DeleteJobAsync(JobReference, DeleteJobOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="jobId">The job ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public virtual Task DeleteJobAsync(string jobId, DeleteJobOptions options = null, CancellationToken cancellationToken = default) =>
        DeleteJobAsync(GetJobReference(jobId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously deletes the specified job.
    /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="DeleteJobAsync(JobReference, DeleteJobOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="jobId">The job ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public virtual Task DeleteJobAsync(string projectId, string jobId, DeleteJobOptions options = null, CancellationToken cancellationToken = default) =>
        DeleteJobAsync(GetJobReference(projectId, jobId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously deletes the specified job.
    /// </summary>
    /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public virtual Task DeleteJobAsync(JobReference jobReference, DeleteJobOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion
}
