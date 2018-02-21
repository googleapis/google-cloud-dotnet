// Copyright 2018 Google Inc. All Rights Reserved.
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

using Google.Api.Gax;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Represents the location traces will be sent to.  The Trace API only supports projects.
    /// </summary>
    public sealed class TraceTarget
    {
        /// <summary>The Google Cloud Platform project Id.</summary>
        public string ProjectId { get; }

        private TraceTarget(string projectId)
        {
            ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId));
        }

        /// <summary>
        /// Creates a <see cref="TraceTarget"/> instance for sending trace entries to a GCP project.
        /// </summary>
        public static TraceTarget ForProject(string projectId) => new TraceTarget(projectId);

        /// <summary>
        /// Gets the full trace name.
        /// See: https://cloud.google.com/logging/docs/reference/v2/rest/v2/LogEntry
        /// </summary>
        /// <param name="traceId">The id of the trace.</param>
        public string GetFullTraceName(string traceId)
        {
            GaxPreconditions.CheckNotNullOrEmpty(traceId, nameof(traceId));
            return $"projects/{ProjectId}/traces/{traceId}";
        }
    }
}
