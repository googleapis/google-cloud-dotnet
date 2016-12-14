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

using Google.Cloud.Diagnostics.Common;

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    /// An <see cref="ISizer{T}"/> for <see cref="TraceProto"/>s.
    /// </summary>
    internal sealed class TraceSizer : ISizer<TraceProto>
    {
        /// <summary>The single trace sizer instance.</summary>
        internal static readonly TraceSizer Instance = new TraceSizer();

        private TraceSizer() { }

        /// <inheritdoc />
        public int GetSize(TraceProto item) => item.CalculateSize();
    }
}