// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Common;
using Google.Apis.Storage.v1.Data;
using Google.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Storage.v1.ClientWrapper
{
    // ListBuckets methods on StorageClient
    public partial class StorageClient
    {
        private static readonly PageStreamer<Bucket, BucketsResource.ListRequest, Buckets, string> s_bucketPageStreamer =
            new PageStreamer<Bucket, BucketsResource.ListRequest, Buckets, string>(
                (request, token) => { request.PageToken = token; return request; },
                buckets => buckets.NextPageToken,
                buckets => buckets.Items ?? Enumerable.Empty<Bucket>(),
                null);

        /// <summary>
        /// Asynchronously lists the buckets in a given project, returning the results as a list.
        /// </summary>
        /// <remarks>
        /// This lists all the buckets within a project before the returned task completes.
        /// This does not support reporting progress, or streaming the results.
        /// </remarks>
        /// <param name="projectId">The ID of the project to list the buckets from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A list of buckets within the project.</returns>
        public async Task<IList<Bucket>> ListAllBucketsAsync(
            string projectId,
            ListBucketsOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return await ListBucketsAsync(projectId, options).ToList(cancellationToken);
        }

        /// <summary>
        /// Asynchronously lists the buckets for a given project.
        /// </summary>
        /// <remarks>
        /// This lists the buckets within a project asynchronously and lazily.
        /// </remarks>
        /// <param name="projectId">The ID of the project to list the buckets from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of buckets within the project.</returns>
        public IAsyncEnumerable<Bucket> ListBucketsAsync(string projectId, ListBucketsOptions options = null)
        {
            Preconditions.CheckNotNull(projectId, nameof(projectId));
            var initialRequest = CreateListBucketsRequest(projectId, options);
            return s_bucketPageStreamer.FetchAsync(initialRequest, (req, cancellationToken) => req.ExecuteAsync(cancellationToken));
        }

        /// <summary>
        /// Lists the buckets for a given project, synchronously but lazily.
        /// </summary>
        /// <remarks>
        /// This method fetches the buckets lazily, making requests to the underlying service
        /// for a page of results at a time, as required. To retrieve all the buckets in a single collection,
        /// simply call LINQ's <c>ToList()</c> method on the returned sequence.
        /// </remarks>
        /// <param name="projectId">The ID of the project to list the buckets from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <returns>A sequence of buckets within the project.</returns>
        public IEnumerable<Bucket> ListBuckets(string projectId, ListBucketsOptions options = null)
        {
            Preconditions.CheckNotNull(projectId, nameof(projectId));
            var initialRequest = CreateListBucketsRequest(projectId, options);
            return s_bucketPageStreamer.Fetch(initialRequest, req => req.Execute());
        }

        private BucketsResource.ListRequest CreateListBucketsRequest(string projectId, ListBucketsOptions options)
        {
            var request = Service.Buckets.List(projectId);
            options?.ModifyRequest(request);
            return request;
        }
    }
}
