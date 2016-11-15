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

namespace Google.Devtools.AspNet
{
    /// <summary>
    /// Options about a trace, such as if tracing should occur.
    /// </summary>
    internal sealed class TraceOptions
    {
        private readonly bool _shouldTrace;

        private TraceOptions(bool shouldTrace)
        {
            _shouldTrace = shouldTrace;
        }

        /// <summary>
        /// Creates a <see cref="TraceOptions"/>.
        /// </summary>
        /// <param name="shouldTrace">True if the tracing should occur</param>
        /// <returns></returns>
        public static TraceOptions Create(bool shouldTrace)
        {
            return new TraceOptions(shouldTrace);
        }

        /// <returns>True if the request should be traced.</returns>
        public bool ShouldTrace() => _shouldTrace;
    }
}