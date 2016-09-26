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

namespace Google.Bigquery.V2
{
    /// <summary>
    /// A dataset within Bigquery.
    /// </summary>
    /// <remarks>
    /// This class wraps the underlying REST API resource and retains a reference to the original
    /// client, allowing for simpler job-oriented operations.
    /// </remarks>
    public sealed class BigqueryJob
    {
        private readonly BigqueryClient _client;
        
        /// <summary>
        /// The underlying REST-ful resource for the job.
        /// </summary>
        /// <remarks>
        /// The data within the resource may be incomplete, depending on how it was obtained.
        /// </remarks>
        public Job Resource { get; }

        /// <summary>
        /// The fully-qualified identifier for the job. This is short-hand for <c>Resource.JobReference</c>.
        /// </summary>
        /// <remarks>
        /// The properties within the reference can be used to determine the project ID
        /// and job ID components.
        /// </remarks>
        public JobReference Reference => Resource.JobReference;

        /// <summary>
        /// The state of the job.
        /// </summary>
        public JobState State => EnumMap<JobState>.ToValue(Resource.Status.State);

        /// <summary>
        /// The statistics of the job. This is short-hand for <c>Resource.Statistcs</c>.
        /// </summary>
        public JobStatistics Statistics => Resource.Statistics;

        /// <summary>
        /// The full status of the job, including any errors. This is short-hand for <c>Resource.Status</c>.
        /// </summary>
        public JobStatus Status => Resource.Status;

        internal BigqueryJob(BigqueryClient client, Job resource)
        {
            _client = client;
            Resource = resource;
        }

        internal BigqueryJob(BigqueryClient client, JobList.JobsData resource)
        {
            _client = client;
            Resource = new Job
            {
                JobReference = resource.JobReference,
                Status = resource.Status,
                Id = resource.Id,
                Statistics = resource.Statistics,
                Configuration = resource.Configuration,
                UserEmail = resource.UserEmail,
                Kind = resource.Kind
            };
        }

        /// <summary>
        /// Polls this job for completion.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The completed job.</returns>
        public BigqueryJob PollUntilCompleted(PollJobOptions options = null) => _client.PollJobUntilCompleted(Reference, options);

        /// <summary>
        /// Polls this job for completion, which must be a query job.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollOptions">The options controlling polling. May be null, in which case defaults will be supplied.</param>
        /// <returns>The completed job.</returns>
        public BigqueryQueryJob PollQueryUntilCompleted(GetQueryResultsOptions options = null, PollJobOptions pollOptions = null) =>
            _client.PollQueryUntilCompleted(Reference, options, pollOptions);

        /// <summary>
        /// Retrieves the result of this job, which must be a query job.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The result of the query.</returns>
        public BigqueryQueryJob GetQueryResults(GetQueryResultsOptions options = null) => _client.GetQueryJob(Reference, options);

        /// <summary>
        /// Cancels this job.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public void Cancel(CancelJobOptions options = null) => _client.CancelJob(Reference, options);

        // TODO: Refresh? Could easily call GetJob, but can't easily modify *this* job...
    }
}
