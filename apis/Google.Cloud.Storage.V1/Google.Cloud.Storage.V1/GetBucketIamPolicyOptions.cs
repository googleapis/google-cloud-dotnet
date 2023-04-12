// Copyright 2017 Google Inc. All Rights Reserved.
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

using static Google.Apis.Storage.v1.BucketsResource;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Options for <c>GetBucketIamPolicy</c> operations.
    /// </summary>
    public sealed class GetBucketIamPolicyOptions
    {
        /// <summary>
        /// If set, this is the ID of the project which will be billed for the request.
        /// The caller must have suitable permissions for the project being billed.
        /// </summary>
        public string UserProject { get; set; }

        /// <summary>
        /// The version of IAM policies to request. If a policy with a condition is requested
        /// without setting this, the server will return an error. This must be set to a value of 3
        /// to retrieve IAM policies containing conditions. This is to prevent client code that
        /// isn't aware of IAM conditions from interpreting and modifying policies incorrectly.
        /// </summary>
        public int? RequestedPolicyVersion { get; set; }

        /// <summary>
        /// Options to pass custom retry configuration for each API request.
        /// </summary>
        public RetryOptions RetryOptions { get; set; }

        internal void ModifyRequest(GetIamPolicyRequest request)
        {
            if (UserProject != null)
            {
                request.UserProject = UserProject;
            }
            if (RequestedPolicyVersion != null)
            {
                request.OptionsRequestedPolicyVersion = RequestedPolicyVersion.Value;
            }
        }
    }
}
