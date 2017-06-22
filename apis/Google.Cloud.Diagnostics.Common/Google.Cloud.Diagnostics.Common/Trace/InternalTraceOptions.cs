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

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Options about a trace, such as if tracing should occur.
    /// </summary>
    internal sealed class InternalTraceOptions
    {
        /// <summary>True if the request should be traced.</summary>
        public bool ShouldTrace { get; }

        private InternalTraceOptions(bool shouldTrace)
        {
            ShouldTrace = shouldTrace;
        }

        /// <summary>
        /// Creates a <see cref="InternalTraceOptions"/>.
        /// </summary>
        /// <param name="shouldTrace">True if the tracing should occur.</param>
        public static InternalTraceOptions Create(bool shouldTrace) => new InternalTraceOptions(shouldTrace);
    }
}