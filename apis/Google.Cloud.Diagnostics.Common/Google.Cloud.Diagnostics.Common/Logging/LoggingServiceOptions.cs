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
using System.IO;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Configuration for initializing Google Cloud Logging.
    /// </summary>
    public sealed class LoggingServiceOptions
    {
        /// <summary>
        /// An identifier of the service, such as the name of the executable or job. May be null.
        /// When set, it will be included in the <code>serviceContext</code> field of the log entry JSON payload.
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// A string that represents the version of the service or the source code that logs are written for.
        /// When set, it will be included in the <code>serviceContext</code> field of the log entry JSON payload.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// The Google Cloud Project ID to store the logs in.
        /// May be null if running on Google Cloud, in which case, and if <see cref="LogTarget"/> is
        /// also null the project ID will be detected from the platform
        /// and used to build the log target.
        /// This is an alternate way to set <see cref="LogTarget"/> for <see cref="LogTargetKind.Project"/>.
        /// </summary>
        public string ProjectId 
        {
            get => LogTarget?.Kind == LogTargetKind.Project ? LogTarget.ProjectId : null;
            set => LogTarget = value is null 
                ? LogTarget?.Kind == LogTargetKind.Project ? null : LogTarget 
                : LogTarget.ForProject(value);
        }

        /// <summary>
        /// Where to log to. May represent a Google Project or Organization.
        /// May be set by setting <see cref="ProjectId"/>.
        /// May be null if running on Google Cloud in which case the
        /// Google Cloud Platform project ID will be detected from the platform
        /// and used to build the log target.
        /// </summary>
        public LogTarget LogTarget { get; set; }

        /// <summary>
        /// A client to log entries with. May be null.
        /// </summary>
        public LoggingServiceV2Client Client { get; set; }

        /// <summary>
        /// A <see cref="TextWriter"/> to write diagnostics info about loggers created
        /// with these <see cref="LoggingOptions"/>.
        /// Currently the only diagnostics info we provide is the URL where the logs written
        /// with these options can be found.
        /// </summary>
        public TextWriter LoggerDiagnosticsOutput { get; set; }

        /// <summary>
        /// Options for logging. May be null.
        /// </summary>
        public LoggingOptions Options { get; set; }
    }
}
