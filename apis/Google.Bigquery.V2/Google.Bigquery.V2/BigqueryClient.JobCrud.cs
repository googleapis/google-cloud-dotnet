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
using System.Threading;
using System.Threading.Tasks;

namespace Google.Bigquery.V2
{
    public abstract partial class BigqueryClient
    {
        /// <summary>
        /// Lists the jobs within this client's project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListJobs(ProjectReference, ListJobsOptions)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of the jobs within this project.</returns>
        public virtual IPagedEnumerable<JobList, BigqueryJob> ListJobs(ListJobsOptions options = null) =>
            ListJobs(GetProjectReference(ProjectId), options);

        /// <summary>
        /// Lists the jobs within the specified project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListJobs(ProjectReference, ListJobsOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project to list the jobs from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of the jobs within the specified project.</returns>
        public virtual IPagedEnumerable<JobList, BigqueryJob> ListJobs(string projectId, ListJobsOptions options = null) =>
            ListJobs(GetProjectReference(projectId), options);

        /// <summary>
        /// Lists the jobs within the specified project.
        /// </summary>
        /// <param name="projectReference">A fully-qualified identifier for the project. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of the jobs within the specified project.</returns>
        public virtual IPagedEnumerable<JobList, BigqueryJob> ListJobs(ProjectReference projectReference, ListJobsOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Polls the job with the specified ID in this client's project for completion.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="PollJobUntilCompleted(JobReference,GetJobOptions,PollSettings)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.</param>
        /// <returns>The completed job.</returns>
        public virtual BigqueryJob PollJobUntilCompleted(string jobId, GetJobOptions options = null, PollSettings pollSettings = null) =>
            PollJobUntilCompleted(GetJobReference(jobId), options, pollSettings);

        /// <summary>
        /// Polls the job with the specified project ID and job ID.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="PollJobUntilCompleted(JobReference,GetJobOptions,PollSettings)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.</param>
        /// <returns>The completed job.</returns>
        public virtual BigqueryJob PollJobUntilCompleted(string projectId, string jobId, GetJobOptions options = null, PollSettings pollSettings = null) =>
            PollJobUntilCompleted(GetJobReference(projectId, jobId), options, pollSettings);

        /// <summary>
        /// Polls the specified job for completion.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.</param>
        /// <returns>The completed job.</returns>
        public virtual BigqueryJob PollJobUntilCompleted(JobReference jobReference, GetJobOptions options = null, PollSettings pollSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves the job with the specified ID within this client's project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetJob(JobReference,GetJobOptions)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The retrieved job.</returns>
        public virtual BigqueryJob GetJob(string jobId, GetJobOptions options = null) =>
            GetJob(GetJobReference(jobId), options);

        /// <summary>
        /// Retrieves a job given a project ID and job ID.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetJob(JobReference,GetJobOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The retrieved job.</returns>
        public virtual BigqueryJob GetJob(string projectId, string jobId, GetJobOptions options = null) =>
            GetJob(GetJobReference(projectId, jobId), options);

        /// <summary>
        /// Retrieves a job.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The retrieved job.</returns>
        public virtual BigqueryJob GetJob(JobReference jobReference, GetJobOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cancels the job with the specified ID in this client's project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="CancelJob(JobReference, CancelJobOptions)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The final state of the job.</returns>
        public virtual BigqueryJob CancelJob(string jobId, CancelJobOptions options = null) =>
            CancelJob(GetJobReference(jobId), options);

        /// <summary>
        /// Cancels the job with the specified project ID and job ID.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="CancelJob(JobReference, CancelJobOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The final state of the job.</returns>
        public virtual BigqueryJob CancelJob(string projectId, string jobId, CancelJobOptions options = null) =>
            CancelJob(GetJobReference(projectId, jobId), options);

        /// <summary>
        /// Cancels a job.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The final state of the job.</returns>
        public virtual BigqueryJob CancelJob(JobReference jobReference, CancelJobOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously lists the jobs within this client's project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListJobsAsync(ProjectReference, ListJobsOptions)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of the jobs within this project.</returns>
        public virtual IPagedAsyncEnumerable<JobList, BigqueryJob> ListJobsAsync(ListJobsOptions options = null) =>
            ListJobsAsync(GetProjectReference(ProjectId), options);

        /// <summary>
        /// Asynchronously lists the jobs within the specified project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListJobsAsync(ProjectReference, ListJobsOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project to list the jobs from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of the jobs within the specified project.</returns>
        public virtual IPagedAsyncEnumerable<JobList, BigqueryJob> ListJobsAsync(string projectId, ListJobsOptions options = null) =>
            ListJobsAsync(GetProjectReference(projectId), options);

        /// <summary>
        /// Asynchronously lists the jobs within the specified project.
        /// </summary>
        /// <param name="projectReference">A fully-qualified identifier for the project. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of the jobs within the specified project.</returns>
        public virtual IPagedAsyncEnumerable<JobList, BigqueryJob> ListJobsAsync(ProjectReference projectReference, ListJobsOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Polls the job with the specified ID in this client's project for completion.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="PollJobUntilCompletedAsync(JobReference,GetJobOptions,PollSettings,CancellationToken)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the completed job.</returns>
        public virtual Task<BigqueryJob> PollJobUntilCompletedAsync(string jobId, GetJobOptions options = null, PollSettings pollSettings = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            PollJobUntilCompletedAsync(GetJobReference(jobId), options, pollSettings, cancellationToken);

        /// <summary>
        /// Polls the job with the specified project ID and job ID.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="PollJobUntilCompletedAsync(JobReference,GetJobOptions,PollSettings,CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the completed job.</returns>
        public virtual Task<BigqueryJob> PollJobUntilCompletedAsync(string projectId, string jobId, GetJobOptions options = null, PollSettings pollSettings = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            PollJobUntilCompletedAsync(GetJobReference(projectId, jobId), options, pollSettings, cancellationToken);

        /// <summary>
        /// Polls the specified job for completion.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the completed job.</returns>
        public virtual Task<BigqueryJob> PollJobUntilCompletedAsync(JobReference jobReference, GetJobOptions options = null, PollSettings pollSettings = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves the job with the specified ID within this client's project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetJobAsync(JobReference,GetJobOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the retrieved job.</returns>
        public virtual Task<BigqueryJob> GetJobAsync(string jobId, GetJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            GetJobAsync(GetJobReference(jobId), options, cancellationToken);

        /// <summary>
        /// Retrieves a job given a project ID and job ID.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetJobAsync(JobReference,GetJobOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the retrieved job.</returns>
        public virtual Task<BigqueryJob> GetJobAsync(string projectId, string jobId, GetJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            GetJobAsync(GetJobReference(projectId, jobId), options, cancellationToken);

        /// <summary>
        /// Retrieves a job.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the retrieved job.</returns>
        public virtual Task<BigqueryJob> GetJobAsync(JobReference jobReference, GetJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously cancels the job with the specified ID in this client's project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="CancelJobAsync(JobReference, CancelJobOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the final state of job.</returns>
        public virtual Task<BigqueryJob> CancelJobAsync(string jobId, CancelJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            CancelJobAsync(GetJobReference(jobId), options, cancellationToken);

        /// <summary>
        /// Asynchronously cancels the job with the specified project ID and job ID.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="CancelJobAsync(JobReference, CancelJobOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the final state of job.</returns>
        public virtual Task<BigqueryJob> CancelJobAsync(string projectId, string jobId, CancelJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            CancelJobAsync(GetJobReference(projectId, jobId), options, cancellationToken);

        /// <summary>
        /// Asynchronously cancels a job.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the final state of job.</returns>
        public virtual Task<BigqueryJob> CancelJobAsync(JobReference jobReference, CancelJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}
