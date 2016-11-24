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
using Google.Apis.Storage.v1;
using static Google.Apis.Storage.v1.BucketsResource.InsertRequest;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Options for <c>CreateBucket</c> operations.
    /// </summary>
    public sealed class CreateBucketOptions
    {
        /// <summary>
        /// A pre-defined ACL of the bucket for simple access control scenarios.
        /// </summary>
        public PredefinedBucketAcl? PredefinedAcl { get; set;  }

        /// <summary>
        /// A pre-defined default ACL for objects created in the bucket, for simple access control scenarios.
        /// </summary>
        public PredefinedObjectAcl? PredefinedDefaultObjectAcl { get; set; }

        /// <summary>
        /// The projection to retrieve.
        /// </summary>
        public Projection? Projection { get; set; }

        internal void ModifyRequest(BucketsResource.InsertRequest request)
        {
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
            if (Projection != null)
            {
                request.Projection = GaxPreconditions.CheckEnumValue((ProjectionEnum) Projection, nameof(Projection));
            }
        }
    }
}
