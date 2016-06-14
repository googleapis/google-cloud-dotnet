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

using Google.Api.Gax.Rest;
using Google.Apis.Requests;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Storage.V1
{
    // ListBuckets methods on StorageClient
    public sealed partial class StorageClientImpl : StorageClient
    {
        private static readonly PageStreamer<Bucket, BucketsResource.ListRequest, Buckets, string> s_bucketPageStreamer =
            new PageStreamer<Bucket, BucketsResource.ListRequest, Buckets, string>(
                (request, token) => request.PageToken = token,
                buckets => buckets.NextPageToken,
                buckets => buckets.Items);

        /// <inheritdoc />
        public override Task<IList<Bucket>> ListAllBucketsAsync(
            string projectId,
            ListBucketsOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxRestPreconditions.CheckNotNull(projectId, nameof(projectId));
            var initialRequest = CreateListBucketsRequest(projectId, options);
            return s_bucketPageStreamer.FetchAllAsync(initialRequest, cancellationToken);
        }

        /// <inheritdoc />
        public override IEnumerable<Bucket> ListBuckets(string projectId, ListBucketsOptions options = null)
        {
            GaxRestPreconditions.CheckNotNull(projectId, nameof(projectId));
            var initialRequest = CreateListBucketsRequest(projectId, options);
            return s_bucketPageStreamer.Fetch(initialRequest);
        }

        private BucketsResource.ListRequest CreateListBucketsRequest(string projectId, ListBucketsOptions options)
        {
            var request = Service.Buckets.List(projectId);
            options?.ModifyRequest(request);
            return request;
        }
    }
}
