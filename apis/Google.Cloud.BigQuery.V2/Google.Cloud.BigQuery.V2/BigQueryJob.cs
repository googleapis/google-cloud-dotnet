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
using Google.Apis.Requests;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// An asynchronous job within BigQuery.
    /// </summary>
    /// <remarks>
    /// This class wraps the underlying REST API resource and retains a reference to the original
    /// client, allowing for simpler job-oriented operations.
    /// </remarks>
    public sealed class BigQueryJob
    {
        private readonly BigQueryClient _client;
        
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
        /// The statistics of the job. This is short-hand for <c>Resource.Statistics</c>.
        /// </summary>
        public JobStatistics Statistics => Resource.Statistics;

        /// <summary>
        /// The full status of the job, including any errors. This is short-hand for <c>Resource.Status</c>.
        /// </summary>
        public JobStatus Status => Resource.Status;

        /// <summary>
        /// Constructs a new job.
        /// </summary>
        /// <remarks>
        /// This is public to allow tests to construct instances for production code to consume;
        /// production code should not normally construct instances itself.
        /// </remarks>
        /// <param name="client">The client to use for operations on the job. Must not be null.</param>
        /// <param name="resource">The REST-ful resource representing the job. Must not be null.</param>
        public BigQueryJob(BigQueryClient client, Job resource)
        {
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
            Resource = GaxPreconditions.CheckNotNull(resource, nameof(resource));
        }

        internal BigQueryJob(BigQueryClient client, JobList.JobsData resource)
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
        /// Returns <c>this</c> if the job has no errors, or throws an exception containing the
        /// errors. A job may have errors but still contain useful information, and may also contain
        /// errors before completing.
        /// </summary>
        /// <exception cref="GoogleApiException">The job has errors.</exception>
        /// <returns><c>this</c> if the job has no errors.</returns>
        public BigQueryJob ThrowOnAnyError()
        {
            var errors = Resource.Status?.Errors;
            if (errors?.Count > 0)
            {
                throw new GoogleApiException(_client.Service.Name, $"Job {Reference?.ProjectId}/{Reference?.Location}/{Reference?.JobId} contained errors")
                {
                    Error = new RequestError
                    {
                        Errors = errors.Select(error => new SingleError
                            {
                                Location = error.Location,
                                Reason = error.Reason,
                                Message = error.Message
                            })
                            .ToList()
                    }
                };
            }
            return this;
        }

        /// <summary>
        /// Polls this job for completion, returning a new <see cref="BigQueryJob"/> object with the updated information.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="BigQueryClient.PollJobUntilCompleted(JobReference, GetJobOptions, PollSettings)"/>.
        /// </summary>
        /// <remarks>
        /// Note that this method does not modify the state of the object it is called on. Instead, a new object is returned.
        /// If you need to check that the job completed without errors, or access any other information, you need to use the
        /// return value of the method.
        /// </remarks>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.
        /// May be null, in which case defaults will be supplied.</param>
        /// <returns>The completed job.</returns>
        public BigQueryJob PollUntilCompleted(GetJobOptions options = null, PollSettings pollSettings = null) =>
            _client.PollJobUntilCompleted(Reference, options, pollSettings);

        /// <summary>
        /// Retrieves the result of this job, which must be a query job.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="BigQueryClient.GetQueryResults(JobReference, GetQueryResultsOptions)"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method will only return when the query has completed.
        /// </para>
        /// </remarks>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The result of the query.</returns>
        public BigQueryResults GetQueryResults(GetQueryResultsOptions options = null) => _client.GetQueryResults(Reference, GetQueryDestinationTable(), options);

        /// <summary>
        /// Cancels this job.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="BigQueryClient.CancelJob(JobReference, CancelJobOptions)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The final state of the job.</returns>
        public BigQueryJob Cancel(CancelJobOptions options = null) => _client.CancelJob(Reference, options);

        /// <summary>
        /// Asynchronously polls this job for completion.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="BigQueryClient.PollJobUntilCompletedAsync(JobReference, GetJobOptions, PollSettings, CancellationToken)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.
        /// May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the completed job.</returns>
        public Task<BigQueryJob> PollUntilCompletedAsync(GetJobOptions options = null, PollSettings pollSettings = null, CancellationToken cancellationToken = default) =>
            _client.PollJobUntilCompletedAsync(Reference, options, pollSettings, cancellationToken);

        /// <summary>
        /// Asynchronously retrieves the result of this job, which must be a query job.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="BigQueryClient.GetQueryResultsAsync(JobReference, GetQueryResultsOptions, CancellationToken)"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The task returned by this method will only complete when the query has completed.
        /// </para>
        /// </remarks>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a <see cref="BigQueryResults"/> representation of the query.</returns>
        public Task<BigQueryResults> GetQueryResultsAsync(GetQueryResultsOptions options = null, CancellationToken cancellationToken = default) =>
            _client.GetQueryResultsAsync(Reference, GetQueryDestinationTable(), options, cancellationToken);

        /// <summary>
        /// Asynchronously cancels this job.
        /// This method just creates a <see cref="JobReference"/> and delegates to <see cref="BigQueryClient.CancelJobAsync(JobReference, CancelJobOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the final state of the job.</returns>
        public Task<BigQueryJob> CancelAsync(CancelJobOptions options = null, CancellationToken cancellationToken = default) =>
            _client.CancelJobAsync(Reference, options, cancellationToken);

        /// <summary>
        /// The query destination table can be null if it's been fetched with and odd field mask
        /// or for script queries. We use the destination table only to pass around in
        /// results so it's OK to return null here.
        /// </summary>
        private TableReference GetQueryDestinationTable()
        {
            var query = Resource?.Configuration?.Query;
            if (query == null)
            {
                throw new InvalidOperationException("Job doesn't represent a query");
            }
            if (Reference == null || Reference.ProjectId == null || Reference.JobId == null)
            {
                throw new InvalidOperationException("Job has no ID. (This can happen for dry run queries.)");
            }
            ThrowOnAnyError();
            return query.DestinationTable;
        }

        // TODO: Refresh? Could easily call GetJob, but can't easily modify *this* job...
    }
}
