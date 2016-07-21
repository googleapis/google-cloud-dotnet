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
    /// The type of CPU platform used by a Google Compute Engine VM instance.
    /// </summary>
    /// <seealso cref="InstanceMetadata.CpuPlatform"/>
    public enum CpuPlatform
    {
        /// <summary>
        /// Unknown CPU platform.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// A 2.6 GHz Intel Xeon E5 CPU platform.
        /// </summary>
        IntelSandyBridge,

        /// <summary>
        /// A 2.5 GHz Intel Xeon E5 v2 CPU platform.
        /// </summary>
        IntelIvyBridge,

        /// <summary>
        /// A 2.3 GHz Intel Xeon E5 v3 CPU platform.
        /// </summary>
        IntelHaswell,

        /// <summary>
        /// A 2.2 GHz Intel Xeon E5 v4 CPU platform.
        /// </summary>
        IntelBroadwell
    }
}
