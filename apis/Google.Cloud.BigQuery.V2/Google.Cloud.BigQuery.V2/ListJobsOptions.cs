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

using static Google.Apis.Bigquery.v2.JobsResource;
using static Google.Apis.Bigquery.v2.JobsResource.ListRequest;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>ListJobs</c> operations.
    /// </summary>
    public sealed class ListJobsOptions
    {
        /// <summary>
        /// If set, only return jobs in the specified state.
        /// </summary>
        public JobState? StateFilter { get; set; }

        /// <summary>
        /// The number of results to return per page. (This modifies the per-request page size;
        /// it does not affect the total number of results returned.)
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// When set to true, jobs for all users will be listed. By default, only jobs
        /// for the current user will be listed.
        /// </summary>
        public bool? AllUsers { get; set; }

        internal void ModifyRequest(ListRequest request)
        {
            if (StateFilter != null)
            {
                request.StateFilter = (StateFilterEnum)StateFilter;
            }

            if (PageSize != null)
            {
                request.MaxResults = PageSize;
            }

            if (AllUsers != null)
            {
                request.AllUsers = AllUsers;
            }

            // TODO: Projection?
        }
    }
}
