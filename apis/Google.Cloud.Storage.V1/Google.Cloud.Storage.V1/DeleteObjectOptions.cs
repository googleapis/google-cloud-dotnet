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
using System;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Options for <c>DeleteObject</c> operations.
    /// </summary>
    public sealed class DeleteObjectOptions
    {
        /// <summary>
        /// The generation to delete. If this is not specified, the latest
        /// generation will be deleted.
        /// </summary>
        public long? Generation { get; set; }

        /// <summary>
        /// Precondition for deletion: the object is only deleted if the object's current
        /// generation matches the given value.
        /// </summary>
        public long? IfGenerationMatch { get; set; }

        /// <summary>
        /// Precondition for deletion: the object is only deleted if the object's current
        /// generation does not match the given value.
        /// </summary>
        public long? IfGenerationNotMatch { get; set; }

        /// <summary>
        /// Precondition for deletion: the object is only deleted if the object's current
        /// meta-generation matches the given value.
        /// </summary>
        public long? IfMetagenerationMatch { get; set; }

        /// <summary>
        /// Precondition for deletion: the object is only deleted if the object's current
        /// meta-generation does not match the given value.
        /// </summary>
        public long? IfMetagenerationNotMatch { get; set; }

        /// <summary>
        /// If set, this is the ID of the project which will be billed for the request, for requester-pays buckets.
        /// The caller must have suitable permissions for the project being billed.
        /// </summary>
        public string UserProject { get; set; }

        internal void ModifyRequest(ObjectsResource.DeleteRequest request)
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
            if (UserProject != null)
            {
                request.UserProject = UserProject;
            }
        }
    }
}
