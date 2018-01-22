// Copyright 2018 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Storage.v1;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Options for LockBucketRetentionPolicy operations.
    /// </summary>
    public sealed class LockBucketRetentionPolicyOptions
    {
        /// <summary>
        /// If set, this is the ID of the project which will be billed for the request.
        /// The caller must have suitable permissions for the project being billed.
        /// </summary>
        public string UserProject { get; set; }

        internal void ModifyRequest(BucketsResource.LockRetentionPolicyRequest request)
        {
            if (UserProject != null)
            {
                request.UserProject = UserProject;
            }
        }
    }
}
