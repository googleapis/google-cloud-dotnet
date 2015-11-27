// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Common;
using Google.Apis.Storage.v1.Data;
using Google.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Apis.Storage.v1.ClientWrapper
{
    // ListObjects methods on StorageClient
    public partial class StorageClient
    {
        private static readonly Paginator<Object, ObjectsResource.ListRequest, Objects, string> s_objectPaginator =
            new Paginator<Object, ObjectsResource.ListRequest, Objects, string>(
                (request, token) => { request.PageToken = token; return request; },
                objects => objects.NextPageToken,
                objects => objects.Items ?? Enumerable.Empty<Object>(),
                null);

        /// <summary>
        /// Asynchronously lists the objects in a given bucket, returning the results as a list.
        /// </summary>
        /// <remarks>
        /// This is a convenience method for calling <see cref="ListAllObjectsAsync(string, ListObjectsOptions, CancellationToken)"/>.
        /// </remarks>
        /// <param name="bucket">The bucket to list the objects from. Must not be null.</param>
        /// <returns>A list of objects within the bucket.</returns>
        public Task<IList<Object>> ListAllObjectsAsync(string bucket)
        {
            return ListAllObjectsAsync(bucket, null, default(CancellationToken));
        }

        /// <summary>
        /// Asynchronously lists the objects in a given bucket, returning the results as a list.
        /// </summary>
        /// <remarks>
        /// This lists the objects within a bucket before the returned task completes.
        /// This does not support reporting progress, or streaming the results.
        /// </remarks>
        /// <param name="bucket">The bucket to list the objects from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A list of objects within the bucket.</returns>
        public async Task<IList<Object>> ListAllObjectsAsync(string bucket, ListObjectsOptions options, CancellationToken cancellationToken)
        {
            return await ListObjectsAsync(bucket, options).ToList(cancellationToken);
        }

        /// <summary>
        /// Asynchronously lists the objects in a given bucket.
        /// </summary>
        /// <remarks>
        /// This lists the objects within a bucket asynchronously and lazily.
        /// </remarks>
        /// <remarks>
        /// This is a convenience method for calling <see cref="ListAllObjectsAsync(string, ListObjectsOptions, CancellationToken)"/>.
        /// </remarks>
        /// <param name="bucket">The bucket to list the objects from. Must not be null.</param>
        public IAsyncEnumerable<Object> ListObjectsAsync(string bucket)
        {
            return ListObjectsAsync(bucket, null);
        }

        /// <summary>
        /// Asynchronously lists the objects in a given bucket.
        /// </summary>
        /// <remarks>
        /// This lists the objects within a bucket asynchronously and lazily.
        /// </remarks>
        /// <param name="bucket">The bucket to list the objects from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <returns>An asynchronus sequence of objects within the bucket.</returns>
        public IAsyncEnumerable<Object> ListObjectsAsync(string bucket, ListObjectsOptions options)
        {
            Preconditions.CheckNotNull(bucket, nameof(bucket));
            var initialRequest = CreateListObjectsRequest(bucket, options);
            return s_objectPaginator.FetchAsync(initialRequest, (req, cancellationToken) => req.ExecuteAsync(cancellationToken));
        }

        /// <summary>
        /// Lists the objects in a given bucket, synchronously but lazily.
        /// </summary>
        /// <remarks>
        /// This method fetches the objects lazily, making requests to the underlying service
        /// for a page of results at a time, as required. To retrieve all the objects in a single collection,
        /// simply call LINQ's <c>ToList()</c> method on the returned sequence.
        /// </remarks>
        /// <param name="bucket">The bucket to list the objects from. Must not be null.</param>
        /// <returns>A sequence of objects within the bucket.</returns>
        public IEnumerable<Object> ListObjects(string bucket)
        {
            return ListObjects(bucket, null);
        }

        /// <summary>
        /// Lists the objects in a given bucket, synchronously but lazily.
        /// </summary>
        /// <remarks>
        /// This method fetches the objects lazily, making requests to the underlying service
        /// for a page of results at a time, as required. To retrieve all the objects in a single collection,
        /// simply call LINQ's <c>ToList()</c> method on the returned sequence.
        /// </remarks>
        /// <param name="bucket">The bucket to list the objects from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <returns>A sequence of objects within the bucket.</returns>
        public IEnumerable<Object> ListObjects(string bucket, ListObjectsOptions options)
        {
            Preconditions.CheckNotNull(bucket, nameof(bucket));
            var initialRequest = CreateListObjectsRequest(bucket, options);
            return s_objectPaginator.Fetch(initialRequest, req => req.Execute());
        }

        private ObjectsResource.ListRequest CreateListObjectsRequest(string bucket, ListObjectsOptions options)
        {
            var request = Service.Objects.List(bucket);
            options?.ModifyRequest(request);
            return request;
        }
    }
}
