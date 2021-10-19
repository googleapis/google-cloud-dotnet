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

using Google.Cloud.Logging.V2;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Configuration for initializing Error Reporting.
    /// </summary>
    public sealed class ErrorReportingServiceOptions
    {
        /// <summary>
        /// The Google Cloud Project ID to store the logs in.
        /// May be null if running on Google Cloud, in which case, and if <see cref="EventTarget"/> is
        /// also null the project ID will be detected from the platform
        /// and used to build the log target.
        /// This is an alternate way to set <see cref="EventTarget"/> for <see cref="LogTargetKind.Project"/>.
        /// </summary>
        public string ProjectId
        {
            get => EventTarget?.ProjectId;
            set => EventTarget = value is null
                ? EventTarget?.ProjectId is object ? null : EventTarget
                : EventTarget.ForProject(value);
        }

        /// <summary>
        /// An identifier of the service, such as the name of the executable or job. May be null.
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Represents the source code version that the developer provided. May be null.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Where to send error reports to. Will ultimately represent a Google Project or Organization.
        /// May be set by setting <see cref="ProjectId"/>.
        /// May be null if running on Google Cloud in which case the
        /// Google Cloud Platform project ID will be detected from the platform
        /// and used to build the event target.
        /// </summary>
        public EventTarget EventTarget { get; set; }

        /// <summary>
        /// A client to log entries with. May be null.
        /// </summary>
        public LoggingServiceV2Client Client { get; set; }

        /// <summary>
        /// Error reporting options for exception logging. May be null.
        /// </summary>
        public ErrorReportingOptions Options { get; set; }
    }
}
