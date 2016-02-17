// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using static Google.Apis.Storage.v1.ObjectsResource;
using static Google.Apis.Storage.v1.ObjectsResource.GetRequest;

namespace Google.Apis.Storage.v1.ClientWrapper
{
    /// <summary>
    /// Options for <c>GetObject</c> operations.
    /// </summary>
    public class GetObjectOptions
    {
        // TODO: Generation preconditions

        /// <summary>
        /// The generation of the object resource to fetch. When not
        /// set, the latest generation will be retrieved.
        /// </summary>
        public long? Generation { get; set; }

        /// <summary>
        /// The projection to retrieve.
        /// </summary>
        public ProjectionEnum? Projection { get; set; }

        internal void ModifyRequest(GetRequest request)
        {
            if (Generation != null)
            {
                request.Generation = Generation;
            }
            if (Projection != null)
            {
                request.Projection = Projection;
            }
        }
    }
}
