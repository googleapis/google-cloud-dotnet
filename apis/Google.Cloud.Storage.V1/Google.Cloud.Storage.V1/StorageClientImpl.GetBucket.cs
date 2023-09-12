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
    public partial class StorageClientImpl
    {
        /// <inheritdoc />
        public override Bucket GetBucket(string bucket, GetBucketOptions options = null) =>
            CreateGetBucketRequest(bucket, options).Execute();

        /// <inheritdoc />
        public override Task<Bucket> GetBucketAsync(string bucket, GetBucketOptions options = null,
            CancellationToken cancellationToken = default) =>
            CreateGetBucketRequest(bucket, options).ExecuteAsync();

        private BucketsResource.GetRequest CreateGetBucketRequest(string bucket, GetBucketOptions options)
        {
            ValidateBucketName(bucket);
            var request = Service.Buckets.Get(bucket);
            options?.ModifyRequest(request);
            RetryOptions retryOptions = options?.RetryOptions ?? RetryOptions.IdempotentRetryOptions;
            MarkAsRetriable(request, retryOptions);
            return request;
        }
    }
}
