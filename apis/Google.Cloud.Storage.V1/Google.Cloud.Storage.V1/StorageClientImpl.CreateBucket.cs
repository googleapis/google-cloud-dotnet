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
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    public partial class StorageClientImpl
    {
        /// <inheritdoc />
        public override Bucket CreateBucket(string projectId, string bucket, CreateBucketOptions options = null) =>
            CreateCreateBucketRequest(projectId, bucket, options).Execute();

        /// <inheritdoc />
        public override Task<Bucket> CreateBucketAsync(string projectId, string bucket, CreateBucketOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken)) =>
            CreateCreateBucketRequest(projectId, bucket, options).ExecuteAsync(cancellationToken);

        /// <inheritdoc />
        public override Bucket CreateBucket(string projectId, Bucket bucket, CreateBucketOptions options = null) =>
            CreateCreateBucketRequest(projectId, bucket, options).Execute();

        /// <inheritdoc />
        public override Task<Bucket> CreateBucketAsync(string projectId, Bucket bucket, CreateBucketOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            CreateCreateBucketRequest(projectId, bucket, options).ExecuteAsync(cancellationToken);

        private BucketsResource.InsertRequest CreateCreateBucketRequest(string projectId, string bucket, CreateBucketOptions options)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            ValidateBucketName(bucket);
            var bucketEntity = new Bucket { Name = bucket };
            var request = Service.Buckets.Insert(bucketEntity, projectId);
            options?.ModifyRequest(request);
            return request;
        }

        private BucketsResource.InsertRequest CreateCreateBucketRequest(string projectId, Bucket bucket, CreateBucketOptions options)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            ValidateBucket(bucket, nameof(bucket));
            var request = Service.Buckets.Insert(bucket, projectId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            return request;
        }
    }
}
