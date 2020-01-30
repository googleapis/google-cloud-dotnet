// Copyright 2020 Google Inc. All Rights Reserved.
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

using System;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Constants for use in Spanner.
    /// </summary>
    internal class SpannerConstants
    {
        /// <summary>
        /// Resource based routing flag.
        /// </summary>
        public static bool IsResourceBasedRoutingEnabled
        {
            get
            {
                string resourceBaseRoutingFlagValue = Environment.GetEnvironmentVariable(ResourceBasedRoutingVariableName);
                return StringComparer.InvariantCultureIgnoreCase.Equals(resourceBaseRoutingFlagValue, "true");
            }
        }

        /// <summary>
        /// Resource based routing environment variable name.
        /// </summary>
        public const string ResourceBasedRoutingVariableName = "GOOGLE_CLOUD_SPANNER_ENABLE_RESOURCE_BASED_ROUTING";
    }
}
