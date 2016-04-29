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
using System.Linq;
using System.Threading.Tasks;

namespace Google.Bigquery.V2
{
    /// <summary>
    /// A dataset within Bigquery.
    /// </summary>
    /// <remarks>
    /// This class wraps the underlying HTTP API resource and retains a reference to the original
    /// client, allowing for simpler job-oriented operations.
    /// </remarks>
    public sealed class BigqueryJob
    {
        private readonly BigqueryClient _client;
        // TODO: We may want to expose this publicly.
        private readonly Job _apiResource;

        /// <summary>
        /// The fully-qualified identifier for the job.
        /// </summary>
        /// <remarks>
        /// The properties within the reference can be used to determine the project ID
        /// and job ID components.
        /// </remarks>
        public JobReference Reference => _apiResource.JobReference;

        // TODO: Use an enum instead? Definitely nicer than magic strings.

        /// <summary>
        /// The state of the job: "RUNNING", "PENDING" or "DONE".
        /// </summary>
        public string State => _apiResource.Status.State;

        /// <summary>
        /// The statistics of the job.
        /// </summary>
        public JobStatistics Statistics => _apiResource.Statistics;

        /// <summary>
        /// The full status of the job, including any errors.
        /// </summary>
        public JobStatus Status => _apiResource.Status;

        internal BigqueryJob(BigqueryClient client, Job apiResource)
        {
            _client = client;
            _apiResource = apiResource;
        }

        internal BigqueryJob(BigqueryClient client, JobList.JobsData job)
        {
            _client = client;
            _apiResource = new Job
            {
                JobReference = job.JobReference,
                Status = job.Status,
                Id = job.Id,
                Statistics = job.Statistics,
                Configuration = job.Configuration,
                UserEmail = job.UserEmail,
                Kind = job.Kind
            };
        }

        // TODO: Poll frequency and time-outs.

        /// <summary>
        /// Polls this job for completion.
        /// </summary>
        /// <returns>The completed job.</returns>
        public BigqueryJob Poll() => _client.PollJob(Reference);

        /// <summary>
        /// Retrieves the result of this job, which must be a query job.
        /// </summary>
        /// <returns>The result of the query.</returns>
        public BigqueryResult GetQueryResult() => _client.GetQueryResult(Reference);

        /// <summary>
        /// Cancels this job.
        /// </summary>
        public void Cancel() => _client.CancelJob(Reference);

        // TODO: Refresh? Could easily call GetJob, but can't easily modify *this* job...
    }
}
