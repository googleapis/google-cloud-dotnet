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
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Storage.V1
{
    public partial class StorageClient
    {
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
        public void DeleteObject(string bucket, string objectName, DeleteObjectOptions options = null)
        {
            CreateDeleteObjectRequest(bucket, objectName, options).Execute();
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
        public Task DeleteObjectAsync(
            string bucket,
            string objectName,
            DeleteObjectOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return CreateDeleteObjectRequest(bucket, objectName, options).ExecuteAsync(cancellationToken);
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
        public void DeleteObject(Object obj, DeleteObjectOptions options = null)
        {
            CreateDeleteObjectRequest(obj, options).Execute();
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
        public Task DeleteObjectAsync(Object obj, DeleteObjectOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
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
            Preconditions.CheckNotNull(name, nameof(name));
            var request = Service.Objects.Delete(bucket, name);
            options?.ModifyRequest(request);
            return request;
        }
    }
}
