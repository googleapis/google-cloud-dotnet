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

using Google.Apis.Storage.v1.Data;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    public abstract partial class StorageClient
    {
        /// <summary>
        /// Creates a storage bucket synchronously.
        /// </summary>
        /// <param name="projectId">The ID of the project to create the buckets in. Must not be null.</param>
        /// <param name="bucket">The name of the bucket to create. Must not be null.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <returns>The resource representation of the newly-created bucket.</returns>
        public virtual Bucket CreateBucket(string projectId, string bucket, CreateBucketOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a storage bucket asynchronously.
        /// </summary>
        /// <param name="projectId">The ID of the project to create the buckets in. Must not be null.</param>
        /// <param name="bucket">The name of the bucket to create. Must not be null.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// resource representation of the newly-created bucket.</returns>
        public virtual Task<Bucket> CreateBucketAsync(string projectId, string bucket, CreateBucketOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a storage bucket synchronously.
        /// </summary>
        /// <param name="projectId">The ID of the project to create the buckets in. Must not be null.</param>
        /// <param name="bucket">The resource representation of the bucket to create. Must not be null, and must have a name.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <returns>The resource representation of the newly-created bucket.</returns>
        public virtual Bucket CreateBucket(string projectId, Bucket bucket, CreateBucketOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a storage bucket asynchronously.
        /// </summary>
        /// <param name="projectId">The ID of the project to create the buckets in. Must not be null.</param>
        /// <param name="bucket">The resource representation of the bucket to create. Must not be null, and must have a name.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// resource representation of the newly-created bucket.</returns>
        public virtual Task<Bucket> CreateBucketAsync(string projectId, Bucket bucket, CreateBucketOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}
