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

using Google.Api.Gax;
using Google.Apis.Storage.v1.Data;
using System;
using static Google.Apis.Storage.v1.BucketsResource;
using static Google.Apis.Storage.v1.BucketsResource.UpdateRequest;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Options for <c>UpdateBucket</c> operations.
    /// </summary>
    public sealed class UpdateBucketOptions
    {
        /// <summary>
        /// Precondition for update: the bucket is only updated if its current
        /// meta-generation matches the given value.
        /// </summary>
        public long? IfMetagenerationMatch { get; set; }

        /// <summary>
        /// Precondition for update: the bucket is only updated if its current
        /// meta-generation does not match the given value.
        /// </summary>
        public long? IfMetagenerationNotMatch { get; set; }

        /// <summary>
        /// The projection of the updated object to return.
        /// </summary>
        public Projection? Projection { get; set; }

        /// <summary>
        /// A pre-defined ACL of the bucket for simple access control scenarios.
        /// </summary>
        public PredefinedBucketAcl? PredefinedAcl { get; set; }

        /// <summary>
        /// A pre-defined default ACL for objects created in the bucket, for simple access control scenarios.
        /// </summary>
        public PredefinedObjectAcl? PredefinedDefaultObjectAcl { get; set; }

        /// <summary>
        /// If set to true, no other preconditions must be set, and
        /// the local metageneration of the bucket being updated is not used
        /// to create a precondition.
        /// </summary>
        public bool? ForceNoPreconditions { get; set; }

        /// <summary>
        /// If set, this is the ID of the project which will be billed for the request, for requester-pays buckets.
        /// The caller must have suitable permissions for the project being billed.
        /// </summary>
        public string UserProject { get; set; }

        private bool AnyExplicitPreconditions => IfMetagenerationMatch != null || IfMetagenerationNotMatch != null;

        internal void ModifyRequest(UpdateRequest request, Bucket bucket)
        {
            if (IfMetagenerationMatch != null && IfMetagenerationNotMatch != null)
            {
                throw new ArgumentException($"Cannot specify {nameof(IfMetagenerationMatch)} and {nameof(IfMetagenerationNotMatch)} in the same options", "options");
            }
            if (ForceNoPreconditions == true && AnyExplicitPreconditions)
            {
                throw new ArgumentException($"Cannot specify {nameof(ForceNoPreconditions)} and any explicit precondition in the same options", "options");
            }

            if (ForceNoPreconditions != true && !AnyExplicitPreconditions)
            {
                request.IfMetagenerationMatch = bucket.Metageneration;
            }
            else
            {
                if (IfMetagenerationMatch != null)
                {
                    request.IfMetagenerationMatch = IfMetagenerationMatch;
                }
                if (IfMetagenerationNotMatch != null)
                {
                    request.IfMetagenerationNotMatch = IfMetagenerationNotMatch;
                }
            }
            if (Projection != null)
            {
                request.Projection = GaxPreconditions.CheckEnumValue((ProjectionEnum) Projection, nameof(Projection));
            }
            if (PredefinedAcl != null)
            {
                request.PredefinedAcl =
                    GaxPreconditions.CheckEnumValue((PredefinedAclEnum) PredefinedAcl, nameof(PredefinedAcl));
            }
            if (PredefinedDefaultObjectAcl != null)
            {
                request.PredefinedDefaultObjectAcl =
                    GaxPreconditions.CheckEnumValue((PredefinedDefaultObjectAclEnum) PredefinedDefaultObjectAcl, nameof(PredefinedDefaultObjectAcl));
            }
            if (UserProject != null)
            {
                request.UserProject = UserProject;
            }
        }
    }
}
