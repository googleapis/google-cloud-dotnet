// Copyright 2020 Google LLC
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

using System;

namespace Google.Cloud.Diagnostics.AspNetCore3
{
    /// <summary>
    /// If this is registered as a dependency, then Log Entries will be associated with
    /// the Google trace and span.
    /// </summary>
    /// <remarks>
    /// To be used when the Tracing component of the Google.Cloud.Diagnostics libraries
    /// is not configured, but Google traces are still being generated, for instance,
    /// because the application is being run in Google Cloud.
    /// If the Tracing component is configured, log entries are automatically associated
    /// to Google traces and spans.
    /// </remarks>
    [Obsolete("Use Google.Cloud.Diagnostics.AspNetCore.AspNetCoreTraceExtensions.TryAddGoogleTraceContextProvider instead.")]
    public class GoogleTraceProvider : IExternalTraceProvider
    {
        /// <inheritdoc/>
        public TraceContextForLogEntry GetCurrentTraceContext(IServiceProvider serviceProvider) =>
            TraceContextForLogEntry.FromGoogleTraceHeader(serviceProvider);
    }
}
