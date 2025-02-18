// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using System.Threading.Tasks;
using System.Threading;
using Google.Apis.Storage.v1;
using Bucket = Google.Apis.Storage.v1.Data.Bucket;

namespace Google.Cloud.Storage.V1;
public sealed partial class StorageClientImpl : StorageClient
{
    /// <inheritdoc/>
    public override Bucket RestoreBucket(string bucket, long generation, RestoreBucketOptions options = null) =>
        CreateRestoreBucketRequest(bucket, generation, options).Execute();

    /// <inheritdoc/>
    public override Task<Bucket> RestoreBucketAsync(
        string bucket,
        long generation,
        RestoreBucketOptions options = null,
        CancellationToken cancellationToken = default) =>
        CreateRestoreBucketRequest(bucket, generation, options).ExecuteAsync(cancellationToken);

    private BucketsResource.RestoreRequest CreateRestoreBucketRequest(string bucket, long generation, RestoreBucketOptions options)
    {
        ValidateBucketName(bucket);
        var request = Service.Buckets.Restore(bucket, generation);
        options?.ModifyRequest(request);
        RetryOptions retryOptions = options?.RetryOptions ?? RetryOptions.IdempotentRetryOptions;
        MarkAsRetriable(request, retryOptions);
        return request;
    }
}