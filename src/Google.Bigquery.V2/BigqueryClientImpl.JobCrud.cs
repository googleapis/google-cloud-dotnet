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

using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Google.Bigquery.V2
{
    public partial class BigqueryClientImpl
    {
        private static readonly PageStreamer<JobList.JobsData, JobsResource.ListRequest, JobList, string> s_jobsPageStreamer =
            new PageStreamer<JobList.JobsData, JobsResource.ListRequest, JobList, string>(
                (request, token) => request.PageToken = token,
                response => response.NextPageToken,
                response => response.Jobs);

        /// <inheritdoc />
        public override IEnumerable<BigqueryJob> ListJobs(ProjectReference projectReference, ListJobsOptions options = null)
        {
            Preconditions.CheckNotNull(projectReference, nameof(projectReference));

            var initialRequest = CreateListJobsRequest(projectReference, options);
            return s_jobsPageStreamer.Fetch(initialRequest).Select(job => new BigqueryJob(this, job));
        }

        private JobsResource.ListRequest CreateListJobsRequest(ProjectReference projectReference, ListJobsOptions options)
        {
            var request = Service.Jobs.List(projectReference.ProjectId);
            options?.ModifyRequest(request);
            return request;
        }

        /// <inheritdoc />
        public override BigqueryJob PollJob(JobReference jobReference)
        {
            Preconditions.CheckNotNull(jobReference, nameof(jobReference));

            while (true)
            {
                var job = GetJob(jobReference);
                switch (job.State)
                {
                    case "DONE":
                        return job;
                    case "PENDING":
                    case "RUNNING":
                        break;
                    default:
                        throw new InvalidOperationException($"Unexpected status: {job.Status.State}");
                }
                // TODO: Parameterize this
                Thread.Sleep(1000);
            }
        }

        /// <inheritdoc />
        public override BigqueryJob GetJob(JobReference jobReference)
        {
            Preconditions.CheckNotNull(jobReference, nameof(jobReference));

            var job = Service.Jobs.Get(jobReference.ProjectId, jobReference.JobId).Execute();
            return new BigqueryJob(this, job);
        }

        /// <inheritdoc />
        public override void CancelJob(JobReference jobReference)
        {
            Preconditions.CheckNotNull(jobReference, nameof(jobReference));

            Service.Jobs.Cancel(jobReference.ProjectId, jobReference.JobId).Execute();
        }
    }
}
