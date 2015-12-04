// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

namespace Google.Apis.Storage.v1.ClientWrapper
{
    /// <summary>
    /// Options for <c>ListObjects</c> operations.
    /// </summary>
    public class ListObjectsOptions
    {
        // TODO: We can't currently return both objects *and* prefixes. Should we have a separate ListPrefixes method?
        // Something more complex? It's unclear how common this is.

        /// <summary>
        /// Used to list in "directory mode". Only objects whose names (aside from the prefix) do not contain delimiter
        /// will be returned.
        /// </summary>
        public string Delimiter { get; set; }

        /// <summary>
        /// The number of results to return per page. (This modifies the per-request page size;
        /// it does not affect the total number of results returned.)
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Modifies the specified request for all non-null properties of this options object.
        /// </summary>
        /// <param name="request">The request to modify</param>
        internal void ModifyRequest(ObjectsResource.ListRequest request)
        {
            if (PageSize != null)
            {
                request.MaxResults = PageSize.Value;
            }
            if (Delimiter != null)
            {
                request.Delimiter = Delimiter;
            }
        }
    }
}
