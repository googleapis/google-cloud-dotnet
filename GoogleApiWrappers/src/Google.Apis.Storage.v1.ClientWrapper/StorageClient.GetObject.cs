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
        /// Fetches the information about an object synchronously.
        /// </summary>
        /// <remarks>This does not retrieve the content of the object itself. Use <see cref="DownloadObject(string, string,  System.IO.Stream)"/>
        /// to download the content.</remarks>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="options">Additional options for the fetch operation. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <returns>The <see cref="Object"/> representation of the storage object.</returns>
        public Object GetObject(string bucket, string objectName, GetObjectOptions options = null)
        {
            ValidateBucket(bucket);
            objectName.CheckNotNull(nameof(objectName));
            return CreateRequest(bucket, objectName, options).Execute();
        }

        /// <summary>
        /// Fetches the information about an object asynchronously.
        /// </summary>
        /// <remarks>This does not retrieve the content of the object itself. Use <see cref="DownloadObject(string, string, System.IO.Stream)"/>
        /// to download the content.</remarks>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="options">Additional options for the fetch operation. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Object"/> representation of the storage object.</returns>
        public Task<Object> GetObjectAsync(
            string bucket,
            string objectName,
            GetObjectOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            ValidateBucket(bucket);
            objectName.CheckNotNull(nameof(objectName));
            return CreateRequest(bucket, objectName, options).ExecuteAsync(cancellationToken);
        }

        private ObjectsResource.GetRequest CreateRequest(string bucket, string objectName, GetObjectOptions options)
        {
            var request = Service.Objects.Get(bucket, objectName);
            options?.ModifyRequest(request);
            return request;
        }
    }
}
