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

using Google.Apis.Storage.v1;
using System;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Options for <c>DeleteBucket</c> operations.
    /// </summary>
    public sealed class DeleteBucketOptions
    {
        /// <summary>
        /// Precondition for deletion: the bucket is only deleted if its
        /// meta-generation matches the given value.
        /// </summary>
        public long? IfMetagenerationMatch { get; set; }

        /// <summary>
        /// Precondition for deletion: the bucket is only deleted if its
        /// meta-generation does not match the given value.
        /// </summary>
        public long? IfMetagenerationNotMatch { get; set; }

        /// <summary>
        /// If set, this is the ID of the project which will be billed for the request.
        /// The caller must have suitable permissions for the project being billed.
        /// </summary>
        public string UserProject { get; set; }

        /// <summary>
        /// If set to true, all objects within the bucket will be deleted before attempting
        /// to delete the bucket itself.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This is a best-effort attempt, with no guarantees of atomicity:
        /// it's entirely possible for the operation to fail having deleted some objects
        /// but not all of them. If a precondition is specified, it is checked before deleting any
        /// objects, and applied again when deleting the bucket, but is not checked while deleting
        /// the objects. The behavior is unspecified if objects are modified, added or deleted while
        /// this operation is taking place.
        /// </para>
        /// <para>
        /// The objects are deleted sequentially. If you need to delete buckets with many objects, you
        /// may wish to implement a parallel solution in application code instead of using this option.
        /// </para>
        /// <para>
        /// If <see cref="UserProject"/> is set, that project will be billed for all operations.
        /// </para>
        /// </remarks>
        public bool? DeleteObjects { get; set; }

        /// <summary>
        /// Options to pass custom retry configuration for each API request.
        /// </summary>
        public RetryOptions RetryOptions { get; set; }

        internal void ModifyRequest(BucketsResource.DeleteRequest request)
        {
            if (IfMetagenerationMatch != null && IfMetagenerationNotMatch != null)
            {
                throw new ArgumentException($"Cannot specify {nameof(IfMetagenerationMatch)} and {nameof(IfMetagenerationNotMatch)} in the same options", "options");
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

        /// <summary>
        /// If this set of options contains any preconditions, return a
        /// <see cref="GetBucketOptions"/> with the same set of options. Otherwise, return null.
        /// </summary>
        internal GetBucketOptions CreateGetBucketOptionsForPreconditions()
        {
            long? match = IfMetagenerationMatch;
            long? notMatch = IfMetagenerationNotMatch;
            return match == null && notMatch == null ? null :
                new GetBucketOptions
                {
                    IfMetagenerationMatch = match,
                    IfMetagenerationNotMatch = notMatch,
                    UserProject = UserProject
                };
        }
    }
}
