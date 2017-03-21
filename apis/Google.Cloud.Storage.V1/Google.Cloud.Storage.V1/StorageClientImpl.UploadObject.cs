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
using Google.Apis.Upload;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class StorageClientImpl : StorageClient
    {
        /// <inheritdoc />
        public override ObjectsResource.InsertMediaUpload CreateObjectUploader(
            string bucket,
            string objectName,
            string contentType,
            Stream source,
            UploadObjectOptions options = null)
        {
            ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(objectName, nameof(objectName));
            return CreateObjectUploader(
                new Object { Bucket = bucket, Name = objectName, ContentType = contentType },
                source, options);
        }

        /// <inheritdoc />
        public override ObjectsResource.InsertMediaUpload CreateObjectUploader(
            Object destination,
            Stream source,
            UploadObjectOptions options = null)
        {
            ValidateObject(destination, nameof(destination));
            GaxPreconditions.CheckNotNull(source, nameof(source));
            var mediaUpload = new CustomMediaUpload(Service, destination, destination.Bucket, source, destination.ContentType);
            options?.ModifyMediaUpload(mediaUpload);
            mediaUpload.Options.ModifySessionInitiationRequest += _versionHeaderAction;
            ApplyEncryptionKey(options?.EncryptionKey, mediaUpload);
            return mediaUpload;
        }

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
            GaxPreconditions.CheckNotNull(objectName, nameof(objectName));
            return UploadObject(
                new Object { Bucket = bucket, Name = objectName, ContentType = contentType },
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
            GaxPreconditions.CheckNotNull(objectName, nameof(objectName));
            return UploadObjectAsync(new Object { Bucket = bucket, Name = objectName, ContentType = contentType },
                source, options, cancellationToken, progress);
        }

        /// <inheritdoc />
        public override Object UploadObject(
            Object destination,
            Stream source,
            UploadObjectOptions options = null,
            IProgress<IUploadProgress> progress = null)
        {
            var mediaUpload = CreateObjectUploader(destination, source, options);
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
            var mediaUpload = CreateObjectUploader(destination, source, options);
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
