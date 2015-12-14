// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Common;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;


namespace Google.Apis.Storage.v1.ClientWrapper
{
    public partial class StorageClient
    {
        /// <summary>
        /// Deletes the latest version of the specified object synchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the bucket containing the object supports versioning, after this operation
        /// completes successfully there may still be another version of the same object, and the
        /// deleted version will still be available (but marked as deleted). In buckets which
        /// do not support versioning, this operation will permanently delete the object.
        /// </para>
        /// <para>
        /// If the request attempts to delete an object that does not exist, this counts as a failure with an HTTP status code of 404.
        /// </para>
        /// </remarks>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        public void DeleteObject(string bucket, string objectName)
        {
            DeleteObject(bucket, objectName, null);
        }

        /// <summary>
        /// Deletes a version of the specified object synchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// By default this will delete the latest version of the object, but this can be
        /// controlled using <see cref="DeleteObjectOptions.Generation"/>. For buckets that support
        /// multiple versions, implicitly deleting the latest version only archives
        /// it so the object is still available and can be listed by specifying <see cref="ListObjectsOptions.Versions"/>.
        /// If the version is explicitly specified, the object is permanently deleted.
        /// </para>
        /// <para>
        /// If the bucket containing the object supports versioning, after this operation
        /// completes successfully there may still be another version of the same object. In buckets which
        /// do not support versioning, this operation will permanently delete the object.
        /// </para>
        /// <para>
        /// If the request attempts to delete an object that does not exist or a specific version that does
        /// not exist, this counts as a failure with an HTTP status code of 404.
        /// </para>
        /// </remarks>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate
        /// defaults will be used.</param>
        public void DeleteObject(string bucket, string objectName, DeleteObjectOptions options)
        {
            CreateDeleteObjectRequest(bucket, objectName, options).Execute();
        }

        /// <summary>
        /// Deletes the latest version of the specified object asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the bucket containing the object supports versioning, after this operation
        /// completes successfully there may still be another version of the same object, and the
        /// deleted version will still be available (but marked as deleted). In buckets which
        /// do not support versioning, this operation will permanently delete the object.
        /// </para>
        /// <para>
        /// If the request attempts to delete an object that does not exist, this counts as a failure with an HTTP status code of 404.
        /// </para>
        /// </remarks>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task DeleteObjectAsync(string bucket, string objectName)
        {
            return DeleteObjectAsync(bucket, objectName, null, CancellationToken.None);
        }

        /// <summary>
        /// Deletes a version of the specified object asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// By default this will delete the latest version of the object, but this can be
        /// controlled using <see cref="DeleteObjectOptions.Generation"/>. For buckets that support
        /// multiple versions, implicitly deleting the latest version only archives
        /// it so the object is still available and can be listed by specifying <see cref="ListObjectsOptions.Versions"/>.
        /// If the version is explicitly specified, the object is permanently deleted.
        /// </para>
        /// <para>
        /// If the bucket containing the object supports versioning, after this operation
        /// completes successfully there may still be another version of the same object. In buckets which
        /// do not support versioning, this operation will permanently delete the object.
        /// </para>
        /// <para>
        /// If the request attempts to delete an object that does not exist or a specific version that does
        /// not exist, this counts as a failure with an HTTP status code of 404.
        /// </para>
        /// </remarks>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task DeleteObjectAsync(string bucket, string objectName, DeleteObjectOptions options, CancellationToken cancellationToken)
        {
            return CreateDeleteObjectRequest(bucket, objectName, options).ExecuteAsync(cancellationToken);
        }

        /// <summary>
        /// Deletes a version of the specified object synchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that any generation information contained within <paramref name="obj"/> is ignored;
        /// this overload will always delete the latest version. Use <see cref="DeleteObject(Object, DeleteObjectOptions)"/>
        /// if you wish to specify a particular version to delete.
        /// If the bucket containing the object supports versioning, after this operation
        /// completes successfully there may still be another version of the same object, and the
        /// deleted version will still be available (but marked as deleted). In buckets which
        /// do not support versioning, this operation will permanently delete the object.
        /// </para>
        /// <para>
        /// If the bucket containing the object supports versioning, after this operation
        /// completes successfully there may still be another version of the same object. In buckets which
        /// do not support versioning, this operation will permanently delete the object.
        /// </para>
        /// <para>
        /// If the request attempts to delete an object that does not exist, this counts as a failure with an HTTP status code of 404.
        /// </para>
        /// </remarks>
        /// <param name="obj">Object to delete. Must not be null, and must have the name and bucket populated.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate
        /// defaults will be used.</param>
        public void DeleteObject(Object obj)
        {
            DeleteObject(obj, null);
        }

