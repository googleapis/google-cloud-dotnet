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
using Google.Api.Gax.Rest;
using Google.Apis.Requests;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    // ListObjects methods on StorageClient
    public sealed partial class StorageClientImpl : StorageClient
    {
        private sealed class ObjectPageManager : IPageManager<ObjectsResource.ListRequest, Objects, Object>
        {
            internal static readonly ObjectPageManager Instance = new ObjectPageManager();
            public string GetNextPageToken(Objects response) => response.NextPageToken;
            public IEnumerable<Object> GetResources(Objects response) => response.Items;
            public void SetPageSize(ObjectsResource.ListRequest request, int pageSize) => request.MaxResults = pageSize;
            public void SetPageToken(ObjectsResource.ListRequest request, string pageToken) => request.PageToken = pageToken;
        }

        /// <inheritdoc />
        public override PagedAsyncEnumerable<Objects, Object> ListObjectsAsync(
            string bucket,
            string prefix = null,
            ListObjectsOptions options = null)
        {
            ValidateBucketName(bucket);
            return new RestPagedAsyncEnumerable<ObjectsResource.ListRequest, Objects, Object>(
                () => CreateListObjectsRequest(bucket, prefix, options), ObjectPageManager.Instance);
        }

        /// <inheritdoc />
        public override PagedEnumerable<Objects, Object> ListObjects(string bucket, string prefix = null, ListObjectsOptions options = null)
        {
            ValidateBucketName(bucket);
            return new RestPagedEnumerable<ObjectsResource.ListRequest, Objects, Object>(
                () => CreateListObjectsRequest(bucket, prefix, options), ObjectPageManager.Instance);
        }

        private ObjectsResource.ListRequest CreateListObjectsRequest(string bucket, string prefix, ListObjectsOptions options)
        {
            var request = Service.Objects.List(bucket);
            request.ModifyRequest += _versionHeaderAction;
            request.Prefix = prefix;
            options?.ModifyRequest(request);
            return request;
        }
    }
}
