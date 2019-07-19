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
using System;
using static Google.Apis.Bigquery.v2.JobsResource;
using static Google.Apis.Bigquery.v2.JobsResource.ListRequest;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>ListJobs</c> operations.
    /// </summary>
    public sealed class ListJobsOptions
    {
        private static readonly DateTimeOffset UnixEpoch = new DateTimeOffset(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc), TimeSpan.Zero);

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

        /// <summary>
        /// The information to retrieve for listed jobs.
        /// </summary>
        public ProjectionEnum? Projection { get; set; }

        /// <summary>
        /// If set, this token is used to indicate a continued list operation.
        /// The value should be taken from the <c>NextPageToken</c> property of either
        /// a <see cref="Page{TResource}"/> or a raw response from <see cref="PagedEnumerable{TResponse, TResource}.AsRawResponses"/>.
        /// </summary>
        public string PageToken { get; set; }

        /// <summary>
        /// Min value for job creation time. If set, only jobs created after or at this timestamp are returned.
        /// </summary>
        public DateTimeOffset? MinCreationTime { get; set; }

        /// <summary>
        /// Max value for job creation time. If set, only jobs created before or at this timestamp are returned.
        /// </summary>
        public DateTimeOffset? MaxCreationTime { get; set; }

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

            if (Projection != null)
            {
                request.Projection = Projection;
            }

            if (PageToken != null)
            {
                request.PageToken = PageToken;
            }

            if (MinCreationTime != null)
            {
                request.MinCreationTime = ConvertDateTimeOffset(MinCreationTime.Value, nameof(MinCreationTime));
            }
            if (MaxCreationTime != null)
            {
                request.MaxCreationTime = ConvertDateTimeOffset(MaxCreationTime.Value, nameof(MaxCreationTime));
            }
            if (MinCreationTime > MaxCreationTime)
            {
                throw new ArgumentException($"{nameof(MinCreationTime)} cannot be later than {nameof(MaxCreationTime)}", "value");
            }
        }

        private ulong ConvertDateTimeOffset(DateTimeOffset value, string name)
        {
            if (value < UnixEpoch)
            {
                throw new ArgumentOutOfRangeException("value", $"{name} property cannot be earlier than 1970.");
            }
            return (ulong) (value - UnixEpoch).TotalMilliseconds;
        }
    }
}
