// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

namespace Google.Apis.Storage.v1.ClientWrapper
{
    /// <summary>
    /// Options for <c>ListBuckets</c> operations.
    /// </summary>
    public class ListBucketsOptions
    {
        /// <summary>
        /// The prefix to match. Only buckets with names that start with this string will be returned.
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// The number of results to return per page. (This modifies the per-request page size;
        /// it does not affect the total number of results returned.)
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Modifies the specified request for all non-null properties of this options object.
        /// </summary>
        /// <param name="request">The request to modify</param>
        internal void ModifyRequest(BucketsResource.ListRequest request)
        {
            if (Prefix != null)
            {
                request.Prefix = Prefix;
            }
            if (PageSize != null)
            {
                request.MaxResults = PageSize.Value;
            }
        }
    }
}
