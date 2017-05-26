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
using static Google.Apis.Storage.v1.ObjectsResource;
using static Google.Apis.Storage.v1.ObjectsResource.ListRequest;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Options for <c>ListObjects</c> operations.
    /// </summary>
    public sealed class ListObjectsOptions
    {
        // TODO: We can't currently return both objects *and* prefixes. Should we have a separate ListPrefixes method?
        // Something more complex? It's unclear how common this is.

        /// <summary>
        /// Used to list in "directory mode". Only objects whose names (aside from the prefix) do not contain delimiter
        /// will be returned.
        /// </summary>
        public string Delimiter { get; set; }

        /// <summary>
        /// The number of results to return per page. (This modifies the per-request page size;
        /// it does not affect the total number of results returned.)
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Controls whether or not multiple versions of an object are listed separately (true)
        /// or not (false). The default API behavior is equivalent to setting this to false, but
        /// it is still a nullable property to allow the intention of "definitely false" to be
        /// separate from "not set".
        /// </summary>
        public bool? Versions { get; set; }

        /// <summary>
        /// The projection to retrieve.
        /// </summary>
        public Projection? Projection { get; set; }

        /// <summary>
        /// If set, this is the ID of the project which will be billed for the request, for requester-pays buckets.
        /// The caller must have suitable permissions for the project being billed.
        /// </summary>
        public string UserProject { get; set; }

        /// <summary>
        /// Modifies the specified request for all non-null properties of this options object.
        /// </summary>
        /// <param name="request">The request to modify</param>
        internal void ModifyRequest(ListRequest request)
        {
            if (PageSize != null)
            {
                request.MaxResults = PageSize;
            }
            if (Delimiter != null)
            {
                request.Delimiter = Delimiter;
            }
            if (Versions != null)
            {
                request.Versions = Versions;
            }
            if (Projection != null)
            {
                request.Projection = GaxPreconditions.CheckEnumValue((ProjectionEnum) Projection, nameof(Projection));
            }
            if (UserProject != null)
            {
                request.UserProject = UserProject;
            }
        }
    }
}
