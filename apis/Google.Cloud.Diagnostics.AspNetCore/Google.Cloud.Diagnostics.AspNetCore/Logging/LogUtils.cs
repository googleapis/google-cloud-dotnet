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
using Google.Cloud.Logging.Type;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    internal static class LogUtils
    {
        /// <summary>
        /// Gets a formated log name.
        /// See: https://cloud.google.com/logging/docs/api/ref/rest/v1beta3/projects.logs.entries/write#LogEntry
        /// </summary>
        /// <param name="projectId">The Google Cloud Platform project ID.</param>
        /// <param name="logName">The name of the log.</param>
        public static string GetLogName(string projectId, string logName) {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            GaxPreconditions.CheckNotNull(logName, nameof(logName));
            return $"projects/{projectId}/logs/{logName}";
        }

        /// <summary>
        /// Converts a <see cref="LogLevel"/> to a <see cref="LogSeverity"/>.
        /// </summary>
        public static LogSeverity Convert(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.Trace:
                case LogLevel.Debug:
                    return LogSeverity.Debug;
                case LogLevel.Information:
                    return LogSeverity.Info;
                case LogLevel.Warning:
                    return LogSeverity.Warning;
                case LogLevel.Error:
                    return LogSeverity.Error;
                case LogLevel.Critical:
                    return LogSeverity.Critical;
                case LogLevel.None:
                default:
                    return LogSeverity.Default;
            }
        }
    }
}
