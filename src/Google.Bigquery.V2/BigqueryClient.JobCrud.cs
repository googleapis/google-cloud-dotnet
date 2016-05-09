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
using System.Collections.Generic;

namespace Google.Bigquery.V2
{
    public abstract partial class BigqueryClient
    {
        /// <summary>
        /// Lists the jobs within this client's project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListJobs(ProjectReference, ListJobsOptions)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <returns>The jobs within this project.</returns>
        public virtual IEnumerable<BigqueryJob> ListJobs(ListJobsOptions options = null) =>
            ListJobs(GetProjectReference(ProjectId), options);

        /// <summary>
        /// Lists the jobs within the specified project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListDatasets(ProjectReference, ListDatasets)"/>.
        /// </summary>
        /// <param name="projectId">The project to list the jobs from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <returns>The jobs within the specified project.</returns>
        public virtual IEnumerable<BigqueryJob> ListJobs(string projectId, ListJobsOptions options = null) =>
            ListJobs(GetProjectReference(projectId), options);

        /// <summary>
        /// Lists the jobs within the specified project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListDatasets(ProjectReference, ListDatasetsOptions)"/>.
        /// </summary>
        /// <param name="projectReference">A fully-qualified identifier for the project. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <returns>The jobs within the specified project.</returns>
        public virtual IEnumerable<BigqueryJob> ListJobs(ProjectReference projectReference, ListJobsOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Polls the job with the specified ID in this client's project for completion.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="PollJob(JobReference)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <returns>The completed job.</returns>
        public virtual BigqueryJob PollJob(string jobId) => PollJob(GetJobReference(jobId));

        /// <summary>
        /// Polls the job with the specified project ID and job ID.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="PollJob(JobReference)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <returns>The completed job.</returns>
        public virtual BigqueryJob PollJob(string projectId, string jobId) => PollJob(GetJobReference(projectId, jobId));

        /// <summary>
        /// Polls the specified job for completion.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <returns>The completed job.</returns>
        public virtual BigqueryJob PollJob(JobReference jobReference)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves the job with the specified ID within this client's project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetJob(JobReference)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <returns>The retrieved job.</returns>
        public virtual BigqueryJob GetJob(string jobId) => GetJob(GetJobReference(jobId));

        /// <summary>
        /// Retrieves a job given a project ID and job ID.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetJob(JobReference)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <returns>The retrieved job.</returns>
        public virtual BigqueryJob GetJob(string projectId, string jobId) => GetJob(GetJobReference(projectId, jobId));
        
        /// <summary>
        /// Retrieves a job.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <returns>The retrieved job.</returns>
        public virtual BigqueryJob GetJob(JobReference jobReference)
        {
            throw new NotImplementedException();
        }
       
        /// <summary>
        /// Cancels the job with the specified ID in this client's project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="CancelJob(JobReference)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        public virtual void CancelJob(string jobId) => CancelJob(GetJobReference(jobId));

        /// <summary>
        /// Cancels the job with the specified project ID and job ID.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="CancelJob(JobReference)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        public virtual void CancelJob(string projectId, string jobId) => CancelJob(GetJobReference(projectId, jobId));

        /// <summary>
        /// Cancels a job.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        public virtual void CancelJob(JobReference jobReference)
        {
            throw new NotImplementedException();
        }
    }
}
