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

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Describes the circumstances under which the hash of an object is validated when downloading.
    /// </summary>
    public enum DownloadValidationMode
    {
        /// <summary>
        /// The hash is always validated.
        /// </summary>
        Always = 0,

        /// <summary>
        /// The hash is never validated; data integrity errors may still be exposed
        /// via other network layers, but there is a risk of data loss.
        /// </summary>
        Never = 1,

        /// <summary>
        /// The hash is validated if the library can detect that validation should
        /// be feasible. If response headers provide information to indicate that
        /// hash validation will fail (even in the face of correct data), the hash
        /// is not validated.
        /// </summary>
        Automatic = 2
    }
}
