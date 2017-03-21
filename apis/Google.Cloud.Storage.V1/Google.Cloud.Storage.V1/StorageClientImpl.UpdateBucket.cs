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
    public sealed partial class StorageClientImpl : StorageClient
    {
        /// <inheritdoc />
        public override Bucket UpdateBucket(
            Bucket bucket,
            UpdateBucketOptions options = null)
            => CreateUpdateBucketRequest(bucket, options).Execute();

        /// <inheritdoc />
        public override Task<Bucket> UpdateBucketAsync(
            Bucket bucket,
            UpdateBucketOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
            => CreateUpdateBucketRequest(bucket, options).ExecuteAsync(cancellationToken);

        private BucketsResource.UpdateRequest CreateUpdateBucketRequest(Bucket bucket, UpdateBucketOptions options)
        {
            ValidateBucket(bucket, nameof(bucket));
            var request = Service.Buckets.Update(bucket, bucket.Name);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request, bucket);
            return request;
        }
    }
}
