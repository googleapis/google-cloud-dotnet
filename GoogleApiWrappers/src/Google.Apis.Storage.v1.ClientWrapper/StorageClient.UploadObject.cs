// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Upload;
using Google.Common;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Apis.Storage.v1.ClientWrapper
{
    public partial class StorageClient
    {
        /// <summary>
        /// Uploads the data for an object in storage synchronously, from a specified stream.
        /// </summary>
        /// <param name="bucket">The name of the bucket in which to store the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="contentType">The content type of the object. This should be a MIME type
        /// such as "text/html" or "application/octet-stream". Must not be null, but may be empty.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <returns>The <see cref="Object"/> representation of the uploaded object.</returns>
        public Object UploadObject(string bucket, string objectName, string contentType, Stream source)
        {
            return UploadObject(bucket, objectName, contentType, source, options: null, progress: null);
        }

        /// <summary>
        /// Uploads the data for an object in storage synchronously, from a specified stream.
        /// </summary>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="contentType">The content type of the object. This should be a MIME type
        /// such as "text/html" or "application/octet-stream". Must not be null, but may be empty.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="progress">Progress reporter for the upload. May be null.</param>
        /// <returns>The <see cref="Object"/> representation of the uploaded object.</returns>
        public Object UploadObject(
            string bucket,
            string objectName,
            string contentType,
            Stream source,
            UploadObjectOptions options,
            IProgress<IUploadProgress> progress)
        {
            ValidateBucket(bucket);
            objectName.CheckNotNull(nameof(objectName));
            contentType.CheckNotNull(nameof(contentType));
            return UploadObject(
                new Object { Bucket = bucket, Name = objectName, ContentType = contentType },
                source, options, progress);
        }

        /// <summary>
        /// Uploads the data for an object in storage asynchronously, from a specified stream.
        /// </summary>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="contentType">The content type of the object. This should be a MIME type
        /// such as "text/html" or "application/octet-stream". Must not be null, but may be empty.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Object"/> representation of the uploaded object.</returns>
        public Task<Object> UploadObjectAsync(string bucket, string objectName, string contentType, Stream source)
        {
            return UploadObjectAsync(bucket, objectName, contentType, source,
                options: null, cancellationToken: CancellationToken.None, progress: null);
        }

        /// <summary>
        /// Uploads the data for an object in storage asynchronously, from a specified stream.
        /// </summary>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="contentType">The content type of the object. This should be a MIME type
        /// such as "text/html" or "application/octet-stream". Must not be null, but may be empty.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <param name="progress">Progress reporter for the upload. May be null.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Object"/> representation of the uploaded object.</returns>
        public Task<Object> UploadObjectAsync(
            string bucket,
            string objectName,
            string contentType,
            Stream source,
            UploadObjectOptions options,
            CancellationToken cancellationToken,
            IProgress<IUploadProgress> progress)
        {
            ValidateBucket(bucket);
            objectName.CheckNotNull(nameof(objectName));
            contentType.CheckNotNull(nameof(contentType));
            return UploadObjectAsync(new Object { Bucket = bucket, Name = objectName, ContentType = contentType },
                source, options, cancellationToken, progress);
        }

        /// <summary>
        /// Uploads the data for an object in storage asynchronously, from a specified stream.
        /// </summary>
        /// <param name="destination">Object to create or update. Must not be null, and must have the name,
        /// bucket and content type populated.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Object"/> representation of the uploaded object.</returns>
        public Task UploadObjectAsync(Object destination, Stream source)
        {
            return UploadObjectAsync(destination, source,
                options: null, cancellationToken: CancellationToken.None, progress: null);
        }

        /// <summary>
        /// Uploads the data for an object in storage synchronously, from a specified stream.
        /// </summary>
        /// <param name="destination">Object to create or update. Must not be null, and must have the name,
        /// bucket and content type populated.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <returns>The <see cref="Object"/> representation of the uploaded object.</returns>
        public Object UploadObject(Object destination, Stream source)
        {
            return UploadObject(destination, source, options: null, progress: null);
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
        public Object UploadObject(
            Object destination,
            Stream source,
            UploadObjectOptions options,
            IProgress<IUploadProgress> progress)
        {
            ValidateObject(destination, nameof(destination));
            source.CheckNotNull(nameof(source));
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
        public async Task<Object> UploadObjectAsync(
            Object destination,
            Stream source,
            UploadObjectOptions options,
            CancellationToken cancellationToken,
            IProgress<IUploadProgress> progress)
        {
            ValidateObject(destination, nameof(destination));
            source.CheckNotNull(nameof(source));
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
