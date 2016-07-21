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

namespace Google.Cloud.Metadata.V1
{
    /// <summary>
    /// The mode of a disk in a Google Compute Engine VM instance.
    /// </summary>
    /// <seealso cref="DiskMetadata.Mode"/>
    public enum DiskMode
    {
        /// <summary>
        /// Unknown disk mode.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// The disk is read-only.
        /// </summary>
        ReadOnly,

        /// <summary>
        /// The disk is read-write.
        /// </summary>
        ReadWrite
    }
}