        /// <summary>
        /// Deletes a version of the specified object synchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// By default this will delete the latest version of the object, but this can be
        /// controlled using <see cref="DeleteObjectOptions.Generation"/>. Note that any generation information
        /// contained within <paramref name="obj"/> is ignored; the generation to delete is only controlled
        /// via <paramref name="options"/>. For buckets that support
        /// multiple versions, implicitly deleting the latest version only archives
        /// it so the object is still available and can be listed by specifying <see cref="ListObjectsOptions.Versions"/>.
        /// If the version is explicitly specified, the object is permanently deleted.
        /// </para>
        /// <para>
        /// If the bucket containing the object supports versioning, after this operation
        /// completes successfully there may still be another version of the same object. In buckets which
        /// do not support versioning, this operation will permanently delete the object.
        /// </para>
        /// <para>
        /// If the request attempts to delete an object that does not exist or a specific version that does
        /// not exist, this counts as a failure with an HTTP status code of 404.
        /// </para>
        /// </remarks>
        /// <param name="obj">Object to delete. Must not be null, and must have the name and bucket populated.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate
        /// defaults will be used.</param>
        public void DeleteObject(Object obj, DeleteObjectOptions options)
        {
            CreateDeleteObjectRequest(obj, options).Execute();
        }

        /// <summary>
        /// Deletes the latest version of the specified object asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that any generation information contained within <paramref name="obj"/> is ignored;
        /// this overload will always delete the latest version. Use <see cref="DeleteObjectAsync(Object, DeleteObjectOptions)"/>
        /// if you wish to specify a particular version to delete.
        /// If the bucket containing the object supports versioning, after this operation
        /// completes successfully there may still be another version of the same object, and the
        /// deleted version will still be available (but marked as deleted). In buckets which
        /// do not support versioning, this operation will permanently delete the object.
        /// </para>
        /// <para>
        /// If the bucket containing the object supports versioning, after this operation
        /// completes successfully there may still be another version of the same object. In buckets which
        /// do not support versioning, this operation will permanently delete the object.
        /// </para>
        /// <para>
        /// If the request attempts to delete an object that does not exist, this counts as a failure with an HTTP status code of 404.
        /// </para>
        /// </remarks>
        /// <param name="obj">Object to delete. Must not be null, and must have the name and bucket populated.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task DeleteObjectAsync(Object obj)
        {
            return DeleteObjectAsync(obj, null, CancellationToken.None);
        }

        /// <summary>
        /// Deletes a version of the specified object asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// By default this will delete the latest version of the object, but this can be
        /// controlled using <see cref="DeleteObjectOptions.Generation"/>. Note that any generation information
        /// contained within <paramref name="obj"/> is ignored; the generation to delete is only controlled
        /// via <paramref name="options"/>. For buckets that support
        /// multiple versions, implicitly deleting the latest version only archives
        /// it so the object is still available and can be listed by specifying <see cref="ListObjectsOptions.Versions"/>.
        /// If the version is explicitly specified, the object is permanently deleted.
        /// </para>
        /// <para>
        /// If the bucket containing the object supports versioning, after this operation
        /// completes successfully there may still be another version of the same object. In buckets which
        /// do not support versioning, this operation will permanently delete the object.
        /// </para>
        /// <para>
        /// If the request attempts to delete an object that does not exist or a specific version that does
        /// not exist, this counts as a failure with an HTTP status code of 404.
        /// </para>
        /// </remarks>
        /// <param name="obj">Object to delete. Must not be null, and must have the name and bucket populated.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task DeleteObjectAsync(Object obj, DeleteObjectOptions options, CancellationToken cancellationToken)
        {
            return CreateDeleteObjectRequest(obj, options).ExecuteAsync(cancellationToken);
        }

        private ObjectsResource.DeleteRequest CreateDeleteObjectRequest(Object obj, DeleteObjectOptions options)
        {
            ValidateObject(obj, nameof(obj));
            var request = Service.Objects.Delete(obj.Bucket, obj.Name);
            options?.ModifyRequest(request);
            return request;
        }

        private ObjectsResource.DeleteRequest CreateDeleteObjectRequest(string bucket, string name, DeleteObjectOptions options)
        {
            ValidateBucket(bucket);
            name.CheckNotNull(nameof(name));
            var request = Service.Objects.Delete(bucket, name);
            options?.ModifyRequest(request);
            return request;
        }
    }
}
