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

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    public partial class StorageClient
    {
        /// <summary>
        /// Locks the retention policy of a bucket. This is a one-way process:
        /// once a retention policy is locked, it cannot be shortened, removed or unlocked,
        /// although it can be increased in duration. The lock persists until the bucket is deleted.
        /// </summary>
        /// <param name="bucket">The name of the bucket whose retention policy should be locked. Must not be null.</param>
        /// <param name="metageneration">The current metageneration of the bucket, used to validate that the bucket version to be locked
        /// is the intended one.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void LockBucketRetentionPolicy(string bucket, long metageneration, LockBucketRetentionPolicyOptions options = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// Asynchronously locks the retention policy of a bucket. This is a one-way process:
        /// once a retention policy is locked, it cannot be shortened, removed or unlocked,
        /// although it can be increased in duration. The lock persists until the bucket is deleted.
        /// </summary>
        /// <param name="bucket">The name of the bucket whose retention policy should be locked. Must not be null.</param>
        /// <param name="metageneration">The current metageneration of the bucket, used to validate that the bucket version to be locked
        /// is the intended one.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task LockBucketRetentionPolicyAsync(string bucket, long metageneration, LockBucketRetentionPolicyOptions options = null, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();
    }
}
