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

using Google.Api.Gax.Rest;
using System;
using static Google.Apis.Storage.v1.ObjectsResource;
using static Google.Apis.Storage.v1.ObjectsResource.GetRequest;

namespace Google.Storage.V1
{
    /// <summary>
    /// Options for <c>GetObject</c> operations.
    /// </summary>
    public class GetObjectOptions
    {
        /// <summary>
        /// The generation of the object resource to fetch. When not
        /// set, the latest generation will be retrieved.
        /// </summary>
        public long? Generation { get; set; }

        /// <summary>
        /// The projection to retrieve.
        /// </summary>
        public Projection? Projection { get; set; }

        /// <summary>
        /// Precondition for retrieval: the object is only fetched if the object's current
        /// generation matches the given value.
        /// </summary>
        public long? IfGenerationMatch { get; set; }

        /// <summary>
        /// Precondition for retrieval: the object is only fetched if the object's current
        /// generation does not match the given value.
        /// </summary>
        public long? IfGenerationNotMatch { get; set; }

        /// <summary>
        /// Precondition for retrieval: the object is only fetched if the object's current
        /// meta-generation matches the given value.
        /// </summary>
        public long? IfMetagenerationMatch { get; set; }

        /// <summary>
        /// Precondition for retrieval: the object is only fetched if the object's current
        /// meta-generation does not match the given value.
        /// </summary>
        public long? IfMetagenerationNotMatch { get; set; }

        internal void ModifyRequest(GetRequest request)
        {
            // Note the use of ArgumentException here, as this will basically be the result of invalid
            // options being passed to a public method.
            if (IfGenerationMatch != null && IfGenerationNotMatch != null)
            {
                throw new ArgumentException($"Cannot specify {nameof(IfGenerationMatch)} and {nameof(IfGenerationNotMatch)} in the same options", "options");
            }
            if (IfMetagenerationMatch != null && IfMetagenerationNotMatch != null)
            {
                throw new ArgumentException($"Cannot specify {nameof(IfMetagenerationMatch)} and {nameof(IfMetagenerationNotMatch)} in the same options", "options");
            }

            if (Generation != null)
            {
                request.Generation = Generation;
            }
            if (IfGenerationMatch != null)
            {
                request.IfGenerationMatch = IfGenerationMatch;
            }
            if (IfGenerationNotMatch != null)
            {
                request.IfGenerationNotMatch = IfGenerationNotMatch;
            }
            if (IfMetagenerationMatch != null)
            {
                request.IfMetagenerationMatch = IfMetagenerationMatch;
            }
            if (IfMetagenerationNotMatch != null)
            {
                request.IfMetagenerationNotMatch = IfMetagenerationNotMatch;
            }
            if (Projection != null)
            {
                request.Projection = GaxRestPreconditions.CheckEnumValue((ProjectionEnum) Projection, nameof(Projection));
            }
        }
    }
}
