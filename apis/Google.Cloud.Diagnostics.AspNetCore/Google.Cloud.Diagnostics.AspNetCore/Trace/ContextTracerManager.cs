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

using Google.Cloud.Diagnostics.Common;
using Microsoft.AspNetCore.Http;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// Manages access to the current <see cref="IManagedTracer"/>.
    /// </summary>
    internal static class ContextTracerManager
    {
        ///<summary>The key to save the tracer under in the <see cref="HttpContext"/>.</summary> 
        internal const string TraceKey = "Google.Cloud.Diagnostics.AspNetCore.Trace";

        /// <summary>
        /// Sets the current <see cref="IManagedTracer"/>.  This is called in <see cref="CloudTraceMiddleware"/>
        /// for each new request.
        /// </summary>
        public static void SetCurrentTracer(IHttpContextAccessor accessor, IManagedTracer tracer)
        {
            if (accessor?.HttpContext?.Items != null)
            {
                accessor.HttpContext.Items[TraceKey] = tracer;
            }
        }

        /// <summary>
        /// Gets the current <see cref="IManagedTracer"/> or a <see cref="NullManagedTracer"/> if none exists.
        /// </summary>
        public static IManagedTracer GetCurrentTracer(IHttpContextAccessor accessor)
        {
            return accessor?.HttpContext?.Items[TraceKey] as IManagedTracer ?? NullManagedTracer.Instance;
        }
    }
}
