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

using Google.Apis.Upload;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Storage.V1
{
    public sealed partial class StorageClientImpl : StorageClient
    {
        /// <inheritdoc />
        public override Object UploadObject(
            string bucket,
            string objectName,
            string contentType,
            Stream source,
            UploadObjectOptions options = null,
            IProgress<IUploadProgress> progress = null)
        {
            ValidateBucketName(bucket);
            Preconditions.CheckNotNull(objectName, nameof(objectName));
            return UploadObject(
                new Object { Bucket = bucket, Name = objectName, ContentType = contentType ?? "" },
                source, options, progress);
        }        
        
        /// <inheritdoc />
        public override Task<Object> UploadObjectAsync(
            string bucket,
            string objectName,
            string contentType,
            Stream source,
            UploadObjectOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken),
            IProgress<IUploadProgress> progress = null)
        {
            ValidateBucketName(bucket);
            Preconditions.CheckNotNull(objectName, nameof(objectName));
            return UploadObjectAsync(new Object { Bucket = bucket, Name = objectName, ContentType = contentType ?? "" },
                source, options, cancellationToken, progress);
        }

        /// <inheritdoc />
        public override Object UploadObject(
            Object destination,
            Stream source,
            UploadObjectOptions options = null,
            IProgress<IUploadProgress> progress = null)
        {
            ValidateObject(destination, nameof(destination));
            Preconditions.CheckNotNull(source, nameof(source));
            var mediaUpload = Service.Objects.Insert(destination, destination.Bucket, source, destination.ContentType);
            options?.ModifyMediaUpload(mediaUpload);
            if (progress != null)
            {
                mediaUpload.ProgressChanged += progress.Report;
            }
            var finalProgress = mediaUpload.Upload();
            if (finalProgress.Exception != null)
            {
                throw finalProgress.Exception;
            }
            return mediaUpload.ResponseBody;
        }

        /// <inheritdoc />
        public override async Task<Object> UploadObjectAsync(
            Object destination,
            Stream source,
            UploadObjectOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken),
            IProgress<IUploadProgress> progress = null)
        {
            ValidateObject(destination, nameof(destination));
            Preconditions.CheckNotNull(source, nameof(source));
            var mediaUpload = Service.Objects.Insert(destination, destination.Bucket, source, destination.ContentType);
            options?.ModifyMediaUpload(mediaUpload);
            if (progress != null)
            {
                mediaUpload.ProgressChanged += progress.Report;
            }
            var finalProgress = await mediaUpload.UploadAsync(cancellationToken).ConfigureAwait(false);
            if (finalProgress.Exception != null)
            {
                throw finalProgress.Exception;
            }
            return mediaUpload.ResponseBody;
        }
    }
}
