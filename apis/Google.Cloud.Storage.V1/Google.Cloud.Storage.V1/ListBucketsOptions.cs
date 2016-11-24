// Copyright 2015 Google Inc. All Rights Reserved.
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
using static Google.Apis.Storage.v1.BucketsResource;
using static Google.Apis.Storage.v1.BucketsResource.ListRequest;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Options for <c>ListBuckets</c> operations.
    /// </summary>
    public sealed class ListBucketsOptions
    {
        /// <summary>
        /// The prefix to match. Only buckets with names that start with this string will be returned.
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// The number of results to return per page. (This modifies the per-request page size;
        /// it does not affect the total number of results returned.)
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// The projection to retrieve.
        /// </summary>
        public Projection? Projection { get; set; }

        /// <summary>
        /// Modifies the specified request for all non-null properties of this options object.
        /// </summary>
        /// <param name="request">The request to modify</param>
        internal void ModifyRequest(ListRequest request)
        {
            if (Prefix != null)
            {
                request.Prefix = Prefix;
            }
            if (PageSize != null)
            {
                request.MaxResults = PageSize;
            }
            if (Projection != null)
            {
                request.Projection = GaxPreconditions.CheckEnumValue((ProjectionEnum) Projection, nameof(Projection));
            }
        }
    }
}
