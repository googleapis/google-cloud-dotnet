// Copyright 2019 Google LLC
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
    /// Options for <c>DeleteHmacKey</c> operations.
    /// </summary>
    public sealed class DeleteHmacKeyOptions
    {
        /// <summary>
        /// Options to pass custom retry configuration for each API request.
        /// </summary>
        public RetryOptions RetryOptions { get; set; }

        internal void ModifyRequest(ProjectsResource.HmacKeysResource.DeleteRequest request)
        {
        }
    }
}
