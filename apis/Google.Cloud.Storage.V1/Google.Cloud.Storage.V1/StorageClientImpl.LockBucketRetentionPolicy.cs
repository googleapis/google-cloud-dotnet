// Copyright 2018 Google LLC
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

using Google.Apis.Storage.v1;
using System;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    public partial class StorageClientImpl
    {
        /// <inheritdoc />
        public override void LockBucketRetentionPolicy(string bucket, long metageneration, LockBucketRetentionPolicyOptions options = null)
        {
            ValidateBucketName(bucket);
            CreateLockBucketRetentionPolicyRequest(bucket, metageneration, options).Execute();
        }

        /// <inheritdoc />
        public override Task LockBucketRetentionPolicyAsync(
            string bucket,
            long metageneration,
            LockBucketRetentionPolicyOptions options = null,
            CancellationToken cancellationToken = default)
        {
            ValidateBucketName(bucket);
            return CreateLockBucketRetentionPolicyRequest(bucket, metageneration, options).ExecuteAsync(cancellationToken);
        }

        private BucketsResource.LockRetentionPolicyRequest CreateLockBucketRetentionPolicyRequest(
            string bucket, long metageneration, LockBucketRetentionPolicyOptions options)
        {
            var request = Service.Buckets.LockRetentionPolicy(bucket, metageneration);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            return request;
        }
    }
}