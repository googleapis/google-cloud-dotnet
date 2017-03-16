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
using Google.Apis.Upload;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    public abstract partial class StorageClient
    {
        /// <summary>
        /// Creates an instance which is capable of starting a resumable upload for an object.
        /// </summary>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="contentType">The content type of the object. This should be a MIME type
        /// such as "text/html" or "application/octet-stream". May be null.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <returns>The <see cref="ObjectsResource.InsertMediaUpload"/> which can be used to upload the object.</returns>
        /// <seealso cref="UploadObject(Object,Stream,UploadObjectOptions,IProgress{IUploadProgress})"/>
        public virtual ObjectsResource.InsertMediaUpload CreateObjectUploader(
            string bucket,
            string objectName,
            string contentType,
            Stream source,
            UploadObjectOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates an instance which is capable of starting a resumable upload for an object.
        /// </summary>
        /// <param name="destination">Object to create or update. Must not be null, and must have the name,
        /// bucket and content type populated.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <returns>The <see cref="ObjectsResource.InsertMediaUpload"/> which can be used to upload the object.</returns>
        /// <seealso cref="UploadObject(Object,Stream,UploadObjectOptions,IProgress{IUploadProgress})"/>
        public virtual ObjectsResource.InsertMediaUpload CreateObjectUploader(
            Object destination,
            Stream source,
            UploadObjectOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Uploads the data for an object in storage synchronously, from a specified stream.
        /// </summary>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="contentType">The content type of the object. This should be a MIME type
        /// such as "text/html" or "application/octet-stream". May be null.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="progress">Progress reporter for the upload. May be null.</param>
        /// <returns>The <see cref="Object"/> representation of the uploaded object.</returns>
        public virtual Object UploadObject(
            string bucket,
            string objectName,
            string contentType,
            Stream source,
            UploadObjectOptions options = null,
            IProgress<IUploadProgress> progress = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Uploads the data for an object in storage asynchronously, from a specified stream.
        /// </summary>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="contentType">The content type of the object. This should be a MIME type
        /// such as "text/html" or "application/octet-stream". May be null.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <param name="progress">Progress reporter for the upload. May be null.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Object"/> representation of the uploaded object.</returns>
        public virtual Task<Object> UploadObjectAsync(
            string bucket,
            string objectName,
            string contentType,
            Stream source,
            UploadObjectOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken),
            IProgress<IUploadProgress> progress = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Uploads the data for an object in storage synchronously, from a specified stream.
        /// </summary>
        /// <param name="destination">Object to create or update. Must not be null, and must have the name,
        /// bucket and content type populated.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="progress">Progress reporter for the upload. May be null.</param>
        /// <returns>The <see cref="Object"/> representation of the uploaded object.</returns>
        public virtual Object UploadObject(
            Object destination,
            Stream source,
            UploadObjectOptions options = null,
            IProgress<IUploadProgress> progress = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Uploads the data for an object in storage asynchronously, from a specified stream.
        /// </summary>
        /// <param name="destination">Object to create or update. Must not be null, and must have the name,
        /// bucket and content type populated.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <param name="progress">Progress reporter for the upload. May be null.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Object"/> representation of the uploaded object.</returns>
        public virtual Task<Object> UploadObjectAsync(
            Object destination,
            Stream source,
            UploadObjectOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken),
            IProgress<IUploadProgress> progress = null)
        {
            throw new NotImplementedException();
        }
    }
}
