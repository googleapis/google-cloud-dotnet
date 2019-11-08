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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class StorageClientImpl : StorageClient
    {
        /// <inheritdoc />
        public override void DeleteBucket(string bucket, DeleteBucketOptions options = null) =>
            DeleteBucketImpl(ValidateBucketName(bucket), options);

        /// <inheritdoc />
        public override Task DeleteBucketAsync(
            string bucket,
            DeleteBucketOptions options = null,
            CancellationToken cancellationToken = default) =>
            DeleteBucketAsyncImpl(ValidateBucketName(bucket), options, cancellationToken);

        /// <inheritdoc />
        public override void DeleteBucket(Bucket bucket, DeleteBucketOptions options = null) =>
            DeleteBucketImpl(ValidateBucket(bucket, nameof(bucket)), options);

        /// <inheritdoc />
        public override Task DeleteBucketAsync(
            Bucket bucket,
            DeleteBucketOptions options = null,
            CancellationToken cancellationToken = default) =>
            DeleteBucketAsyncImpl(ValidateBucket(bucket, nameof(bucket)), options, cancellationToken);

        // Implementation methods assuming a previously-validate bucket name

        private void DeleteBucketImpl(string bucket, DeleteBucketOptions options)
        {
            // Create the request at the start, so we validate the options before we
            // start deleting objects.
            var deleteBucketRequest = CreateDeleteBucketRequest(bucket, options);
            string userProject = options?.UserProject;
            if (options?.DeleteObjects ?? false)
            {
                // Don't start deleting objects if the bucket has the wrong metageneration to start with.
                var preconditionOptions = options.CreateGetBucketOptionsForPreconditions();
                if (preconditionOptions != null)
                {
                    GetBucket(bucket, preconditionOptions);
                }
                foreach (var obj in ListObjects(bucket, null, new ListObjectsOptions { Versions = true, UserProject = userProject }))
                {
                    var deleteObjectOptions = new DeleteObjectOptions { UserProject = userProject, Generation = obj.Generation };
                    DeleteObject(obj, deleteObjectOptions);
                }
            }
            deleteBucketRequest.Execute();
        }

        private async Task DeleteBucketAsyncImpl(string bucket, DeleteBucketOptions options, CancellationToken cancellationToken)
        {
            var deleteBucketRequest = CreateDeleteBucketRequest(bucket, options);
            string userProject = options?.UserProject;
            if (options?.DeleteObjects ?? false)
            {
                // Don't start deleting objects if the bucket has the wrong metageneration to start with.
                var preconditionOptions = options.CreateGetBucketOptionsForPreconditions();
                if (preconditionOptions != null)
                {
                    await GetBucketAsync(bucket, preconditionOptions, cancellationToken).ConfigureAwait(false);
                }
                var objects = ListObjectsAsync(bucket, null, new ListObjectsOptions { Versions = true, UserProject = userProject });
                var iterator = objects.GetAsyncEnumerator();
                try
                {
                    while (await iterator.MoveNextAsync().ConfigureAwait(false))
                    {
                        var obj = iterator.Current;
                        var deleteObjectOptions = new DeleteObjectOptions { UserProject = userProject, Generation = obj.Generation };
                        await DeleteObjectAsync(obj, deleteObjectOptions, cancellationToken).ConfigureAwait(false);
                    }
                }
                finally
                {
                    await iterator.DisposeAsync().ConfigureAwait(false);
                }
            }
            await deleteBucketRequest.ExecuteAsync(cancellationToken).ConfigureAwait(false);
        }

        private BucketsResource.DeleteRequest CreateDeleteBucketRequest(string bucket, DeleteBucketOptions options)
        {
            var request = Service.Buckets.Delete(bucket);
            options?.ModifyRequest(request);
            return request;
        }
    }
}
