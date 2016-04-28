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
        /// Lists the jobs in this client's project.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <returns>The jobs in this client's projects.</returns>
        public virtual IEnumerable<JobList.JobsData> ListJobs(ListJobsOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Polls the specified job for completion.
        /// This method just uses the job's <see cref="JobReference"/> and delegates to <see cref="PollJob(JobReference)"/>.
        /// </summary>
        /// <param name="job">The job to poll. Must not be null.</param>
        /// <returns>The completed job.</returns>
        public virtual Job PollJob(Job job) => PollJob(Preconditions.CheckNotNull(job, nameof(job)).JobReference);


        /// <summary>
        /// Polls the job with the specified ID in this client's project for completion.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="PollJob(JobReference)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <returns>The completed job.</returns>
        public virtual Job PollJob(string jobId) => PollJob(GetJobReference(jobId));

        /// <summary>
        /// Polls the specified job for completion.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <returns>The completed job.</returns>
        public virtual Job PollJob(JobReference jobReference)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves the job with the specified ID within this client's project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="GetJob(JobReference)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <returns>The retrieved job.</returns>
        public virtual Job GetJob(string jobId) => GetJob(GetJobReference(jobId));

        /// <summary>
        /// Retrieves a job.
        /// </summary>
        /// <param name="jobReference">A fully-qualified identifier for the job. Must not be null.</param>
        /// <returns>The retrieved job.</returns>
        public virtual Job GetJob(JobReference jobReference)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cancels the specified job.
        /// This method just uses the job's <see cref="JobReference"/> and delegates to <see cref="CancelJob(JobReference)"/>.
        /// </summary>
        /// <param name="job">The job to cancel. Must not be null.</param>
        public virtual void CancelJob(Job job) => CancelJob(Preconditions.CheckNotNull(job, nameof(job)).JobReference);

        /// <summary>
        /// Cancels the job with the specified ID in this client's project.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="CancelJob(JobReference)"/>.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        public virtual void CancelJob(string jobId) => CancelJob(GetJobReference(jobId));

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
