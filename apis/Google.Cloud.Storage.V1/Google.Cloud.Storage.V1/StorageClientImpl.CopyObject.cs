// Copyright 2015 Google Inc. All Rights Reserved.
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
using System;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class StorageClientImpl : StorageClient
    {
        /// <inheritdoc />
        public override Object CopyObject(
            string sourceBucket,
            string sourceObjectName,
            string destinationBucket,
            string destinationObjectName,
            CopyObjectOptions options = null)
        {
            var request = CreateCopyObjectRequest(sourceBucket, sourceObjectName, destinationBucket, destinationObjectName, options);
            var response = request.Execute();
            while (response.RewriteToken != null)
            {
                request.RewriteToken = response.RewriteToken;
                response = request.Execute();
            }
            return response.Resource;
        }

        /// <inheritdoc />
        public override async Task<Object> CopyObjectAsync(
            string sourceBucket,
            string sourceObjectName,
            string destinationBucket,
            string destinationObjectName,
            CopyObjectOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = CreateCopyObjectRequest(sourceBucket, sourceObjectName, destinationBucket, destinationObjectName, options);
            var response = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            while (response.RewriteToken != null)
            {
                request.RewriteToken = response.RewriteToken;
                response = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
            return response.Resource;
        }

        private ObjectsResource.RewriteRequest CreateCopyObjectRequest(
            string sourceBucket,
            string sourceObjectName,
            string destinationBucket,
            string destinationObjectName,
            CopyObjectOptions options)
        {
            GaxPreconditions.CheckNotNull(sourceBucket, nameof(sourceBucket));
            GaxPreconditions.CheckNotNull(sourceObjectName, nameof(sourceObjectName));
            GaxPreconditions.CheckNotNull(destinationBucket, nameof(destinationBucket));
            GaxPreconditions.CheckNotNull(destinationObjectName, nameof(destinationObjectName));
            Object obj = options?.ExtraMetadata ?? new Object();
            var request = Service.Objects.Rewrite(obj, sourceBucket, sourceObjectName, destinationBucket, destinationObjectName);
            options?.ModifyRequest(request);
            ApplyEncryptionKey(options?.EncryptionKey, request);
            request.ModifyRequest += (options?.SourceEncryptionKey ?? EncryptionKey).ModifyRequestForRewriteSource;
            request.ModifyRequest += _versionHeaderAction;
            return request;
        }
    }
}
