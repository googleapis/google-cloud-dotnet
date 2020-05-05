// Copyright 2020 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using static Google.Apis.Bigquery.v2.RoutinesResource;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>ListModels</c> operations.
    /// </summary>
    public sealed class ListRoutinesOptions
    {
        private const string RoutineTypeFilterName = "routineType";
        /// <summary>
        /// The number of results to return per page. (This modifies the per-request page size;
        /// it does not affect the total number of results returned.)
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// If set, this token is used to indicate a continued list operation.
        /// The value should be taken from the <c>NextPageToken</c> property of either
        /// a <see cref="Page{TResource}"/> or a raw response from <see cref="PagedEnumerable{TResponse, TResource}.AsRawResponses"/>.
        /// </summary>
        public string PageToken { get; set; }

        /// <summary>
        /// Comma separated list of fully qualified names of <see cref="Routine"/> fields that
        /// will be populated in the returned resource.
        /// If unset then only fields enumerated here are returned:
        /// https://cloud.google.com/bigquery/docs/reference/rest/v2/routines/list#query-parameters.
        /// </summary>
        public string ReadMask { get; set; }

        /// <summary>
        /// If set, only routines with the given <see cref="RoutineType"/> will be listed.
        /// </summary>
        public RoutineType? RoutineTypeFilter { get; set; }

        internal void ModifyRequest(ListRequest request)
        {
            if (PageSize != null)
            {
                request.MaxResults = PageSize;
            }
            if (PageToken != null)
            {
                request.PageToken = PageToken;
            }
            if (ReadMask != null)
            {
                request.ReadMask = ReadMask;
            }
            if (RoutineTypeFilter.HasValue)
            {
                request.Filter = $"{RoutineTypeFilterName}:{EnumMap.ToApiValue(RoutineTypeFilter.Value, nameof(RoutineTypeFilter))}";
            }
        }
    }
}