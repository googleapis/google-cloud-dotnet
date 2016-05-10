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

using Google.Apis.Storage.v1;
using System;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Storage.V1
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
            Preconditions.CheckNotNull(sourceBucket, nameof(sourceBucket));
            Preconditions.CheckNotNull(sourceObjectName, nameof(sourceObjectName));
            Preconditions.CheckNotNull(destinationBucket, nameof(destinationBucket));
            Preconditions.CheckNotNull(destinationObjectName, nameof(destinationObjectName));
            if (destinationBucket == sourceBucket && destinationObjectName == sourceObjectName)
            {
                throw new ArgumentException("Cannot copy an object to itself. Specify either a different destination bucket or a different destination object name");
            }
            var request = Service.Objects.Rewrite(new Object(), sourceBucket, sourceObjectName, destinationBucket, destinationObjectName);
            options?.ModifyRequest(request);
            return request;
        }
    }
}
