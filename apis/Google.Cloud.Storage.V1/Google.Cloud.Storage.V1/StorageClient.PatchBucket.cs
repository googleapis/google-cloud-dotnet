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
        /// Patches the metadata for a storage bucket synchronously.
        /// </summary>
        /// <param name="bucket">Bucket to update. Must not be null, and must have a populated <c>Name</c> property.</param>
        /// <param name="options">Additional options for the update. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <returns>The <see cref="Bucket"/> representation of the updated storage bucket.</returns>
        public virtual Bucket PatchBucket(
            Bucket bucket,
            PatchBucketOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Patches the metadata for a storage bucket asynchronously.
        /// </summary>
        /// <param name="bucket">Bucket to update. Must not be null, and must have a populated <c>Name</c> property.</param>
        /// <param name="options">Additional options for the update. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Bucket"/> representation of the bucket storage bucket.</returns>
        public virtual Task<Bucket> PatchBucketAsync(
            Bucket bucket,
            PatchBucketOptions options = null,
            CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
