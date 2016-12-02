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
using Google.Api.Gax.Rest;
using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Bigquery.v2.JobsResource;

namespace Google.Cloud.BigQuery.V2
{
    public partial class BigQueryClientImpl
    {
        private static readonly PollSettings s_defaultPollSettings = new PollSettings(Expiration.None, TimeSpan.FromSeconds(5));

        private sealed class JobPageManager : IPageManager<ListRequest, JobList, BigQueryJob>
        {
            private readonly BigQueryClient _client;

            internal JobPageManager(BigQueryClient client)
            {
                _client = client;
            }

            public string GetNextPageToken(JobList response) => response.NextPageToken;
            public IEnumerable<BigQueryJob> GetResources(JobList response) => response.Jobs?.Select(resource => new BigQueryJob(_client, resource));
            public void SetPageSize(ListRequest request, int pageSize) => request.MaxResults = pageSize;
            public void SetPageToken(ListRequest request, string pageToken) => request.PageToken = pageToken;
        }

        /// <inheritdoc />
        public override PagedEnumerable<JobList, BigQueryJob> ListJobs(ProjectReference projectReference, ListJobsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(projectReference, nameof(projectReference));

            var pageManager = new JobPageManager(this);
            return new RestPagedEnumerable<ListRequest, JobList, BigQueryJob>(
                () => CreateListJobsRequest(projectReference, options),
                pageManager);
        }

        private ListRequest CreateListJobsRequest(ProjectReference projectReference, ListJobsOptions options = null)
        {
            var request = Service.Jobs.List(projectReference.ProjectId);
            options?.ModifyRequest(request);
            return request;
        }

        /// <inheritdoc />
        public override BigQueryJob PollJobUntilCompleted(JobReference jobReference, GetJobOptions options = null, PollSettings pollSettings = null)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            return Polling.PollRepeatedly(ignoredDeadline => GetJob(jobReference, options),
                job => job.State == JobState.Done,
                Clock, Scheduler, pollSettings ?? s_defaultPollSettings, CancellationToken.None);
        }

        /// <inheritdoc />
        public override BigQueryJob GetJob(JobReference jobReference, GetJobOptions options = null)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));

            var request = Service.Jobs.Get(jobReference.ProjectId, jobReference.JobId);
            options?.ModifyRequest(request);
            var job = request.Execute();
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override BigQueryJob CancelJob(JobReference jobReference, CancelJobOptions options = null)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            var request = Service.Jobs.Cancel(jobReference.ProjectId, jobReference.JobId);
            options?.ModifyRequest(request);
            var result = request.Execute();
            return new BigQueryJob(this, result.Job);
        }

        /// <inheritdoc />
        public override PagedAsyncEnumerable<JobList, BigQueryJob> ListJobsAsync(ProjectReference projectReference, ListJobsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(projectReference, nameof(projectReference));

            var pageManager = new JobPageManager(this);
            return new RestPagedAsyncEnumerable<ListRequest, JobList, BigQueryJob>(
                () => CreateListJobsRequest(projectReference, options),
                pageManager);
        }

        /// <inheritdoc />
        public override Task<BigQueryJob> PollJobUntilCompletedAsync(JobReference jobReference, GetJobOptions options = null,
            PollSettings pollSettings = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            return Polling.PollRepeatedlyAsync(ignoredDeadline => GetJobAsync(jobReference, options, cancellationToken),
                job => job.State == JobState.Done,
                Clock, Scheduler, pollSettings ?? s_defaultPollSettings, cancellationToken);
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> GetJobAsync(JobReference jobReference, GetJobOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));

            var request = Service.Jobs.Get(jobReference.ProjectId, jobReference.JobId);
            options?.ModifyRequest(request);
            var job = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> CancelJobAsync(JobReference jobReference, CancelJobOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            var request = Service.Jobs.Cancel(jobReference.ProjectId, jobReference.JobId);
            options?.ModifyRequest(request);
            var result = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryJob(this, result.Job);
        }
    }
}
