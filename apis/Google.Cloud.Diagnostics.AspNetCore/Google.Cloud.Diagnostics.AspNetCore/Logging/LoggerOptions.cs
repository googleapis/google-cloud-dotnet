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
using Microsoft.Extensions.Logging;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    // TODO(talarico): Add option for logging to other resources and organizations.

    /// <summary>
    /// Options for the logger.
    /// </summary>
    public class LoggerOptions
    {
        /// <summary>The minimum log level.</summary>
        public LogLevel LogLevel { get; private set; }

        /// <summary>The buffer options for the logger.</summary>
        public BufferOptions BufferOptions { get; private set; }

        private LoggerOptions(LogLevel logLevel, BufferOptions bufferOptions)
        {
            LogLevel = logLevel;
            BufferOptions = GaxPreconditions.CheckNotNull(bufferOptions, nameof(bufferOptions));
        }

        /// <summary>
        /// Create a new instance of <see cref="LoggerOptions"/>.
        /// </summary>
        /// <param name="logLevel">Optional, the minimum log level.  Defaults to <see cref="LogLevel.Information"/></param>
        /// <param name="bufferOptions">Optional, the buffer options.  Defaults to a <see cref="BufferType.Sized"/> </param>
        public static LoggerOptions Create(LogLevel logLevel = LogLevel.Information, BufferOptions bufferOptions = null)
        {
            bufferOptions = bufferOptions ?? BufferOptions.SizedBuffer();
            return new LoggerOptions(logLevel, bufferOptions);
        }
    }
}
