// Copyright 2019 Google LLC
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
using Google.Apis.Storage.v1;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Options for <c>ListHmacKey</c> operations.
    /// </summary>
    public sealed class ListHmacKeysOptions
    {
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
        /// If set, this determines whether deleted keys are included in the results.
        /// </summary>
        public bool? ShowDeletedKeys { get; set; }

        /// <summary>
        /// Options to pass custom retry configuration for each API request.
        /// </summary>
        public RetryOptions RetryOptions { get; set; }

        internal void ModifyRequest(ProjectsResource.HmacKeysResource.ListRequest request)
        {
            if (PageSize != null)
            {
                request.MaxResults = PageSize;
            }
            if (PageToken != null)
            {
                request.PageToken = PageToken;
            }
            if (ShowDeletedKeys != null)
            {
                request.ShowDeletedKeys = ShowDeletedKeys;
            }
        }
    }
}
