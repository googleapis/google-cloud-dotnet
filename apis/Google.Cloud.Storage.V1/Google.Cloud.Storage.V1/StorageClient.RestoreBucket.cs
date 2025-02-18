// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Bucket = Google.Apis.Storage.v1.Data.Bucket;

namespace Google.Cloud.Storage.V1;
public abstract partial class StorageClient
{
    /// <summary>
    /// Restores a soft-deleted bucket.
    /// </summary>
    /// <param name="bucket">The name of the bucket. Must not be null.</param>
    /// <param name="generation">The specific revision of the bucket to restore.</param>
    /// <param name="options">Additional options for the restore operation. May be null, in which case appropriate
    /// defaults will be used.</param>
    /// <returns>The <see cref="Bucket"/> representation of the restored Storage bucket.</returns>
    public virtual Bucket RestoreBucket(string bucket, long generation, RestoreBucketOptions options = null) =>
        throw new NotImplementedException();

    /// <summary>
    /// Restores a soft-deleted bucket.
    /// </summary>
    /// <param name="bucket">The name of the bucket. Must not be null.</param>
    /// <param name="generation">The specific revision of the bucket to restore.</param>
    /// <param name="options">Additional options for the restore operation. May be null, in which case appropriate
    /// defaults will be used.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation, with a result returning the
    /// <see cref="Bucket"/> representation of the restored Storage bucket.</returns>
    public virtual Task<Bucket> RestoreBucketAsync(
        string bucket,
        long generation,
        RestoreBucketOptions options = null,
        CancellationToken cancellationToken = default) => throw new NotImplementedException();
}