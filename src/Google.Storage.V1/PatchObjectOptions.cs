// Copyright 2016 Google Inc. All Rights Reserved.
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

using System;
using static Google.Apis.Storage.v1.ObjectsResource;
using static Google.Apis.Storage.v1.ObjectsResource.PatchRequest;

namespace Google.Storage.V1
{
    /// <summary>
    /// Options for <c>PatchObject</c> operations.
    /// </summary>
    public class PatchObjectOptions
    {
        /// <summary>
        /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
        /// </summary>
        public long? Generation { get; set; }

        /// <summary>
        /// Precondition for patch: the object is only patched if the existing object's
        /// generation matches the given value.
        /// </summary>
        public long? IfGenerationMatch;

        /// <summary>
        /// Precondition for patch: the object is only patched if the existing object's
        /// generation does not match the given value.
        /// </summary>
        public long? IfGenerationNotMatch;

        /// <summary>
        /// Precondition for patch: the object is only patched if the existing object's
        /// meta-generation matches the given value.
        /// </summary>
        public long? IfMetagenerationMatch;

        /// <summary>
        /// Precondition for patch: the object is only patched if the existing object's
        /// meta-generation does not match the given value.
        /// </summary>
        public long? IfMetagenerationNotMatch;

        /// <summary>
        /// The projection of the updated object to return.
        /// </summary>
        public Projection? Projection;

        /// <summary>
        /// A pre-defined ACL for simple access control scenarios.
        /// </summary>
        public PredefinedObjectAcl? PredefinedAcl;

        internal void ModifyRequest(PatchRequest request)
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
                request.Projection = Preconditions.CheckEnumValue((ProjectionEnum) Projection, nameof(Projection));
            }
            if (PredefinedAcl != null)
            {
                request.PredefinedAcl =
                    Preconditions.CheckEnumValue((PredefinedAclEnum) PredefinedAcl, nameof(PredefinedAcl));
            }
        }
    }
}
