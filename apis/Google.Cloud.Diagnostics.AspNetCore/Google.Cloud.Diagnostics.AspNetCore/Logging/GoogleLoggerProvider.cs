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

using Google.Api.Gax;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Logging.V2;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// <see cref="ILoggerProvider"/> for Stackdriver Logging.
    /// </summary>
    public sealed class GoogleLoggerProvider : ILoggerProvider
    {
        /// <summary>The consumer to push logs to.</summary>
        private readonly IConsumer<LogEntry> _consumer;

        /// <summary>The minimum log level.</summary>
        private readonly LogLevel _logLevel;

        /// <summary>The Google Cloud Platform project ID.</summary>
        private readonly string _projectId;

        /// <summary>
        /// <see cref="ILoggerProvider"/> for Stackdriver Logging.
        /// </summary>
        /// <param name="consumer">The consumer to push logs to. Cannot be null.</param>
        /// <param name="projectId">The Google Cloud Platform project ID. Cannot be null.</param>
        /// <param name="logLevel">The minimum log level.</param>
        internal GoogleLoggerProvider(IConsumer<LogEntry> consumer, string projectId, LogLevel logLevel)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _projectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            _logLevel = GaxPreconditions.CheckEnumValue(logLevel, nameof(logLevel));
        }

        /// <summary>
        /// Creates a <see cref="GoogleLogger"/> with the given log name.
        /// </summary>
        /// <param name="logName">The name of the log.  This will be combined with the project Id to generate the 
        /// resource name for the log.</param>
        public ILogger CreateLogger(string logName) => new GoogleLogger(_consumer, _logLevel, _projectId, logName);

        public void Dispose() {}
    }
}
