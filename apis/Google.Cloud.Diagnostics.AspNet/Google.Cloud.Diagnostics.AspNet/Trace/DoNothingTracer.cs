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

using System.Collections.Generic;
using System.Diagnostics;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    /// A managed tracer that does nothing.
    /// </summary>
    internal sealed class DoNothingTracer : IManagedTracer
    {
        public static DoNothingTracer Instance = new DoNothingTracer();
        private DoNothingTracer() { }
        public void StartSpan(string name, StartSpanOptions options = null) { }
        public void EndSpan() { }
        public void AnnotateSpan(Dictionary<string, string> labels) { }
        public void SetStackTrace(StackTrace stackTrace) { }
        public string GetCurrentTraceId() => null;
        public ulong? GetCurrentSpanId() => null;
    }
}