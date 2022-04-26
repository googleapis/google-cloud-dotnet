// Copyright 2021 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// Configuration for initializing tracing for ASP.NET Core applications.
    /// </summary>
    public sealed class AspNetCoreTraceOptions
    {
        /// <summary>
        /// Options for configuring the tracing service.
        /// </summary>
        public Common.TraceServiceOptions ServiceOptions { get; set; }

        /// <summary>
        ///  A function to trace requests. If the trace header is not set then this function
        ///  will be called to determine if a given request should be traced.  This will
        ///  not override trace headers. Can be null.
        /// </summary>
        public TraceDecisionPredicate TraceFallbackPredicate { get; set; }
    }
}
