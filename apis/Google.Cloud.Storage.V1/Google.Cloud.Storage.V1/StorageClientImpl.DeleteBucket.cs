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

using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class StorageClientImpl : StorageClient
    {
        /// <inheritdoc />
        public override void DeleteBucket(string bucket, DeleteBucketOptions options = null) =>
            CreateDeleteBucketRequest(bucket, options).Execute();

        /// <inheritdoc />
        public override Task DeleteBucketAsync(
            string bucket,
            DeleteBucketOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken)
        ) => CreateDeleteBucketRequest(bucket, options).ExecuteAsync(cancellationToken);

        /// <inheritdoc />
        public override void DeleteBucket(Bucket bucket, DeleteBucketOptions options = null)
            => CreateDeleteBucketRequest(bucket, options).Execute();

        /// <inheritdoc />
        public override Task DeleteBucketAsync(
            Bucket bucket,
            DeleteBucketOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken)
        ) => CreateDeleteBucketRequest(bucket, options).ExecuteAsync(cancellationToken);

        private BucketsResource.DeleteRequest CreateDeleteBucketRequest(Bucket bucket, DeleteBucketOptions options)
        {
            ValidateBucket(bucket, nameof(bucket));
            var request = Service.Buckets.Delete(bucket.Name);
            options?.ModifyRequest(request);
            return request;
        }

        private BucketsResource.DeleteRequest CreateDeleteBucketRequest(string bucket, DeleteBucketOptions options)
        {
            ValidateBucketName(bucket);
            var request = Service.Buckets.Delete(bucket);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            return request;
        }
    }
}
