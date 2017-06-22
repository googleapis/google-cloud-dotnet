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
using Google.Cloud.Trace.V1;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// Configuration for initializing tracing.
    /// </summary>
    public sealed class TraceServiceOptions
    {
        /// <summary>
        /// The Google Cloud Platform project ID. If unspecified and running on GAE or GCE the project
        /// ID will be detected from the platform.
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// Trace options. Can be null.
        /// </summary>
        public TraceOptions Options { get; set; }

        /// <summary>
        /// A client to send traces with. Can be null.
        /// </summary>
        public TraceServiceClient Client { get; set; }

        /// <summary>
        ///  A function to trace requests. If the trace header is not set then this function
        ///  will be called to determine if a given request should be traced.  This will
        ///  not override trace headers. Can be null.
        /// </summary>
        public TraceDecisionPredicate TraceFallbackPredicate { get; set; }
    }
}