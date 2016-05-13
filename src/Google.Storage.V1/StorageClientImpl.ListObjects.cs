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

using Google.Apis.Requests;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Storage.V1
{
    // ListObjects methods on StorageClient
    public sealed partial class StorageClientImpl : StorageClient
    {
        private static readonly PageStreamer<Object, ObjectsResource.ListRequest, Objects, string> s_objectPageStreamer =
            new PageStreamer<Object, ObjectsResource.ListRequest, Objects, string>(
                (request, token) => request.PageToken = token,
                objects => objects.NextPageToken,
                objects => objects.Items);

        /// <inheritdoc />
        public override Task<IList<Object>> ListAllObjectsAsync(
            string bucket,
            string prefix,
            ListObjectsOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var initialRequest = CreateListObjectsRequest(bucket, prefix, options);
            return s_objectPageStreamer.FetchAllAsync(initialRequest, cancellationToken);
        }

        /// <inheritdoc />
        public override IEnumerable<Object> ListObjects(string bucket, string prefix, ListObjectsOptions options = null)
        {
            var initialRequest = CreateListObjectsRequest(bucket, prefix, options);
            return s_objectPageStreamer.Fetch(initialRequest);
        }

        private ObjectsResource.ListRequest CreateListObjectsRequest(string bucket, string prefix, ListObjectsOptions options)
        {
            ValidateBucketName(bucket);
            var request = Service.Objects.List(bucket);
            request.Prefix = prefix;
            options?.ModifyRequest(request);
            return request;
        }
    }
}
