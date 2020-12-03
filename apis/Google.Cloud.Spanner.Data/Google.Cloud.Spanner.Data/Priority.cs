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

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// The relative priority for requests.
    /// </summary>
    public enum Priority
    {
        /// <summary>
        /// Executes the request with unspecified priority.
        /// </summary>
        Unspecified,
        /// <summary>
        /// Executes the request with low priority.
        /// </summary>
        Low,
        /// <summary>
        /// Executes the request with medium priority.
        /// </summary>
        Medium,
        /// <summary>
        /// Executes the request with high priority.
        /// </summary>
        High
    }

    internal class PriorityConverter
    {
        internal static Priority FromProto(V1.RequestOptions.Types.Priority proto)
        {
            return (Priority)System.Enum.Parse(typeof(Priority), proto.ToString());
        }

        internal static V1.RequestOptions.Types.Priority ToProto(Priority priority)
        {
            return (V1.RequestOptions.Types.Priority)System.Enum.Parse(typeof(V1.RequestOptions.Types.Priority), priority.ToString());
        }
    }

}
