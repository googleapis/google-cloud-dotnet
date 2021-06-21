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

using Google.Cloud.Logging.Type;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Extension methods for <see cref="LogLevel"/>.
    /// </summary>
    internal static class LogLevelExtensions
    {
        /// <summary>
        /// Extensions to get a <see cref="LogSeverity"/> for a <see cref="LogLevel"/>.
        /// </summary>
        public static LogSeverity ToLogSeverity(this LogLevel logLevel)
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
