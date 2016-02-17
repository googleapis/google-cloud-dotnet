// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Storage.v1;

namespace Google.Storage.V1
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
        /// Controls whether or not multiple versions of an object are listed separately (true)
        /// or not (false). The default API behavior is equivalent to setting this to false, but
        /// it is still a nullable property to allow the intention of "definitely false" to be
        /// separate from "not set".
        /// </summary>
        public bool? Versions { get; set; }

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
            if (Versions != null)
            {
                request.Versions = Versions.Value;
            }
        }
    }
}
